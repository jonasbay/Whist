using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameRounds",
                columns: new[] { "Id", "Ended", "GameId", "RoundNum", "Started" },
                values: new object[] { 2, false, 1, 1, false });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "BidAttachment", "BitTricks", "Tricks" },
                values: new object[] { 2, "NormalRound", 2, 5, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
