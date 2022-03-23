using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace BookCatalogueService.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        /// <summary>
        /// Add a Book
        /// </summary>
        /// <returns></returns>
        [HttpPost,Route("add")]
        public IEnumerable<string> AddBook()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get list of Books
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string GetBookList(int id)
        {
            return "value";
        }

        /// <summary>
        /// Update the Book
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void UpdateBook([FromBody] string value)
        {
        }

        
        /// <summary>
        /// Delete the Book
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteBook(int id)
        {

        }
    }
}
