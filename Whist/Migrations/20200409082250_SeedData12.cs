using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SoleRoundWinner",
                columns: new[] { "Id", "GameRoundId", "Tricks" },
                values: new object[] { 1, 1, 13 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SoleRoundWinner",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
