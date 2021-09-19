using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class jjzzzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FromHistory",
                table: "TempAttendance",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "StaffAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    IsInActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId1 = table.Column<Guid>(nullable: true),
                    StaffId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    DayShift = table.Column<bool>(nullable: false),
                    NightShift = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffAttendance_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffAttendance_Staff_StaffId1",
                        column: x => x.StaffId1,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb4fff0c-fa15-4fd5-b6d5-58fb3333d268", "AQAAAAEAACcQAAAAECjsJV5XA5vriVxbALQQpABNrq3zTXemJnWXjSt1B2dF+3vbrk5A27VDzfyvFRfJMg==", "6e831fb2-7522-406a-9f87-c2923d2a2846" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b8b07e3-88f9-411a-ab6d-28c0cf2e3d08", "AQAAAAEAACcQAAAAEPKyDA5tVq5X5edyemGIOZ4GVIpR6QHu535WSYUlFWFOKZsow2VDJsqBXO0OztGHuA==", "85e89a36-abe9-4390-85ad-5bba9231979d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36ee1191-ba0a-49e1-a3d1-3876f4b8e175", "AQAAAAEAACcQAAAAEOxhgHtmrwY1x3mkspmNr3J3oCOesbv1oBFrwbml9pOYmBZe3ZNPI88dgkTAdQipGQ==", "b7f2cef1-f063-4315-816e-66cddb22974f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1af9f3a2-4e11-46a9-8512-70407e304051", "AQAAAAEAACcQAAAAEONTq2n289qBVn//iosgCDvCppXYMy8o0saiXF1n885ciAUBByj9MZtCzPZk1BCsFA==", "46d2be7f-a0b6-4f27-9c87-d09e886d98ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88fda890-8da7-4976-b659-e26d2407925c", "AQAAAAEAACcQAAAAEHcwA/R4NKr8nekmMR6B39AySA1VBNRO2gtc3DUYpEezDPMpdhqJeZrC/OOKX8KXWA==", "9110e546-4a7a-4eeb-9a23-f9afc3fe1e25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d15e3ee-5ffb-475e-ae1b-7f5ad9537e5c", "AQAAAAEAACcQAAAAEPZTOQq1M4sqaJlwysxtXi5FKM2breCEYMdFdP70jK/nJ7JS2LxDKTHGxTVvwts2sQ==", "97be4c48-9cd4-4702-9cb5-6355d01eb236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2761e872-c53a-4d9d-a8e4-d98c054d263c", "AQAAAAEAACcQAAAAEB0j4CUeALPmAYV8V4S+rmo+nuDX3RKSDPrEUZkTLxlMIk9MqqzOJF9scEVIQWd1cg==", "61b19213-536e-4f18-8113-4835a29f03bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9380160-bac0-43dd-8a7c-01942c52de9e", "AQAAAAEAACcQAAAAEGyRfvIuouvMpvvSspUOw6KhHHRlk6HB+wDtApOxFZrDTcP2bVlxe7a3Yr9opq9HoA==", "d1f90de8-727a-4e0a-9cea-9ae73f8aefae" });

            migrationBuilder.CreateIndex(
                name: "IX_StaffAttendance_LocationId",
                table: "StaffAttendance",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffAttendance_StaffId1",
                table: "StaffAttendance",
                column: "StaffId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffAttendance");

            migrationBuilder.DropColumn(
                name: "FromHistory",
                table: "TempAttendance");

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
        }
    }
}
