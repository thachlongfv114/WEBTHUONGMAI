using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BooksShopOnline.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BooksShopOnline")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

    }
}