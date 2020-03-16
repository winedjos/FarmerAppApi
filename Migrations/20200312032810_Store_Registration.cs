using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class Store_Registration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(3815), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(6466), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7159), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7793), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(3831), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4531), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4538), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4539), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4539), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4540), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4541), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4542), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4543), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4543), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4544), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4545), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4545), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4546), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4547), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4548), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4548), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4549), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4550), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4551), new DateTime(2020, 3, 9, 11, 9, 9, 882, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(720), new DateTime(2020, 3, 9, 11, 9, 9, 881, DateTimeKind.Utc).AddTicks(736) });
        }
    }
}
