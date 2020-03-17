using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class WeedRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeedRemove",
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
                    table.PrimaryKey("PK_WeedRemove", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeedRemove");

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
    }
}
