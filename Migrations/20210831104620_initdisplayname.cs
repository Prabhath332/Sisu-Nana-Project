using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class initdisplayname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Staff",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9593c81a-6027-4229-9bc5-1f114eb70c4d", "AQAAAAEAACcQAAAAEBIbtprt3EEHfKsiRYSueSMippfSlKkFUZucbs+64dLUHqb8QJqpgEBMaibxv91Sug==", "cc0d9926-7574-4f9e-a92c-00fc3604e312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d27fa491-0839-4332-8a6f-9bf7f3832353", "AQAAAAEAACcQAAAAENzf2DYE78Ex04E/CGMqllTfh0z525H1Nc5mvCApqH4l6omtTYaz1o3PIuF4NognLQ==", "f6683e50-bc61-424e-bf9b-456fcd2fbdf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33d6a503-8403-45c9-ac0a-f8e505976442", "AQAAAAEAACcQAAAAEKRKDrcKCBmrsFMl5PnqhouhSvQolP/lJc5LamoiUN1ang3oBkqLFfWXDud08wlNiA==", "4495730c-66c9-4921-93bd-2bc6d8d33105" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4698de1-ba8c-4db0-8ece-37cf64de8645", "AQAAAAEAACcQAAAAEN20n10bYXPDTrtDwV55mKPE9bQXLFVkZSILA+66idhCQwvfXhNHLfFqSgADh5QNZw==", "4784fbe1-5aef-499f-88f4-885b2d275479" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fe6699f-d256-433e-8f58-caf5f5fdbac5", "AQAAAAEAACcQAAAAEFLeFOOE3+CA5OUyZ0JtrI5xz9/R922CVurxt5GdA7Pd4UtLD2Hbhmm6Ph6NDeh4Hw==", "f5f8936c-c0b7-4b70-8758-20f112fa233d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ba39223-cf31-4db9-9af6-9845abb30459", "AQAAAAEAACcQAAAAEDMZ/wMtqy5H8GF/ACG10OxIesbgQ3l7Bgfi61IC4DqxzO27X+iLYWXH2+gCmjUUHw==", "97a7c400-8d8e-4392-a74e-863e0e20e167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf16e9ce-6a3e-4e6d-bb10-1aeebcbb5ac1", "AQAAAAEAACcQAAAAEKXVR5IocDDgfiTTH80XZyqc3H7Ff6voV1215SnqlwLixp3AO/DFGQnrL/FDQKEakg==", "5425f9b5-c071-4c07-a2da-f211481b8928" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "848ea233-950b-48a0-b573-5da19d2768c9", "AQAAAAEAACcQAAAAEAn3YGSraRsaONAYIyzvzj0PrO96TS6vyZT1LoDol7EaSCW8IDgQCnQIQhHSL7RpGw==", "98150b6e-2cec-4714-bc83-fb3583c4d8f0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Staff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d7e4a5-415b-4013-b23d-6f694d4e5f46", "AQAAAAEAACcQAAAAEOyOW1ilXnXaA3AUP0qPj4BteNz6bpCEaXmZmjObhRZlJ/fQIwDWiWf5pn8LR2ql2Q==", "0fa04636-c374-49f4-a3ed-441ee8cb32ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76f12896-f0b4-4614-a3c8-e79fbb81d75d", "AQAAAAEAACcQAAAAEODBMDR1gG2Pceems3rjoOIPOmDw4TuTZKV/LO0ZRYTECN6/uSPZ4W6YCbGzXVc+AQ==", "8c2298fc-dd4b-49d4-b3ed-1e23818723a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e4202b3-bfaf-474b-9586-02de334528aa", "AQAAAAEAACcQAAAAEKGnaN8k9wkkp2Q8XMpgfKa/FN0RJox+dciAgxZCVdgzuSFPxrP7m4JFV9yYaZX1Lg==", "5101166b-e2b5-443a-b3b8-bb66c5c918cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b37ac54d-9171-464d-b13b-8fdd218c9d5f", "AQAAAAEAACcQAAAAEHZeKe7nnXsAVfftPnYNe5INADo37BKbl2p54sveKGGqBZhf+9+K72uElNQPx5Gdrg==", "f6d5a939-1f22-4f73-afa4-bf08ce94e5d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c196a3-29ba-48c8-8cd6-38b8285934df", "AQAAAAEAACcQAAAAED3i8s+FtWriNw8AZ81mey8yqKd37HqPDip6HKZM84B+FYhtVLPovfokFv70nSBjLw==", "be7480a3-c9ed-4e52-a967-4b97612980c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fe5220f-3336-4db0-af24-621b00f71541", "AQAAAAEAACcQAAAAEKsfEMU607slPJn2NNVMtq/cxJnGCx20Adg2ih9lTTgl/KQvgwAOWv0xOky5+Bslug==", "54872c29-f982-464d-a313-49dd76f2f28d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2facf3a-4a8e-4909-8712-895ba4a1c076", "AQAAAAEAACcQAAAAEBBSpqcjWtibfQsflPEF+ReF68PTmgqK3c14sDGg3/ksxwGSZBL2hFAuA1YyxxvhDw==", "524605e4-f160-4cd3-8d7e-78f5f946bf59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5477af9e-d8b3-4be4-85ea-ce4bf99a3315", "AQAAAAEAACcQAAAAEED9PTrQEBGbOew6b4zLTw4obAgXRu5LvbT9a3VJbrLswoKgVm6xZWE/ix3ZVsrnjw==", "0aa34acf-b78e-4cfa-ab16-e3fd487461a2" });
        }
    }
}
