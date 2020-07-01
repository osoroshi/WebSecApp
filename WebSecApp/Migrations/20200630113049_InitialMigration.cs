using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSecApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProdCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "SecSer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prodcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    technology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projecttype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projduration = table.Column<int>(type: "int", nullable: false),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    finishdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecSer", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "SecSer",
                columns: new[] { "id", "finishdate", "prodcode", "projduration", "projecttype", "servName", "startdate", "technology" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CTXSF1", 10, "Fixed", "WAF Design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citrix" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CTXSF2", 20, "Fixed", "WAF Build ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citrix" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CTXST3", 5, "T&M", "WAF Testing ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citrix" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CTXST4", 15, "T&M", "WAF Prod Deploy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citrix" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZSF1", 20, "Fixed", "Azure Firewall ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZSF2", 25, "Fixed", "Azure Sentinel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZSF3", 30, "Fixed", "Azure Security Centre", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZST4", 15, "T&M", "Citrix ADC WAF on Azure ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AZST4", 15, "T&M", "Azure Endpoint Protection", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CTXSF5", 15, "Citrix", "Citrix ADC Adnvanced WAF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SecSer");
        }
    }
}
