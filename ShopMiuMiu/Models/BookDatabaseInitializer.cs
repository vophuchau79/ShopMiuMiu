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
                    CategoryName = "MÈO KATTY"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "MÈO DOREMOM"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "MÈO QUEEN ANN"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "MÈO MILK"
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
                    BookName = "Queen",
                    Description = "Mật Pet",
                    ImagePath ="cat1.jpg",
                    UnitPrice = 179.79f,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "King",
                    Description = "Miu Miu",
                    ImagePath ="cat2.jpg",
                    UnitPrice = 169.96f,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Lu Lu",
                    Description = "Gấu Pet",
                    ImagePath ="cat3.jpg",
                    UnitPrice = 168.68f,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Ki Ki",
                    Description = "Zon Pet",
                    ImagePath ="cat4.jpg",
                    UnitPrice = 210.10f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 5,
                    BookName = "Alan",
                    Description = "Xu Pet",
                    ImagePath ="cat5.jpg",
                    UnitPrice = 220.20f,
                    CategoryID = 4
                },
                new Book
                {
                    BookID = 6,
                    BookName = "Xu ka",
                    Description = "Garen",
                    ImagePath = "cat6.jpg",
                    UnitPrice = 211.11f,
                    CategoryID = 1
                },

            };
            return books;
        }
    }
}