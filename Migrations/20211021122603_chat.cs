using Microsoft.EntityFrameworkCore.Migrations;

namespace web_project.Migrations
{
    public partial class chat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e781930a-17f8-45d2-9bc8-af6b512ba930", "AQAAAAEAACcQAAAAEDRUdXt6kd0OmlyvH7FwV0rurLOkKsJq0gaV5cNgdyMe+L81sjjNTV4q6TqO/8EvxA==", "747ec246-ea42-445f-9068-35188f692f32" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e3e2bd-b94a-4996-b684-07b9d88f9841",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8ae99fe-baf6-4b28-9175-78bdb24c74a2", "AQAAAAEAACcQAAAAEIyhNkbuT9uD0bIL3IUCIpae4B6eUhaQQspks6TLzPN/fP74J20tJPfBIjuLzAsI4Q==", "ff5555f7-a6ad-4df8-adb9-386070bee1dd" });
        }
    }
}
