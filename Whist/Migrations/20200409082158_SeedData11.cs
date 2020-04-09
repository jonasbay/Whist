using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameRoundPlayers",
                columns: new[] { "Id", "GameRoundId", "Points" },
                values: new object[,]
                {
                    { 2, 2, 4 },
                    { 3, 4, 2 },
                    { 4, 3, 1 },
                    { 5, 6, 6 },
                    { 6, 7, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
