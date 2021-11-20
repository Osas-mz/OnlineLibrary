using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineLibrary.Areas.Identity.Pages.Account;
using OnlineLibrary.Models;

namespace OnlineLibrary.Data
{
    public class OnlineLibraryContext : IdentityDbContext<ApplicationUser>
    {

      


        public OnlineLibraryContext(DbContextOptions<OnlineLibraryContext> options) : base(options)
        {
            //Database.EnsureCreated();

        }
    }

}
