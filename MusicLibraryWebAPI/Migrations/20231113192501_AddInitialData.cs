using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibraryWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Ez Come Ez Go");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Cumin' Atcha Live");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Gettin Better");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "2 Late 4 Love");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Rock Me To The Top");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "We're No Good Together");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 7, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern Day Cowboy" },
                    { 8, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Changes" },
                    { 9, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Suzi" },
                    { 10, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Me" },
                    { 11, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cover Queen" },
                    { 12, "Mechanical Resonance", "Tesla", "Rock", new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Before My Eyes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Modernday Cowboy");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Modernday Cowboy");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Modernday Cowboy");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Modernday Cowboy");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Modernday Cowboy");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Modernday Cowboy");
        }
    }
}
