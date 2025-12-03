using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "cecc52cb-af01-4dcd-9a67-e2d367520ab2", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEE7OhllOZv34I+U9VEf7qCAGPzT+0oa/MUJPmFT+d5/OYOQQmqB/cqeMuyqcAtz5ZQ==", null, false, "c0a60c5b-a6b8-408d-9d89-c25cd68f937e", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(579), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(965), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(968), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1104), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1107), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1109), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1111), new DateTime(2025, 12, 3, 15, 47, 26, 179, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2106), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2136), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2475), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2479), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2618), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2621), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2623), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2625), new DateTime(2025, 12, 3, 15, 32, 36, 509, DateTimeKind.Local).AddTicks(2625) });
        }
    }
}
