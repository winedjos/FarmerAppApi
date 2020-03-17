using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class PartFkforLand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartitionLandDetailIDFK",
                table: "PartitionLandDetails",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(5987), new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(8789), new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(9559), new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(166), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(6504), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7219), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7226), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7227), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7228), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7229), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7229), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7230), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7231), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7232), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7233), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7234), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7234), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7235), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7236), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7237), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7238), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7238), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7239), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7240), new DateTime(2020, 3, 7, 11, 25, 16, 539, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(2992), new DateTime(2020, 3, 7, 11, 25, 16, 538, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.CreateIndex(
                name: "IX_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "PartitionLandDetails",
                column: "PartitionLandDetailIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_PartitionLandDetailIDFK",
                table: "PartitionLandDetails",
                column: "PartitionLandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_PartitionLandDetailIDFK",
                table: "PartitionLandDetails");

            migrationBuilder.DropIndex(
                name: "IX_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "PartitionLandDetails");

            migrationBuilder.DropColumn(
                name: "PartitionLandDetailIDFK",
                table: "PartitionLandDetails");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(8360), new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2155), new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2918), new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(3521), new DateTime(2020, 2, 26, 4, 45, 20, 350, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(45), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(869), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(875), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(876), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(877), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(878), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(878), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(879), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(880), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(881), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(882), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(882), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(883), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(884), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(885), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(885), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(886), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(887), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(888), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(889), new DateTime(2020, 2, 26, 4, 45, 20, 351, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(5165), new DateTime(2020, 2, 26, 4, 45, 20, 349, DateTimeKind.Utc).AddTicks(5176) });
        }
    }
}
