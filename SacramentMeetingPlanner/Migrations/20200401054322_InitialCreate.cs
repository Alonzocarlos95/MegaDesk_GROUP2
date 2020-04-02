using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Presiding = table.Column<string>(nullable: true),
                    Leading = table.Column<string>(nullable: true),
                    Pianist = table.Column<string>(nullable: true),
                    MusicDirector = table.Column<string>(nullable: true),
                    StakeAuthority = table.Column<string>(nullable: true),
                    EssentialAnnouncements = table.Column<string>(nullable: true),
                    FirstHymn = table.Column<string>(nullable: true),
                    FirstPrayer = table.Column<string>(nullable: true),
                    WardAnnouncements = table.Column<string>(nullable: true),
                    SacramentHymn = table.Column<string>(nullable: true),
                    FirstMessagePerson = table.Column<string>(nullable: true),
                    SecondMessagePerson = table.Column<string>(nullable: true),
                    ThirdMessagePerson = table.Column<string>(nullable: true),
                    LastHymn = table.Column<string>(nullable: true),
                    LastPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
