using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibraryWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modernday Cowboy" },
                    { 2, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modernday Cowboy" },
                    { 3, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modernday Cowboy" },
                    { 4, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modernday Cowboy" },
                    { 5, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modernday Cowboy" },
                    { 6, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modernday Cowboy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
