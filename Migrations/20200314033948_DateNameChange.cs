using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class DateNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Sales",
                newName: "SaleDate");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "PestControls",
                newName: "PestControlDate");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 113, DateTimeKind.Utc).AddTicks(9218), new DateTime(2020, 3, 14, 3, 39, 48, 113, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(2076), new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(2790), new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(3405), new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(9782), new DateTime(2020, 3, 14, 3, 39, 48, 114, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(519), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(526), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(526), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(527), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(528), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(529), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(530), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(530), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(531), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(532), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(533), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(569), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(570), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(571), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(571), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(572), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(573), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(574), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(574), new DateTime(2020, 3, 14, 3, 39, 48, 115, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 14, 3, 39, 48, 113, DateTimeKind.Utc).AddTicks(6463), new DateTime(2020, 3, 14, 3, 39, 48, 113, DateTimeKind.Utc).AddTicks(6476) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SaleDate",
                table: "Sales",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "PestControlDate",
                table: "PestControls",
                newName: "Date");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(7542), new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(17), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(705), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(1413), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(7417), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8110), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8116), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8117), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8118), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8118), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8119), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8120), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8121), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8121), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8122), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8123), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8124), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8124), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8125), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8126), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8127), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8128), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8128), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8129), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(5043), new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(5054) });
        }
    }
}
