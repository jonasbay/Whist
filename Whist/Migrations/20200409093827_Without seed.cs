using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class Withoutseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GamePlayers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GameRoundPlayers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameRoundPlayers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameRoundPlayers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameRoundPlayers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameRoundPlayers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameRoundPlayers",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SoleRoundWinner",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Ended", "Started", "Updates" },
                values: new object[,]
                {
                    { 1, "Hallelujah", false, true, true },
                    { 2, "Best Game", false, false, true },
                    { 3, "Focused", true, true, false }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Hans", "Emil" },
                    { 2, "Alex", "Hansen" },
                    { 3, "Joe", "Moe" },
                    { 4, "Gurli", "Kristensen" },
                    { 5, "Henriette", "Bohl" },
                    { 6, "Top", "Gunn" },
                    { 7, "Palle", "Henriksen" },
                    { 8, "Julie", "Jensen" }
                });

            migrationBuilder.InsertData(
                table: "GamePlayers",
                columns: new[] { "Id", "GameId", "PlayerId", "Points" },
                values: new object[,]
                {
                    { 3, 2, 1, 7 },
                    { 7, 3, 6, 8 },
                    { 11, 1, 5, 8 },
                    { 4, 2, 5, 6 },
                    { 10, 1, 4, 10 },
                    { 5, 3, 4, 5 },
                    { 9, 1, 3, 6 },
                    { 2, 2, 3, 4 },
                    { 12, 1, 2, 500 },
                    { 8, 3, 2, 6 },
                    { 1, 2, 7, 3 },
                    { 6, 3, 8, 4 }
                });

            migrationBuilder.InsertData(
                table: "GameRounds",
                columns: new[] { "Id", "Ended", "GameId", "RoundNum", "Started" },
                values: new object[,]
                {
                    { 7, false, 3, 2, true },
                    { 3, false, 3, 1, true },
                    { 5, false, 2, 2, true },
                    { 1, false, 2, 1, true },
                    { 6, false, 1, 3, false },
                    { 4, false, 1, 2, false },
                    { 2, false, 1, 1, false }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "GameId", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Denmark" },
                    { 3, 1, "USA" },
                    { 2, 1, "India" },
                    { 4, 3, "China" }
                });

            migrationBuilder.InsertData(
                table: "GameRoundPlayers",
                columns: new[] { "Id", "GameRoundId", "Points" },
                values: new object[,]
                {
                    { 2, 2, 4 },
                    { 6, 7, 3 },
                    { 3, 4, 2 },
                    { 4, 3, 1 },
                    { 5, 6, 6 },
                    { 1, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "SoleRoundWinner",
                columns: new[] { "Id", "GameRoundId", "Tricks" },
                values: new object[,]
                {
                    { 2, 3, 10 },
                    { 1, 1, 13 },
                    { 4, 7, 9 },
                    { 3, 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "SoloType" },
                values: new object[,]
                {
                    { 6, "SoleRound", "Strong Oak" },
                    { 5, "SoleRound", "Clean solo" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "BidAttachment", "BitTricks", "Tricks" },
                values: new object[] { 3, "NormalRound", 5, 5, 9 });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "SoloType" },
                values: new object[] { 4, "SoleRound", "Solo" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "BidAttachment", "BitTricks", "Tricks" },
                values: new object[,]
                {
                    { 2, "NormalRound", 2, 5, 7 },
                    { 7, "NormalRound", 4, 10, 7 }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "SoloType" },
                values: new object[] { 1, "SoleRound", "Good" });
        }
    }
}
