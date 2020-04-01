using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class delfName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptedTermsAndConditions",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ResetPasswordToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Registrations");

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
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 11, 50, 10, 985, DateTimeKind.Utc).AddTicks(7609), new DateTime(2020, 3, 23, 11, 50, 10, 985, DateTimeKind.Utc).AddTicks(7620) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AcceptedTermsAndConditions",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResetPasswordToken",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Registrations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Registrations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 58, DateTimeKind.Utc).AddTicks(9999), new DateTime(2020, 3, 23, 8, 48, 0, 58, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(2439), new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(3121), new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(3716), new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(9746), new DateTime(2020, 3, 23, 8, 48, 0, 59, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(434), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(440), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(441), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(442), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(443), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(443), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(444), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(445), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(446), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(446), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(447), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(448), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(449), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(450), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(450), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(451), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(452), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(452), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(453), new DateTime(2020, 3, 23, 8, 48, 0, 60, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AcceptedTermsAndConditions", "DateAdded", "DateModified" },
                values: new object[] { true, new DateTime(2020, 3, 23, 8, 48, 0, 58, DateTimeKind.Utc).AddTicks(7417), new DateTime(2020, 3, 23, 8, 48, 0, 58, DateTimeKind.Utc).AddTicks(7428) });
        }
    }
}
