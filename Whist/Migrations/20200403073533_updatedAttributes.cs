using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class updatedAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "PlayerPosition",
                table: "gameplayers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerPosition",
                table: "gameplayers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
