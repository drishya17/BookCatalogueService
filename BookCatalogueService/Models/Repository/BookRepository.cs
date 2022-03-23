using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogueService.Models.Repository
{
    public class BookRepository : IBook
    {
        /// <summary>
        /// _books
        /// </summary>
        private  List<Book> _books ;

        public BookRepository()
        {
            _books.Add( new Book { Id = Guid.NewGuid(), Title = "Kids Story Book", Author = "Laskshmy" , ISBN=6564543433339 , PublicationDate =DateTime.Now} );
        }

        public void CreateBook(Book book)
        {
            _books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            _books.Remove(book);
        }

        public Book GetBook(Guid id)
        {
            var book = _books.Where(x => x.Id == id).SingleOrDefault();
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }

        public void UpdateBook(Guid id, Book book)
        {
            var bookindex = _books.FindIndex(x => x.Id == id);
            if (bookindex > -1)
                _books[bookindex] = book;
        }
    }
}


