using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class clzzzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_User_UserId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_UserId",
                table: "Class");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Class",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0390c9c1-6532-4fd9-bd06-ff65b192d0bd", "AQAAAAEAACcQAAAAEEPk7weTMs50mVGlD2CRwDZ61ZOMNXB66eSXO8GmtuOZX1x2zhST4RVPWhctsKnk1Q==", "d15c8f8c-6ca6-400a-920b-7520a5ca93e4" });

            migrationBuilder.CreateIndex(
                name: "IX_Class_UserId1",
                table: "Class",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_AspNetUsers_UserId1",
                table: "Class",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_AspNetUsers_UserId1",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_UserId1",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Class");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d95189-699f-48b4-8d32-2f8a953e3236", "AQAAAAEAACcQAAAAEFtl3eE+VEYzcB4peWTg5/G9klnDlcAgwPjsEgvuw3tuihrMLQ+ZUICL0BbpreRBYA==", "0eb31ece-1083-4db4-a68f-150107823203" });

            migrationBuilder.CreateIndex(
                name: "IX_Class_UserId",
                table: "Class",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_User_UserId",
                table: "Class",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
