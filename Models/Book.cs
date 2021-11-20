using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title {get;set;}

        public string ISBN { get; set; }

        public string RevisionNumber { get; set; }

        public string Publishdate { get; set; }

        public string Publisher { get; set; }

        public string Authors { get; set; }

        public string DateAdded { get; set; }

        public string BookGenre { get; set; }

        [Display(Name = "Book Cover")]
        public string BookImageUrl { get; set; }

        [NotMappedAttribute]
        public IFormFile BookImage { get; set; }
    }
}
