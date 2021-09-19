using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class attendnce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "FestivalAdvance",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 15, nullable: false),
                    TelephoneNo = table.Column<string>(maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    UserTypeId = table.Column<string>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnterAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    IsInActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    DayShift = table.Column<bool>(nullable: false),
                    NightShift = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnterAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnterAttendance_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnterAttendance_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a6333b6-2d23-4c30-8548-7870e5bb653d", "AQAAAAEAACcQAAAAEIzeAGefDiJ1d5zxPERhwgIPQsLOThFMcGweDbah1Q5ChbQqugYUJBJ9JuOf00P6rg==", "9b74eff1-6861-40bb-9089-9430e95df5eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dfaa991-95f9-489d-956b-f9189eb78149", "AQAAAAEAACcQAAAAEISHhTYH+F+hnpeWH7qwnSGr7eLctxLrLtqL5bQH9g6zgPwuXe6OoAKzeeYAfEF9vg==", "7d835c9e-2d22-4733-8a00-52c0946e085d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d13598b0-259a-4cd1-ac87-023f42427df2", "AQAAAAEAACcQAAAAEJImlHp88i56XxrxrFBOfGlbms/Jz8q+RpB3+EgZWyaovUlRtyULAV4VTpoowkENrQ==", "6b047db2-69fd-4ebc-92e0-d2f7b16ffe7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd28378a-917b-4d11-97d9-45a2c30140a6", "AQAAAAEAACcQAAAAEFFimIaQLeRZoVr9MMJV3qoFvEhPqOg1MW+J27eQZoOvB55mtBy6j8N8Se7gi4d5/Q==", "e90c7305-ca3d-4bc9-8f42-dd12e450b8d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a51a3223-b03c-4157-807d-56718d25fe59", "AQAAAAEAACcQAAAAEPQKu4Ly189wRSN+d9PATA7NIPP9UBqcY9f3OgkCQn3o9hhl7Z4l/rLjESeW7bngDA==", "67ce31b2-7058-4ca6-99f7-99df9894f560" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba2c8e0b-d8b6-466c-bebe-c8894bf370e3", "AQAAAAEAACcQAAAAEPQd/LdQA5xkitkGdEIpZYO+p9hKfkn+fHO8Jpmnz29EA6dZxA+mrTWNTWB/YHtU3Q==", "0ee7648c-377a-47cb-9711-6462ab143cae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf7ffc2d-e06a-45fb-bac2-472e9346da4d", "AQAAAAEAACcQAAAAED73hRqShHtRKL6LkIY5+/YF+2zABXPSbOrzqgJeFXN+BQPAjif3BGV+kIPm276Rjw==", "eedaf289-a308-401b-9872-587b7e1ad70e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07e20fa-e473-49cd-98ca-d951087e0fd6", "AQAAAAEAACcQAAAAEOXTvsqmAcAIFjVrS2EO1D3/BTJ4xIlFjDzq9HVGjbrEAYRThvlQdCTFK+zNh1tLNA==", "2cb87344-1bc3-49ff-a690-9d7a974f427a" });

            migrationBuilder.CreateIndex(
                name: "IX_EnterAttendance_LocationId",
                table: "EnterAttendance",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_EnterAttendance_UserId",
                table: "EnterAttendance",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnterAttendance");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "FestivalAdvance");

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
    }
}
