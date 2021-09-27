using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class hj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountNo",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nic",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1716b09-a4c4-4066-affd-89689ca223c0", "AQAAAAEAACcQAAAAEAU+czZlwZln3vPuhAtAYpf+sc8FS+WtSTVRxnGfJUzWdWGquFadE5jE72WUyakUJw==", "a602f411-a4d9-4146-9c3c-350ac3225d46" });

            migrationBuilder.CreateIndex(
                name: "IX_User_BankId",
                table: "User",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Bank_BankId",
                table: "User",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Bank_BankId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_User_BankId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AccountNo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Nic",
                table: "User");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7955243e-0a92-46ed-8ac5-70d4d3cfa566", "AQAAAAEAACcQAAAAEC+8RoxYcNpyc6/QrCajtnhHgQi5lxOVPaIk33LaTqiRzFEvO3AanJ6pklVmST7G3Q==", "c4a219e2-9458-4aa1-8468-19db0e07e106" });
        }
    }
}
