﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AniList.Data.Migrations
{
    /// <inheritdoc />
    public partial class _46 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_AspNetUsers_UserId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_UserId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "News");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "News",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_UserId",
                table: "News",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_AspNetUsers_UserId",
                table: "News",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
