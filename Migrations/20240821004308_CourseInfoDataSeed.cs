using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeeTimeAPI.Migrations
{
    /// <inheritdoc />
    public partial class CourseInfoDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "CourseURL" },
                values: new object[,]
                {
                    { 1, "The Links at Terranea", "https://www.terranea.com/golf" },
                    { 2, "Trump National Golf Club", "https://www.trumpnationallosangeles.com/" }
                });

            migrationBuilder.InsertData(
                table: "TeeTimes",
                columns: new[] { "Id", "CourseId", "Date", "NumberOfPlayer", "Price", "Time" },
                values: new object[,]
                {
                    { 1, 1, "2024-09-01", 4, 200.0, "10:00" },
                    { 2, 1, "2024-09-01", 3, 200.0, "11:00" },
                    { 3, 1, "2024-09-01", 4, 200.0, "12:00" },
                    { 4, 2, "2024-09-01", 4, 150.0, "10:00" },
                    { 5, 2, "2024-09-01", 4, 150.0, "11:00" },
                    { 6, 2, "2024-09-01", 2, 150.0, "12:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
