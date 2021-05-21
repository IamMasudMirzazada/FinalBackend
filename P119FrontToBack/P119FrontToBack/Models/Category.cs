using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P119FrontToBack.Models
{
    public class Category
    {
        public int  Id { get; set; }

        [Required,MaxLength(50)]

        public string Name { get; set; }

        public virtual ICollection<Product>  Products { get; set; }
         
    }
}
