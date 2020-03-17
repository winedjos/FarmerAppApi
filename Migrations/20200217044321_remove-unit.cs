using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class removeunit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "LandDetails");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(676), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(3581), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(4400), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(5005), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(1697), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2496), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2506), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2507), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2507), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2508), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2509), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2510), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2510), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2511), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2512), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2513), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2514), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2514), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2515), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2516), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2517), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2517), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2518), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2519), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 160, DateTimeKind.Utc).AddTicks(7776), new DateTime(2020, 2, 17, 4, 43, 21, 160, DateTimeKind.Utc).AddTicks(7788) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "LandDetails",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(4388), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7101), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7884), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(8506), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(4438), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5126), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5132), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5133), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5134), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5135), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5136), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5136), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5137), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5138), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5139), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5139), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5140), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5141), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5142), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5142), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5143), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5144), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5145), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5145), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(1659), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(1668) });
        }
    }
}
