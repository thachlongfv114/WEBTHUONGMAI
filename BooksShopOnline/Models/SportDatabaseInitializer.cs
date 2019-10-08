using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<SportContext>
    {
        protected override void Seed(SportContext context)
        {
            GetCategories().ForEach(c => context.SportCategories.Add(c));
            GetBooks().ForEach(p => context.Sports.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    GroupID = 1,
                    GroupName = "TUYỂN QUỐC GIA"
                },
                new Category
                {
                    GroupID = 2,
                    GroupName = "CÂU LẠC BỘ"
                },
                new Category
                {
                    GroupID = 3,
                    GroupName = "SET KHÔNG LOGO"
                },
                new Category
                {
                    GroupID = 4,
                    GroupName = "GIÀY THỂ THAO"
                }

            };
            return categories;
        }
        private static List<Sport> GetBooks()
        {
            var sports = new List<Sport> {
                new Sport
                {
                    SportID = 1,
                    SportName = "Áo đội tuyển VIỆT NAM",
                    Description = "Mẫu quần áo bóng đá đội tuyển Việt Nam sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của đội tuyển:",
                    ImagePath ="vietnam2.jpg",
                    UnitPrice =120000,
                    CategoryID = 1
                    },

                new Sport
                {
                    SportID = 11,
                    SportName = "Áo đội tuyển BRAZIL",
                    Description = "Mẫu quần áo bóng đá đội tuyển Brazil sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của đội tuyển:",
                    ImagePath ="brazill.jpg",
                    UnitPrice =120000,
                    CategoryID = 1
                    },
                new Sport
                {
                    SportID = 12,
                    SportName = "Áo đội tuyển ILALIA",
                    Description = "Mẫu quần áo bóng đá đội tuyển Ý sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của đội tuyển:",
                    ImagePath ="y.png",
                    UnitPrice =120000,
                    CategoryID = 1
                    },
                new Sport
                {
                    SportID = 13,
                    SportName = "Áo đội tuyển ĐỨC",
                    Description = "Mẫu quần áo bóng đá đội tuyển Đức sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của đội tuyển:",
                    ImagePath ="gemany.png",
                    UnitPrice =120000,
                    CategoryID = 1
                    },
                 new Sport
                {
                    SportID = 14,
                    SportName = "Áo đội tuyển HÀ LAN",
                    Description = "Mẫu quần áo bóng đá đội tuyển HÀ LAN sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của đội tuyển:",
                    ImagePath ="hl.jpg",
                    UnitPrice =120000,
                    CategoryID = 1
                    },
                 new Sport
                {
                    SportID = 15,
                    SportName = "Áo đội tuyển ARGENTINA",
                    Description = "Mẫu quần áo bóng đá đội tuyển HÀ LAN sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của đội tuyển:",
                    ImagePath ="argen.jpg",
                    UnitPrice =120000,
                    CategoryID = 1
                    },
                 new Sport
                {
                    SportID = 16,
                    SportName = "Áo đội tuyển TÂY BAN NHA",
                    Description = "Mẫu quần áo bóng đá đội tuyển TÂY BAN NHA sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của đội tuyển:",
                    ImagePath ="tbn.png",
                    UnitPrice =120000,
                    CategoryID = 1
                    },

                new Sport
                {
                    SportID = 3,
                    SportName = "CLB BARCALONA",
                    Description = " Mẫu quần áo bóng đá CLB Bacarlona sân khách , đây là mẫu quần áo bóng đá sân mùa giải mới của câu lạc bộ:",
                    ImagePath ="barcalona.jpg",
                    UnitPrice = 150000,
                    CategoryID = 2
                },
                new Sport
                {
                    SportID = 31,
                    SportName = "CLB JUVENTUS",
                    Description = "Mẫu quần áo bóng đá CLB Juventus sân nhà , đây là mẫu quần áo bóng đá sân mùa giải mới của câu lạc bộ:",
                    ImagePath ="juve.jpg",
                    UnitPrice = 150000,
                    CategoryID = 2
                },

                 new Sport
                {
                    SportID = 32,
                    SportName = "CLB Chelsea",
                    Description = "Mẫu quần áo bóng đá CLB Chelsea sân khách , đây là mẫu quần áo bóng đá sân mùa giải mới của câu lạc bộ:",
                    ImagePath ="chelsea.jpg",
                    UnitPrice = 150000,
                    CategoryID = 2
                },
                 new Sport
                {
                    SportID = 33,
                    SportName = "CLB AC Milan",
                    Description = "Áo sân nhà, chất liệu siêu tốt, body đẹp dáng",
                    ImagePath ="acmilan.jpg",
                    UnitPrice = 150000,
                    CategoryID = 2
                },
                new Sport
                {
                    SportID = 4,
                    SportName = "QUẦN ÁO BÓNG ĐÁ Z17 MÀU ĐỎ 2017",
                    Description = "Thêm một mẫu Z17 cập bến TTV để bạn lựa chọn, có 5 màu để bạn lựa chọn.",
                    ImagePath ="ao6.jpg",
                    UnitPrice = 150000,
                    CategoryID = 3
                },
                new Sport
                {
                    SportID = 4,
                    SportName = "QUẦN ÁO ĐÁ BANH Z17 MÀU TÌM MỚI NHẤT 2017",
                    Description = "Thêm một mẫu Z17 cập bến TTV để bạn lựa chọn, có 5 màu để bạn lựa chọn.",
                    ImagePath ="ao7.jpg",
                    UnitPrice = 150000,
                    CategoryID = 3
                },
                 new Sport
                {
                    SportID = 41,
                    SportName = "QUẦN ÁO ĐÁ BÓNG SAKKA 012 MÀU VÀNG XANH 2",
                    Description = "Mẫu áo bóng đá mới nhất tại Thể Thao VIP vào cuối tháng 08. Thiết kế ấn tượng và ko đụng hàng.",
                    ImagePath ="ao8.jpg",
                    UnitPrice = 150000,
                    CategoryID = 3
                },
                  new Sport
                {
                    SportID = 43,
                    SportName = "Quần áo đá bóng F50 caro mới màu xanh biển",
                    Description = "Mẫu áo bóng đá mới nhất tại Thể Thao VIP vào cuối tháng 08. Thiết kế ấn tượng và ko đụng hàng.",
                    ImagePath ="ao9.jpg",
                    UnitPrice = 150000,
                    CategoryID = 3
                },

                new Sport
                {
                    SportID = 5,
                    SportName = "Giày bóng đá Mizuno MRL CLUB AS Xanh/Than – P1GD191650",
                    Description = "Giày nhẹ, đủ mọi size cho các bạn yêu cầu.",
                    ImagePath ="giay3.jpg",
                    UnitPrice = 300000,
                    CategoryID = 4
                },
                new Sport
                {
                    SportID = 5,
                    SportName = "Giày đá bóng Mizuno Monar Neo Select AS-Đỏ/bạc – P1GD192652",
                    Description = "Giày nhẹ, đủ mọi size cho các bạn yêu cầu.",
                    ImagePath ="giay4.jpg",
                    UnitPrice = 300000,
                    CategoryID = 4
                },
                new Sport
                {
                    SportID = 5,
                    SportName = "Mizuno Monar Neo Select AS trắng đen P1GD192509",
                    Description = "Giày nhẹ, đủ mọi size cho các bạn yêu cầu.",
                    ImagePath ="giay5.jpg",
                    UnitPrice = 300000,
                    CategoryID = 4
                },


            };
            return sports;
        }
    }
}