using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class urlx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    When = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    SenderId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54a5bddb-b38e-438d-833f-44e578cc0394", "AQAAAAEAACcQAAAAEHaYvYBY409H2xuWB/DORlGIrWXYCMyGUMpY3TqnxZpA5z9fzbEU+6CAGVnxeP5BYA==", "bf90bbc1-3419-4c3a-9f7c-c11af8c0d3f4" });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b415d169-9792-49ec-b684-833d8cd4c71b", "AQAAAAEAACcQAAAAEBJKK52mE3odi0z9APzZG+XIZIqOQmk9ryWLMv+i24Jhf5nUOZLO/kOwX89oyDWCgQ==", "5bd536de-2f9e-4237-a796-69bfea61060b" });
        }
    }
}
