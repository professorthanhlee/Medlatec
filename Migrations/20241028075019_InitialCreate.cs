using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medlatec.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2024, 10, 29, 14, 50, 19, 57, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2024, 10, 30, 14, 50, 19, 57, DateTimeKind.Local).AddTicks(7835));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2024, 10, 29, 14, 40, 35, 304, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDate",
                value: new DateTime(2024, 10, 30, 14, 40, 35, 304, DateTimeKind.Local).AddTicks(5749));
        }
    }
}
