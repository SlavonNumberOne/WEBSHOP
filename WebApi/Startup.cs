using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShop.DataAccess.Context;
using WebShopDataAccesLear;
using WebShop.DataAccess.Initialization;
using Microsoft.Extensions.Logging;
using WebShop.BusinessLogic.Servises;
using WebShop.BusinessLogic.Servises.Interface;
using WebShop.DataAccess.Interfaces;
using WebShop.DataAccess.EFRepositories;
using WebShop.BusinessLogic.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpsPolicy;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddControllers();

            services.AddEntityFrameworkSqlServer()
                .AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
            services.AddTransient<IBookService, BookService>();
           // services.AddTransient<IAccountService, AccountService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUserRepositive, UserRepository>();
            services.AddScoped<ApplicationContext>();
            services.AddScoped<DataBaseInitialization>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env, DataBaseInitialization dataBase, ILoggerFactory loggerFactory  )
        {
            // IBookService service = app.ApplicationServices.GetService<IBookService>();

            dataBase.Initialize();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // other code remove for clarity 
            loggerFactory.AddFile("Logs/mylog-{Date}.txt");

            

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "default",
                 template: "api/{controller}/{action}/{id?}");
            });

        }
    }
}
