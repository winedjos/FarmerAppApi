using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class harvestings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Harvestings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Land = table.Column<string>(maxLength: 75, nullable: false),
                    PartitionLand = table.Column<string>(maxLength: 75, nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    NOofLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harvestings", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(4877), new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(7613), new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(8359), new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(8971), new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(5276), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6100), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6110), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6111), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6112), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6113), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6113), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6114), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6115), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6116), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6117), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6118), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6119), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6119), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6120), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6121), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6122), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6123), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6124), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6125), new DateTime(2020, 1, 18, 8, 27, 16, 471, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(2018), new DateTime(2020, 1, 18, 8, 27, 16, 470, DateTimeKind.Utc).AddTicks(2030) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Harvestings");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 375, DateTimeKind.Utc).AddTicks(7831), new DateTime(2020, 1, 2, 14, 48, 12, 375, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(6342), new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(9198), new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 377, DateTimeKind.Utc).AddTicks(1596), new DateTime(2020, 1, 2, 14, 48, 12, 377, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(2714), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4927), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4951), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4954), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4957), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4960), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4963), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4966), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4968), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4971), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4974), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4977), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5127), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5130), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5132), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5135), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5138), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5141), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5144), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5147), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 2, 14, 48, 12, 374, DateTimeKind.Utc).AddTicks(8983), new DateTime(2020, 1, 2, 14, 48, 12, 374, DateTimeKind.Utc).AddTicks(9011) });
        }
    }
}
