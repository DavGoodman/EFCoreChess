using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreChess.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChessGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhitePlayerId = table.Column<int>(type: "int", nullable: false),
                    BlackPlayerId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChessGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChessGames_Players_BlackPlayerId",
                        column: x => x.BlackPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChessGames_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChessGames_Players_WhitePlayerId",
                        column: x => x.WhitePlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Country", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Norway", "Magnus Carlsen", 2870 },
                    { 2, "USA", "Fabiano Caruana", 2822 },
                    { 3, "USA", "Hikaru Nakamura", 2780 },
                    { 4, "USA", "Levy Rossman", 2400 }
                });

            migrationBuilder.InsertData(
                table: "ChessGames",
                columns: new[] { "Id", "BlackPlayerId", "Date", "PlayerId", "WhitePlayerId", "WinnerId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2012, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 },
                    { 2, 1, new DateTime(2013, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3 },
                    { 3, 4, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 4 },
                    { 4, 1, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChessGames_BlackPlayerId",
                table: "ChessGames",
                column: "BlackPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_ChessGames_PlayerId",
                table: "ChessGames",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_ChessGames_WhitePlayerId",
                table: "ChessGames",
                column: "WhitePlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChessGames");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
