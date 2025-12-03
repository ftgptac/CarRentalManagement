using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5471), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5498), "Black", "system" },
                    { 2, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5502), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5503), "Blue", "system" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5811), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5812), "BMW", "system" },
                    { 2, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5814), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5815), "Toyota", "system" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5963), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5964), "i4", "system" },
                    { 2, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5968), "X5", "system" },
                    { 3, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5969), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5970), "Prius", "system" },
                    { 4, "system", new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5972), new DateTime(2025, 12, 3, 14, 32, 56, 142, DateTimeKind.Local).AddTicks(5972), "C-HR", "system" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
