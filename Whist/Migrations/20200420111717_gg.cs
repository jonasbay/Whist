using Microsoft.EntityFrameworkCore.Migrations;

namespace Whist.Migrations
{
    public partial class gg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Started = table.Column<bool>(nullable: false),
                    Ended = table.Column<bool>(nullable: false),
                    Updates = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameRounds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(nullable: false),
                    RoundNum = table.Column<int>(nullable: false),
                    Ended = table.Column<bool>(nullable: false),
                    Started = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameRounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameRounds_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameRoundPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameRoundId = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameRoundPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameRoundPlayers_GameRounds_GameRoundId",
                        column: x => x.GameRoundId,
                        principalTable: "GameRounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoleRoundWinner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameRoundId = table.Column<int>(nullable: false),
                    Tricks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoleRoundWinner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoleRoundWinner_GameRounds_GameRoundId",
                        column: x => x.GameRoundId,
                        principalTable: "GameRounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Tricks = table.Column<int>(nullable: true),
                    BidAttachment = table.Column<int>(nullable: true),
                    BitTricks = table.Column<int>(nullable: true),
                    SoloType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Types_GameRounds_Id",
                        column: x => x.Id,
                        principalTable: "GameRounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_GameId",
                table: "GamePlayers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayers_PlayerId",
                table: "GamePlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameRoundPlayers_GameRoundId",
                table: "GameRoundPlayers",
                column: "GameRoundId");

            migrationBuilder.CreateIndex(
                name: "IX_GameRounds_GameId",
                table: "GameRounds",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_GameId",
                table: "Location",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_SoleRoundWinner_GameRoundId",
                table: "SoleRoundWinner",
                column: "GameRoundId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamePlayers");

            migrationBuilder.DropTable(
                name: "GameRoundPlayers");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "SoleRoundWinner");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "GameRounds");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
