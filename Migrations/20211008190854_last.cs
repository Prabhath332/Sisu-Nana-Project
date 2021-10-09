using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46233c65-1636-48ae-ad72-889eb27f21bb", "AQAAAAEAACcQAAAAEHGJpL/RIXMflUrgwo/0/tng6ypwBHKNhFwNZ1LpOHn0geEK5cgpdGHBKoExOBQruQ==", "f592bf0b-9a1b-4431-9a28-a831b80da69c" });
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
