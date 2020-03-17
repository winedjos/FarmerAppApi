using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class AddedAndUpdatedAgainTheRelationshipWithLandDetailAndPartitionTabe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(8950), new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(2540), new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(3498), new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(4296), new DateTime(2020, 3, 7, 12, 13, 35, 924, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(2790), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3745), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3753), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3755), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3756), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3757), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3758), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3759), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3760), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3761), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3762), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3763), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3764), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3765), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3766), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3767), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3768), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3769), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3770), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3771), new DateTime(2020, 3, 7, 12, 13, 35, 925, DateTimeKind.Utc).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(4995), new DateTime(2020, 3, 7, 12, 13, 35, 923, DateTimeKind.Utc).AddTicks(5011) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(7295), new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(222), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1051), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1693), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(7980), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8704), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8711), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8712), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8713), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8713), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8714), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8715), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8716), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8717), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8718), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8718), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8719), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8720), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8721), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8722), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8723), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8723), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8724), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8725), new DateTime(2020, 3, 7, 12, 8, 23, 790, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(4108), new DateTime(2020, 3, 7, 12, 8, 23, 789, DateTimeKind.Utc).AddTicks(4118) });
        }
    }
}
