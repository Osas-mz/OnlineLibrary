using Microsoft.AspNetCore.Identity;
using OnlineLibrary.Areas.Identity.Pages.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public static class MyIdentityDataInitializer
    {
        public static void SeedData(UserManager<ApplicationUser> userManager,
    RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
            AddUserToRole(userManager);
        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync("Liberian1").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Liberian1";
                user.Email = "liberian1@gmail.com";
                user.ImageUrl = "grace";
                //user.FullName = "Nancy Davolio";
                //user.BirthDate = new DateTime(1960, 1, 1);

                IdentityResult result = userManager.CreateAsync
                (user, "admin_GRACE7").Result;

                var t = "grace gracw";
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,"admin").Wait();
                }
            }


           
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            


            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
              IdentityRole   role = new IdentityRole();
                role.Name = "Administrator";
               // role.Description = "Perform all the operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
        public static void SeedUserToRole(RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {



            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                // role.Description = "Perform all the operations.";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }

        public static void AddUserToRole(UserManager<ApplicationUser> userManager)
        {
            var usa = userManager.FindByNameAsync("Liberian1").Result;
            var res =  userManager.IsInRoleAsync(usa, "Admin").Result;
            if (!res)
            {
                userManager.AddToRoleAsync(usa, "Admin");
            }

        }
    }
}
