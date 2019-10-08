using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace BooksShopOnline.Models
{
    public class SportContext : DbContext
    {
        public SportContext() : base("SportShop")
        { }
        public DbSet<Category> SportCategories { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public object ShoppingCartItems { get; internal set; }
    }

}