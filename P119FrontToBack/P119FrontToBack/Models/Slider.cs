﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P119FrontToBack.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public  string  ImageUrl { get; set; }
        public string MyProperty { get; set; }
    }
}
