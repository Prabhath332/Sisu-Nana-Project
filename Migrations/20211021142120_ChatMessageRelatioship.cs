using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class ChatMessageRelatioship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "messageId",
                table: "Contact",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e3c630d6-ccf9-48a4-9175-5f2490ee46b0", "AQAAAAEAACcQAAAAEBIeT54/yJbtvZDgBnrXPI/NDLfPsme3PHT/cei7FgnnlWYrQcWM9nBBKXBfXeNcxg==", "fc9770a3-0722-4090-b530-65510ba13c91" });
        }
    }
}
