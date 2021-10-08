using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class url : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Class",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b415d169-9792-49ec-b684-833d8cd4c71b", "AQAAAAEAACcQAAAAEBJKK52mE3odi0z9APzZG+XIZIqOQmk9ryWLMv+i24Jhf5nUOZLO/kOwX89oyDWCgQ==", "5bd536de-2f9e-4237-a796-69bfea61060b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Class");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd0dd165-3ee4-4ac0-8b1c-8835abc94ef7", "AQAAAAEAACcQAAAAENUI2Dsx7bdzyGiHzr4jqrwngycMbljFDCJpzzGwyL8tki6McrGe6jObrkI6/OjpAQ==", "d2e53b7b-6db1-4a93-8db9-d667e3db40db" });
        }
    }
}
