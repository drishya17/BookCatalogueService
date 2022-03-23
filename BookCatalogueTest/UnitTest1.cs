using BookCatalogueService.Controllers;
using BookCatalogueService.Models;
using BookCatalogueService.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace BookCatalogueTest
{
    public class BookCatalogueTestMethods
    {
        private readonly Mock<BookRepository> service;
        public BookCatalogueTestMethods()
        {
            service = new Mock<BookRepository>();
        }
        [Fact]
        public void GetBook_BookExistsInRepo()
        {
            //arrange
            // var book = GetSampleBook();
            service.Setup(x => x.GetBooks())
                .Returns(GetSampleBook);
            var controller = new BookController(service.Object);

            //act
            var actionResult = controller.GetBooks();
            var result = actionResult as OkObjectResult;
            var actual = result.Value as IEnumerable<Book>;

            //assert
            Assert.Equal(GetSampleBook().ToArray().Length, actual.ToString().Length);
        }
        [Fact]
        public void GetBookById_BookwithSpecificIdExists()
        {
            //arrange
            var books = GetSampleBook();

            Guid g = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00");
            var firstBook = books[0];
            service.Setup(x => x.GetBook((Guid)g))
                .Returns(firstBook);
            var controller = new BookController(service.Object);

            //act
            var actionResult = controller.GetBook((Guid)g);

            //Assert
            Assert.IsType<OkObjectResult>(actionResult);

        }
        [Fact]
        public void GetBookById_BookWithIDNotExists()
        {
            //arrange
            Guid g = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00");
            var books = GetSampleBook();
            var firstbook = books[0];
            service.Setup(x => x.GetBook((Guid)g))
                .Returns(firstbook);
            var controller = new BookController(service.Object);

            //act
            var actionResult = controller.GetBook((Guid)g);

            //assert
            var result = actionResult;
            Assert.IsType<NotFoundObjectResult>(result);
        }
        private List<Book> GetSampleBook()
        {
            Guid g = new Guid("11223344-5566-7788-99AA-BBCCDDEEFF00");
            Guid hg = new Guid("112233474-5566-7788-99AA-BBCCDDEEFF00");
            List<Book> output = new List<Book>
            {
                new Book
                {
                     Title = "Asp.NET Core",
                    Id = g,
                    Author = "Jhon",
                    ISBN = 2342342,
                    PublicationDate = DateTime.Parse("23-08-2020")
                },
                new Book
                {
                  Title = "Asp.NET Web API",
                    Id = hg,
                    Author = "Alexis",
                    ISBN = 4545,
                    PublicationDate = DateTime.Parse("23-08-2020")
                }
            };
            return output;

        }
    }
}
