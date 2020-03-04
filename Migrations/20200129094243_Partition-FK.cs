using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class PartitionFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LandDetailsID",
                table: "PartitionLandDetails",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(8134), new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(906), new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(1669), new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(2895), new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(587), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1349), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1356), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1357), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1358), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1358), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1359), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1360), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1361), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1362), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1363), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1363), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1364), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1365), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1406), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1407), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1407), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1408), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1409), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1410), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(5102), new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(5113) });

            migrationBuilder.CreateIndex(
                name: "IX_PartitionLandDetails_LandDetailsID",
                table: "PartitionLandDetails",
                column: "LandDetailsID");

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailsID",
                table: "PartitionLandDetails",
                column: "LandDetailsID",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailsID",
                table: "PartitionLandDetails");

            migrationBuilder.DropIndex(
                name: "IX_PartitionLandDetails_LandDetailsID",
                table: "PartitionLandDetails");

            migrationBuilder.DropColumn(
                name: "LandDetailsID",
                table: "PartitionLandDetails");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 709, DateTimeKind.Utc).AddTicks(6848), new DateTime(2020, 1, 27, 3, 21, 22, 709, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 709, DateTimeKind.Utc).AddTicks(9633), new DateTime(2020, 1, 27, 3, 21, 22, 709, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(417), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(1043), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(7358), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8190), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8197), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8198), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8198), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8199), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8200), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8201), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8202), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8202), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8203), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8204), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8205), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8206), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8206), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8207), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8208), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8209), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8210), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8211), new DateTime(2020, 1, 27, 3, 21, 22, 710, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 27, 3, 21, 22, 709, DateTimeKind.Utc).AddTicks(4026), new DateTime(2020, 1, 27, 3, 21, 22, 709, DateTimeKind.Utc).AddTicks(4037) });
        }
    }
}
