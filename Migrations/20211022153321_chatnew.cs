using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class chatnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Messages_messageId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_messageId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "messageId",
                table: "Contact");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "001eeca2-a70d-4bad-8658-03a7d26c7a11", "AQAAAAEAACcQAAAAEKIc6BInFxphRzZ+z2AdvmdljbIR+9P9vcGthrXBn+spqp/XiwYncOm9z/36oHZFcA==", "8e092869-13c8-404c-8a8a-fdfb59cc1535" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "messageId",
                table: "Contact",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f0171b-3562-451a-b90e-681477c30f21", "AQAAAAEAACcQAAAAEHGCcMjZClobHyXzAtr38L+OqsqveOu0WsgVw+UXSflrQknlyfgUKNWcZNNX53E7KQ==", "be9e03f7-b04c-47bf-82a5-7c327cc62ba3" });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_messageId",
                table: "Contact",
                column: "messageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Messages_messageId",
                table: "Contact",
                column: "messageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
