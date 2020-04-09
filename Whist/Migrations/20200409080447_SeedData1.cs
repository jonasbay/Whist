using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Ended", "Started", "Updates" },
                values: new object[] { 1, "Hallelujah", false, true, true });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Ended", "Started", "Updates" },
                values: new object[] { 2, "Best Game", false, false, true });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Ended", "Started", "Updates" },
                values: new object[] { 3, "Focused", true, true, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
