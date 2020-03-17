using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class Plowing_date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Plowings");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlowingDate",
                table: "Plowings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(3815), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(6466), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7159), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7793), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(3831), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4531), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4538), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4539), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4539), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4540), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4541), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4542), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4543), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4543), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4544), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4545), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4545), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4546), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4547), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4548), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4548), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4549), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4550), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4551), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(720), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(736) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlowingDate",
                table: "Plowings");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Plowings",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(1079), new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(3559), new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(4249), new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(4896), new DateTime(2020, 3, 9, 5, 45, 49, 80, DateTimeKind.Utc).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(910), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1599), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1606), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1607), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1607), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1608), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1609), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1610), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1611), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1611), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1612), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1613), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1614), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1614), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1615), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1616), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1617), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1617), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1618), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1619), new DateTime(2020, 3, 9, 5, 45, 49, 81, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 45, 49, 79, DateTimeKind.Utc).AddTicks(8545), new DateTime(2020, 3, 9, 5, 45, 49, 79, DateTimeKind.Utc).AddTicks(8556) });
        }
    }
}
