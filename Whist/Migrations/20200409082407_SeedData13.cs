using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SoleRoundWinner",
                columns: new[] { "Id", "GameRoundId", "Tricks" },
                values: new object[] { 2, 3, 10 });

            migrationBuilder.InsertData(
                table: "SoleRoundWinner",
                columns: new[] { "Id", "GameRoundId", "Tricks" },
                values: new object[] { 3, 4, 7 });

            migrationBuilder.InsertData(
                table: "SoleRoundWinner",
                columns: new[] { "Id", "GameRoundId", "Tricks" },
                values: new object[] { 4, 7, 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SoleRoundWinner",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SoleRoundWinner",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SoleRoundWinner",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
