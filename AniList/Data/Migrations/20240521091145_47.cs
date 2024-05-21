using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AniList.Data.Migrations
{
    /// <inheritdoc />
    public partial class _47 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "News");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
