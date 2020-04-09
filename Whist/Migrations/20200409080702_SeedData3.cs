using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamePlayers",
                columns: new[] { "Id", "GameId", "PlayerId", "Points" },
                values: new object[,]
                {
                    { 4, 2, 5, 6 },
                    { 5, 3, 4, 5 },
                    { 6, 3, 8, 4 },
                    { 7, 3, 6, 8 },
                    { 8, 3, 2, 6 },
                    { 9, 1, 3, 6 },
                    { 10, 1, 4, 10 },
                    { 11, 1, 5, 8 },
                    { 12, 1, 2, 500 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
