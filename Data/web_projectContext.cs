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
            }

            return base.SaveChanges();
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //chatapplication

            //base.OnModelCreating(builder);
            //builder.Entity<Message>()
            //.HasOne<AppUser>(a => a.Sender)
            //.WithMany(d => d.Messages)
            //.HasForeignKey(d => d.UserID);

            base.OnModelCreating(builder);

          
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new BankSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
         

        }

        public DbSet<web_project.Models.Class> Class { get; set; }
        public DbSet<web_project.Models.Message> Messages { get; set; }


        public DbSet<web_project.Models.RegistedStudent> RegistedStudent { get; set; }

        public DbSet<web_project.Models.User> User { get; set; }


        public DbSet<web_project.Models.Contact> Contact { get; set; }

    }
    public class BankSeed : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable("Bank");

            builder.HasData
            (

                 new Bank
                 {
                     Id = 1,
                     Name = "Commercial Bank of Ceylon",
                 },
                                  new Bank
                                  {
                                      Id = 2,
                                      Name = "Sampath Bank Plc",
                                  },
                                                   new Bank
                                                   {
                                                       Id = 3,
                                                       Name = "National Savings Bank",
                                                   },
                             new Bank
                             {
                                 Id = 4,
                                 Name = "People’s Bank",
                             },
                                              new Bank
                                              {
                                                  Id = 5,
                                                  Name = "Hatton National Bank",
                                              },
                                                               new Bank
                                                               {
                                                                   Id = 6,
                                                                   Name = "Seylan Bank Plc",
                                                               },
                                                                                new Bank
                                                                                {
                                                                                    Id = 7,
                                                                                    Name = "National Development Bank Plc",
                                                                                },
                                  new Bank
                                  {
                                      Id = 8,
                                      Name = "Amana Bank",
                                  },
                                                   new Bank
                                                   {
                                                       Id = 9,
                                                       Name = "Nations Trust Bank Plc",
                                                   },
                                                               new Bank
                                                               {
                                                                   Id = 10,
                                                                   Name = "DFCC Bank",
                                                               }
                                                               );
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
                     NormalizedName = "Admin",
                     ConcurrencyStamp = "1"
                 },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Teacher",
                    NormalizedName = "Teacher",
                    ConcurrencyStamp = "2"
                },
                 new IdentityRole
                 {
                     Id = "3",
                     Name = "Student",
                     NormalizedName = "Student",
                     ConcurrencyStamp = "3"
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
            ) ;
        }
    }
  

    }
