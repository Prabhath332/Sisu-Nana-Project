using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllowanceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowanceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeductionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsMonthlyDeducting = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BudgetAllowance = table.Column<double>(nullable: false),
                    CostOfLiving = table.Column<double>(nullable: false),
                    RationAllowance = table.Column<double>(nullable: false),
                    WesternAllowance = table.Column<double>(nullable: false),
                    AviationAllowance = table.Column<double>(nullable: false),
                    RiskAllowance = table.Column<double>(nullable: false),
                    SpecialTransportAllowance = table.Column<double>(nullable: false),
                    CompanyEmail = table.Column<string>(nullable: true),
                    EmailPassword = table.Column<string>(nullable: true),
                    PayBankEmail = table.Column<string>(nullable: true),
                    EPFDepartmentEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LocationNo = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    Address3 = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthEnd",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthEnd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cols = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsAdd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasicSalary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    RankId = table.Column<int>(nullable: false),
                    Increment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicSalary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicSalary_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EmpNo = table.Column<string>(nullable: false),
                    Epf = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    RankId = table.Column<int>(nullable: false),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    NicNo = table.Column<string>(nullable: true),
                    BatchNo = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    JoinedDate = table.Column<DateTime>(nullable: false),
                    BankCode = table.Column<string>(nullable: true),
                    BranchCode = table.Column<string>(nullable: true),
                    ACNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReportTypeId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    RankId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Report_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Report_ReportType_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allowance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    AllowanceTypeId = table.Column<int>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allowance_AllowanceType_AllowanceTypeId",
                        column: x => x.AllowanceTypeId,
                        principalTable: "AllowanceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Allowance_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deduction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    DeductionTypeId = table.Column<int>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deduction_DeductionType_DeductionTypeId",
                        column: x => x.DeductionTypeId,
                        principalTable: "DeductionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deduction_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeductionHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    DeductionTypeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Balance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeductionHistory_DeductionType_DeductionTypeId",
                        column: x => x.DeductionTypeId,
                        principalTable: "DeductionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeductionHistory_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donation_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeClearance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    JoinedDate = table.Column<DateTime>(nullable: false),
                    LastDate = table.Column<DateTime>(nullable: false),
                    ClearanceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeClearance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeClearance_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FestivalAdvance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    EmpNo = table.Column<string>(nullable: false),
                    Month = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FestivalAdvance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FestivalAdvance_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fine_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gratuity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StaffId = table.Column<Guid>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    ServiceDuration = table.Column<double>(nullable: false),
                    JoinedDate = table.Column<DateTime>(nullable: false),
                    LastDate = table.Column<DateTime>(nullable: false),
                    ChequeDate = table.Column<DateTime>(nullable: false),
                    BankDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gratuity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gratuity_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    PolicyDate = table.Column<DateTime>(nullable: false),
                    Premium = table.Column<double>(nullable: false),
                    Installment = table.Column<double>(nullable: false),
                    PolicyNo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceDetails_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    SalaryTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ReferenceId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salary_SalaryType_SalaryTypeId",
                        column: x => x.SalaryTypeId,
                        principalTable: "SalaryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salary_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryAdvance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    BrCode = table.Column<string>(nullable: false),
                    AccNo = table.Column<string>(nullable: false),
                    Advance = table.Column<double>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryAdvance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaryAdvance_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AllowanceType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "OTHER ALLOWANCE" },
                    { 11, "BONUS" },
                    { 10, "MEAL ALLOWANCE" },
                    { 9, "BIKE MAINTAIN ALLOWANCE" },
                    { 8, "HOSTEL INCHARGE" },
                    { 7, "OVER TIME" },
                    { 6, "EXTRA DUTY ALLOWANCE" },
                    { 5, "ARMS ALLOWANCE" },
                    { 3, "FUEL ALLOWANCE" },
                    { 2, "TRAVELING ALLOWANCE" },
                    { 1, "EXTRA DUTY ALLOWANCE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "1", "Admin", null },
                    { "2", "2", "Officer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19e3e2cc-b94a-1196-b684-17bbd78f9861", 0, "b37ac54d-9171-464d-b13b-8fdd218c9d5f", "Kosala@outlook.com", false, false, null, "Kosala@outlook.com", "Kosala", "AQAAAAEAACcQAAAAEHZeKe7nnXsAVfftPnYNe5INADo37BKbl2p54sveKGGqBZhf+9+K72uElNQPx5Gdrg==", null, false, "f6d5a939-1f22-4f73-afa4-bf08ce94e5d2", false, "Kosala" },
                    { "19ede2cc-b94a-4996-b684-17b5d78f986c", 0, "2fe5220f-3336-4db0-af24-621b00f71541", "MADUKA@outlook.com", false, false, null, "MADUKA@outlook.com", "MADUKA", "AQAAAAEAACcQAAAAEKsfEMU607slPJn2NNVMtq/cxJnGCx20Adg2ih9lTTgl/KQvgwAOWv0xOky5+Bslug==", null, false, "54872c29-f982-464d-a313-49dd76f2f28d", false, "MADUKA" },
                    { "14e3e2dc-b94a-4996-l685-17bbz78f98x1", 0, "6e4202b3-bfaf-474b-9586-02de334528aa", "Dinali@outlook.com", false, false, null, "Dinali@outlook.com", "Dinali", "AQAAAAEAACcQAAAAEKGnaN8k9wkkp2Q8XMpgfKa/FN0RJox+dciAgxZCVdgzuSFPxrP7m4JFV9yYaZX1Lg==", null, false, "5101166b-e2b5-443a-b3b8-bb66c5c918cf", false, "Dinali" },
                    { "19e3e2cc-b94a-4996-b684-17bbd78f9861", 0, "49c196a3-29ba-48c8-8cd6-38b8285934df", "Mekala@outlook.com", false, false, null, "Mekala@outlook.com", "Mekala", "AQAAAAEAACcQAAAAED3i8s+FtWriNw8AZ81mey8yqKd37HqPDip6HKZM84B+FYhtVLPovfokFv70nSBjLw==", null, false, "be7480a3-c9ed-4e52-a967-4b97612980c1", false, "Mekala" },
                    { "11e3e2cd-b94a-4996-b684-17bbd88f9861", 0, "76f12896-f0b4-4614-a3c8-e79fbb81d75d", "Nadeesha@outlook.com", false, false, null, "Nadeesha@outlook.com", "Nadeesha", "AQAAAAEAACcQAAAAEODBMDR1gG2Pceems3rjoOIPOmDw4TuTZKV/LO0ZRYTECN6/uSPZ4W6YCbGzXVc+AQ==", null, false, "8c2298fc-dd4b-49d4-b3ed-1e23818723a2", false, "Nadeesha" },
                    { "11e3e2bd-b94a-4996-b684-07b9d88f9841", 0, "81d7e4a5-415b-4013-b23d-6f694d4e5f46", "senath@outlook.com", false, false, null, "ruchikamperera@outlook.com", "Senath_Admin", "AQAAAAEAACcQAAAAEOyOW1ilXnXaA3AUP0qPj4BteNz6bpCEaXmZmjObhRZlJ/fQIwDWiWf5pn8LR2ql2Q==", null, false, "0fa04636-c374-49f4-a3ed-441ee8cb32ee", false, "Admin" },
                    { "72e3e2bd-b94a-4996-b684-07b9d88f9841", 0, "c2facf3a-4a8e-4909-8712-895ba4a1c076", "ruchikamperera@outlook.com", false, false, null, "ruchikamperera@outlook.com", "Admin", "AQAAAAEAACcQAAAAEBBSpqcjWtibfQsflPEF+ReF68PTmgqK3c14sDGg3/ksxwGSZBL2hFAuA1YyxxvhDw==", null, false, "524605e4-f160-4cd3-8d7e-78f5f946bf59", false, "Admin" },
                    { "99ede2cc-b94a-4996-b684-17b5d78f986c", 0, "5477af9e-d8b3-4be4-85ea-ce4bf99a3315", "Gamage@outlook.com", false, false, null, "Gamage@outlook.com", "Gamage", "AQAAAAEAACcQAAAAEED9PTrQEBGbOew6b4zLTw4obAgXRu5LvbT9a3VJbrLswoKgVm6xZWE/ix3ZVsrnjw==", null, false, "0aa34acf-b78e-4cfa-ab16-e3fd487461a2", false, "Gamage" }
                });

            migrationBuilder.InsertData(
                table: "DeductionType",
                columns: new[] { "Id", "IsMonthlyDeducting", "Name" },
                values: new object[,]
                {
                    { 9, true, "Sport Uniform Deductions" },
                    { 15, true, "Fixed Deductions" },
                    { 14, false, "Festival Advance" },
                    { 13, true, "Fine and Penalty" },
                    { 12, false, "Donation" },
                    { 10, true, "Suwasampatha Insurance" },
                    { 8, true, "Uniform Deductions" },
                    { 11, true, "Personal Accident Insurance" },
                    { 6, false, "Loan" },
                    { 5, false, "ID Cost" },
                    { 7, false, "Other Deductions" },
                    { 4, false, "Mobile Phone Bill Deductions" },
                    { 3, false, "Special Deductions" },
                    { 2, false, "Meal Deductions" },
                    { 1, false, "Medical Checkup Charges" }
                });

            migrationBuilder.InsertData(
                table: "Rank",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "CSO" },
                    { 3, "SSO" },
                    { 4, "OIC" },
                    { 1, "JSO" },
                    { 2, "LSO" }
                });

            migrationBuilder.InsertData(
                table: "ReportType",
                columns: new[] { "Id", "Cols", "Name" },
                values: new object[,]
                {
                    { 35, "No.,Emp No,Name,Location No,Location,EPF No,Signature", "EPF/ETF H-O List" },
                    { 28, "", "Donation Recovery Deductions" },
                    { 29, "Emp. No.,Name,Rank,Festival Advance", "Festival Advance Deductions" },
                    { 30, "Emp. No.,Name,Rank,Amount", "Welfare Deductions" },
                    { 31, "", "Pay slip" },
                    { 32, "Emp No,Name,Rank,Gross Salary(Rs.),Deductions(Rs.),Net Salary(Rs.),Date,Signature", "Pay sheet" },
                    { 27, "Emp. No.,Name,Rank,Mobile Phone", "Mobile Phone Deductions" },
                    { 33, "", "Pay Summary" },
                    { 34, "Month,Pay Strength,Total Earnings,Total Deductions,Net Salary,Average", "Pay Analyzer" },
                    { 36, "No.,Emp No,Name,Location No,Location,EPF No,Signature", "EPF/ETF Statement" },
                    { 42, "Emp No,Name,Rank,TotalAmount,Paid Amount,Balance", "Fine And Penalty" },
                    { 38, "NIC Number,Surname,Initial,EPF No.,Tot. Con.,Emp. Con.,Mem. Con.,B. Sal.,Emp. No.,No. Of Days", "EPF E Return" },
                    { 39, "Emp No,Name,Rank,Premium,Paid Amount,Balance", "Insurance" },
                    { 40, "Emp No,Name,Rank,TotalAmount,Paid Amount,Balance", "Uniform" },
                    { 41, "Emp No,Name,Rank,Total Amount,Paid Amount,Balance", "Sport Uniforms" },
                    { 43, "Emp No.,Name,Rank,Tot. Balance,Paid Amount,Balance", "Donations" },
                    { 44, "Emp No,Name,Rank,Full Amount,Paid Amount,Balance", "Festival Advance" },
                    { 45, "Emp. No.,Name,Rank,Available Balance", "Death Deductions" },
                    { 46, "Emp.No.,Name,Rank,Deduction,Amount,Balance", "Fixed Deductions" },
                    { 47, "Sector,Location No.,Location Name", "Locations Report" },
                    { 26, "Emp. No.,Name,Rank,Fine and Penalty", "Fine and Penalty Deductions" },
                    { 37, "", "ETF 6 Month Return" },
                    { 25, "Emp. No.,Name,Rank,Special Deduction", "Special Deductions ll" },
                    { 14, "Emp No,Name,NIC No.,A/C. No.,Salary Amt", "Bank Payment" },
                    { 23, "Emp. No.,Name,Rank,Meal Deduction", "Meal Deductions" },
                    { 1, "Emp No,Name,Account No,Advance Amount", "Advance_All" },
                    { 24, "Emp. No.,Name,Rank,Amount", "Insurance Deductions" },
                    { 3, "Emp No,Name,Account No,Bank Amount", "Advance_Bank" },
                    { 4, "Emp No,Name,Account No,Loan Amount", "Loan_All" },
                    { 5, "Emp No,Name,Loan Cash Amount", "Loan_Cash" },
                    { 6, "Emp No,Name,Account No,Loan Bank Amount", "Loan_Bank" },
                    { 7, "No,Emp No,Name,Rank,Location,Shifts,Gross,Loan,Balance", "Loan Payment" },
                    { 8, "EMP.NO.,SURNAME & INITIALS,LOC. NO.,LOC. NAME,ADDRESS,RANK,BRANCH,A/C NO.,EPF NO.,NIC NO.,Join Date", "All Employee Details" },
                    { 9, "Emp No,Name,Rank,DOJ,L/D Worked DOR,Active,Cleared", "Employee Clearance" },
                    { 10, "Emp No,Name,Location,Shifts,Date,", "Shift Wise" },
                    { 11, "Emp.No.,Name,Rank,Budget,Cost of Liv.,Dty. Allo.,O.T. Amt.,Uni. Upkeep,Risk Allo.,Ration Allo.,Budget Allo. 2015,Extra Duty Allo.,Sp. Allo. Western,Aviation Allo.,Travel All. +Festiva,Meal Allo.,Sp. Trans. Allo.,Hostel Fuel Other,Arr Refund,Arms.SS,Bike Allo.,Total Earn.,Tot Shi,OT,Incentive Allowance,Incentive", "Total Earning" },
                    { 2, "Emp No,Name,Cash Amount", "Advance_Cash" },
                    { 13, "Location Number,Location Name,Employee Number,Name,Rank,Total Shifts,Total OT Hours,Duty Allowance,Basic Salary,Budget Allowance,Budget Allowance ,Hostel In charge Allowance,Risk Allowance,Aviation Allowance,Arrears and Refund,Festival Advance,Travelling Allowance,Fuel Allowance,ARMS Allowance,Extra Duty Allowance,Extra OT Allowance,Bike Maintenance,Meal Allowance,Bonus,Uniform ,Upkeep Makeup,Uniform Upkeeping,Ration Allowance,Western Allowance,Overtime,Transport Allowance,Performance Allowance,Incentive,Incentive Allowance,Other Earnings,Total Earnings,EPF 8%,No pay,Bank Charges,Death Donation,Medical Checkup,Uniform Deduction,Sport Uniform Deduction,Loan Recovery,Salary Advance,Meal Deductions,Insurance Per. Acc. Co-Operative,insurance Support line,insurance 24x7,ID ,Cost,Special Deduction II,Fine and Penalty,Mobile Phone Deduction,Festival Advance,Welfare Deduction,Stamp Duty,Other Deductions,EPF Salary,Total Deductions,Net Salary,Bank Code,Branch Code,Account Number", "Earning and Deduction" },
                    { 12, "Emp No,Name,Rank,EPF No.,EPF,Basic Sal.,Death Do.& Welfar,Death Reco.,Uniform,Sport,Co-Operative.,Supportline Ins.,Twenty Forty Ins.,Peer.Acci.Ceylinco,Loan Reco.,Medi Check,Salary Adv.,Fine & Pen.,Fes.Adv.,Don. Reco.,Meal Deduc,ID Cost,Spect Ded,Tot.Ded.,Net Salary", "Total Deductions" },
                    { 15, "Emp. No.,Name,Rank,Tot.Ear.,Tot.Ded.,Salary Amt.", "Cash Payment" },
                    { 16, "Emp. No.,Name,Account No.,Rank,Tot.Shifts,Tot.Ear.,Total Ded.,Salary Amount", "Late Payment" },
                    { 17, "Emp No,Name,Rank,Amount", "Death Donation Deductions" },
                    { 18, "Emp. No.,Name,Rank,M.C. Charges", "Medical Checkup Deductions" },
                    { 19, "Emp. No.,Name,Rank,Uniform Deduction", "Uniform Deductions" },
                    { 20, "Emp. No.,Name,Rank,Sport Uniform", "Sport Uniform Deductions" },
                    { 21, "Emp. No.,Name,Rank,Loan Recovery", "Loan Recovery Deductions" },
                    { 22, "Emp. No.,Name,Rank,Salary Advance", "Salary Advance Deductions" }
                });

            migrationBuilder.InsertData(
                table: "SalaryType",
                columns: new[] { "Id", "IsAdd", "Name" },
                values: new object[,]
                {
                    { 5, false, "Stamp" },
                    { 4, true, "Over Time" },
                    { 6, false, "Epf" },
                    { 2, true, "Allowance" },
                    { 1, true, "Basic Salary" },
                    { 3, false, "Deduction" }
                });

            migrationBuilder.InsertData(
                table: "Sector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 13, "WESTERN PROVINCE - V" },
                    { 12, "WESTERN PROVINCE - IV" },
                    { 11, "WESTERN PROVINCE - III" },
                    { 10, "WESTERN PROVINCE - II" },
                    { 9, "WESTERN PROVINCE – I" },
                    { 8, "SOUTHERN PROVINCE - MATARA" },
                    { 6, "SOUTHERN PROVINCE - HBT" },
                    { 5, "SABARAGAMUWA & UVA PROVINCE" },
                    { 4, "NORTH WESTERN PROVINCE" },
                    { 3, "NORTH / NORTH CENTRAL / EASTERN PROVINCE " },
                    { 2, "LADY SECTION" },
                    { 1, "CENTRAL PROVINCE" },
                    { 14, "WESTERN PROVINCE - VI" },
                    { 7, "SOUTHERN PROVINCE - GALLE" },
                    { 15, "WESTERN PROVINCE - VII" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "72e3e2bd-b94a-4996-b684-07b9d88f9841", "1" });

            migrationBuilder.InsertData(
                table: "BasicSalary",
                columns: new[] { "Id", "Amount", "Increment", "RankId" },
                values: new object[,]
                {
                    { 1, 10000, 100, 1 },
                    { 2, 10000, 100, 2 },
                    { 3, 10000, 100, 3 },
                    { 4, 10620, 150, 4 },
                    { 5, 10620, 150, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allowance_AllowanceTypeId",
                table: "Allowance",
                column: "AllowanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Allowance_StaffId",
                table: "Allowance",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasicSalary_RankId",
                table: "BasicSalary",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Deduction_DeductionTypeId",
                table: "Deduction",
                column: "DeductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deduction_StaffId",
                table: "Deduction",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionHistory_DeductionTypeId",
                table: "DeductionHistory",
                column: "DeductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionHistory_StaffId",
                table: "DeductionHistory",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_StaffId",
                table: "Donation",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeClearance_StaffId",
                table: "EmployeeClearance",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_FestivalAdvance_StaffId",
                table: "FestivalAdvance",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Fine_StaffId",
                table: "Fine",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Gratuity_StaffId",
                table: "Gratuity",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceDetails_StaffId",
                table: "InsuranceDetails",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_LocationId",
                table: "Report",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_RankId",
                table: "Report",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ReportTypeId",
                table: "Report",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_SalaryTypeId",
                table: "Salary",
                column: "SalaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_StaffId",
                table: "Salary",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryAdvance_StaffId",
                table: "SalaryAdvance",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RankId",
                table: "Staff",
                column: "RankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allowance");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BasicSalary");

            migrationBuilder.DropTable(
                name: "Deduction");

            migrationBuilder.DropTable(
                name: "DeductionHistory");

            migrationBuilder.DropTable(
                name: "Donation");

            migrationBuilder.DropTable(
                name: "EmployeeClearance");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "FestivalAdvance");

            migrationBuilder.DropTable(
                name: "Fine");

            migrationBuilder.DropTable(
                name: "GeneralSetting");

            migrationBuilder.DropTable(
                name: "Gratuity");

            migrationBuilder.DropTable(
                name: "InsuranceDetails");

            migrationBuilder.DropTable(
                name: "MonthEnd");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "SalaryAdvance");

            migrationBuilder.DropTable(
                name: "Sector");

            migrationBuilder.DropTable(
                name: "AllowanceType");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DeductionType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "ReportType");

            migrationBuilder.DropTable(
                name: "SalaryType");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Rank");
        }
    }
}
