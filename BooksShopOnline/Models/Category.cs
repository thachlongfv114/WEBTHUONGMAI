﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksShopOnline.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int GroupID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string GroupName { get; set; }
        public virtual ICollection<Sport> Sports{ get; set; }
    }
}