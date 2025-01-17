﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LevelsTables.Models.Tables
{
    public class Kassa
    {
        [Key]
        public int Id { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public string ContainWhat { get; set; }
        public long Data {  get; set; }
        public long DateOfLastUpdate { get; set; }
        public long DateOfLastIn { get; set; }
    }
}
