using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheatreBoxOffice.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, "Arvilla", "Lesch" },
                    { 2L, "Fabiola", "Connelly" },
                    { 3L, "Helga", "Collier" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hip Hop" },
                    { 2, "Stage And Screen" },
                    { 3, "World" },
                    { 4, "Classical" },
                    { 5, "Rap" }
                });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 9, 3, 14, 34, 44, 168, DateTimeKind.Local).AddTicks(8131), "Dynamic Implementation Supervisor" },
                    { 2L, new DateTime(2024, 5, 27, 23, 0, 49, 448, DateTimeKind.Local).AddTicks(2553), "Dynamic Integration Planner" },
                    { 3L, new DateTime(2024, 4, 19, 23, 21, 16, 296, DateTimeKind.Local).AddTicks(6836), "Corporate Infrastructure Strategist" },
                    { 4L, new DateTime(2024, 3, 4, 20, 50, 9, 951, DateTimeKind.Local).AddTicks(4061), "Lead Communications Associate" },
                    { 5L, new DateTime(2024, 9, 2, 20, 7, 1, 781, DateTimeKind.Local).AddTicks(4840), "Legacy Implementation Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Number", "Row", "SeatCategory" },
                values: new object[,]
                {
                    { 1L, 1, 1, 1 },
                    { 2L, 2, 1, 1 },
                    { 3L, 3, 1, 1 },
                    { 4L, 4, 1, 1 },
                    { 5L, 5, 1, 1 },
                    { 6L, 6, 2, 2 },
                    { 7L, 7, 2, 2 },
                    { 8L, 8, 2, 2 },
                    { 9L, 9, 2, 2 },
                    { 10L, 10, 2, 2 },
                    { 11L, 11, 3, 3 },
                    { 12L, 12, 3, 3 },
                    { 13L, 13, 3, 3 },
                    { 14L, 14, 3, 3 },
                    { 15L, 15, 3, 3 },
                    { 16L, 16, 4, 4 },
                    { 17L, 17, 4, 4 },
                    { 18L, 18, 4, 4 },
                    { 19L, 19, 4, 4 },
                    { 20L, 20, 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20L);
        }
    }
}
