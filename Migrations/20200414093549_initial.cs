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

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.ID);
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
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
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
                name: "LandDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    Village = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    PattaNumber = table.Column<string>(maxLength: 50, nullable: true),
                    AreaSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LandDetails_StateLists_StateId",
                        column: x => x.StateId,
                        principalTable: "StateLists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePageAccesses_Roles_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartitionLandDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    LandDirection = table.Column<string>(maxLength: 75, nullable: false),
                    AreaSize = table.Column<string>(maxLength: 75, nullable: false),
                    LandDetailId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartitionLandDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartitionLandDetails_LandDetails_LandDetailId",
                        column: x => x.LandDetailId,
                        principalTable: "LandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartitionLandDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Harvestings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    NoOfLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harvestings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Harvestings_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Harvestings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PestControls",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    PestControlDate = table.Column<string>(nullable: true),
                    NameofthePestSide = table.Column<string>(maxLength: 50, nullable: true),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    Purpose = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PestControls", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PestControls_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PestControls_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plowings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    PlowingDate = table.Column<DateTime>(nullable: false),
                    TypeofPlowing = table.Column<string>(maxLength: 50, nullable: true),
                    PlowingExp = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plowings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plowings_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plowings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    SaleDate = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<string>(maxLength: 50, nullable: true),
                    BuyerName = table.Column<string>(maxLength: 50, nullable: true),
                    BuyerMobileNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sales_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seedings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    Quantity = table.Column<string>(maxLength: 50, nullable: true),
                    SeedName = table.Column<string>(maxLength: 50, nullable: true),
                    SeedCost = table.Column<string>(maxLength: 50, nullable: true),
                    NoOfLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seedings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Seedings_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seedings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeedRemove",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PartitionLandDetailId = table.Column<int>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(maxLength: 50, nullable: true),
                    NoOfLabours = table.Column<string>(maxLength: 50, nullable: true),
                    LabourCost = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeedRemove", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WeedRemove_PartitionLandDetails_PartitionLandDetailId",
                        column: x => x.PartitionLandDetailId,
                        principalTable: "PartitionLandDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeedRemove_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "ID", "DateAdded", "DateModified", "Deleted", "Name", "ParentID", "Text", "Type", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(9827), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(9828), false, "UserID", null, null, "SystemEmailSettings", "vNp/Rg/59Wq/aUZBS0+1LDWmAArWOdzzJByWFcSqj9c=" },
                    { 2, new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(5578), new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(5579), false, "Password", null, null, "SystemEmailSettings", "DR7VkCQllyJBLRHqnhoFLg==" },
                    { 3, new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(7459), new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(7459), false, "SMTPPort", null, null, "SystemEmailSettings", "KfPgC+VOAFLCwNmgAKPmfQ==" },
                    { 4, new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(9110), new DateTime(2020, 4, 14, 9, 35, 49, 298, DateTimeKind.Utc).AddTicks(9110), false, "Host", null, null, "SystemEmailSettings", "+fNJD/SKxu6Pyz64X9mIMQ==" }
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
                values: new object[,]
                {
                    { 5, true, new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(4149), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(4149), false, "edwin@inisys.in", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, "edwin" },
                    { 3, true, new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(820), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(822), false, "senthil@gmail.com", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, "senthil" },
                    { 4, true, new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(2496), new DateTime(2020, 4, 14, 9, 35, 49, 297, DateTimeKind.Utc).AddTicks(2497), false, "seetha@inisys.in", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, "seetha" },
                    { 1, false, new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(4052), new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(4080), false, "winedjos@gmail.com", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 0, "admin" },
                    { 2, true, new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(7521), new DateTime(2020, 4, 14, 9, 35, 49, 296, DateTimeKind.Utc).AddTicks(7522), false, "seenu@inisys.in", null, true, null, "llFg1YwNHgLVbQGDz1aaEQ==", null, 1, "seenu" }
                });

            migrationBuilder.InsertData(
                table: "WebPages",
                columns: new[] { "ID", "Deleted", "Name", "Text", "Url" },
                values: new object[,]
                {
                    { 9, false, "Sale", "Sale", "/sale" },
                    { 1, false, "ManageLand", "Land", "/manageland" },
                    { 2, false, "ManagePartition", "Partition", "/managepartition" },
                    { 3, false, "Plowing", "Plowing ", "/plowing " },
                    { 4, false, "Seeding", "Seeding", "/seeding" },
                    { 5, false, "PestControl", "Pest Control", "/pestcontrol" },
                    { 6, false, "WeedRemove", "Weed Remove", "/weedremove" },
                    { 7, false, "PostLogin", "Post Login", "/postlogin" },
                    { 8, false, "Harvesting", "Harvesting", "/harvesting" },
                    { 10, false, "Report", "Report", "/report" }
                });

            migrationBuilder.InsertData(
                table: "RolePageAccesses",
                columns: new[] { "ID", "DateAdded", "DateModified", "Deleted", "PagesID", "RolesID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(2877), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(2878), false, 1, 1 },
                    { 19, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4379), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4380), false, 9, 2 },
                    { 9, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4361), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4362), false, 9, 1 },
                    { 18, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4377), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4378), false, 8, 2 },
                    { 8, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4360), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4360), false, 8, 1 },
                    { 17, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4375), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4376), false, 7, 2 },
                    { 7, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4358), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4358), false, 7, 1 },
                    { 16, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4374), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4374), false, 6, 2 },
                    { 6, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4356), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4357), false, 6, 1 },
                    { 15, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4372), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4373), false, 5, 2 },
                    { 5, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4354), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4355), false, 5, 1 },
                    { 14, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4370), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4371), false, 4, 2 },
                    { 4, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4352), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4353), false, 4, 1 },
                    { 13, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4368), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4369), false, 3, 2 },
                    { 3, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4350), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4351), false, 3, 1 },
                    { 12, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4367), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4367), false, 2, 2 },
                    { 2, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4336), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4337), false, 2, 1 },
                    { 11, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4365), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4365), false, 1, 2 },
                    { 10, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4363), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4364), false, 10, 1 },
                    { 20, new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4381), new DateTime(2020, 4, 14, 9, 35, 49, 300, DateTimeKind.Utc).AddTicks(4381), false, 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Harvestings_PartitionLandDetailId",
                table: "Harvestings",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Harvestings_UserId",
                table: "Harvestings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LandDetails_StateId",
                table: "LandDetails",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_LandDetails_UserId",
                table: "LandDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartitionLandDetails_LandDetailId",
                table: "PartitionLandDetails",
                column: "LandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PartitionLandDetails_UserId",
                table: "PartitionLandDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PestControls_PartitionLandDetailId",
                table: "PestControls",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PestControls_UserId",
                table: "PestControls",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Plowings_PartitionLandDetailId",
                table: "Plowings",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Plowings_UserId",
                table: "Plowings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePageAccesses_PagesID",
                table: "RolePageAccesses",
                column: "PagesID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePageAccesses_RolesID",
                table: "RolePageAccesses",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PartitionLandDetailId",
                table: "Sales",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UserId",
                table: "Sales",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Seedings_PartitionLandDetailId",
                table: "Seedings",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Seedings_UserId",
                table: "Seedings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_UserID",
                table: "UserActivity",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_WeedRemove_PartitionLandDetailId",
                table: "WeedRemove",
                column: "PartitionLandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_WeedRemove_UserId",
                table: "WeedRemove",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Harvestings");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "PestControls");

            migrationBuilder.DropTable(
                name: "Plowings");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "RolePageAccesses");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Seedings");

            migrationBuilder.DropTable(
                name: "UserActivity");

            migrationBuilder.DropTable(
                name: "WeedRemove");

            migrationBuilder.DropTable(
                name: "WebPages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "PartitionLandDetails");

            migrationBuilder.DropTable(
                name: "LandDetails");

            migrationBuilder.DropTable(
                name: "StateLists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
