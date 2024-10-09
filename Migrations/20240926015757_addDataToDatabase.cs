using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeeTimeAPI.Migrations
{
    /// <inheritdoc />
    public partial class addDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "CourseURL" },
                values: new object[,]
                {
                    { 4, "Red Woods Golf Club", "https://www.redwoodsgolfclub.com/" },
                    { 5, "Hazelmere Golf Club", "https://www.hazelmeregolfclub.com/" },
                    { 6, "Morgan Creek Golf Club", "https://www.morgancreekgolfclub.com/" }
                });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 180.0);

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Price", "Time" },
                values: new object[] { 1, 180.0, new TimeSpan(0, 12, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "NumberOfPlayer", "Price", "Time" },
                values: new object[] { 1, 3, 150.0, new TimeSpan(0, 14, 10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "NumberOfPlayer", "Price", "Time" },
                values: new object[] { 1, 4, 150.0, new TimeSpan(0, 14, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Price", "Time" },
                values: new object[] { 2, 150.0, new TimeSpan(0, 11, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Price", "Time" },
                values: new object[] { 2, 120.0, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Time" },
                values: new object[] { 2, new TimeSpan(0, 15, 50, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0, new TimeSpan(0, 11, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0, new TimeSpan(0, 14, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 2, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0, new TimeSpan(0, 10, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 180.0, new TimeSpan(0, 13, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 130.0, new TimeSpan(0, 15, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 180.0, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "NumberOfPlayer", "Price", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 130.0, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "TeeTimes",
                columns: new[] { "Id", "CourseId", "Date", "NumberOfPlayer", "Price", "Time" },
                values: new object[,]
                {
                    { 19, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 200.0, new TimeSpan(0, 10, 30, 0, 0) },
                    { 20, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 200.0, new TimeSpan(0, 10, 50, 0, 0) },
                    { 21, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 180.0, new TimeSpan(0, 12, 30, 0, 0) },
                    { 22, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 200.0, new TimeSpan(0, 10, 40, 0, 0) },
                    { 23, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 200.0, new TimeSpan(0, 11, 20, 0, 0) },
                    { 24, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 180.0, new TimeSpan(0, 12, 40, 0, 0) },
                    { 25, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 11, 20, 0, 0) },
                    { 26, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 120.0, new TimeSpan(0, 14, 0, 0, 0) },
                    { 27, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100.0, new TimeSpan(0, 15, 50, 0, 0) },
                    { 28, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 12, 0, 0, 0) },
                    { 29, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 120.0, new TimeSpan(0, 14, 20, 0, 0) },
                    { 30, 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100.0, new TimeSpan(0, 16, 10, 0, 0) },
                    { 31, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 200.0, new TimeSpan(0, 10, 20, 0, 0) },
                    { 32, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 13, 30, 0, 0) },
                    { 33, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 130.0, new TimeSpan(0, 15, 40, 0, 0) },
                    { 34, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 200.0, new TimeSpan(0, 10, 30, 0, 0) },
                    { 35, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150.0, new TimeSpan(0, 13, 10, 0, 0) },
                    { 36, 3, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 130.0, new TimeSpan(0, 16, 10, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 150.0);

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Price", "Time" },
                values: new object[] { 2, 150.0, new TimeSpan(0, 11, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "NumberOfPlayer", "Price", "Time" },
                values: new object[] { 2, 4, 120.0, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "NumberOfPlayer", "Price", "Time" },
                values: new object[] { 2, 2, 100.0, new TimeSpan(0, 15, 50, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Price", "Time" },
                values: new object[] { 3, 200.0, new TimeSpan(0, 10, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Price", "Time" },
                values: new object[] { 3, 150.0, new TimeSpan(0, 13, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Time" },
                values: new object[] { 3, new TimeSpan(0, 15, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0, new TimeSpan(0, 10, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0, new TimeSpan(0, 10, 50, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0, new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0, new TimeSpan(0, 11, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Date", "Price", "Time" },
                values: new object[] { 2, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0, new TimeSpan(0, 15, 50, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0, new TimeSpan(0, 13, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "NumberOfPlayer", "Price", "Time" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100.0, new TimeSpan(0, 15, 40, 0, 0) });
        }
    }
}
