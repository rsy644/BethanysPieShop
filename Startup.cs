using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BethanysPieShop.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BethanysPieShop
{
    
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        

    public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();
            services.AddScoped<IPieRepository, PieRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            // when the user comes to my site, I am going to create a scoped shopping cart using the 'GetCart' method.

            services.AddRazorPages();
            services.AddHttpContextAccessor();
            services.AddSession();
            services.AddControllersWithViews(); // replaces services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // middleware components. Takes http request and outputs http response.
        {
            if (env.IsDevelopment())
            {
                app.UseHttpsRedirection();                
                app.UseStaticFiles();
                
            }

            app.UseRouting(); // Middleware that will enable MVC routing in our application.
            app.UseAuthentication(); // To use with asp net core identity.
            app.UseAuthorization();
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseEndpoints(endpoints => // Will accept a collection of endpoints.
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); // three segments. Controller, action, id parameter.
                endpoints.MapRazorPages();
            });
        }
    }
}
