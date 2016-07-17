﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherWebApp.Models
{
    public class UserWeatherLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public DateTime Date { get; set; }
        public string CityName { get; set; }
    }
}