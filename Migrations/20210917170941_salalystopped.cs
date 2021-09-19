using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class salalystopped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSalaryStopped",
                table: "Staff",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "StopSalary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<int>(nullable: false),
                    CreatedUserName = table.Column<string>(nullable: true),
                    IsInActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<Guid>(nullable: false),
                    EmpCode = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsStopped = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopSalary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StopSalary_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c8dd6c2-23b4-498d-8c67-136ffa1b5cae", "AQAAAAEAACcQAAAAEBEH9OckIZan3NpyjeZv0I08NNrUqrc8nOF87gmATsEgk7rmjw6xUttfU0eb7UMaVQ==", "e10541dd-5dc5-468e-8481-d95649268bbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48cfb782-a690-4e5c-8cd1-c51c7ca0c256", "AQAAAAEAACcQAAAAEOyL/pjdwkWF1qOUqwRoE5wtnhKdj0I/ufChfkyyKuAILGHM0d0eh04ayFCjRItNaQ==", "10f40e84-e94d-41c5-a9b9-c680e28f0ad8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76efc720-cbc6-4275-865f-b43e0719a66e", "AQAAAAEAACcQAAAAEPXE70ngqNdq7Ov/lVkN+k3dKuAS1LL8om9ctF22wE/yJWS1xCapE7RQdzlj8yFQ9w==", "53db8772-2256-47c2-bceb-77784d8b8a42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48c13426-dd62-4c19-a7b7-8cd270d0fab3", "AQAAAAEAACcQAAAAEL+qUnPRiQ92uDPNAgF9HZTAludP5rRkPBosjD6Lr+5l9+1dKY4qTVXOahnzgYgtFg==", "10b17768-7165-4c92-b13c-8a70d16c68bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54d06702-37cb-4908-9662-7d5daae78107", "AQAAAAEAACcQAAAAECpktAPYOr1D3Ka/U0LiFth2e9GJ8DWI2+fM1YOAzH8GaIL5JQKxSlomvGU2Z6XbyA==", "31ec2929-c848-4766-ad29-36f71c200735" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d4d40e5-594a-4e59-ab04-c8236d980de8", "AQAAAAEAACcQAAAAEHintYfxOyaUPHe5T/KKOANtX3sewIbhrOQjIqV7vodbka3/bZlr4vtzP7O5MZq67w==", "6aae4c2b-9eed-4630-983b-75249cac5e01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bf8d12c-7d71-41e2-9812-6f45280cd597", "AQAAAAEAACcQAAAAEDn95mt2czfCqkHyhA+ploF5hUBnOSkNzKY3ChK9oEQuHMlxCwww6ML7occuE+YBXg==", "a8bbad27-1339-413b-9399-d28f2662bd27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "382faac0-b3da-43b6-b3fa-83695bc576d2", "AQAAAAEAACcQAAAAELm6VVlLXaOaASOkhM6UzPPiKHsCP74h6J9TOMpbDYVqO9psJF2m4nOhi/VcuUeydg==", "52afdc4a-2720-4da5-a6c0-43db5d092427" });

            migrationBuilder.CreateIndex(
                name: "IX_StopSalary_StaffId",
                table: "StopSalary",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StopSalary");

            migrationBuilder.DropColumn(
                name: "IsSalaryStopped",
                table: "Staff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca57cd12-1ffa-4972-b218-137cfba191e4", "AQAAAAEAACcQAAAAEEVWkj4e0Sw80wVViZH4bPZYiHZcuKlevUZQDZ3006TYgaTu3VXGuvMxSlTQkTxK9g==", "da4c0d22-8f9d-44f4-b3c9-89b61633d405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e3e2cd-b94a-4996-b684-17bbd88f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e96d8a0-3158-4bc9-95ef-d29961179b9d", "AQAAAAEAACcQAAAAENmXJYCwpsH1iC0E1/BM0T8ebPVdNCYb4po/NBh5X7swFc86HI2iN+1gvNkQEwnDpg==", "6b0c9bcd-7df4-4943-b055-ae4a2ea7dc00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e3e2dc-b94a-4996-l685-17bbz78f98x1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "288e9b9a-17d1-4b31-9504-1484afe04039", "AQAAAAEAACcQAAAAEHdSEWe4oG+XSEGz4rgKcYmFOTkx2xVPmL/UAdCLrE3QTi8FV2z60oZJfVxa9iVfjA==", "8f12576c-05ff-4112-bed3-af768c29aafb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-1196-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1a57f38-55ac-40ea-a0be-e93f5c9929ba", "AQAAAAEAACcQAAAAEMLH3eDjVi+NxqRauKX5M6Ho/VK5StRPaDcsVY9HEBSDoayyfkDpcks9YFJNrC1Bxg==", "810556b6-b5f3-43d6-af0a-fb876e128232" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e3e2cc-b94a-4996-b684-17bbd78f9861",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ff1ba47-6aa2-492f-afc9-4eb19a020d4a", "AQAAAAEAACcQAAAAEAWlHSKXJlHzsYADHKmSPm5sOHRZjPqzfgVtCWl2UCnZuQEt2ppIDBIrUDM6TfRYVA==", "4744eac6-7892-4497-a4c3-6501416d0be0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbac75ab-fb09-42aa-aa94-920631ccc4f0", "AQAAAAEAACcQAAAAEFigsC7fdusGCYtNDyIFQmuqrHNz5is82BVdsM1NQ/sdwyGn59ueg/Y95gNmd++9Tw==", "b966462b-1a02-4399-8422-5e72e0f5ae0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcad5be6-b165-447b-b532-96bd3493a8f7", "AQAAAAEAACcQAAAAENEeTwm6Ze9jgsDOfJE+Er4iA1NDccfR7KNO8x51qMqa9CoQbBMB7Au8nWzrpuTptw==", "9346a5f8-df6e-465e-8b21-0ac16f442c40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ede2cc-b94a-4996-b684-17b5d78f986c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13b1ca3f-8874-4486-9905-4c49552080e9", "AQAAAAEAACcQAAAAEA52rs0lMPihSWhknzOWHomHldhFdIKZ4SxnI8vyYTqzmhXfCgnLS2alOWheK36qgA==", "aa0a54d0-5ac4-4c09-86ae-f5b7d3c4b5ac" });
        }
    }
}
