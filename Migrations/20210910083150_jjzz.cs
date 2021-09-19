using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class jjzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempAttendance_Staff_StaffId1",
                table: "TempAttendance");

            migrationBuilder.DropIndex(
                name: "IX_TempAttendance_StaffId1",
                table: "TempAttendance");

            migrationBuilder.DropColumn(
                name: "StaffId1",
                table: "TempAttendance");

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "TempAttendance",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e93bf1c-e2bd-42ba-b9bb-90e259f306c7", "AQAAAAEAACcQAAAAEM5G4WuFf5ho3g/Sb4TQ2wzdclUBStJR3Hm0z9uPiRFYg20eJbt6iIRPOv6YzA3fRQ==", "77112dff-5cc1-47b1-a994-e904d2ee127a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10b5d01e-d7ef-452d-954a-2c64fcfdf1a7", "AQAAAAEAACcQAAAAEEktGLS4wp/IDGJgdIxwovCnfOFvAPEyYQwu5GKm1pQf2vbQeNVK8czWiuyPIPZHSQ==", "3edb4c11-220c-443a-a4e5-3b79e85dcf86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ab8e144-ce14-4add-a5cb-af84ed172f20", "AQAAAAEAACcQAAAAEKY9HbSdWvwcq7Dmj6WQ3cJyJxsi9Pi9kjz+GPKii9a96UQfPWqpDvL59oV2oPdnGg==", "df30ca3e-f581-47be-ae9c-9257f981b863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feae43fc-4bc2-42c9-ad2b-1ce6a2d6c695", "AQAAAAEAACcQAAAAELvcMhEYzpXlgKxRYaPsARzibdMCd+u1V7G9Bub0k4zn3JO6j8rV+VD00kDg325dFA==", "e9631485-2b27-43eb-9b07-2407280a6c46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4de3289e-afe7-4d59-8f94-414a347755d5", "AQAAAAEAACcQAAAAELxqbgwQhq1odMyyNMPVUrejCV0DLAGOEfMzJ9tRBkXkw3dFQzcGe3B9dSXOKvJVbw==", "de0213cf-fa15-4817-9821-4cb7e4ba8bd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95afe018-263c-4640-b768-266bf4bfd876", "AQAAAAEAACcQAAAAEKeeHR2FGWLNs58u9silmIq6vKB2Z9Kzcg+gNks70/U5TLX0o9fZwnIuBGYTEOQTyw==", "f6f45a9f-f1ee-4438-8e28-8277c30a7db1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7035580-3639-4ab2-a2eb-d4478054e2eb", "AQAAAAEAACcQAAAAEJMyT2JAQM7Fn4AGQIukpXHfIbSwJ7jIDf4ue0AUZo1kPze+EVCPPvJNWGDU/WzfBw==", "da83389b-b406-4e69-a73d-4576e682a965" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cabac9c-20df-444b-bf5e-a619c2e082ae", "AQAAAAEAACcQAAAAECsf3ZnkIm1ZHoUwbvGOZzQyj/mv7lm+6nfY0pLA2Yps27uQlpzIkdRtTxTR3lyfwA==", "e6589a73-b327-4b1c-ae89-805175d61362" });

            migrationBuilder.CreateIndex(
                name: "IX_TempAttendance_StaffId",
                table: "TempAttendance",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempAttendance_Staff_StaffId",
                table: "TempAttendance",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempAttendance_Staff_StaffId",
                table: "TempAttendance");

            migrationBuilder.DropIndex(
                name: "IX_TempAttendance_StaffId",
                table: "TempAttendance");

            migrationBuilder.AlterColumn<int>(
                name: "StaffId",
                table: "TempAttendance",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId1",
                table: "TempAttendance",
                type: "char(36)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TempAttendance_StaffId1",
                table: "TempAttendance",
                column: "StaffId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TempAttendance_Staff_StaffId1",
                table: "TempAttendance",
                column: "StaffId1",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
