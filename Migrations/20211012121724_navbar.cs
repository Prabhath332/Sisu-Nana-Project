using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class navbar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8ae99fe-baf6-4b28-9175-78bdb24c74a2", "AQAAAAEAACcQAAAAEIyhNkbuT9uD0bIL3IUCIpae4B6eUhaQQspks6TLzPN/fP74J20tJPfBIjuLzAsI4Q==", "ff5555f7-a6ad-4df8-adb9-386070bee1dd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dd108a0-b180-482a-8dfb-c90fb21ec0fe", "AQAAAAEAACcQAAAAEG8bjO4pxdRXTatW3N3W7yjkr3oJ2xCzGRYf0KHDIVug3ilbIA1SrX5TvlcYFi2+xA==", "64b9ad2e-f782-4d74-b85e-cebbb6ba9c6c" });
        }
    }
}
