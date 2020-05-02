using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalManager.Data.Entities;
using PersonalManager.Models;

[assembly: HostingStartup(typeof(PersonalManager.Areas.Identity.IdentityHostingStartup))]
namespace PersonalManager.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PersonalManagerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ManagerConnectionString")));

                services.AddIdentity<User, IdentityRole>()
                         .AddEntityFrameworkStores<PersonalManagerContext>();
            });
        }
    }
}