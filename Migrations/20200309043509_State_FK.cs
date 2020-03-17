using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class State_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "LandDetails");

            migrationBuilder.AddColumn<int>(
                name: "StateListId",
                table: "LandDetails",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(3661), new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(7748), new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(8901), new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(9939), new DateTime(2020, 3, 9, 4, 35, 9, 256, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(8777), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9793), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9804), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9805), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9806), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9808), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9809), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9810), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9811), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9812), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9813), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9814), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9815), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9816), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9817), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9818), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9819), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9820), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9821), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9822), new DateTime(2020, 3, 9, 4, 35, 9, 257, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 9, 4, 35, 9, 255, DateTimeKind.Utc).AddTicks(9681), new DateTime(2020, 3, 9, 4, 35, 9, 255, DateTimeKind.Utc).AddTicks(9693) });

            migrationBuilder.CreateIndex(
                name: "IX_LandDetails_StateListId",
                table: "LandDetails",
                column: "StateListId");

            migrationBuilder.AddForeignKey(
                name: "FK_LandDetails_StateLists_StateListId",
                table: "LandDetails",
                column: "StateListId",
                principalTable: "StateLists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandDetails_StateLists_StateListId",
                table: "LandDetails");

            migrationBuilder.DropIndex(
                name: "IX_LandDetails_StateListId",
                table: "LandDetails");

            migrationBuilder.DropColumn(
                name: "StateListId",
                table: "LandDetails");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "LandDetails",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(3656), new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(6296), new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(7020), new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(7631), new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(3891), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4618), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4626), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4627), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4628), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4629), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4630), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4631), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4632), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4633), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4634), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4634), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4638), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4639), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4639), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4640), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4641), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4642), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4642), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "RolePageAccesses",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4643), new DateTime(2020, 3, 7, 12, 28, 15, 344, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "DateModified" },
                values: new object[] { new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(913), new DateTime(2020, 3, 7, 12, 28, 15, 343, DateTimeKind.Utc).AddTicks(924) });
        }
    }
}
