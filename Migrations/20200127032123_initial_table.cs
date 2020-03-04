using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class initial_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartitionLandDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    LandDirection = table.Column<string>(maxLength: 75, nullable: false),
                    LandName = table.Column<string>(maxLength: 75, nullable: false),
                    AreaSize = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartitionLandDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PestControls",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Land = table.Column<string>(maxLength: 75, nullable: false),
                    PartitionLand = table.Column<string>(maxLength: 75, nullable: false),
                    Date = table.Column<string>(nullable: true),
                    NameofthePestSide = table.Column<string>(maxLength: 50, nullable: true),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PestControls", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Plowings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Land = table.Column<string>(maxLength: 75, nullable: false),
                    PartitionLand = table.Column<string>(maxLength: 75, nullable: false),
                    Date = table.Column<string>(nullable: true),
                    TypeofPlowing = table.Column<string>(maxLength: 50, nullable: true),
                    PlowingExp = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plowings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Land = table.Column<string>(maxLength: 75, nullable: false),
                    PartitionLand = table.Column<string>(maxLength: 75, nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<string>(maxLength: 50, nullable: true),
                    BuyerName = table.Column<string>(maxLength: 50, nullable: true),
                    BuyerMobileNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Seedings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Land = table.Column<string>(maxLength: 75, nullable: false),
                    PartitionLand = table.Column<string>(maxLength: 75, nullable: false),
                    Quantity = table.Column<string>(maxLength: 50, nullable: true),
                    SeedName = table.Column<string>(maxLength: 50, nullable: true),
                    SeedCost = table.Column<string>(maxLength: 50, nullable: true),
                    NOofLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seedings", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartitionLandDetails");

            migrationBuilder.DropTable(
                name: "PestControls");

            migrationBuilder.DropTable(
                name: "Plowings");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Seedings");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(1116), new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(6144), new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(7771), new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(9369), new DateTime(2020, 1, 22, 10, 21, 1, 597, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(164), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(955), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(962), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(962), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(963), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(964), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(965), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(965), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(966), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(967), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(968), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(969), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(969), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(970), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(971), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(972), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(972), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(973), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(974), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(975), new DateTime(2020, 1, 22, 10, 21, 1, 599, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 22, 10, 21, 1, 596, DateTimeKind.Utc).AddTicks(7256), new DateTime(2020, 1, 22, 10, 21, 1, 596, DateTimeKind.Utc).AddTicks(7268) });
        }
    }
}
