using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class removerole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(5790), new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(8330), new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(9044), new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(9716), new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(5692), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6399), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6406), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6407), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6407), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6408), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6409), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6410), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6410), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6411), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6412), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6413), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6413), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6414), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6415), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6416), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6416), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6417), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6418), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6419), new DateTime(2020, 3, 23, 11, 52, 17, 502, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(3614), new DateTime(2020, 3, 23, 11, 52, 17, 501, DateTimeKind.Utc).AddTicks(3624) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(739), new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(3358), new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(4051), new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(4641), new DateTime(2020, 3, 23, 11, 50, 10, 986, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(763), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1466), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1472), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1473), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1474), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1475), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1475), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1512), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1513), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1514), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1514), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1515), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1516), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1517), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1517), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1518), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1519), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1520), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1520), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1521), new DateTime(2020, 3, 23, 11, 50, 10, 987, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified", "RoleID" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 985, DateTimeKind.Utc).AddTicks(7609), new DateTime(2020, 3, 23, 11, 50, 10, 985, DateTimeKind.Utc).AddTicks(7620), 1 });
        }
    }
}
