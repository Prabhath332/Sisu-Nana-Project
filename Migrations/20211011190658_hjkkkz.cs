using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class hjkkkz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "NormalizedName",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "NormalizedName",
                value: "Teacher");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "NormalizedName",
                value: "Student");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75d1f25b-4668-4223-b655-0224efb91bb7", "AQAAAAEAACcQAAAAEHgGz6lwQkzqR0ITsEUrtnFynHv2phCMm3vuyItJwQ9dxL/r5Zlvhj7H76pUwOCvIw==", "de5e7324-f53c-41d7-91cf-5a0a08bac090" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b235075-4a69-4a11-9baf-5fa94de77d2b", "AQAAAAEAACcQAAAAELT6CICGU4jcRxGRy6OHVdAEGcxGJ1AkZbm5AMA2lIb05YKQmQKoDMpqNM0vUj4tQg==", "f99fbca8-ed48-46ff-ba77-944cae819f65" });
        }
    }
}
