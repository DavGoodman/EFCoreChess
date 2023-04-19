using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreChess.Migrations
{
    /// <inheritdoc />
    public partial class PlayerDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Players",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MostPLayedOpening",
                table: "Players",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "MostPLayedOpening" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "MostPLayedOpening", "Rating" },
                values: new object[] { null, null, 2775 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "MostPLayedOpening", "Rating" },
                values: new object[] { null, null, 2747 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Bio", "MostPLayedOpening", "Rating" },
                values: new object[] { "Levy Rozman", null, null, 2322 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "MostPLayedOpening",
                table: "Players");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Players",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rating",
                value: 2822);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rating",
                value: 2780);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Rating" },
                values: new object[] { "Levy Rossman", 2400 });
        }
    }
}
