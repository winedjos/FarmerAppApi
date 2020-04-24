using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class Addeddatecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SeedCost",
                table: "Seedings",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Seedings",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(7866), new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(9907), new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(664), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(1273), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(7291), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8146), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8152), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8153), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8154), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8155), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8155), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8156), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8157), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8158), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8158), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8159), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8160), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8161), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8162), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8162), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8163), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8164), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8165), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8166), new DateTime(2020, 4, 24, 10, 35, 55, 783, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(2182), new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(3301), new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(4512), new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(5154), new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(5731), new DateTime(2020, 4, 24, 10, 35, 55, 782, DateTimeKind.Utc).AddTicks(5731) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Seedings");

            migrationBuilder.AlterColumn<string>(
                name: "SeedCost",
                table: "Seedings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(7620), new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(9880), new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 262, DateTimeKind.Utc).AddTicks(609), new DateTime(2020, 4, 24, 9, 53, 7, 262, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 262, DateTimeKind.Utc).AddTicks(1222), new DateTime(2020, 4, 24, 9, 53, 7, 262, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 262, DateTimeKind.Utc).AddTicks(9442), new DateTime(2020, 4, 24, 9, 53, 7, 262, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(191), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(198), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(199), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(199), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(200), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(201), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(202), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(203), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(203), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(204), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(205), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(206), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(207), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(207), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(208), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(209), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(210), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(210), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(211), new DateTime(2020, 4, 24, 9, 53, 7, 263, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 260, DateTimeKind.Utc).AddTicks(9289), new DateTime(2020, 4, 24, 9, 53, 7, 260, DateTimeKind.Utc).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(726), new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(2059), new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(2711), new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(4329), new DateTime(2020, 4, 24, 9, 53, 7, 261, DateTimeKind.Utc).AddTicks(4331) });
        }
    }
}
