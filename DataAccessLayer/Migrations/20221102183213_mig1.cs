using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    blog_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blog_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blog_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blog_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blog_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blog_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.blog_ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    teammate_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teammate_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teammate_Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teammate_Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teammate_Salary = table.Column<int>(type: "int", nullable: false),
                    teammate_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teammate_Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.teammate_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
