using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AniList.Data.Migrations
{
    /// <inheritdoc />
    public partial class _55 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Movie_MovieId",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Movie_MovieId",
                table: "Characters",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Movie_MovieId",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Movie_MovieId",
                table: "Characters",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id");
        }
    }
}
