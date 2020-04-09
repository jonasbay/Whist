using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class SeedData9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "BidAttachment", "BitTricks", "Tricks" },
                values: new object[] { 7, "NormalRound", 4, 10, 7 });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Discriminator", "SoloType" },
                values: new object[,]
                {
                    { 4, "SoleRound", "Solo" },
                    { 5, "SoleRound", "Clean solo" },
                    { 6, "SoleRound", "Strong Oak" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7);

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
        }
    }
}
