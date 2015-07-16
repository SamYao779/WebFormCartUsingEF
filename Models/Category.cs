using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebFormEntity.Models
{
    public class Category
    {
        [Key, Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Origin { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}