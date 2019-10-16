using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.Entity;

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
                    CategoryName = "Mèo Ta"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Mèo Nước Ngoài"
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
                    BookName = "Mèo Mướp",
                    Description = "Bộ lông có sọc vằn, đó là những đường vân có nhiều màu sắc khác nhau, tông màu chủ đạo là màu đen.",
                    ImagePath ="1.PNG",
                    UnitPrice = 200000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "Mèo Vàng",
                    Description = "Lông ngắn, thường có màu vàng hoặc vàng trắng.",
                    ImagePath ="2.PNG",
                    UnitPrice = 150000,
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Mèo Xiêm",
                    Description = " Thân hình dài, đầy đặn, khuôn mặt to tròn, dáng người rất giống với những chú mèo mướp hoặc mèo vàng khác",
                    ImagePath ="3.PNG",
                    UnitPrice = 168000,
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Anh lông dài",
                    Description = "Đầu to tròn, mắt tròn sáng, tai ngắn",
                    ImagePath ="4.PNG",
                    UnitPrice = 210000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 5,
                    BookName = "Mèo Ba Tư(Persian)",
                    Description = "Đầu to, mắt lớn, mũi nhỏ, tai nhỏ hình tam giác, thân hình săn chắc.",
                    ImagePath ="5.PNG",
                    UnitPrice = 230000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 6,
                    BookName = "Mèo tai cụp Scottish Fold",
                    Description = "Mèo này có quả tai vô cùng đặc biệt từ 2 - 3 nếp gấp, khiến tai chúng lúc nào cũng cụp xuống không ngóc đầu lên nổi (do gen tự nhiên).",
                    ImagePath = "6.PNG",
                    UnitPrice = 242000,
                    CategoryID = 2
                },

            };
            return books;
        }
    }
}