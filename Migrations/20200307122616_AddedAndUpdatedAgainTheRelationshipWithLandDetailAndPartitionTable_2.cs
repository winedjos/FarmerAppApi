using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class AddedAndUpdatedAgainTheRelationshipWithLandDetailAndPartitionTable_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailID",
                table: "PartitionLandDetails");

            migrationBuilder.RenameColumn(
                name: "LandDetailID",
                table: "PartitionLandDetails",
                newName: "LandDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_LandDetailID",
                table: "PartitionLandDetails",
                newName: "IX_PartitionLandDetails_LandDetailId");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 135, DateTimeKind.Utc).AddTicks(5830), new DateTime(2020, 3, 7, 12, 26, 16, 135, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 135, DateTimeKind.Utc).AddTicks(9245), new DateTime(2020, 3, 7, 12, 26, 16, 135, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 136, DateTimeKind.Utc).AddTicks(118), new DateTime(2020, 3, 7, 12, 26, 16, 136, DateTimeKind.Utc).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 136, DateTimeKind.Utc).AddTicks(803), new DateTime(2020, 3, 7, 12, 26, 16, 136, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(359), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1541), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1556), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1558), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1559), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1560), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1561), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1562), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1563), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1564), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1565), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1566), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1568), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1569), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1570), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1572), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1573), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1574), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1575), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1577), new DateTime(2020, 3, 7, 12, 26, 16, 137, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 26, 16, 135, DateTimeKind.Utc).AddTicks(2711), new DateTime(2020, 3, 7, 12, 26, 16, 135, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailId",
                table: "PartitionLandDetails",
                column: "LandDetailId",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailId",
                table: "PartitionLandDetails");

            migrationBuilder.RenameColumn(
                name: "LandDetailId",
                table: "PartitionLandDetails",
                newName: "LandDetailID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_LandDetailId",
                table: "PartitionLandDetails",
                newName: "IX_PartitionLandDetails_LandDetailID");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(3784), new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(6242), new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(6937), new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(7521), new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(3931), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4666), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4710), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4711), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4712), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4713), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4714), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4715), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4715), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4716), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4717), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4718), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4719), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4720), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4720), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4721), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4722), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4723), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4724), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4725), new DateTime(2020, 3, 7, 12, 24, 32, 772, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(1380), new DateTime(2020, 3, 7, 12, 24, 32, 771, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailID",
                table: "PartitionLandDetails",
                column: "LandDetailID",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
