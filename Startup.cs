using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using web_project.Data;
using web_project.Hubs;
using web_project.Models;

namespace web_project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            //chatproject

            //services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<web_projectContext>();
            //services.AddControllersWithViews();
            //services.AddRazorPages();
            services.AddSignalR();


            services.ConfigureApplicationCookie(options =>
            {

                options.Cookie.HttpOnly = true;


                options.ExpireTimeSpan = TimeSpan.FromHours(2);
                options.LoginPath = "/Ideaaantity/Accaaount/Loaagin";
                options.LogoutPath = "/Identity/Account/Logout";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();

            services.AddDbContext<web_projectContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("web_projectContext")));
            //  services.AddDbContext<web_projectContext>(options =>
            //options.UseMySql(Configuration.GetConnectionString("web_projectContext")));
            services.AddSignalR();

            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<web_projectContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();
            app.UseSignalR(route =>
            {
                route.MapHub<ChatHub>("/Home/Index");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
