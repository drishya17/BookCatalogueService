using System;

namespace BookCatalogueService
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public long ISBN { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
