using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class bankseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd0dd165-3ee4-4ac0-8b1c-8835abc94ef7", "AQAAAAEAACcQAAAAENUI2Dsx7bdzyGiHzr4jqrwngycMbljFDCJpzzGwyL8tki6McrGe6jObrkI6/OjpAQ==", "d2e53b7b-6db1-4a93-8db9-d667e3db40db" });

            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "AAA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bank",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa2a5c0c-08b0-45f2-a8c3-8420508b5fbe", "AQAAAAEAACcQAAAAECYrlQTJLigSJqA7/e8Cc2+Q5k8M4n3BMKSzAmQC6zPHFT0UeyJ4JseszCa9fw7QMg==", "c4c51be9-270f-4639-9906-e4cf426e153f" });
        }
    }
}
