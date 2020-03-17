using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class AddedAndUpdatedAgainTheRelationshipWithLandDetailAndPartitionTable_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailsID",
                table: "PartitionLandDetails");

            migrationBuilder.RenameColumn(
                name: "LandDetailsID",
                table: "PartitionLandDetails",
                newName: "LandDetailID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_LandDetailsID",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailID",
                table: "PartitionLandDetails");

            migrationBuilder.RenameColumn(
                name: "LandDetailID",
                table: "PartitionLandDetails",
                newName: "LandDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_LandDetailID",
                table: "PartitionLandDetails",
                newName: "IX_PartitionLandDetails_LandDetailsID");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(8950), new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(2540), new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(3498), new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(4296), new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(2790), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3745), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3753), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3755), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3756), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3757), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3758), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3759), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3760), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3761), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3762), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3763), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3764), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3765), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3766), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3767), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3768), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3769), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3770), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3771), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(4995), new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailsID",
                table: "PartitionLandDetails",
                column: "LandDetailsID",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
