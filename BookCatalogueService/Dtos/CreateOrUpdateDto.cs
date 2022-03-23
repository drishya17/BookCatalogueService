using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogueService.Dtos
{
    public class CreateOrUpdateDto
    {
        public string Title { get; set; }

        public string Author { get; set; }
    }
}
