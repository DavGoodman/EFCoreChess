using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreChess.Migrations
{
    /// <inheritdoc />
    public partial class updateinitseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_ChessTournaments_ChessTournamentId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_ChessTournamentId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ChessTournamentId",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 5,
                column: "ChessTournamentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 6,
                column: "ChessTournamentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 7,
                column: "ChessTournamentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 8,
                column: "ChessTournamentId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChessTournamentId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 5,
                column: "ChessTournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 6,
                column: "ChessTournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 7,
                column: "ChessTournamentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChessGames",
                keyColumn: "Id",
                keyValue: 8,
                column: "ChessTournamentId",
                value: null);

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

            migrationBuilder.CreateIndex(
                name: "IX_Players_ChessTournamentId",
                table: "Players",
                column: "ChessTournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_ChessTournaments_ChessTournamentId",
                table: "Players",
                column: "ChessTournamentId",
                principalTable: "ChessTournaments",
                principalColumn: "Id");
        }
    }
}
