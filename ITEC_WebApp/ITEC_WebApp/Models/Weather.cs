﻿using System.ComponentModel.DataAnnotations;

namespace ITEC_WebApp.Models
{
    public class Weather
    {
        [Key]
        public int IdWheather { get; set; }
        public string Details { get; set; }
        public City City { get; set; }
    }
}
