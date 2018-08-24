using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API
{
    public class BooksDataStore
    {
        public static BooksDataStore Current { get; } = new BooksDataStore();
        public List<BookDTO> Books { get; set; }
        public BooksDataStore()
        {
            Books = new List<BookDTO>(){
                new BookDTO()
                {
                    Id = 1,
                    Name = "Book 1",
                    Category = "Sci-Fi"
                },
                new BookDTO()
                {
                    Id = 2,
                    Name = "Book 2",
                    Category = "History"
                }
            };
            
        }
    }
}
