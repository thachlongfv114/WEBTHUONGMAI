using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BooksShopOnline.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int SportId { get; set; }
        public virtual Sport Sport { get; set; }
    }
}