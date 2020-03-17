using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class StateList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StateLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateLists", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(585), new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(3184), new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(3974), new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(4598), new DateTime(2020, 2, 10, 9, 24, 17, 770, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(770), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1513), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1520), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1521), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1521), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1522), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1523), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1524), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1525), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1526), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1527), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1527), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1529), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1530), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1532), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1532), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1533), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1534), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1535), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1536), new DateTime(2020, 2, 10, 9, 24, 17, 771, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 24, 17, 769, DateTimeKind.Utc).AddTicks(7906), new DateTime(2020, 2, 10, 9, 24, 17, 769, DateTimeKind.Utc).AddTicks(7916) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateLists");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(8134), new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(906), new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(1669), new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(2895), new DateTime(2020, 1, 29, 9, 42, 43, 496, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(587), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1349), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1356), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1357), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1358), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1358), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1359), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1360), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1361), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1362), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1363), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1363), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1364), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1365), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1406), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1407), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1407), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1408), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1409), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1410), new DateTime(2020, 1, 29, 9, 42, 43, 497, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(5102), new DateTime(2020, 1, 29, 9, 42, 43, 495, DateTimeKind.Utc).AddTicks(5113) });
        }
    }
}
