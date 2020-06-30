using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppyest.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivitiesTable",
                columns: table => new
                {
                    ActivitiesId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityNumber = table.Column<long>(nullable: false),
                    ActivityTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    SelectTeam = table.Column<string>(nullable: false),
                    ActivityImage = table.Column<string>(nullable: true),
                    ActivityManagerImage = table.Column<string>(nullable: true),
                    Start = table.Column<string>(nullable: true),
                    End = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesTable", x => x.ActivitiesId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityTitleTable",
                columns: table => new
                {
                    ActivityId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTitleTable", x => x.ActivityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesTable");

            migrationBuilder.DropTable(
                name: "ActivityTitleTable");
        }
    }
}
