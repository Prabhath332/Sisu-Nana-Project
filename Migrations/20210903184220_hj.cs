using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class hj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateInFull",
                table: "MonthEnd",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57e1122d-9766-493b-9d1c-cb7752dbad83", "AQAAAAEAACcQAAAAEFlK2Qpr4P8qMoUQaaNz21+GEAzSfxNwuU9nNX0riaoQQt0cXTvm0tfBaz4kGnuM1w==", "f0de1b66-516a-459a-b12b-b3317a996b77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23682ce9-1349-420d-beea-4da34387bca1", "AQAAAAEAACcQAAAAEHmQRY9G/f8UPm9JWYFQnZ7raBQmgOlIgxzdViUq9a5oRxEJLtEICh2SIcvR3Wbmtw==", "96c0b39a-239d-401b-a2d7-05e9b9a76c3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8733633-ca45-4088-9233-c5442b1223f6", "AQAAAAEAACcQAAAAEB8NJZk+FL67XT7uU5A0xwhdZditIf8LwRwgYB0SmpK2h9zQknJ3ri2nzOO38U/6qg==", "81e8fd6d-7f4f-4ce9-8192-09233b5fb3de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c1567bc-044a-4820-a928-89dbe9caee8b", "AQAAAAEAACcQAAAAENn4+XIi5MNZ8DNYlo31Jr/fgisdunwLWCKGnoqEmNA4asoaGh2VTgzgQ2l5JciiFg==", "d0bc105a-ce4e-4925-b3d0-ee7bdc474021" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e1b2823-40a6-4808-be24-ccfb5ea3dd1e", "AQAAAAEAACcQAAAAEAdk9ZXZao6lw8py12sNhCQncliECbIDcFSjuhjZaPHfy2cjux1XUFLJpEw7Vn/OaA==", "4b2497ce-49bf-4ae2-896e-e11afe79ed9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b889c906-4f72-40e5-98e4-b547516557cd", "AQAAAAEAACcQAAAAEO07pUHChGOTdutTeDIrTFlMKXURRbf6MPgSOP6hZnjbomBQUk0jFeN80gd0h8bF+g==", "8c40c354-3c7f-4f35-bb56-c872bcd92b30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e0e2af-e2cb-44e0-8211-58cc713f3191", "AQAAAAEAACcQAAAAEPE1Zq9jnNn916qKeG7j1Fkdd/GdjIFL/LTaZ3hBnDzCXziR8EcQ2dKHJ4bQkj1TcA==", "08ac497f-22d9-4be2-85f0-f9795d888764" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a584f4cf-3cb9-4857-818b-f28134928e0f", "AQAAAAEAACcQAAAAENoX6cvrkLzOc/gr0udAhO4/epTvgcOjMPyZBE4+TLg9XV0C0RYM7muSiyDegiZSTA==", "f621e61e-1f8b-45e5-b572-6d35facd339d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateInFull",
                table: "MonthEnd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f79a04e6-39c9-465c-b0ac-7c7fe7b152d8", "AQAAAAEAACcQAAAAEJjB9PoZ5+mg4+PSWpwqDx4iZwXQySNeJg2rwxv0Y71rkbxD+MMaE2aiD5IRmbS31A==", "faa1e70f-1402-4b05-8fc4-f282651a928f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8f3f75b-09b1-4c32-8deb-87300ea39a04", "AQAAAAEAACcQAAAAEPzCt6kxPMpIyCKTddmoUTRStssqi5kf6XAzaLrHNJuqmNrwmG/ZpIxSUNPI2lkD0w==", "d2051851-055b-4089-9cf0-2190ab61d3da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069aad2f-7eb2-43fa-99ff-2814e9a2d5e5", "AQAAAAEAACcQAAAAELwNUX6RyolGFYK2B61KBI/2gLbE4MTuatf3Rb28aF5JzhX+KxVGgnpCFUZjgsp8lA==", "ca766cd3-9caf-4577-9710-7fe81acd99b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ceb195-e727-471d-b068-dcc719125246", "AQAAAAEAACcQAAAAEFXjsjMWUDmQIAFvvDn5ZBAqnlUVF1yN6CW4S/Wrpmhf5f8XP/CM1lEsb9Z0jZjiuQ==", "893fa71e-0f66-4442-bd80-c6e05e30626b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd90bbb-b554-4b58-84cc-6fd2b2975f19", "AQAAAAEAACcQAAAAEOPZnQbAj85VfRX6hi2LqVPIhg/uM8md2msRDZUNjTpIDr07ufVJCuURIz/1qkuohA==", "bbe66d0e-ba02-4b66-8921-4eeb291719a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a37cf24e-bb69-4906-a8b9-c6636a961da0", "AQAAAAEAACcQAAAAEOmxNURnHpqC1p36zwJ3VHNK+fAoBCCL3QUlf/CFy7FyXINiwjzmMdz0igEHn/CHXA==", "2a0c174e-863b-46c8-bc39-c4bfa5d6b227" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a11a2b09-4e65-4c73-af10-0b937f9a6389", "AQAAAAEAACcQAAAAEA67DHdoHVIRoUZaPMslZH05PYZAJQlTADJONuLG4JOY1lZUfO/ryLmzJzO3q2h1Iw==", "0d904836-fbec-43d3-8356-3b73e2fce149" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c38a3f-e95b-4f38-b99a-58909ec405e6", "AQAAAAEAACcQAAAAEAwL2E5CsUresKEGroJmzx9jDsWMyPEYQovu+NRSjJYkAVgt49BKsek1o65Zc4Ggvw==", "97279d7e-50df-4a84-90a2-dab2011d45c3" });
        }
    }
}
