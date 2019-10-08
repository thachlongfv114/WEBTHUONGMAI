using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BooksShopOnline.Models
{
    public class Sport
    {
        [ScaffoldColumn(false)]
        public int SportID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string SportName { get; set; }
        [Required, StringLength(1000), Display(Name = "Mo ta"),
        DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Gia")]
        public float? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}