using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class BookCheckinCheckout
    {
        [Key]
       public int CheckOutId { get; set; }

       public int CheckStatus { get; set; }

        public int CheckOutStatus { get; set; }

        public int CheckInStatus { get; set; }

        public string CheckInDate { get; set; }

        public string CheckOutdate { get; set; }

        public string readerId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
    }
}
