using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web_project.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Http;

namespace web_project.Data
{
    public class web_projectContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        IHttpContextAccessor _httpContextAccessor;
        public web_projectContext(DbContextOptions<web_projectContext> options , IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

          


        



        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var user = _httpContextAccessor.HttpContext.User;
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added)
                        .Select(t => t.Entity)
                        .ToArray();
           
            foreach (var entity in added)
            {
                var track = entity as BaseModel;
                track.CreatedDate = System.DateTime.Now;
                track.CreatedUserName = user.Identity.Name;
            }

            return base.SaveChanges();
        }
        public override int SaveChanges()
        {

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

          
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
         

        }



    }


  
    public class UserSeed : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.ToTable("AspNetUsers");
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();

            IdentityUser user = new IdentityUser()
            {
                Id = "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                UserName = "Admin",
                Email = "admin@outlook.com",
                NormalizedEmail = "admin@outlook.com",
                NormalizedUserName = "Admin",

            };
            
            user.PasswordHash = passwordHasher.HashPassword(user, "Password@123");
           
            builder.HasData
            (
                user               
            );
        }
    }
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.ToTable("AspNetRoles");

            builder.HasData
            (
                 new IdentityRole
                 {
                     Id = "1",
                     Name = "Admin",
                     ConcurrencyStamp = "1"
                 },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Teacher",
                    ConcurrencyStamp = "2"
                },
                 new IdentityRole
                 {
                     Id = "2",
                     Name = "Student",
                     ConcurrencyStamp = "2"
                 }
            );
        }
    }
   
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.ToTable("AspNetUserRoles");


            builder.HasData
            (
                 new IdentityUserRole<string>
                 {
                     UserId = "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                     RoleId = "1",

                 }
            );
        }
    }
  

    }
