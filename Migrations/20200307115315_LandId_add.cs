using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class LandId_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailIDFK",
                table: "PartitionLandDetails");

            migrationBuilder.DropIndex(
                name: "IX_PartitionLandDetails_LandDetailIDFK",
                table: "PartitionLandDetails");

            migrationBuilder.DropColumn(
                name: "LandDetailIDFK",
                table: "PartitionLandDetails");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LandDetailID",
                table: "PartitionLandDetails");

            migrationBuilder.AddColumn<int>(
                name: "LandDetailIDFK",
                table: "PartitionLandDetails",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(5089), new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(7593), new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(8310), new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(8890), new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5068), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5753), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5760), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5761), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5762), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5762), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5763), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5764), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5765), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5765), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5766), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5767), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5768), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5768), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5769), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5770), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5771), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5771), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5772), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5773), new DateTime(2020, 3, 7, 11, 37, 32, 311, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(2534), new DateTime(2020, 3, 7, 11, 37, 32, 310, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.CreateIndex(
                name: "IX_PartitionLandDetails_LandDetailIDFK",
                table: "PartitionLandDetails",
                column: "LandDetailIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailIDFK",
                table: "PartitionLandDetails",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
