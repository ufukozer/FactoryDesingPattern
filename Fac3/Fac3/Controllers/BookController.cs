using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fac3.Factories;
using Fac3.Models;
using Fac3.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fac3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        DataContextFactory<BookService> dataContextFactory = new DataContextFactory<BookService>();
        [HttpGet]
        public IActionResult GetBooks()
        {
            dataContextFactory.Instance.Insert(new Book()
            {
                CreateDate = DateTime.UtcNow,
                Name = "xxa"
            });
            IEnumerable<Book> books = dataContextFactory.Instance.List().ToList();
            return new JsonResult(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            Book book = dataContextFactory.Instance.Get(id);
            return new JsonResult(book);
        }
        [HttpGet("{id}")]
        public void DeleteBook(int id)
        {
            dataContextFactory.Instance.Delete(id);
        }
        [HttpGet("{id}")]
        public IActionResult UpdateBook(Book book)
        {
            Book Book = dataContextFactory.Instance.Update(book);
            return new JsonResult(book);
        }
        [HttpPost]
        public IActionResult PostBook(Book book)
        {
            dataContextFactory.Instance.Insert(book);
            return new JsonResult(book);
        }
    }
}