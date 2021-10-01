using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class clz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21d3468-021c-4ff5-9f8f-7a0f8c43bc78", "AQAAAAEAACcQAAAAEFhoJSMfZSJt4Ehy2ydIuEyj6F/gHetN9GYI/2VCYGovp+casbzFyqjRaGsHaLG5bA==", "c513ecac-11eb-4b40-ad64-1d312c8758c6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1716b09-a4c4-4066-affd-89689ca223c0", "AQAAAAEAACcQAAAAEAU+czZlwZln3vPuhAtAYpf+sc8FS+WtSTVRxnGfJUzWdWGquFadE5jE72WUyakUJw==", "a602f411-a4d9-4146-9c3c-350ac3225d46" });
        }
    }
}
