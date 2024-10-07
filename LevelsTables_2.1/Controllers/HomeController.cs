using AlisonicLevels.Models;
using Levels.Models;
using LevelsTables.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Linq;
using LevelsTables.Models.View_Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System;

namespace LevelsTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly LevelsDbContext _db;

        public HomeController(LevelsDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Info(int id, string date)
        {
            DateTime dateTime = new DateTime();
            if (date != null)
            {
                dateTime = DateTime.ParseExact(date, "o", CultureInfo.InvariantCulture);
            }

            var allUploadDates = _db.Calibrations
                .Where(t => t.TankId == id)
                .Select(t => t.timeOfUploadOrUpdate)
                .Distinct()
                .OrderByDescending(d => d)
                .ToList();

            List<Calibration> values = new List<Calibration>();
            DateTime currentTableTime = new DateTime();

            if (allUploadDates.Count > 0)
            {
                //going from info with date
                if (date != null)
                {
                    values = await _db.Calibrations.Where(q => q.TankId == id && q.timeOfUploadOrUpdate == dateTime).OrderBy(q => q.Level).ToListAsync();
                    currentTableTime = dateTime;
                }
                else //going from index
                {
                    values = await _db.Calibrations.Where(q => q.TankId == id && q.timeOfUploadOrUpdate == allUploadDates[0]).OrderBy(q => q.Level).ToListAsync();
                    currentTableTime = allUploadDates[0];
                }
            }

            InfoVM infoVM = new InfoVM
            {
                Tank = _db.Tanks.FirstOrDefault(s => s.Id == id),
                Calibrations = values,
                AllUploadTimes = allUploadDates.Select(d => (long)(d - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds).ToList(),
                CurrentTableTime = (long)(currentTableTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds
            };

            return View(infoVM);
        }


        //[HttpPost]
        //public IActionResult Info(int id, IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //    {
        //        TempData["Error"] = "Додайте CSV файл";
        //        return RedirectToAction("Info", id);
        //    }
        //    try
        //    {
        //        using (var reader = new StreamReader(file.OpenReadStream()))
        //        {
        //            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        //            {
        //                Delimiter = ";",
        //                HasHeaderRecord = true,
        //                PrepareHeaderForMatch = (header) => header.Header.ToLower()
        //            };


        //            var csv = new CsvReader(reader, csvConfig);
        //            var records = csv.GetRecords<Calibration>().ToList();

        //            DateTime currentTime = DateTime.Now;
        //            decimal previousVolume = -1;
        //            long stepOfLevels = (long)(records[1].Level - records[0].Level);



        //            foreach (var record in records)
        //            {
        //                record.TankId = id;
        //                record.timeOfUploadOrUpdate = currentTime;
        //                if (previousVolume == -1)
        //                {
        //                    record.ratio = 0;
        //                }
        //                else
        //                {
        //                    record.ratio = (record.Volume - previousVolume) / stepOfLevels;
        //                }

        //                _db.Calibrations.Add(record);

        //                previousVolume = record.Volume;
        //            }


        //            _db.SaveChanges();
        //            TempData["Success"] = "Дані успішно додані";
        //            return RedirectToAction("Info", id);
        //        }
        //    }
        //    catch
        //    {
        //        TempData["Error"] = "Додайте правильний CSV файл";
        //        return RedirectToAction("Info", id);
        //    }
        //}

        //[HttpPost]
        //public IActionResult Delete(int id, string? date)
        //{
        //    try
        //    {
        //        DateTime dateTime = DateTime.ParseExact(date, "o", CultureInfo.InvariantCulture);
        //        var values = _db.Calibrations.Where(q => q.TankId == id && q.timeOfUploadOrUpdate == dateTime);

        //        _db.Calibrations.RemoveRange(values);

        //        _db.SaveChanges();
        //        TempData["Success"] = "Дані успішно видалені";
        //        return Ok(id);
        //    }
        //    catch
        //    {
        //        TempData["Error"] = "Помилка під час видалення";
        //        return Ok(id);
        //    }
        //    //return RedirectToAction("Info", new {id = id});
        //}
        //[HttpPost]
        //public IActionResult Update(IFormFile file)
        //{
        //    string jsonData = new StreamReader(file.OpenReadStream()).ReadToEnd();
        //    List<Calibration> calibrationList = JsonConvert.DeserializeObject<List<Calibration>>(jsonData);

        //    int id = calibrationList[0].TankId;
        //    decimal previousVolume = -1;
        //    DateTime currentTime = DateTime.Now;

        //    try
        //    {
        //        long stepOfLevels = (long)(calibrationList[1].Level - calibrationList[0].Level);

        //        foreach (Calibration calibration in calibrationList)
        //        {
        //            if (previousVolume == -1)
        //            {
        //                calibration.ratio = 0;
        //            }
        //            else
        //            {
        //                calibration.ratio = (calibration.Volume - previousVolume) / stepOfLevels;
        //            }
        //            calibration.timeOfUploadOrUpdate = currentTime;
        //            _db.Calibrations.Update(calibration);
        //            previousVolume = calibration.Volume;
        //        }

        //        _db.SaveChanges();

        //        return RedirectToAction("Info", new { id = id });
        //    }
        //    catch
        //    {
        //        TempData["Error"] = "Введені дані не вірні";
        //        return RedirectToAction("Info", new { id = id });
        //    }
        //}

        //[HttpGet]
        //public async Task<string> GetTable(int id, DateTime? dateTime)
        //{
        //    var allDates = await _db.Calibrations
        //        .Where(t => t.TankId == id)
        //        .Select(t => t.timeOfUploadOrUpdate)
        //        .Distinct()
        //        .OrderByDescending(d => d)
        //        .ToListAsync();

        //    GetTableModel getTableModel = new GetTableModel()
        //    {
        //        countOfRows = 0,
        //        CalibrationList = new List<CalibrationGetModel>()
        //    };
        //    string jsonTableModel = System.Text.Json.JsonSerializer.Serialize(getTableModel);


        //    if (allDates.Any())
        //    {
        //        var values = await _db.Calibrations.Where(q => q.TankId == id && q.timeOfUploadOrUpdate == allDates[0]).OrderBy(q => q.Level).ToListAsync();

        //        foreach (var value in values)
        //        {
        //            CalibrationGetModel model = new CalibrationGetModel()
        //            {
        //                Level = value.Level,
        //                Volume = value.Volume,
        //                ratio = value.ratio,
        //                timeOfUploadOrUpdate = value.timeOfUploadOrUpdate
        //            };
        //            getTableModel.CalibrationList.Add(model);
        //        }

        //        if (dateTime == allDates[0])
        //        {
        //            return jsonTableModel;
        //        }
        //    }

        //    getTableModel.countOfRows = getTableModel.CalibrationList.Count();

        //    jsonTableModel = System.Text.Json.JsonSerializer.Serialize(getTableModel);

        //    return jsonTableModel;
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
