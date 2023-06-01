﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; } 
        public string Baslik { get; set; }
        public string Açıklama { get; set; }
    }
}