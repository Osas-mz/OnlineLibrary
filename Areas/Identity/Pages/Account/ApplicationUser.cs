using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Areas.Identity.Pages.Account
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string ImageUrl { get; set; }
    }
}
