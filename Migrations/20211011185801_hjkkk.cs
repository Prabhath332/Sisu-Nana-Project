using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class hjkkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b235075-4a69-4a11-9baf-5fa94de77d2b", "AQAAAAEAACcQAAAAELT6CICGU4jcRxGRy6OHVdAEGcxGJ1AkZbm5AMA2lIb05YKQmQKoDMpqNM0vUj4tQg==", "f99fbca8-ed48-46ff-ba77-944cae819f65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54a5bddb-b38e-438d-833f-44e578cc0394", "AQAAAAEAACcQAAAAEHaYvYBY409H2xuWB/DORlGIrWXYCMyGUMpY3TqnxZpA5z9fzbEU+6CAGVnxeP5BYA==", "bf90bbc1-3419-4c3a-9f7c-c11af8c0d3f4" });
        }
    }
}
