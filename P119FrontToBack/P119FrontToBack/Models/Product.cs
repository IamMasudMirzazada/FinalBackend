﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P119FrontToBack.Models
{
    public class Product
    {
        public int  Id { get; set; }
        public  string  Title { get; set; }
        public  double Price { get; set; }
        public  string  ImageUrl { get; set; }
        public    Category  Category { get; set; }
        public   int    CategoryId { get; set; }
    }
}
