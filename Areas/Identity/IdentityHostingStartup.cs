using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineLibrary.Data;

[assembly: HostingStartup(typeof(OnlineLibrary.Areas.Identity.IdentityHostingStartup))]
namespace OnlineLibrary.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OnlineLibraryContext>(options =>
                   options.UseMySql(
              context.Configuration.GetConnectionString("DefaultConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                   // .AddEntityFrameworkStores<OnlineLibraryContext>();
            });
        }
    }
}