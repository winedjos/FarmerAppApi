using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class RemovedAndAddedLandDetailAndPartitionIDInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_PartitionLandDetailIDFK",
                table: "PartitionLandDetails");

            migrationBuilder.DropColumn(
                name: "LandDetailID",
                table: "PartitionLandDetails");

            migrationBuilder.RenameColumn(
                name: "PartitionLandDetailIDFK",
                table: "PartitionLandDetails",
                newName: "LandDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "PartitionLandDetails",
                newName: "IX_PartitionLandDetails_LandDetailsID");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(7295), new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(222), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1051), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1693), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(7980), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8704), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8711), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8712), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8713), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8713), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8714), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8715), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8716), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8717), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8718), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8718), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8719), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8720), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8721), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8722), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8723), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8723), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8724), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8725), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(4108), new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(4118) });

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

            migrationBuilder.RenameColumn(
                name: "LandDetailsID",
                table: "PartitionLandDetails",
                newName: "PartitionLandDetailIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_LandDetailsID",
                table: "PartitionLandDetails",
                newName: "IX_PartitionLandDetails_PartitionLandDetailIDFK");

            migrationBuilder.AddColumn<int>(
                name: "LandDetailID",
                table: "PartitionLandDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(6559), new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(9181), new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(9913), new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(537), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(6652), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7353), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7361), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7362), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7362), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7363), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7364), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7365), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7365), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7366), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7367), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7368), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7368), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7369), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7370), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7371), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7371), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7372), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7373), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7374), new DateTime(2020, 3, 7, 11, 53, 15, 596, DateTimeKind.Utc).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(4005), new DateTime(2020, 3, 7, 11, 53, 15, 595, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_PartitionLandDetailIDFK",
                table: "PartitionLandDetails",
                column: "PartitionLandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
