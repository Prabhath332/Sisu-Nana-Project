using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class banks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c642cb7-4590-42d0-8e53-2c2ed65b853d", "AQAAAAEAACcQAAAAENR7haRhhVY1xOlf5W+2v+uNON8Dh9UfXob2/9tgRhNVQcywq85n+EdzcqvUTsbReQ==", "4807ccf5-1536-4e71-bd13-397f097009ae" });

            migrationBuilder.UpdateData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Commercial Bank of Ceylon");

            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Sampath Bank Plc" },
                    { 3, "National Savings Bank" },
                    { 4, "People’s Bank" },
                    { 5, "Hatton National Bank" },
                    { 6, "Seylan Bank Plc" },
                    { 7, "National Development Bank Plc" },
                    { 8, "Amana Bank" },
                    { 9, "Nations Trust Bank Plc" },
                    { 12, "DFCC Bank" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46233c65-1636-48ae-ad72-889eb27f21bb", "AQAAAAEAACcQAAAAEHGJpL/RIXMflUrgwo/0/tng6ypwBHKNhFwNZ1LpOHn0geEK5cgpdGHBKoExOBQruQ==", "f592bf0b-9a1b-4431-9a28-a831b80da69c" });

            migrationBuilder.UpdateData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "AAA");
        }
    }
}
