using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeeTimeAPI.Migrations
{
    /// <inheritdoc />
    public partial class addDummyDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "CourseURL" },
                values: new object[] { 3, "Northview Golf Club", "https://www.northviewgolfclub.com/" });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 15, 50, 0, 0));

            migrationBuilder.InsertData(
                table: "TeeTimes",
                columns: new[] { "Id", "CourseId", "Date", "NumberOfPlayer", "Price", "Time" },
                values: new object[,]
                {
                    { 10, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 200.0, new TimeSpan(0, 10, 30, 0, 0) },
                    { 11, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 200.0, new TimeSpan(0, 10, 50, 0, 0) },
                    { 12, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 12, 30, 0, 0) },
                    { 13, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 11, 20, 0, 0) },
                    { 14, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 120.0, new TimeSpan(0, 14, 0, 0, 0) },
                    { 15, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100.0, new TimeSpan(0, 15, 50, 0, 0) },
                    { 7, 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 200.0, new TimeSpan(0, 10, 20, 0, 0) },
                    { 8, 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 13, 30, 0, 0) },
                    { 9, 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100.0, new TimeSpan(0, 15, 40, 0, 0) },
                    { 16, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 200.0, new TimeSpan(0, 10, 20, 0, 0) },
                    { 17, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 13, 30, 0, 0) },
                    { 18, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100.0, new TimeSpan(0, 15, 40, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(2, 2, 50, 0, 0));
        }
    }
}
