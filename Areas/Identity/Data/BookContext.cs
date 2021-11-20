using Microsoft.EntityFrameworkCore;
using OnlineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Areas.Identity.Data
{
    public class BookContext:DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Book> Books { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<BookCheckinCheckout> BookCheckinCheckouts { get; set; }


        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            //Database.EnsureCreated();

        }
    }
}
