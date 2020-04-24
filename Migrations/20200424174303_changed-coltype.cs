using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class changedcoltype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Harvestings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(9113), new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(1344), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(2061), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(2669), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(8930), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9623), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9630), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9631), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9631), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9632), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9633), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9634), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9634), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9635), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9636), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9637), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9637), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9638), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9639), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9640), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9640), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9641), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9642), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9643), new DateTime(2020, 4, 24, 17, 43, 3, 145, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(2742), new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(4038), new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(5332), new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(6028), new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(6638), new DateTime(2020, 4, 24, 17, 43, 3, 144, DateTimeKind.Utc).AddTicks(6638) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Harvestings",
                nullable: true,
                oldClrType: typeof(DateTime));

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
    }
}
