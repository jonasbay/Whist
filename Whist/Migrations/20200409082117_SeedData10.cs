using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameRoundPlayers",
                columns: new[] { "Id", "GameRoundId", "Points" },
                values: new object[] { 1, 1, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameRoundPlayers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
