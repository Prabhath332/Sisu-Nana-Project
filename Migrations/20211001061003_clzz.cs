using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class clzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d95189-699f-48b4-8d32-2f8a953e3236", "AQAAAAEAACcQAAAAEFtl3eE+VEYzcB4peWTg5/G9klnDlcAgwPjsEgvuw3tuihrMLQ+ZUICL0BbpreRBYA==", "0eb31ece-1083-4db4-a68f-150107823203" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21d3468-021c-4ff5-9f8f-7a0f8c43bc78", "AQAAAAEAACcQAAAAEFhoJSMfZSJt4Ehy2ydIuEyj6F/gHetN9GYI/2VCYGovp+casbzFyqjRaGsHaLG5bA==", "c513ecac-11eb-4b40-ad64-1d312c8758c6" });
        }
    }
}
