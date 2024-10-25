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
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;
using LevelsTables.Models.Tables;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Drawing;

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
        public IActionResult Table()
        {
            var data = _db.Stations.Include(q => q.Kassas).Include(q => q.TankForStations).OrderBy(q => q.Id).ToList();

            foreach (Station station in data)
            {
                List<Kassa> kassasOfDiesel = station.Kassas.Where(t => t.ContainWhat == "Diesel").ToList();
                List<Kassa> kassasOfPetrol = station.Kassas.Where(t => t.ContainWhat == "Petrol").ToList();
                List<Kassa> kassasOfGas = station.Kassas.Where(t => t.ContainWhat == "Gas").ToList();

                if (kassasOfDiesel.Any(t => t.ContainWhat == "Diesel"))
                {
                    station.DisplayLastInOfDieselKassa = TimeZoneInfo.ConvertTimeFromUtc(DateTimeOffset.FromUnixTimeSeconds(kassasOfDiesel.LastOrDefault().DateOfLastIn).UtcDateTime, TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time"));
                    long averageUpdateOfDiesel = (long)kassasOfDiesel.Select(q => q.DateOfLastUpdate).Average();
                    station.ColorOfDieselKassa = getColor(averageUpdateOfDiesel);
                    foreach (Kassa kassa in kassasOfDiesel)
                    {
                        station.DisplayDataOfDieselKassa += kassa.Data;
                    }
                    station.CountOfDieselTanks = station.TankForStations.Where(t => t.ContainWhat == "Diesel").Count();
                    foreach (TankForStation tank in station.TankForStations.Where(t => t.ContainWhat == "Diesel"))
                    {
                        tank.Color = getColor(tank.DateOfLastUpdate);
                    }
                }

                if (kassasOfPetrol.Any(t => t.ContainWhat == "Petrol"))
                {
                    station.DisplayLastInOfPetrolKassa = TimeZoneInfo.ConvertTimeFromUtc(DateTimeOffset.FromUnixTimeSeconds(kassasOfPetrol.LastOrDefault().DateOfLastIn).UtcDateTime, TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time"));
                    long averageUpdateOfPetrol = (long)kassasOfPetrol.Select(q => q.DateOfLastUpdate).Average();
                    station.ColorOfPetrolKassa = getColor(averageUpdateOfPetrol);
                    foreach (Kassa kassa in kassasOfPetrol)
                    {
                        station.DisplayDataOfPetrolKassa += kassa.Data;
                    }
                    station.CountOfPetrolTanks = station.TankForStations.Where(t => t.ContainWhat == "Petrol").Count();
                    foreach (TankForStation tank in station.TankForStations.Where(t => t.ContainWhat == "Petrol"))
                    {
                        tank.Color = getColor(tank.DateOfLastUpdate);
                    }
                }

                if (kassasOfGas.Any(t => t.ContainWhat == "Gas"))
                {
                    station.DisplayLastInOfGasKassa = TimeZoneInfo.ConvertTimeFromUtc(DateTimeOffset.FromUnixTimeSeconds(kassasOfGas.LastOrDefault().DateOfLastIn).UtcDateTime, TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time"));
                    long averageUpdateOfGas = (long)kassasOfGas.Select(q => q.DateOfLastUpdate).Average();
                    station.ColorOfGasKassa = getColor(averageUpdateOfGas);
                    foreach (Kassa kassa in kassasOfGas)
                    {
                        station.DisplayDataOfGasKassa += kassa.Data;
                    }
                    station.CountOfGasTanks = station.TankForStations.Where(t => t.ContainWhat == "Gas").Count();
                    foreach (TankForStation tank in station.TankForStations.Where(t => t.ContainWhat == "Gas"))
                    {
                        tank.Color = getColor(tank.DateOfLastUpdate);
                    }
                }
            }

            return View(data);
        }
        public string getColor(long time)
        {
            long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long timeMinusFour = currentTime - 14400;
            long timeMinusEigth = currentTime - 28800;

            string redColor = "#fa4925";
            string yellowColor = "#ffde70";
            string noColor = "";

            if (time < timeMinusEigth)
            {
                return redColor;
            }
            else if (time < timeMinusFour)
            {
                return yellowColor;
            }
            else
            {
                return noColor;
            }
        }


        public async Task<IActionResult> Info(int id, long? date)
        {
            var allUploadDates = _db.Calibrations
                .Where(t => t.TankId == id)
                .Select(t => t.timeOfUploadOrUpdate)
                .Distinct()
                .OrderByDescending(d => d)
                .ToList();

            List<Calibration> values = new List<Calibration>();
            long currentTableTime = 0;

            if (allUploadDates.Count > 0)
            {
                //going from info with date
                if (date != null)
                {
                    values = await _db.Calibrations.Where(q => q.TankId == id && q.timeOfUploadOrUpdate == date).OrderBy(q => q.Level).ToListAsync();
                    currentTableTime = (long)date;
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
                AllUploadTimes = allUploadDates,
                CurrentTableTime = currentTableTime
            };

            return View(infoVM);
        }


        [HttpPost]
        public IActionResult Info(int id, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                TempData["Error"] = "Додайте CSV файл";
                return RedirectToAction("Info", id);
            }
            try
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var csvConfig = new CsvConfiguration(CultureInfo.CreateSpecificCulture("uk-UA"))
                    {
                        Delimiter = ";",
                        HasHeaderRecord = true,
                        PrepareHeaderForMatch = (header) => header.Header.ToLower()
                    };


                    var csv = new CsvReader(reader, csvConfig);
                    var records = csv.GetRecords<Calibration>().ToList();

                    DateTime currentTime = DateTime.Now;
                    long currentTimeInUnixTimestamp = (long)(currentTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
                    decimal previousVolume = -1;
                    long stepOfLevels = (long)(records[1].Level - records[0].Level);



                    foreach (var record in records)
                    {
                        record.TankId = id;
                        record.timeOfUploadOrUpdate = currentTimeInUnixTimestamp;
                        if (previousVolume == -1)
                        {
                            record.ratio = 0;
                        }
                        else
                        {
                            record.ratio = (record.Volume - previousVolume) / stepOfLevels;
                        }

                        _db.Calibrations.Add(record);

                        previousVolume = record.Volume;
                    }


                    _db.SaveChanges();
                    TempData["Success"] = "Дані успішно додані";
                    return RedirectToAction("Info", id);
                }
            }
            catch
            {
                TempData["Error"] = "Додайте правильний CSV файл";
                return RedirectToAction("Info", id);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id, long date)
        {
            try
            {
                var values = _db.Calibrations.Where(q => q.TankId == id && q.timeOfUploadOrUpdate == date);

                _db.Calibrations.RemoveRange(values);

                _db.SaveChanges();
                TempData["Success"] = "Дані успішно видалені";
                return Ok(id);
            }
            catch
            {
                TempData["Error"] = "Помилка під час видалення";
                return Ok(id);
            }
            //return RedirectToAction("Info", new {id = id});
        }


        [HttpPost]
        public IActionResult Update(IFormFile file)
        {
            List<Calibration> calibrationList = new List<Calibration>();
            try
            {
                string jsonData = new StreamReader(file.OpenReadStream()).ReadToEnd();
                calibrationList = JsonConvert.DeserializeObject<List<Calibration>>(jsonData);
            }
            catch
            {
                TempData["Error"] = "Введені дані не коректні";
                return Ok();
            }

            int id = calibrationList[0].TankId;
            decimal previousVolume = -1;
            DateTime currentTime = DateTime.Now;
            long currentTimeInUnixTimestamp = (long)(currentTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

            try
            {
                long stepOfLevels = (long)(calibrationList[1].Level - calibrationList[0].Level);

                foreach (Calibration calibration in calibrationList)
                {
                    if (previousVolume == -1)
                    {
                        calibration.ratio = 0;
                    }
                    else
                    {
                        calibration.ratio = (calibration.Volume - previousVolume) / stepOfLevels;
                    }
                    calibration.timeOfUploadOrUpdate = currentTimeInUnixTimestamp;
                    _db.Calibrations.Update(calibration);
                    previousVolume = calibration.Volume;
                }

                _db.SaveChanges();
                TempData["Success"] = "Дані успішно оновлені";
                return Ok();
            }
            catch
            {
                TempData["Error"] = "Помилка при оновлені даних";
                return Ok();
            }
        }
        [HttpGet]
        [Route("/getCsv/{id}/{date}")]
        public async Task<IActionResult> GetCsv(int id, long date)
        {
            var values = await _db.Calibrations
                .Where(q => q.TankId == id && q.timeOfUploadOrUpdate == date)
                .OrderBy(q => q.Level)
                .ToListAsync();

            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            var csvWriter = new CsvWriter(writer, new CsvConfiguration(new CultureInfo("uk-UA"))
            {
                HasHeaderRecord = true,
                Delimiter = ";"
            });

            csvWriter.WriteRecords(values);

            writer.Flush();
            stream.Position = 0;

            return File(stream, "text/csv", $"calibrations_{id}_{date}.csv");
        }



        [HttpGet]
        public async Task<string> GetTable(int id, long? date)
        {
            var allDates = await _db.Calibrations
                .Where(t => t.TankId == id)
                .Select(t => t.timeOfUploadOrUpdate)
                .Distinct()
                .OrderByDescending(d => d)
                .ToListAsync();

            GetTableModel getTableModel = new GetTableModel()
            {
                CountOfRows = 0,
                CalibrationList = new List<CalibrationGetModel>()
            };
            string jsonTableModel = JsonConvert.SerializeObject(getTableModel);


            if (allDates.Any())
            {
                var values = await _db.Calibrations.Where(q => q.TankId == id && q.timeOfUploadOrUpdate == allDates[0]).OrderBy(q => q.Level).ToListAsync();

                foreach (var value in values)
                {
                    CalibrationGetModel model = new CalibrationGetModel()
                    {
                        Level = value.Level,
                        Volume = value.Volume,
                        ratio = value.ratio,
                        timeOfUploadOrUpdate = value.timeOfUploadOrUpdate
                    };
                    getTableModel.CalibrationList.Add(model);
                }

                if (date == allDates[0])
                {
                    return jsonTableModel;
                }
            }

            getTableModel.CountOfRows = getTableModel.CalibrationList.Count();

            jsonTableModel = JsonConvert.SerializeObject(getTableModel);

            return jsonTableModel;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
