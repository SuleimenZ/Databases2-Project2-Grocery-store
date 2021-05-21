using System;
using Databases_2_Project2_Grocery_store.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Databases_2_Project2_Grocery_store.Areas.Identity.IdentityHostingStartup))]
namespace Databases_2_Project2_Grocery_store.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityContext>(options =>
                    options.UseNpgsql(
                        context.Configuration.GetConnectionString("IdentityContextConnection"), o => o.SetPostgresVersion(9,6)));

                services.AddDefaultIdentity<IdentityUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    })
                    .AddEntityFrameworkStores<IdentityContext>();
            });
        }
    }
}