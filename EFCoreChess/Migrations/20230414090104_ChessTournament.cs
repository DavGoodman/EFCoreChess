using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreChess.Migrations
{
    /// <inheritdoc />
    public partial class ChessTournament : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChessGames_Players_PlayerId",
                table: "ChessGames");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "ChessGames",
                newName: "ChessTournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_ChessGames_PlayerId",
                table: "ChessGames",
                newName: "IX_ChessGames_ChessTournamentId");

            migrationBuilder.AddColumn<int>(
                name: "ChessTournamentId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChessTournament",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChessTournament", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerChessTournament",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    ChessTournamentId = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerChessTournament", x => new { x.PlayerId, x.ChessTournamentId });
                    table.ForeignKey(
                        name: "FK_PlayerChessTournament_ChessTournament_ChessTournamentId",
                        column: x => x.ChessTournamentId,
                        principalTable: "ChessTournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerChessTournament_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "WhitePlayerId", "WinnerId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "ChessGames",
                columns: new[] { "Id", "BlackPlayerId", "ChessTournamentId", "Date", "WhitePlayerId", "WinnerId" },
                values: new object[,]
                {
                    { 5, 3, null, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 6, 2, null, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 7, 2, null, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 8, 1, null, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChessTournament",
                columns: new[] { "Id", "TournamentName" },
                values: new object[] { 1, "Goodman Chess Tournament" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChessTournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChessTournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChessTournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "ChessTournamentId",
                value: null);

            migrationBuilder.InsertData(
                table: "PlayerChessTournament",
                columns: new[] { "ChessTournamentId", "PlayerId", "Place" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 3 },
                    { 1, 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_ChessTournamentId",
                table: "Players",
                column: "ChessTournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerChessTournament_ChessTournamentId",
                table: "PlayerChessTournament",
                column: "ChessTournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChessGames_ChessTournament_ChessTournamentId",
                table: "ChessGames",
                column: "ChessTournamentId",
                principalTable: "ChessTournament",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_ChessTournament_ChessTournamentId",
                table: "Players",
                column: "ChessTournamentId",
                principalTable: "ChessTournament",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChessGames_ChessTournament_ChessTournamentId",
                table: "ChessGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_ChessTournament_ChessTournamentId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "PlayerChessTournament");

            migrationBuilder.DropTable(
                name: "ChessTournament");

            migrationBuilder.DropIndex(
                name: "IX_Players_ChessTournamentId",
                table: "Players");

            migrationBuilder.DeleteData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "ChessTournamentId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "ChessTournamentId",
                table: "ChessGames",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_ChessGames_ChessTournamentId",
                table: "ChessGames",
                newName: "IX_ChessGames_PlayerId");

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "WhitePlayerId", "WinnerId" },
                values: new object[] { 1, 4 });

            migrationBuilder.AddForeignKey(
                name: "FK_ChessGames_Players_PlayerId",
                table: "ChessGames",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
