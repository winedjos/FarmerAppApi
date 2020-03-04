using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class removeingLandName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LandName",
                table: "PartitionLandDetails");

            migrationBuilder.AlterColumn<string>(
                name: "AreaSize",
                table: "PartitionLandDetails",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AreaSize",
                table: "PartitionLandDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 75);

            migrationBuilder.AddColumn<string>(
                name: "LandName",
                table: "PartitionLandDetails",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

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
    }
}
