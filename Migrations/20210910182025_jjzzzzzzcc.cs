using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class jjzzzzzzcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffAttendance_Location_LocationId",
                table: "StaffAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffAttendance_Staff_StaffId1",
                table: "StaffAttendance");

            migrationBuilder.DropIndex(
                name: "IX_StaffAttendance_LocationId",
                table: "StaffAttendance");

            migrationBuilder.DropIndex(
                name: "IX_StaffAttendance_StaffId1",
                table: "StaffAttendance");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "StaffAttendance");

            migrationBuilder.DropColumn(
                name: "DayShift",
                table: "StaffAttendance");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "StaffAttendance");

            migrationBuilder.DropColumn(
                name: "NightShift",
                table: "StaffAttendance");

            migrationBuilder.DropColumn(
                name: "StaffId1",
                table: "StaffAttendance");

            migrationBuilder.AlterColumn<Guid>(
                name: "StaffId",
                table: "StaffAttendance",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EnterAttendanceId",
                table: "StaffAttendance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "494a1e29-94c1-415e-b554-78c0635bfd4a", "AQAAAAEAACcQAAAAEExDzvIH7JUkolXhOQFjmXBZJLdcnX526TFS98hFtkHsH1GsqvfkCHed1Vx2P4iobw==", "31a44ed7-bac4-4adb-9f56-7e5bd531c3fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2fe1be0-73eb-4362-a305-f868c430aeed", "AQAAAAEAACcQAAAAEAnq5OmevPTbyVlxSaUfI4liMMBPts2mPob58usZmY9XDWwmLygi30Ok8bu9Gwk4Fw==", "e3ccaf62-4d30-464c-8d37-9ad15bbcf71f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abba35d5-49a4-4d0f-bfa7-5b268eadd4f9", "AQAAAAEAACcQAAAAEEsjI7OPNNu3uxR4+9DsixUxBuYLPRHlCzrJ7dCKI9DOaXWIAxQ8GDsaU59Q+rCY5w==", "3afcd0e5-128c-4654-9450-140e7f9e7490" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4661ad99-9324-43c5-8125-3c5212dd80c0", "AQAAAAEAACcQAAAAEMFB74GhFNDe5LCqdrcL7rx1hOK7uso46phNjIL55h5XMO0wehReH+0KZ8HFCr+aZQ==", "1e291264-df64-4417-8a30-c8ae4cf80548" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85bf46ef-db5d-406a-9ec7-a0e854d6047e", "AQAAAAEAACcQAAAAEF4upqVngTY6K7ZudXCZHoaF715HWebT/iIlzZ+PkNlZbEUS7pbp4VfbzMNKemwR/w==", "c0dab48c-61a5-464c-8680-5242fa2204f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52489601-e486-4184-b1ba-2dd016929ff8", "AQAAAAEAACcQAAAAEI5aIDNwr5Zf4jf0v8Nb6LZiGeheTo35An7MLILGZokV3Bb1MTuCkrQ8ZeBjHFkB9g==", "c001f289-6e45-4c10-bbd6-d1bc76e61966" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee61616-62e3-4ddb-8ec0-a4cbf0c2fe48", "AQAAAAEAACcQAAAAEMlWFXFbDq8Jfv93quz2tOeW1CyVgS6oZwYCOxCFbbfbrfXn4Lp2UE9xGZ2Wc17eXg==", "d812bc8b-1a44-4853-83cb-df0f116932f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35867782-6b79-486c-ae5a-8bc8bb0b7bbe", "AQAAAAEAACcQAAAAEEM7/ufE/3hZeT8nRa5aDDFS4r1AedbBZn8Za4lXsH57vMdd5zLNkYMKVpp+ZRMxXQ==", "7150535a-1266-4c3c-bf77-5736ecd3abca" });

            migrationBuilder.CreateIndex(
                name: "IX_StaffAttendance_EnterAttendanceId",
                table: "StaffAttendance",
                column: "EnterAttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffAttendance_StaffId",
                table: "StaffAttendance",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffAttendance_EnterAttendance_EnterAttendanceId",
                table: "StaffAttendance",
                column: "EnterAttendanceId",
                principalTable: "EnterAttendance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffAttendance_Staff_StaffId",
                table: "StaffAttendance",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffAttendance_EnterAttendance_EnterAttendanceId",
                table: "StaffAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffAttendance_Staff_StaffId",
                table: "StaffAttendance");

            migrationBuilder.DropIndex(
                name: "IX_StaffAttendance_EnterAttendanceId",
                table: "StaffAttendance");

            migrationBuilder.DropIndex(
                name: "IX_StaffAttendance_StaffId",
                table: "StaffAttendance");

            migrationBuilder.DropColumn(
                name: "EnterAttendanceId",
                table: "StaffAttendance");

            migrationBuilder.AlterColumn<int>(
                name: "StaffId",
                table: "StaffAttendance",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "StaffAttendance",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "DayShift",
                table: "StaffAttendance",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "StaffAttendance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "NightShift",
                table: "StaffAttendance",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId1",
                table: "StaffAttendance",
                type: "char(36)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_StaffAttendance_Location_LocationId",
                table: "StaffAttendance",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaffAttendance_Staff_StaffId1",
                table: "StaffAttendance",
                column: "StaffId1",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
