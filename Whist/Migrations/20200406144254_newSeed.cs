using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class newSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 3, "Hans", "Emil" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
