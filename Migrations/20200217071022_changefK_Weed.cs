using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class changefK_Weed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Land",
                table: "WeedRemove");

            migrationBuilder.DropColumn(
                name: "PartitionLand",
                table: "WeedRemove");

            migrationBuilder.AddColumn<int>(
                name: "LandDetailIDFK",
                table: "WeedRemove",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartitionLandDetailIDFK",
                table: "WeedRemove",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 742, DateTimeKind.Utc).AddTicks(7399), new DateTime(2020, 2, 17, 7, 10, 22, 742, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(190), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(929), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(1523), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(7522), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8212), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8219), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8220), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8221), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8222), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8222), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8223), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8224), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8225), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8225), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8226), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8227), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8228), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8228), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8229), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8230), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8231), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8231), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8232), new DateTime(2020, 2, 17, 7, 10, 22, 743, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 7, 10, 22, 742, DateTimeKind.Utc).AddTicks(3951), new DateTime(2020, 2, 17, 7, 10, 22, 742, DateTimeKind.Utc).AddTicks(3962) });

            migrationBuilder.CreateIndex(
                name: "IX_WeedRemove_LandDetailIDFK",
                table: "WeedRemove",
                column: "LandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_WeedRemove_PartitionLandDetailIDFK",
                table: "WeedRemove",
                column: "PartitionLandDetailIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_WeedRemove_LandDetails_LandDetailIDFK",
                table: "WeedRemove",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeedRemove_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "WeedRemove",
                column: "PartitionLandDetailIDFK",
                principalTable: "PartitionLandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeedRemove_LandDetails_LandDetailIDFK",
                table: "WeedRemove");

            migrationBuilder.DropForeignKey(
                name: "FK_WeedRemove_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "WeedRemove");

            migrationBuilder.DropIndex(
                name: "IX_WeedRemove_LandDetailIDFK",
                table: "WeedRemove");

            migrationBuilder.DropIndex(
                name: "IX_WeedRemove_PartitionLandDetailIDFK",
                table: "WeedRemove");

            migrationBuilder.DropColumn(
                name: "LandDetailIDFK",
                table: "WeedRemove");

            migrationBuilder.DropColumn(
                name: "PartitionLandDetailIDFK",
                table: "WeedRemove");

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "WeedRemove",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartitionLand",
                table: "WeedRemove",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(676), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(3581), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(4400), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(5005), new DateTime(2020, 2, 17, 4, 43, 21, 161, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(1697), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2496), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2506), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2507), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2507), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2508), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2509), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2510), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2510), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2511), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2512), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2513), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2514), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2514), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2515), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2516), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2517), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2517), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2518), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2519), new DateTime(2020, 2, 17, 4, 43, 21, 162, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 17, 4, 43, 21, 160, DateTimeKind.Utc).AddTicks(7776), new DateTime(2020, 2, 17, 4, 43, 21, 160, DateTimeKind.Utc).AddTicks(7788) });
        }
    }
}
