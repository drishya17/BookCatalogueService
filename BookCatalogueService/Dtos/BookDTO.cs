using System;

namespace BookCatalogueService
{
    public class BookDTO
    {

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public long ISBN { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
