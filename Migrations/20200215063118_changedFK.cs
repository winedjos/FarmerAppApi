using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class changedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailsID",
                table: "PartitionLandDetails");

            migrationBuilder.RenameColumn(
                name: "LandDetailsID",
                table: "PartitionLandDetails",
                newName: "LandDetailIDFK");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_LandDetailsID",
                table: "PartitionLandDetails",
                newName: "IX_PartitionLandDetails_LandDetailIDFK");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(4388), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7101), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7884), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(8506), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(4438), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5126), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5132), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5133), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5134), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5135), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5136), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5136), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5137), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5138), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5139), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5139), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5140), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5141), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5142), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5142), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5143), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5144), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5145), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5145), new DateTime(2020, 2, 15, 6, 31, 18, 113, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(1659), new DateTime(2020, 2, 15, 6, 31, 18, 112, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.AddForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailIDFK",
                table: "PartitionLandDetails",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartitionLandDetails_LandDetails_LandDetailIDFK",
                table: "PartitionLandDetails");

            migrationBuilder.RenameColumn(
                name: "LandDetailIDFK",
                table: "PartitionLandDetails",
                newName: "LandDetailsID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitionLandDetails_LandDetailIDFK",
                table: "PartitionLandDetails",
                newName: "IX_PartitionLandDetails_LandDetailsID");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(6789), new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(9485), new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(249), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(855), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7128), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7846), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7853), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7854), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7854), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7855), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7856), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7857), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7858), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7858), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7859), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7860), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7861), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7862), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7862), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7863), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7903), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7904), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7905), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7906), new DateTime(2020, 2, 15, 4, 57, 51, 224, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(3816), new DateTime(2020, 2, 15, 4, 57, 51, 223, DateTimeKind.Utc).AddTicks(3827) });

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
