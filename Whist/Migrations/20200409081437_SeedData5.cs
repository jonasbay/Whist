using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameRounds",
                columns: new[] { "Id", "Ended", "GameId", "RoundNum", "Started" },
                values: new object[] { 1, false, 2, 1, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameRounds",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
