using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreChess.Migrations
{
    /// <inheritdoc />
    public partial class TournamentsDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChessGames_ChessTournament_ChessTournamentId",
                table: "ChessGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerChessTournament_ChessTournament_ChessTournamentId",
                table: "PlayerChessTournament");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerChessTournament_Players_PlayerId",
                table: "PlayerChessTournament");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_ChessTournament_ChessTournamentId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerChessTournament",
                table: "PlayerChessTournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChessTournament",
                table: "ChessTournament");

            migrationBuilder.RenameTable(
                name: "PlayerChessTournament",
                newName: "PlayerChessTournaments");

            migrationBuilder.RenameTable(
                name: "ChessTournament",
                newName: "ChessTournaments");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerChessTournament_ChessTournamentId",
                table: "PlayerChessTournaments",
                newName: "IX_PlayerChessTournaments_ChessTournamentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerChessTournaments",
                table: "PlayerChessTournaments",
                columns: new[] { "PlayerId", "ChessTournamentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChessTournaments",
                table: "ChessTournaments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChessGames_ChessTournaments_ChessTournamentId",
                table: "ChessGames",
                column: "ChessTournamentId",
                principalTable: "ChessTournaments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerChessTournaments_ChessTournaments_ChessTournamentId",
                table: "PlayerChessTournaments",
                column: "ChessTournamentId",
                principalTable: "ChessTournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerChessTournaments_Players_PlayerId",
                table: "PlayerChessTournaments",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_ChessTournaments_ChessTournamentId",
                table: "Players",
                column: "ChessTournamentId",
                principalTable: "ChessTournaments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChessGames_ChessTournaments_ChessTournamentId",
                table: "ChessGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerChessTournaments_ChessTournaments_ChessTournamentId",
                table: "PlayerChessTournaments");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerChessTournaments_Players_PlayerId",
                table: "PlayerChessTournaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_ChessTournaments_ChessTournamentId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerChessTournaments",
                table: "PlayerChessTournaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChessTournaments",
                table: "ChessTournaments");

            migrationBuilder.RenameTable(
                name: "PlayerChessTournaments",
                newName: "PlayerChessTournament");

            migrationBuilder.RenameTable(
                name: "ChessTournaments",
                newName: "ChessTournament");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerChessTournaments_ChessTournamentId",
                table: "PlayerChessTournament",
                newName: "IX_PlayerChessTournament_ChessTournamentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerChessTournament",
                table: "PlayerChessTournament",
                columns: new[] { "PlayerId", "ChessTournamentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChessTournament",
                table: "ChessTournament",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChessGames_ChessTournament_ChessTournamentId",
                table: "ChessGames",
                column: "ChessTournamentId",
                principalTable: "ChessTournament",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerChessTournament_ChessTournament_ChessTournamentId",
                table: "PlayerChessTournament",
                column: "ChessTournamentId",
                principalTable: "ChessTournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerChessTournament_Players_PlayerId",
                table: "PlayerChessTournament",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_ChessTournament_ChessTournamentId",
                table: "Players",
                column: "ChessTournamentId",
                principalTable: "ChessTournament",
                principalColumn: "Id");
        }
    }
}
