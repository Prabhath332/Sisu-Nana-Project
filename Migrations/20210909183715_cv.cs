using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class cv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffAttendanceDetailsId",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectorId",
                table: "Location",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StaffAttendanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    IsInActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EmpCode = table.Column<string>(nullable: true),
                    EnterAttendanceId = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAttendanceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffAttendanceDetails_EnterAttendance_EnterAttendanceId",
                        column: x => x.EnterAttendanceId,
                        principalTable: "EnterAttendance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TempAttendance",
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
                    EnterAttendanceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TempAttendance_EnterAttendance_EnterAttendanceId",
                        column: x => x.EnterAttendanceId,
                        principalTable: "EnterAttendance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TempAttendance_Staff_StaffId1",
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
                name: "IX_Staff_StaffAttendanceDetailsId",
                table: "Staff",
                column: "StaffAttendanceDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffAttendanceDetails_EnterAttendanceId",
                table: "StaffAttendanceDetails",
                column: "EnterAttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAttendance_EnterAttendanceId",
                table: "TempAttendance",
                column: "EnterAttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAttendance_StaffId1",
                table: "TempAttendance",
                column: "StaffId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_StaffAttendanceDetails_StaffAttendanceDetailsId",
                table: "Staff",
                column: "StaffAttendanceDetailsId",
                principalTable: "StaffAttendanceDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_StaffAttendanceDetails_StaffAttendanceDetailsId",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "StaffAttendanceDetails");

            migrationBuilder.DropTable(
                name: "TempAttendance");

            migrationBuilder.DropIndex(
                name: "IX_Staff_StaffAttendanceDetailsId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "StaffAttendanceDetailsId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "Location");

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
        }
    }
}
