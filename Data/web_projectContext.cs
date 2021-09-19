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


        public DbSet<web_project.Models.Feedback> Feedback { get; set; }

        public DbSet<web_project.Models.Staff> Staff { get; set; }

        public DbSet<web_project.Models.FestivalAdvance> FestivalAdvance { get; set; }

        public DbSet<web_project.Models.InsuranceDetails> InsuranceDetails { get; set; }

        public DbSet<web_project.Models.Donation> Donation { get; set; }

        public DbSet<web_project.Models.GeneralSetting> GeneralSetting { get; set; }

        public DbSet<web_project.Models.EmployeeClearance> EmployeeClearance { get; set; }

        public DbSet<web_project.Models.Gratuity> Gratuity { get; set; }

        public DbSet<web_project.Models.Location> Location { get; set; }

        public DbSet<web_project.Models.SalaryAdvance> SalaryAdvance { get; set; }

        public DbSet<web_project.Models.Allowance> Allowance { get; set; }
        public DbSet<web_project.Models.ReportType> ReportType { get; set; }
        public DbSet<web_project.Models.Report> Report { get; set; }
        public DbSet<web_project.Models.DeductionHistory> DeductionHistory { get; set; }
        public DbSet<web_project.Models.SalaryType> SalaryType { get; set; }
        public DbSet<web_project.Models.MonthEnd> MonthEnd { get; set; }
        public DbSet<web_project.Models.Rank> Rank { get; set; }

        public DbSet<web_project.Models.AllowanceType> AllowanceType { get; set; }
        public DbSet<web_project.Models.DeductionType> DeductionType { get; set; }
        public DbSet<web_project.Models.TempAttendance> TempAttendance { get; set; }
        public DbSet<web_project.Models.StaffAttendance> StaffAttendance { get; set; }


        



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

            builder.ApplyConfiguration(new ReportTypeSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new SalaryTypeSeed());
            builder.ApplyConfiguration(new AllowancesTypeSeed());
            builder.ApplyConfiguration(new DeductionTypeSeed());
            builder.ApplyConfiguration(new RankSeed());
            builder.ApplyConfiguration(new BasicSalarySeed());
            builder.ApplyConfiguration(new SectorSeed());




        }

        public DbSet<web_project.Models.Deduction> Deduction { get; set; }

        public DbSet<web_project.Models.Salary> Salary { get; set; }

        public DbSet<web_project.Models.BasicSalary> BasicSalary { get; set; }
        public DbSet<web_project.Models.Sector> Sector { get; set; }
        public DbSet<web_project.Models.EnterAttendance> EnterAttendance { get; set; }
        public DbSet<web_project.Models.StaffAttendanceDetails> StaffAttendanceDetails { get; set; }
        public DbSet<web_project.Models.StopSalary> StopSalary { get; set; }


    }


    public class ReportTypeSeed : IEntityTypeConfiguration<ReportType>
    {
        public void Configure(EntityTypeBuilder<ReportType> builder)
        {
            builder.ToTable("ReportType");
            builder.Property(s => s.Name)
                .IsRequired(false);

            builder.HasData
            (
                            // Loan and Advance Report

                            // Advance
                            new ReportType
                            {
                                Id = 1,
                                Name = "Advance_All",
                                Cols = "Emp No,Name,Account No,Advance Amount"
                            },
                            new ReportType
                            {
                                Id = 2,
                                Name = "Advance_Cash",
                                Cols = "Emp No,Name,Cash Amount"
                            },
                            new ReportType
                            {
                                Id = 3,
                                Name = "Advance_Bank",
                                Cols = "Emp No,Name,Account No,Bank Amount"
                            },
                            // Loan
                            new ReportType
                            {
                                Id = 4,
                                Name = "Loan_All",
                                Cols = "Emp No,Name,Account No,Loan Amount"
                            },
                            new ReportType
                            {
                                Id = 5,
                                Name = "Loan_Cash",
                                Cols = "Emp No,Name,Loan Cash Amount"
                            },
                            new ReportType
                            {
                                Id = 6,
                                Name = "Loan_Bank",
                                Cols = "Emp No,Name,Account No,Loan Bank Amount"
                            },
                new ReportType
                {
                    Id = 7,
                    Name = "Loan Payment",
                    Cols = "No,Emp No,Name,Rank,Location,Shifts,Gross,Loan,Balance"
                },

                // Employees
                new ReportType
                {
                    Id = 8,
                    Name = "All Employee Details",
                    Cols = "EMP.NO.,SURNAME & INITIALS,LOC. NO.,LOC. NAME,ADDRESS,RANK,BRANCH,A/C NO.,EPF NO.,NIC NO.,Join Date"
                },
                new ReportType
                {
                    Id = 9,
                    Name = "Employee Clearance",
                    Cols = "Emp No,Name,Rank,DOJ,L/D Worked DOR,Active,Cleared"
                },
                // Attendance 

                /*new ReportType
                {
                    Id = 6,
                    Name = "Date Wise"
                },
                new ReportType
                {
                    Id = 7,
                    Name = "Location Wise"
                },
                new ReportType
                {
                    Id = 8,
                    Name = "Employee Wise"
                }, */

                new ReportType
                {
                    Id = 10,
                    Name = "Shift Wise",
                    Cols = "Emp No,Name,Location,Shifts,Date,"
                },
                // Salary Reports
                new ReportType
                {
                    Id = 11,
                    Name = "Total Earning",
                    Cols = "Emp.No.,Name,Rank,Budget,Cost of Liv.,Dty. Allo.,O.T. Amt.,Uni. Upkeep,Risk Allo.,Ration Allo.,Budget Allo. 2015,Extra Duty Allo.,Sp. Allo. Western,Aviation Allo.,Travel All. +Festiva,Meal Allo.,Sp. Trans. Allo.,Hostel Fuel Other,Arr Refund,Arms.SS,Bike Allo.,Total Earn.,Tot Shi,OT,Incentive Allowance,Incentive"
                },
                new ReportType
                {
                    Id = 12,
                    Name = "Total Deductions",
                    Cols = "Emp No,Name,Rank,EPF No.,EPF,Basic Sal.,Death Do.& Welfar,Death Reco.,Uniform,Sport,Co-Operative.,Supportline Ins.,Twenty Forty Ins.,Peer.Acci.Ceylinco,Loan Reco.,Medi Check,Salary Adv.,Fine & Pen.,Fes.Adv.,Don. Reco.,Meal Deduc,ID Cost,Spect Ded,Tot.Ded.,Net Salary"
                },
                new ReportType
                {
                    Id = 13,
                    Name = "Earning and Deduction",
                    Cols = "Location Number,Location Name,Employee Number,Name,Rank,Total Shifts,Total OT Hours,Duty Allowance,Basic Salary,Budget Allowance,Budget Allowance ,Hostel In charge Allowance,Risk Allowance,Aviation Allowance,Arrears and Refund,Festival Advance,Travelling Allowance,Fuel Allowance,ARMS Allowance,Extra Duty Allowance,Extra OT Allowance,Bike Maintenance,Meal Allowance,Bonus,Uniform ,Upkeep Makeup,Uniform Upkeeping,Ration Allowance,Western Allowance,Overtime,Transport Allowance,Performance Allowance,Incentive,Incentive Allowance,Other Earnings,Total Earnings,EPF 8%,No pay,Bank Charges,Death Donation,Medical Checkup,Uniform Deduction,Sport Uniform Deduction,Loan Recovery,Salary Advance,Meal Deductions,Insurance Per. Acc. Co-Operative,insurance Support line,insurance 24x7,ID ,Cost,Special Deduction II,Fine and Penalty,Mobile Phone Deduction,Festival Advance,Welfare Deduction,Stamp Duty,Other Deductions,EPF Salary,Total Deductions,Net Salary,Bank Code,Branch Code,Account Number"
                },
                new ReportType
                {
                    Id = 14,
                    Name = "Bank Payment",
                    Cols = "Emp No,Name,NIC No.,A/C. No.,Salary Amt"
                },
                new ReportType
                {
                    Id = 15,
                    Name = "Cash Payment",
                    Cols = "Emp. No.,Name,Rank,Tot.Ear.,Tot.Ded.,Salary Amt."
                },
                new ReportType
                {
                    Id = 16,
                    Name = "Late Payment",
                    Cols = "Emp. No.,Name,Account No.,Rank,Tot.Shifts,Tot.Ear.,Total Ded.,Salary Amount"
                },

                            // Salary Deductions

                            new ReportType
                            {
                                Id = 17,
                                Name = "Death Donation Deductions",
                                Cols = "Emp No,Name,Rank,Amount"
                            },
                            new ReportType
                            {
                                Id = 18,
                                Name = "Medical Checkup Deductions",
                                Cols = "Emp. No.,Name,Rank,M.C. Charges"
                            },
                            new ReportType
                            {
                                Id = 19,
                                Name = "Uniform Deductions",
                                Cols = "Emp. No.,Name,Rank,Uniform Deduction"
                            },
                            new ReportType
                            {
                                Id = 20,
                                Name = "Sport Uniform Deductions",
                                Cols = "Emp. No.,Name,Rank,Sport Uniform"
                            },
                            new ReportType
                            {
                                Id = 21,
                                Name = "Loan Recovery Deductions",
                                Cols = "Emp. No.,Name,Rank,Loan Recovery"
                            },
                            new ReportType
                            {
                                Id = 22,
                                Name = "Salary Advance Deductions",
                                Cols = "Emp. No.,Name,Rank,Salary Advance"
                            },
                            new ReportType
                            {
                                Id = 23,
                                Name = "Meal Deductions",
                                Cols = "Emp. No.,Name,Rank,Meal Deduction"
                            },
                            new ReportType
                            {
                                Id = 24,
                                Name = "Insurance Deductions",
                                Cols = "Emp. No.,Name,Rank,Amount"
                            },
                            new ReportType
                            {
                                Id = 25,
                                Name = "Special Deductions ll",
                                Cols = "Emp. No.,Name,Rank,Special Deduction"
                            },
                            new ReportType
                            {
                                Id = 26,
                                Name = "Fine and Penalty Deductions",
                                Cols = "Emp. No.,Name,Rank,Fine and Penalty"
                            },
                            new ReportType
                            {
                                Id = 27,
                                Name = "Mobile Phone Deductions",
                                Cols = "Emp. No.,Name,Rank,Mobile Phone"
                            },
                            new ReportType
                            {
                                Id = 28,
                                Name = "Donation Recovery Deductions",
                                Cols = ""
                            },
                            new ReportType
                            {
                                Id = 29,
                                Name = "Festival Advance Deductions",
                                Cols = "Emp. No.,Name,Rank,Festival Advance"
                            },
                            new ReportType
                            {
                                Id = 30,
                                Name = "Welfare Deductions",
                                Cols = "Emp. No.,Name,Rank,Amount"
                            },

                            //Pay Reports

                            new ReportType
                            {
                                Id = 31,
                                Name = "Pay slip",
                                Cols = ""
                            },
                            new ReportType
                            {
                                Id = 32,
                                Name = "Pay sheet",
                                Cols = "Emp No,Name,Rank,Gross Salary(Rs.),Deductions(Rs.),Net Salary(Rs.),Date,Signature"
                            },
                            new ReportType
                            {
                                Id = 33,
                                Name = "Pay Summary",
                                Cols = ""
                            },
                            new ReportType
                            {
                                Id = 34,
                                Name = "Pay Analyzer",
                                Cols = "Month,Pay Strength,Total Earnings,Total Deductions,Net Salary,Average"
                            },

                            // EPF/ETF Reports  
                            new ReportType
                            {
                                Id = 35,
                                Name = "EPF/ETF H-O List",
                                Cols = "No.,Emp No,Name,Location No,Location,EPF No,Signature"
                            },
                            new ReportType
                            {
                                Id = 36,
                                Name = "EPF/ETF Statement",
                                Cols = "No.,Emp No,Name,Location No,Location,EPF No,Signature"
                            },
                            new ReportType
                            {
                                Id = 37,
                                Name = "ETF 6 Month Return",
                                Cols = ""
                            },
                            new ReportType
                            {
                                Id = 38,
                                Name = "EPF E Return",
                                Cols = "NIC Number,Surname,Initial,EPF No.,Tot. Con.,Emp. Con.,Mem. Con.,B. Sal.,Emp. No.,No. Of Days"
                            },

                            // Deduction Balance 
                            new ReportType
                            {
                                Id = 39,
                                Name = "Insurance",
                                Cols = "Emp No,Name,Rank,Premium,Paid Amount,Balance"
                            },
                            new ReportType
                            {
                                Id = 40,
                                Name = "Uniform",
                                Cols = "Emp No,Name,Rank,TotalAmount,Paid Amount,Balance"
                            },
                            new ReportType
                            {
                                Id = 41,
                                Name = "Sport Uniforms",
                                Cols = "Emp No,Name,Rank,Total Amount,Paid Amount,Balance"
                            },
                            new ReportType
                            {
                                Id = 42,
                                Name = "Fine And Penalty",
                                Cols = "Emp No,Name,Rank,TotalAmount,Paid Amount,Balance"
                            },
                            new ReportType
                            {
                                Id = 43,
                                Name = "Donations",
                                Cols = "Emp No.,Name,Rank,Tot. Balance,Paid Amount,Balance"
                            },
                            new ReportType
                            {
                                Id = 44,
                                Name = "Festival Advance",
                                Cols = "Emp No,Name,Rank,Full Amount,Paid Amount,Balance"
                            },
                            new ReportType
                            {
                                Id = 45,
                                Name = "Death Deductions",
                                Cols = "Emp. No.,Name,Rank,Available Balance"
                            },
                            new ReportType
                            {
                                Id = 46,
                                Name = "Fixed Deductions",
                                Cols = "Emp.No.,Name,Rank,Deduction,Amount,Balance"
                            },
                // Locations 
                new ReportType
                {
                    Id = 47,
                    Name = "Locations Report",
                    Cols = "Sector,Location No.,Location Name"
                }

            // 
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
                    Name = "Officer",
                    ConcurrencyStamp = "2"
                }
            );
        }
    }
    public class RankSeed : IEntityTypeConfiguration<Rank>
    {
        public void Configure(EntityTypeBuilder<Rank> builder)
        {
            builder.ToTable("Rank");

            builder.HasData
            (
                 new Rank
                 {
                     Id = 1,
                     Name = "JSO",

                 },
                new Rank
                {
                    Id = 2,
                    Name = "LSO",

                },
                 new Rank
                 {
                     Id = 3,
                     Name = "SSO",

                 },
                  new Rank
                  {
                      Id = 4,
                      Name = "OIC",

                  },
                   new Rank
                   {
                       Id = 5,
                       Name = "CSO",

                   }
            );
        }
    }
    public class BasicSalarySeed : IEntityTypeConfiguration<BasicSalary>
    {
        public void Configure(EntityTypeBuilder<BasicSalary> builder)
        {
            builder.ToTable("BasicSalary");

            builder.HasData
            (
                 new BasicSalary
                 {
                     Id = 1,
                     Amount = 10000,
                     RankId = 1,
                     Increment = 100

                 },
                new BasicSalary
                {
                    Id = 2,
                    Amount = 10000,
                    RankId = 2,
                    Increment = 100

                },
                 new BasicSalary
                 {
                     Id = 3,
                     Amount = 10000,
                     RankId = 3,
                     Increment = 100

                 },
                  new BasicSalary
                  {
                      Id = 4,
                      Amount = 10620,
                      RankId = 4,
                      Increment = 150


                  },
                   new BasicSalary
                   {
                       Id = 5,
                       Amount = 10620,
                       RankId = 5,
                       Increment = 150


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
    public class AllowancesTypeSeed : IEntityTypeConfiguration<AllowanceType>
    {
        public void Configure(EntityTypeBuilder<AllowanceType> builder)
        {
            builder.ToTable("AllowanceType");


            builder.HasData
            (
                 new AllowanceType
                 {
                     Id = 1,
                     Name = "EXTRA DUTY ALLOWANCE",


                 },
                 new AllowanceType
                 {
                     Id = 2,
                     Name = "TRAVELING ALLOWANCE",

                 },
                 new AllowanceType
                 {
                     Id = 3,
                     Name = "FUEL ALLOWANCE",

                 },
                 new AllowanceType
                 {
                     Id = 4,
                     Name = "OTHER ALLOWANCE",


                 },
                 new AllowanceType
                 {
                     Id = 5,
                     Name = "ARMS ALLOWANCE",

                 },
                 new AllowanceType
                 {
                     Id = 6,
                     Name = "EXTRA DUTY ALLOWANCE",


                 },
                 new AllowanceType
                 {
                     Id = 7,
                     Name = "OVER TIME",

                 },
                 new AllowanceType
                 {
                     Id = 8,
                     Name = "HOSTEL INCHARGE",


                 },
                 new AllowanceType
                 {
                     Id = 9,
                     Name = "BIKE MAINTAIN ALLOWANCE",

                 },
                 new AllowanceType
                 {
                     Id = 10,
                     Name = "MEAL ALLOWANCE",


                 },
                 new AllowanceType
                 {
                     Id = 11,
                     Name = "BONUS",

                 }  // add all allowance type for allowance drop down list
            );
        }
    }
    public class DeductionTypeSeed : IEntityTypeConfiguration<DeductionType>
    {
        public void Configure(EntityTypeBuilder<DeductionType> builder)
        {
            builder.ToTable("DeductionType");


            builder.HasData
            (
                 // Deduction 
                 new DeductionType
                 {
                     Id = 1,
                     Name = "Medical Checkup Charges",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 2,
                     Name = "Meal Deductions",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 3,
                     Name = "Special Deductions",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 4,
                     Name = "Mobile Phone Bill Deductions",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 5,
                     Name = "ID Cost",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 6,
                     Name = "Loan",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 7,
                     Name = "Other Deductions",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 8,
                     Name = "Uniform Deductions",
                     IsMonthlyDeducting = true

                 },
                 new DeductionType
                 {
                     Id = 9,
                     Name = "Sport Uniform Deductions",
                     IsMonthlyDeducting = true

                 },
                 new DeductionType
                 {
                     Id = 10,
                     Name = "Suwasampatha Insurance",
                     IsMonthlyDeducting = true

                 },
                 new DeductionType
                 {
                     Id = 11,
                     Name = "Personal Accident Insurance",
                     IsMonthlyDeducting = true

                 },
                 new DeductionType
                 {
                     Id = 12,
                     Name = "Donation",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 13,
                     Name = "Fine and Penalty",
                     IsMonthlyDeducting = true 

                 },
                 new DeductionType
                 {
                     Id = 14,
                     Name = "Festival Advance",
                     IsMonthlyDeducting = false

                 },
                 new DeductionType
                 {
                     Id = 15,
                     Name = "Fixed Deductions",
                     IsMonthlyDeducting = true

                 }
            );
        }
    }
    public class SalaryTypeSeed : IEntityTypeConfiguration<SalaryType>
    {
        public void Configure(EntityTypeBuilder<SalaryType> builder)
        {
            builder.ToTable("SalaryType");

            builder.HasData
            (
                 // Deduction 
                 new SalaryType
                 {
                     Id = 1,
                     Name = "Basic Salary",
                     IsAdd = true
                 },
                 new SalaryType
                 {
                     Id = 2,
                     Name = "Allowance",
                     IsAdd = true
                 },
                 new SalaryType
                 {
                     Id = 3,
                     Name = "Deduction",
                     IsAdd = false
                 },
                 new SalaryType
                 {
                     Id = 4,
                     Name = "Over Time",
                     IsAdd = true
                 },
                  new SalaryType
                  {
                      Id = 5,
                      Name = "Stamp",
                      IsAdd = false
                  },
                   new SalaryType
                   {
                       Id = 6,
                       Name = "Epf",
                       IsAdd = false
                   }
               );
        }
    }

    // SECTORS
    public class SectorSeed : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sector");

            builder.HasData
            (
    
                 new Sector
                 {
                     Id = 1,
                     Name = "CENTRAL PROVINCE",

                 },
                 new Sector
                 {
                     Id = 2,
                     Name = "LADY SECTION",

                 },
                 new Sector
                 {
                     Id = 3,
                     Name = "NORTH / NORTH CENTRAL / EASTERN PROVINCE ",

                 },
                 new Sector
                 {
                     Id = 4,
                     Name = "NORTH WESTERN PROVINCE",

                 },
                 new Sector
                 {
                     Id = 5,
                     Name = "SABARAGAMUWA & UVA PROVINCE",

                 },
                 new Sector
                 {
                     Id = 6,
                     Name = "SOUTHERN PROVINCE - HBT",

                 },
                 new Sector
                 {
                     Id = 7,
                     Name = "SOUTHERN PROVINCE - GALLE",

                 },
                 new Sector
                 {
                     Id = 8,
                     Name = "SOUTHERN PROVINCE - MATARA",

                 },
                 new Sector
                 {
                     Id = 9,
                     Name = "WESTERN PROVINCE – I",

                 },
                 new Sector
                 {
                     Id = 10,
                     Name = "WESTERN PROVINCE - II",

                 },
                 new Sector
                 {
                     Id = 11,
                     Name = "WESTERN PROVINCE - III",

                 },
                 new Sector
                 {
                     Id = 12,
                     Name = "WESTERN PROVINCE - IV",

                 },
                 new Sector
                 {
                     Id = 13,
                     Name = "WESTERN PROVINCE - V",

                 },
                 new Sector
                 {
                     Id = 14,
                     Name = "WESTERN PROVINCE - VI",

                 },
                 new Sector
                 {
                     Id = 15,
                     Name = "WESTERN PROVINCE - VII",

                 }


               );
        }
    }

    }
