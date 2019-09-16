using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Áo Tuyển Quốc Gia"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Áo Câu Lạc Bộ"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Áo Không LOGO"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Giày Thể Thao"
                }
                
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    BookID = 1,
                    BookName = "Áo bóng đá Việt Nam đỏ Asian cup 2019",
                    Description = "Hàng body fit, tay ngắn",
                    ImagePath ="vietnam2.jpg",
                    UnitPrice =120000,
                    CategoryID = 1
                    },

                new Book
                {
                    BookID = 11,
                    BookName = "Áo đội tuyển Brazil",
                    Description = "Nơi sản sinh ra nhiều thiên tài bóng đá, nhảy múa với trái bóng với điệu samba, và bạn cũng vậy, mua đi mua đi",
                    ImagePath ="brazill.jpg",
                    UnitPrice =120000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 12,
                    BookName = "Áo đội tuyển Ý",
                    Description = "Là đội tuyển nhiều truyền thống với những ngôi sao hàng đầu",
                    ImagePath ="y.png",
                    UnitPrice =120000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 13,
                    BookName = "Áo đội tuyển Đức",
                    Description = "Nhà vô địch World Cup 2014, cổ xe tăng đích thực, ",
                    ImagePath ="gemany.png",
                    UnitPrice =120000,
                    CategoryID = 1
                    },

                
                new Book
                {
                    BookID = 3,
                    BookName = "CLB BARCA",
                    Description = " Áo sân nhà, chất liệu siêu tốt, body đẹp dáng",
                    ImagePath ="bacarlona.jpg",
                    UnitPrice = 150000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 31,
                    BookName = "CLB Manchester City",
                    Description = "Áo sân nhà, chất liệu siêu tốt, body đẹp dáng",
                    ImagePath ="juve.jpg",
                    UnitPrice = 150000,
                    CategoryID = 2
                },

                 new Book
                {
                    BookID = 32,
                    BookName = "CLB Manchester United",
                    Description = "Áo sân nhà, chất liệu siêu tốt, body đẹp dáng",
                    ImagePath ="chelsea.jpg",
                    UnitPrice = 150000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Áo Ko Logo T90-Victory đỏ",
                    Description = "Vải thun, tay ngắn, body.",
                    ImagePath ="ao2.jpg",
                    UnitPrice = 250000,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Áo Ko Logo T90-Victory trắng",
                    Description = "Vải thun, tay ngắn, body.",
                    ImagePath ="ao3.png",
                    UnitPrice = 250000,
                    CategoryID = 3
                },

                new Book
                {
                    BookID = 5,
                    BookName = "Giầy Bóng Đá Predator cao cổ xám",
                    Description = "Giày nhẹ, đủ mọi size cho các bạn yêu cầu.",
                    ImagePath ="giay1.jpg",
                    UnitPrice = 300000,
                    CategoryID = 4
                },
                new Book
                {
                    BookID = 5,
                    BookName = "Giầy Bóng Đá Predator cao cổ hồng",
                    Description = "Giày nhẹ, đủ mọi size cho các bạn yêu cầu.",
                    ImagePath ="giay2.jpg",
                    UnitPrice = 300000,
                    CategoryID = 4
                },


            };
            return books;
        }
    }
}