using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class ghh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassCode",
                table: "RegistedStudent");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "RegistedStudent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa2a5c0c-08b0-45f2-a8c3-8420508b5fbe", "AQAAAAEAACcQAAAAECYrlQTJLigSJqA7/e8Cc2+Q5k8M4n3BMKSzAmQC6zPHFT0UeyJ4JseszCa9fw7QMg==", "c4c51be9-270f-4639-9906-e4cf426e153f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "RegistedStudent");

            migrationBuilder.AddColumn<int>(
                name: "ClassCode",
                table: "RegistedStudent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c60c6955-c599-4bc3-95a2-8a23c302ecde", "AQAAAAEAACcQAAAAEEEILR/rUOwcpOjy5+OUH/3OB5jQmzlPL/g2vVgkZQ/1xr/N2zYHOl6ZMBKUHf0WNA==", "617e5603-48b4-49ee-9280-90bce3867ce7" });
        }
    }
}
