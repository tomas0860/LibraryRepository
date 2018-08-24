using Library.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [Route("api/books")]
    public class BooksController : Controller
    {
        [HttpGet()]
        public IActionResult GetBooks()
        {
            return Ok(BooksDataStore.Current.Books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = BooksDataStore.Current.Books.FirstOrDefault(b => b.Id == id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
