using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class Fetch_login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(7542), new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(17), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(705), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(1413), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(7417), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8110), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8116), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8117), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8118), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8118), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8119), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8120), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8121), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8121), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8122), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8123), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8124), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8124), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8125), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8126), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8127), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8128), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8128), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8129), new DateTime(2020, 3, 12, 4, 11, 25, 937, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(5043), new DateTime(2020, 3, 12, 4, 11, 25, 936, DateTimeKind.Utc).AddTicks(5054) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 368, DateTimeKind.Utc).AddTicks(2611), new DateTime(2020, 3, 12, 3, 28, 10, 368, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 368, DateTimeKind.Utc).AddTicks(8010), new DateTime(2020, 3, 12, 3, 28, 10, 368, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 368, DateTimeKind.Utc).AddTicks(9487), new DateTime(2020, 3, 12, 3, 28, 10, 368, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 369, DateTimeKind.Utc).AddTicks(863), new DateTime(2020, 3, 12, 3, 28, 10, 369, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(4061), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5349), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5361), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5362), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5364), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5366), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5442), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5444), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5445), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5447), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5448), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5450), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5451), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5452), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5454), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5456), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5457), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5458), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5460), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5461), new DateTime(2020, 3, 12, 3, 28, 10, 370, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 12, 3, 28, 10, 367, DateTimeKind.Utc).AddTicks(7072), new DateTime(2020, 3, 12, 3, 28, 10, 367, DateTimeKind.Utc).AddTicks(7097) });
        }
    }
}
