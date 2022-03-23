using BookCatalogueService.Dtos;
using BookCatalogueService.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BookCatalogueService.Models;

namespace BookCatalogueService.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBook _Ibook;

        public BookController(IBook book)
        {
            _Ibook = book;
        }
        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return _Ibook.GetBooks();
        }

        [HttpGet("{id}")]
        public ActionResult<BookDTO> GetBook(Guid id)
        {
            var book = _Ibook.GetBook(id);
            if (book == null)
                return NotFound();
            var bookDto = new BookDTO { Id = book.Id, Title = book.Title};
            return bookDto;
        }


        [HttpPost]
        public ActionResult<Book> CreatBook(CreateOrUpdateDto book)
        {
            var newBook = new Book();
            newBook.Title = book.Title;
            newBook.Id = Guid.NewGuid();

            _Ibook.CreateBook(newBook);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<BookDTO> UpdateBook(Guid id, CreateOrUpdateDto book)
        {
            var mybook = _Ibook.GetBook(id);
            if (mybook == null)
            {
                return NotFound();
            }
            mybook.Author = book.Author;
            mybook.Title = book.Title;
            mybook.Id = Guid.NewGuid();

            _Ibook.UpdateBook(id, mybook);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<BookDTO> DeleteBook(Guid id)
        {
            var mybook = _Ibook.GetBook(id);
            if (mybook == null)
            {
                return NotFound();
            }
            _Ibook.DeleteBook(mybook);
            return Ok();
        }
    }
}
