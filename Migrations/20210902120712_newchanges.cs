using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class newchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fine");

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "Staff",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SalaryAdvance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "SalaryAdvance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "Salary",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "MonthEnd",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "Location",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "InsuranceDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "FestivalAdvance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Premium",
                table: "FestivalAdvance",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "Feedback",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "EmployeeClearance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "Donation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "DeductionHistory",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "InvoiceDate",
                table: "Deduction",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "Deduction",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Premium",
                table: "Deduction",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsInActive",
                table: "Allowance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f79a04e6-39c9-465c-b0ac-7c7fe7b152d8", "AQAAAAEAACcQAAAAEJjB9PoZ5+mg4+PSWpwqDx4iZwXQySNeJg2rwxv0Y71rkbxD+MMaE2aiD5IRmbS31A==", "faa1e70f-1402-4b05-8fc4-f282651a928f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8f3f75b-09b1-4c32-8deb-87300ea39a04", "AQAAAAEAACcQAAAAEPzCt6kxPMpIyCKTddmoUTRStssqi5kf6XAzaLrHNJuqmNrwmG/ZpIxSUNPI2lkD0w==", "d2051851-055b-4089-9cf0-2190ab61d3da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069aad2f-7eb2-43fa-99ff-2814e9a2d5e5", "AQAAAAEAACcQAAAAELwNUX6RyolGFYK2B61KBI/2gLbE4MTuatf3Rb28aF5JzhX+KxVGgnpCFUZjgsp8lA==", "ca766cd3-9caf-4577-9710-7fe81acd99b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ceb195-e727-471d-b068-dcc719125246", "AQAAAAEAACcQAAAAEFXjsjMWUDmQIAFvvDn5ZBAqnlUVF1yN6CW4S/Wrpmhf5f8XP/CM1lEsb9Z0jZjiuQ==", "893fa71e-0f66-4442-bd80-c6e05e30626b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd90bbb-b554-4b58-84cc-6fd2b2975f19", "AQAAAAEAACcQAAAAEOPZnQbAj85VfRX6hi2LqVPIhg/uM8md2msRDZUNjTpIDr07ufVJCuURIz/1qkuohA==", "bbe66d0e-ba02-4b66-8921-4eeb291719a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a37cf24e-bb69-4906-a8b9-c6636a961da0", "AQAAAAEAACcQAAAAEOmxNURnHpqC1p36zwJ3VHNK+fAoBCCL3QUlf/CFy7FyXINiwjzmMdz0igEHn/CHXA==", "2a0c174e-863b-46c8-bc39-c4bfa5d6b227" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a11a2b09-4e65-4c73-af10-0b937f9a6389", "AQAAAAEAACcQAAAAEA67DHdoHVIRoUZaPMslZH05PYZAJQlTADJONuLG4JOY1lZUfO/ryLmzJzO3q2h1Iw==", "0d904836-fbec-43d3-8356-3b73e2fce149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c38a3f-e95b-4f38-b99a-58909ec405e6", "AQAAAAEAACcQAAAAEAwL2E5CsUresKEGroJmzx9jDsWMyPEYQovu+NRSjJYkAVgt49BKsek1o65Zc4Ggvw==", "97279d7e-50df-4a84-90a2-dab2011d45c3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SalaryAdvance");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "SalaryAdvance");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "Salary");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "MonthEnd");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "InsuranceDetails");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "FestivalAdvance");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "FestivalAdvance");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "EmployeeClearance");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "DeductionHistory");

            migrationBuilder.DropColumn(
                name: "InvoiceDate",
                table: "Deduction");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "Deduction");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "Deduction");

            migrationBuilder.DropColumn(
                name: "IsInActive",
                table: "Allowance");

            migrationBuilder.CreateTable(
                name: "Fine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedUserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EmpCode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    StaffId = table.Column<Guid>(type: "char(36)", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9593c81a-6027-4229-9bc5-1f114eb70c4d", "AQAAAAEAACcQAAAAEBIbtprt3EEHfKsiRYSueSMippfSlKkFUZucbs+64dLUHqb8QJqpgEBMaibxv91Sug==", "cc0d9926-7574-4f9e-a92c-00fc3604e312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d27fa491-0839-4332-8a6f-9bf7f3832353", "AQAAAAEAACcQAAAAENzf2DYE78Ex04E/CGMqllTfh0z525H1Nc5mvCApqH4l6omtTYaz1o3PIuF4NognLQ==", "f6683e50-bc61-424e-bf9b-456fcd2fbdf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d6a503-8403-45c9-ac0a-f8e505976442", "AQAAAAEAACcQAAAAEKRKDrcKCBmrsFMl5PnqhouhSvQolP/lJc5LamoiUN1ang3oBkqLFfWXDud08wlNiA==", "4495730c-66c9-4921-93bd-2bc6d8d33105" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4698de1-ba8c-4db0-8ece-37cf64de8645", "AQAAAAEAACcQAAAAEN20n10bYXPDTrtDwV55mKPE9bQXLFVkZSILA+66idhCQwvfXhNHLfFqSgADh5QNZw==", "4784fbe1-5aef-499f-88f4-885b2d275479" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fe6699f-d256-433e-8f58-caf5f5fdbac5", "AQAAAAEAACcQAAAAEFLeFOOE3+CA5OUyZ0JtrI5xz9/R922CVurxt5GdA7Pd4UtLD2Hbhmm6Ph6NDeh4Hw==", "f5f8936c-c0b7-4b70-8758-20f112fa233d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ba39223-cf31-4db9-9af6-9845abb30459", "AQAAAAEAACcQAAAAEDMZ/wMtqy5H8GF/ACG10OxIesbgQ3l7Bgfi61IC4DqxzO27X+iLYWXH2+gCmjUUHw==", "97a7c400-8d8e-4392-a74e-863e0e20e167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf16e9ce-6a3e-4e6d-bb10-1aeebcbb5ac1", "AQAAAAEAACcQAAAAEKXVR5IocDDgfiTTH80XZyqc3H7Ff6voV1215SnqlwLixp3AO/DFGQnrL/FDQKEakg==", "5425f9b5-c071-4c07-a2da-f211481b8928" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "848ea233-950b-48a0-b573-5da19d2768c9", "AQAAAAEAACcQAAAAEAn3YGSraRsaONAYIyzvzj0PrO96TS6vyZT1LoDol7EaSCW8IDgQCnQIQhHSL7RpGw==", "98150b6e-2cec-4714-bc83-fb3583c4d8f0" });

            migrationBuilder.CreateIndex(
                name: "IX_Fine_StaffId",
                table: "Fine",
                column: "StaffId");
        }
    }
}
