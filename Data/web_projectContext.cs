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
                Email = "ruchikamperera@outlook.com",
                NormalizedEmail = "ruchikamperera@outlook.com",
                NormalizedUserName = "Admin",

            };
            IdentityUser user1 = new IdentityUser()
            {
                Id = "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                UserName = "Admin",
                Email = "senath@outlook.com",
                NormalizedEmail = "ruchikamperera@outlook.com",
                NormalizedUserName = "Senath_Admin",

            };

            IdentityUser user2 = new IdentityUser()
            {
                Id = "11e3e2cd-b94a-4996-b684-17b9d88f9841",
                UserName = "TestAdmin",
                Email = "TestAdmin@outlook.com",
                NormalizedEmail = "ruchikamperera@outlook.com",
                NormalizedUserName = "Senath_Admin",

            };
            IdentityUser Nadeesha = new IdentityUser()
            {
                Id = "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                UserName = "Nadeesha",
                Email = "Nadeesha@outlook.com",
                NormalizedEmail = "Nadeesha@outlook.com",
                NormalizedUserName = "Nadeesha",
               

            };
            Nadeesha.PasswordHash = passwordHasher.HashPassword(Nadeesha, "Nadeesha@199328");

            IdentityUser Mekala = new IdentityUser()
            {
                Id = "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                UserName = "Mekala",
                Email = "Mekala@outlook.com",
                NormalizedEmail = "Mekala@outlook.com",
                NormalizedUserName = "Mekala",


            };
            Mekala.PasswordHash = passwordHasher.HashPassword(Mekala, "Mekala&1989");

            IdentityUser Dinali = new IdentityUser()
            {
                Id = "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                UserName = "Dinali",
                Email = "Dinali@outlook.com",
                NormalizedEmail = "Dinali@outlook.com",
                NormalizedUserName = "Dinali",


            };
            Dinali.PasswordHash = passwordHasher.HashPassword(Dinali, "Dinali@0104");

            IdentityUser MADUKA = new IdentityUser()
            {
                Id = "19ede2cc-b94a-4996-b684-17b5d78f986c",
                UserName = "MADUKA",
                Email = "MADUKA@outlook.com",
                NormalizedEmail = "MADUKA@outlook.com",
                NormalizedUserName = "MADUKA",


            };
            MADUKA.PasswordHash = passwordHasher.HashPassword(MADUKA, "MADUKA@123");

            IdentityUser Kosala = new IdentityUser()
            {
                Id = "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                UserName = "Kosala",
                Email = "Kosala@outlook.com",
                NormalizedEmail = "Kosala@outlook.com",
                NormalizedUserName = "Kosala",


            };
            
            Kosala.PasswordHash = passwordHasher.HashPassword(Kosala, "Kosala@1234");

            IdentityUser Gamage = new IdentityUser()
            {
                Id = "99ede2cc-b94a-4996-b684-17b5d78f986c",
                UserName = "Gamage",
                Email = "Gamage@outlook.com",
                NormalizedEmail = "Gamage@outlook.com",
                NormalizedUserName = "Gamage",


            };
            Gamage.PasswordHash = passwordHasher.HashPassword(Gamage, "Gamage@1234");


            user.PasswordHash = passwordHasher.HashPassword(user, "Password@1996");
            user1.PasswordHash = passwordHasher.HashPassword(user1, "Password@12345");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "TestAdmin@123");



            builder.HasData
            (
                user,
                user1,
                Nadeesha,
                Mekala,
                Dinali,
                MADUKA,
                Kosala,
                Gamage
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
