using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class FK_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Land",
                table: "Seedings");

            migrationBuilder.DropColumn(
                name: "PartitionLand",
                table: "Seedings");

            migrationBuilder.DropColumn(
                name: "Land",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PartitionLand",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Land",
                table: "Plowings");

            migrationBuilder.DropColumn(
                name: "PartitionLand",
                table: "Plowings");

            migrationBuilder.DropColumn(
                name: "Land",
                table: "PestControls");

            migrationBuilder.DropColumn(
                name: "PartitionLand",
                table: "PestControls");

            migrationBuilder.DropColumn(
                name: "Land",
                table: "Harvestings");

            migrationBuilder.DropColumn(
                name: "PartitionLand",
                table: "Harvestings");

            migrationBuilder.AddColumn<int>(
                name: "LandDetailIDFK",
                table: "Seedings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartitionLandDetailIDFK",
                table: "Seedings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LandDetailIDFK",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartitionLandDetailIDFK",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LandDetailIDFK",
                table: "Plowings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartitionLandDetailIDFK",
                table: "Plowings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LandDetailIDFK",
                table: "PestControls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartitionLandDetailIDFK",
                table: "PestControls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LandDetailIDFK",
                table: "Harvestings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartitionLandDetailIDFK",
                table: "Harvestings",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Seedings_LandDetailIDFK",
                table: "Seedings",
                column: "LandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Seedings_PartitionLandDetailIDFK",
                table: "Seedings",
                column: "PartitionLandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_LandDetailIDFK",
                table: "Sales",
                column: "LandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PartitionLandDetailIDFK",
                table: "Sales",
                column: "PartitionLandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Plowings_LandDetailIDFK",
                table: "Plowings",
                column: "LandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Plowings_PartitionLandDetailIDFK",
                table: "Plowings",
                column: "PartitionLandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_PestControls_LandDetailIDFK",
                table: "PestControls",
                column: "LandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_PestControls_PartitionLandDetailIDFK",
                table: "PestControls",
                column: "PartitionLandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Harvestings_LandDetailIDFK",
                table: "Harvestings",
                column: "LandDetailIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Harvestings_PartitionLandDetailIDFK",
                table: "Harvestings",
                column: "PartitionLandDetailIDFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Harvestings_LandDetails_LandDetailIDFK",
                table: "Harvestings",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Harvestings_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Harvestings",
                column: "PartitionLandDetailIDFK",
                principalTable: "PartitionLandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PestControls_LandDetails_LandDetailIDFK",
                table: "PestControls",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PestControls_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "PestControls",
                column: "PartitionLandDetailIDFK",
                principalTable: "PartitionLandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plowings_LandDetails_LandDetailIDFK",
                table: "Plowings",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plowings_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Plowings",
                column: "PartitionLandDetailIDFK",
                principalTable: "PartitionLandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_LandDetails_LandDetailIDFK",
                table: "Sales",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Sales",
                column: "PartitionLandDetailIDFK",
                principalTable: "PartitionLandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seedings_LandDetails_LandDetailIDFK",
                table: "Seedings",
                column: "LandDetailIDFK",
                principalTable: "LandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seedings_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Seedings",
                column: "PartitionLandDetailIDFK",
                principalTable: "PartitionLandDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Harvestings_LandDetails_LandDetailIDFK",
                table: "Harvestings");

            migrationBuilder.DropForeignKey(
                name: "FK_Harvestings_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Harvestings");

            migrationBuilder.DropForeignKey(
                name: "FK_PestControls_LandDetails_LandDetailIDFK",
                table: "PestControls");

            migrationBuilder.DropForeignKey(
                name: "FK_PestControls_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "PestControls");

            migrationBuilder.DropForeignKey(
                name: "FK_Plowings_LandDetails_LandDetailIDFK",
                table: "Plowings");

            migrationBuilder.DropForeignKey(
                name: "FK_Plowings_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Plowings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_LandDetails_LandDetailIDFK",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Seedings_LandDetails_LandDetailIDFK",
                table: "Seedings");

            migrationBuilder.DropForeignKey(
                name: "FK_Seedings_PartitionLandDetails_PartitionLandDetailIDFK",
                table: "Seedings");

            migrationBuilder.DropIndex(
                name: "IX_Seedings_LandDetailIDFK",
                table: "Seedings");

            migrationBuilder.DropIndex(
                name: "IX_Seedings_PartitionLandDetailIDFK",
                table: "Seedings");

            migrationBuilder.DropIndex(
                name: "IX_Sales_LandDetailIDFK",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_PartitionLandDetailIDFK",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Plowings_LandDetailIDFK",
                table: "Plowings");

            migrationBuilder.DropIndex(
                name: "IX_Plowings_PartitionLandDetailIDFK",
                table: "Plowings");

            migrationBuilder.DropIndex(
                name: "IX_PestControls_LandDetailIDFK",
                table: "PestControls");

            migrationBuilder.DropIndex(
                name: "IX_PestControls_PartitionLandDetailIDFK",
                table: "PestControls");

            migrationBuilder.DropIndex(
                name: "IX_Harvestings_LandDetailIDFK",
                table: "Harvestings");

            migrationBuilder.DropIndex(
                name: "IX_Harvestings_PartitionLandDetailIDFK",
                table: "Harvestings");

            migrationBuilder.DropColumn(
                name: "LandDetailIDFK",
                table: "Seedings");

            migrationBuilder.DropColumn(
                name: "PartitionLandDetailIDFK",
                table: "Seedings");

            migrationBuilder.DropColumn(
                name: "LandDetailIDFK",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PartitionLandDetailIDFK",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "LandDetailIDFK",
                table: "Plowings");

            migrationBuilder.DropColumn(
                name: "PartitionLandDetailIDFK",
                table: "Plowings");

            migrationBuilder.DropColumn(
                name: "LandDetailIDFK",
                table: "PestControls");

            migrationBuilder.DropColumn(
                name: "PartitionLandDetailIDFK",
                table: "PestControls");

            migrationBuilder.DropColumn(
                name: "LandDetailIDFK",
                table: "Harvestings");

            migrationBuilder.DropColumn(
                name: "PartitionLandDetailIDFK",
                table: "Harvestings");

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "Seedings",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartitionLand",
                table: "Seedings",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "Sales",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartitionLand",
                table: "Sales",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "Plowings",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartitionLand",
                table: "Plowings",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "PestControls",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartitionLand",
                table: "PestControls",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Land",
                table: "Harvestings",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartitionLand",
                table: "Harvestings",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

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
        }
    }
}
