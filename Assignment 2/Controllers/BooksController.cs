using Assignment_2.Managers;
using Assignment1;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_2.Controllers
{
    //api/Books
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookManager _manager = new BookManager();
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{ISBN13}")]
        public Book Get(String ISBN13)
        {
            return _manager.Get(ISBN13);
        }

        // POST api/<BooksController>
        [HttpPost]
        public Book Post([FromBody] Book book )
        {
           // var book = JsonSerializer.Deserialize<Book>(value);
           
            return _manager.create(book);
            
        }

        // PUT api/<BooksController>/5
        [HttpPut("{ISBN13}")]
        public Book Put(String ISBN13, [FromBody] Book book)
        {
           // var book = JsonSerializer.Deserialize<Book>(value);
            return _manager.Update(ISBN13, book);

            
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{ISBN13}")]
        public Book Delete(String ISBN13)
        {
            return _manager.Delete(ISBN13);
        }
    }
}
