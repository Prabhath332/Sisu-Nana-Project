using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class jj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnterAttendance_User_UserId",
                table: "EnterAttendance");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_EnterAttendance_UserId",
                table: "EnterAttendance");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EnterAttendance");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7593ff74-06ca-4dcc-9ef0-813daab6171a", "AQAAAAEAACcQAAAAEAZQ8jL5wNFPOH2bn646ArVvFExq3/CLKW9zpXdAu67/RWJabN+e45opNuFbGBoVmQ==", "08a08826-f3fd-43b9-93b0-45dbcabdc3fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7a42415-cf49-42d0-a3ec-f1c347c14028", "AQAAAAEAACcQAAAAEEFTjZWwB4/YjOJrtt1FNzct8mmJypyosWw9OCEz7ZXFfIM4lHwjniyhfx36osXEyw==", "f79c7073-cf8e-4e25-9c60-ccd7fb308555" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9de84f57-0a00-43fa-8daf-5d2297f6b8ad", "AQAAAAEAACcQAAAAEMG8nvwHG5tCdgaK7ArafGRvmdbJzi1FgvDrmXgtlwmptgMKqXQN6GW9556mk48ejw==", "cb657fcc-a377-4599-ab0f-a715e1789552" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "434e6a2c-6af3-463d-b431-5f4f97304714", "AQAAAAEAACcQAAAAECWp7HkYHz6F02vJd7lszKi8Msj5/GVCWKIHFg9w4xX3MwFKdNHHnsPVEDqAm001gQ==", "de629c24-a4da-4b56-a944-babdea6ce226" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "886d57f0-200d-491e-806e-4d36280c0e34", "AQAAAAEAACcQAAAAEObM0+bvXs/kLc20B9WGc4BiCqK/rVSZQu4OXwOL4FiY4Sfu/A+/1D3eHt8jOnWPjw==", "7872ad8c-30f9-4e62-b577-8d11e17eb345" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "744a210d-e415-4622-8c71-ef5bbb5b5757", "AQAAAAEAACcQAAAAEPyf/IB58oKyQiKiP5J64ZhziCm7PljpoJ1Ddt5rr0ME7fAnQ1e/ViwERIOVVI9vGg==", "776a2fa3-1671-426d-b96b-9cfe49f57073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f5e1ed4-e0f3-4e5b-99b5-7d4b81e5a4e4", "AQAAAAEAACcQAAAAEMB4gFFAi2N7tWUD15ib2DlCdmvzPXiVC2hLBNx/QLS2/XJPuDFIJVhT0z6jjUg2LA==", "2da01959-4dac-4abb-abc9-c9042ab9fd50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac2cd3b0-8252-4b76-a638-675bc9ba5703", "AQAAAAEAACcQAAAAEITRYMGoVb4/Yyu6b8lPLfBUlCA2YftUh5yqR25nS4UP7eDmjw6+D/lFK++/J8vGdw==", "9c9a9a8c-39f2-4d48-bd92-2c2b86d12af8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EnterAttendance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Password = table.Column<string>(type: "varchar(15) CHARACTER SET utf8mb4", maxLength: 15, nullable: false),
                    TelephoneNo = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: true),
                    UserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    UserTypeId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21d414e0-96a1-4421-81d9-4f937ebd0802", "AQAAAAEAACcQAAAAEFbemSiYjCxZyr4Y2G0eGiU0fftPj8Va2Rq24j/6JnKnRAgTAcTrCLt1wiWEbAae5A==", "c9ba613c-ec0a-4e30-95ec-e7b958293cfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b27aa8bd-3633-4769-a013-b4671a626047", "AQAAAAEAACcQAAAAECnku8D29MXeWrKXRweyACh0z3Q0Zj31+qPSh8ox9PRTtFNWq3qBWn7rUJU7lurg9w==", "74536cfe-f013-45ec-a72a-12feeb1d2f3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b776eb2-7df5-41c2-bc5a-e54dbdf00c3a", "AQAAAAEAACcQAAAAEGl8V4ah+ZnQrZb7ATOJReFdvlg4FOFnIdjNyTnuEszelFzVq8QUHlfQ7nE5CoU2ig==", "e6addde8-f0f4-4e74-8a6b-b8f97b79d166" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b756420b-3772-44ca-b478-b4399b27ccea", "AQAAAAEAACcQAAAAEBc67yt2gO3gTkAw+uM1NL9wkXpNhBssvmWYSXbGJXy+NgzqACKkwE6H7vKpcy+62A==", "79392309-716a-4a98-8a30-1100e87d2e9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c36d513-d56d-4f93-b636-5ce9b8e684b6", "AQAAAAEAACcQAAAAEHMMghrBJcT0fngBIuCINccTKPbXrkBAdPbzxOVYBOZIWTjMnFZYCnsGdkCsBajBrQ==", "dfff1ddb-9ba1-4f02-86f3-f7ea0566f6de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b5b8c8-4b8e-4729-b4c1-91366fe302bd", "AQAAAAEAACcQAAAAENaPMjBcgKkoUVotwDCWeYSx5eh8ZQVNAe/1Z4ih2qQVVz76tSpuMLD4GXEgdLbgKQ==", "ea104f4c-fa12-47fa-8014-4788a493598b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e805085-628e-4b7a-99bd-cf6188613ebd", "AQAAAAEAACcQAAAAEJwv4qFb/oYS1eL4OrTu4Wxr/KY6XRcXoxgprDKBWrevId9jpclN4rS2BXV1v9XzNg==", "68048d24-a57d-42f3-90ad-4c1deea8219c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4faa47c-8590-4a61-bd56-2246b2f62e4f", "AQAAAAEAACcQAAAAEJw9LCXC/dcgmx3mngZkkMUU+0MPCE6JIgheVsOh7gk9hB12/i2oj1hfFvrxXsm7OQ==", "35eb42f8-41ab-4bc7-b5fd-98fecb6244a4" });

            migrationBuilder.CreateIndex(
                name: "IX_EnterAttendance_UserId",
                table: "EnterAttendance",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnterAttendance_User_UserId",
                table: "EnterAttendance",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
