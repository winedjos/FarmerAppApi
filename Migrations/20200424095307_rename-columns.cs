using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class renamecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(9827), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(5578), new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(7459), new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(9110), new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(2877), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4336), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4350), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4352), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4354), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4356), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4358), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4360), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4361), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4363), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4365), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4367), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4368), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4370), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4372), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4374), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4375), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4377), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4379), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4381), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(4052), new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(7521), new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(820), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(2496), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(4149), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(4149) });
        }
    }
}
