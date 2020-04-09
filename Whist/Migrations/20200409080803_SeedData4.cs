using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "GameId", "Name" },
                values: new object[] { 1, 2, "Denmark" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "GameId", "Name" },
                values: new object[] { 2, 1, "USA" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "GameId", "Name" },
                values: new object[] { 3, 3, "Kina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
