using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GamePlayers",
                columns: new[] { "Id", "GameId", "PlayerId", "Points" },
                values: new object[] { 1, 2, 7, 3 });

            migrationBuilder.InsertData(
                table: "GamePlayers",
                columns: new[] { "Id", "GameId", "PlayerId", "Points" },
                values: new object[] { 2, 2, 3, 4 });

            migrationBuilder.InsertData(
                table: "GamePlayers",
                columns: new[] { "Id", "GameId", "PlayerId", "Points" },
                values: new object[] { 3, 2, 1, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
