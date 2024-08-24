using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeeTimeAPI.Migrations
{
    /// <inheritdoc />
    public partial class changeDateAndTimeTypeForTeeTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 50, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0, new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0, new TimeSpan(2, 2, 50, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Time" },
                values: new object[] { "2024-09-01", "10:00" });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Time" },
                values: new object[] { "2024-09-01", "11:00" });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { "2024-09-01", 200.0, "12:00" });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Time" },
                values: new object[] { "2024-09-01", "10:00" });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { "2024-09-01", 150.0, "11:00" });

            migrationBuilder.UpdateData(
                table: "TeeTimes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Price", "Time" },
                values: new object[] { "2024-09-01", 150.0, "12:00" });
        }
    }
}
