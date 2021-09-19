using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class hjZ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "Deduction",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb5624fc-ace2-4047-b02c-ee3add5f5779", "AQAAAAEAACcQAAAAEJWKDGH2j40qtfqg6UapGT24U0NIzqKIJfM4qW6vfrqf4nPQsZUQL2MfOfo2Yx3+jg==", "c1137c86-6f1b-47a1-8b53-4c3cc9e090d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cf37417-e42c-4d4a-8b37-31cce73ad178", "AQAAAAEAACcQAAAAEIHaWG/Sp/bzUykK/vVmW21NJERu6bQSpnjbii8IGLlFK6c4Q/EoEVuDai+7+FZ2Zw==", "59ba0505-7fd0-4eb0-b556-58065eb6f115" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "955e044e-357b-48cc-81d7-61d0e8c0c7e7", "AQAAAAEAACcQAAAAECjZJRGiAt+rKRC4/9ZbyNS2IiZic1Gyum+0EPsq0NhdwAV2h03RFHViKAtsZNCK0Q==", "261024a6-ca8f-4691-9fc0-d86777df5cf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27650dfa-b1f1-4bf8-bcab-332bdfdc754a", "AQAAAAEAACcQAAAAEGN+RbHzaYWCevefjMdmrmz63jsMXxrGY7tcUmoUpjaao1x0L6147kggOY/+AG63DQ==", "7df08c89-a585-4320-a983-6f71e14b0e91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "567f6f90-21c0-48f5-a04b-15d0c718e9ed", "AQAAAAEAACcQAAAAEDoDiY7LA1bj7cy7GuSJWnUQwHK+Bz4Jcy4u1Q/NHllRYvLFUPkutrmnsFDzfPkZVw==", "9a77a174-37d6-4c99-a854-1170c4f39ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78ca6cae-160e-4515-95c9-4312830209e0", "AQAAAAEAACcQAAAAENqj8qlNp/Zi/4CQLumm/QznzLo83IDYWZXKhUXI4Qd/MNdbVAWzT4/ttQdzhsRCXQ==", "d1065047-c7d7-423c-a372-c5e8918bd32f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26fc239c-e25b-49e0-ad19-52d535057287", "AQAAAAEAACcQAAAAEMyBUBXsCSOnWgmM+CZlNCcYyY1taxy9pk3UOhpPG/nk6Sf0Ze/ILXXd7a4RWRqPaw==", "3ef08c8f-241d-47f5-8841-d017f2770cce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c3a2cec-9451-48d5-9ce7-95d2e30cc9ad", "AQAAAAEAACcQAAAAEOs5tfbSSVagOb46FuGXL19h/MV2fMvQP4Jk/bOsRqZR1q9MUHGsxA4yd0p2jdTY5A==", "9279d7fd-510b-4ecc-b294-554c9a962eb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "Deduction",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

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
    }
}
