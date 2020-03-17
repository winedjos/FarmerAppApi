using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThaniyasFarmerAppAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LandDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    State = table.Column<string>(maxLength: 75, nullable: false),
                    Village = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    PattaNumber = table.Column<string>(maxLength: 50, nullable: true),
                    AreaSize = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    IsFirstTimeLogin = table.Column<bool>(nullable: false),
                    AcceptedTermsAndConditions = table.Column<bool>(nullable: false),
                    ResetPasswordToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WebPages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebPages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserActivity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Activity = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserActivity_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePageAccesses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    RolesID = table.Column<int>(nullable: false),
                    PagesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePageAccesses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RolePageAccesses_WebPages_PagesID",
                        column: x => x.PagesID,
                        principalTable: "WebPages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePageAccesses_Roles_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "ID", "DateAdded", "DateModified", "Deleted", "Name", "ParentID", "Text", "Type", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 2, 14, 48, 12, 375, DateTimeKind.Utc).AddTicks(7831), new DateTime(2020, 1, 2, 14, 48, 12, 375, DateTimeKind.Utc).AddTicks(7833), false, "UserID", null, null, "SystemEmailSettings", "vNp/Rg/59Wq/aUZBS0+1LDWmAArWOdzzJByWFcSqj9c=" },
                    { 2, new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(6342), new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(6343), false, "Password", null, null, "SystemEmailSettings", "DR7VkCQllyJBLRHqnhoFLg==" },
                    { 3, new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(9198), new DateTime(2020, 1, 2, 14, 48, 12, 376, DateTimeKind.Utc).AddTicks(9199), false, "SMTPPort", null, null, "SystemEmailSettings", "KfPgC+VOAFLCwNmgAKPmfQ==" },
                    { 4, new DateTime(2020, 1, 2, 14, 48, 12, 377, DateTimeKind.Utc).AddTicks(1596), new DateTime(2020, 1, 2, 14, 48, 12, 377, DateTimeKind.Utc).AddTicks(1597), false, "Host", null, null, "SystemEmailSettings", "+fNJD/SKxu6Pyz64X9mIMQ==" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "Deleted", "Name", "Text" },
                values: new object[,]
                {
                    { 1, false, "Admin", "Admin" },
                    { 2, false, "User", "User" },
                    { 3, false, "SiteAdmin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "AcceptedTermsAndConditions", "DateAdded", "DateModified", "Deleted", "Email", "FirstName", "IsFirstTimeLogin", "LastName", "Password", "ResetPasswordToken", "RoleID", "UserName" },
                values: new object[] { 1, true, new DateTime(2020, 1, 2, 14, 48, 12, 374, DateTimeKind.Utc).AddTicks(8983), new DateTime(2020, 1, 2, 14, 48, 12, 374, DateTimeKind.Utc).AddTicks(9011), false, "winedjos@gmail.com", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, "admin" });

            migrationBuilder.InsertData(
                table: "WebPages",
                columns: new[] { "ID", "Deleted", "Name", "Text", "Url" },
                values: new object[,]
                {
                    { 8, false, "Harvesting", "Harvesting", "/harvesting" },
                    { 7, false, "PostLogin", "Post Login", "/postlogin" },
                    { 6, false, "WeedRemove", "Weed Remove", "/weedremove" },
                    { 5, false, "PestControl", "Pest Control", "/pestcontrol" },
                    { 1, false, "ManageLand", "Land", "/manageland" },
                    { 3, false, "Plowing", "Plowing ", "/plowing " },
                    { 2, false, "ManagePartition", "Partition", "/managepartition" },
                    { 9, false, "Sale", "Sale", "/sale" },
                    { 4, false, "Seeding", "Seeding", "/seeding" },
                    { 10, false, "Report", "Report", "/report" }
                });

            migrationBuilder.InsertData(
                table: "RolePageAccesses",
                columns: new[] { "ID", "DateAdded", "DateModified", "Deleted", "PagesID", "RolesID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(2714), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(2716), false, 1, 1 },
                    { 19, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5144), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5145), false, 9, 2 },
                    { 9, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4968), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4969), false, 9, 1 },
                    { 18, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5141), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5142), false, 8, 2 },
                    { 8, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4966), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4966), false, 8, 1 },
                    { 17, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5138), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5139), false, 7, 2 },
                    { 7, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4963), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4964), false, 7, 1 },
                    { 16, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5135), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5135), false, 6, 2 },
                    { 6, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4960), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4961), false, 6, 1 },
                    { 15, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5132), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5133), false, 5, 2 },
                    { 5, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4957), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4958), false, 5, 1 },
                    { 14, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5130), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5131), false, 4, 2 },
                    { 4, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4954), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4955), false, 4, 1 },
                    { 13, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5127), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5127), false, 3, 2 },
                    { 3, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4951), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4952), false, 3, 1 },
                    { 12, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4977), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4977), false, 2, 2 },
                    { 2, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4927), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4929), false, 2, 1 },
                    { 11, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4974), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4975), false, 1, 2 },
                    { 10, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4971), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(4972), false, 10, 1 },
                    { 20, new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5147), new DateTime(2020, 1, 2, 14, 48, 12, 379, DateTimeKind.Utc).AddTicks(5148), false, 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePageAccesses_PagesID",
                table: "RolePageAccesses",
                column: "PagesID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePageAccesses_RolesID",
                table: "RolePageAccesses",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_UserID",
                table: "UserActivity",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "LandDetails");

            migrationBuilder.DropTable(
                name: "RolePageAccesses");

            migrationBuilder.DropTable(
                name: "UserActivity");

            migrationBuilder.DropTable(
                name: "WebPages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
