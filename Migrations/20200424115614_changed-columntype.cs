using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class changedcolumntype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WeedRemove",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Seedings",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleDate",
                table: "Sales",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PestControlDate",
                table: "PestControls",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(9272), new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(1366), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(2097), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(2696), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9053), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9781), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9789), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9791), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9792), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9794), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9795), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9795), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9796), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9797), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9798), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9799), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9799), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9800), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9801), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9803), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9803), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9804), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9805), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9806), new DateTime(2020, 4, 24, 11, 56, 14, 22, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(3325), new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(4506), new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(5797), new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(6451), new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(7048), new DateTime(2020, 4, 24, 11, 56, 14, 21, DateTimeKind.Utc).AddTicks(7049) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "WeedRemove",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Seedings",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SaleDate",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "PestControlDate",
                table: "PestControls",
                nullable: true,
                oldClrType: typeof(DateTime));

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
    }
}
