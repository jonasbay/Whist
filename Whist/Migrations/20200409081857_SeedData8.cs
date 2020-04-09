using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameRounds",
                columns: new[] { "Id", "Ended", "GameId", "RoundNum", "Started" },
                values: new object[,]
                {
                    { 3, false, 3, 1, true },
                    { 4, false, 1, 2, false },
                    { 5, false, 2, 2, true },
                    { 6, false, 1, 3, false },
                    { 7, false, 3, 2, true }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "BidAttachment", "BitTricks", "Tricks" },
                values: new object[] { 3, "NormalRound", 5, 5, 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
