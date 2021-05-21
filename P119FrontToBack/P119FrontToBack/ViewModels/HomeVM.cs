using P119FrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P119FrontToBack.ViewModels
{
    public class HomeVM
    {
        public List<Slider>Sliders { get; set; }
        public Caption Caption { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
       public About About { get; set; }
    }
}
