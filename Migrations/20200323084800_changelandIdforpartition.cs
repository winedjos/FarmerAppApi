using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class changelandIdforpartition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 23, 8, 48, 0, 58, DateTimeKind.Utc).AddTicks(7417), new DateTime(2020, 3, 23, 8, 48, 0, 58, DateTimeKind.Utc).AddTicks(7428) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(4641), new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(7411), new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(8146), new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(8849), new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(5314), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6055), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6061), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6062), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6063), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6064), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6065), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6066), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6066), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6067), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6068), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6069), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6070), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6070), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6071), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6072), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6073), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6074), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6074), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6075), new DateTime(2020, 3, 16, 11, 15, 53, 265, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(1770), new DateTime(2020, 3, 16, 11, 15, 53, 264, DateTimeKind.Utc).AddTicks(1782) });
        }
    }
}
