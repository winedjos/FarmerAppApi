using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class add_Username_Password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Registrations",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Registrations",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Registrations",
                newName: "Name");

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
    }
}
