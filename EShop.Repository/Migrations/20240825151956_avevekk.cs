using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Repository.Migrations
{
    /// <inheritdoc />
    public partial class avevekk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Concert_ConcertId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Concert");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "ConcertId",
                table: "Tickets",
                newName: "SportEventId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ConcertId",
                table: "Tickets",
                newName: "IX_Tickets_SportEventId");

            migrationBuilder.CreateTable(
                name: "SportsEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Team1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TeamId2 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Team2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SportEventsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SportsEventsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchSchedules_SportsEvents_SportsEventsId",
                        column: x => x.SportsEventsId,
                        principalTable: "SportsEvents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatchSchedules_Team_Team1Id",
                        column: x => x.Team1Id,
                        principalTable: "Team",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatchSchedules_Team_Team2Id",
                        column: x => x.Team2Id,
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    years = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayerOnTeam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerOnTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerOnTeam_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerOnTeam_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchSchedules_SportsEventsId",
                table: "MatchSchedules",
                column: "SportsEventsId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchSchedules_Team1Id",
                table: "MatchSchedules",
                column: "Team1Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchSchedules_Team2Id",
                table: "MatchSchedules",
                column: "Team2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerOnTeam_PlayerId",
                table: "PlayerOnTeam",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerOnTeam_TeamId",
                table: "PlayerOnTeam",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_SportsEvents_SportEventId",
                table: "Tickets",
                column: "SportEventId",
                principalTable: "SportsEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_SportsEvents_SportEventId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "MatchSchedules");

            migrationBuilder.DropTable(
                name: "PlayerOnTeam");

            migrationBuilder.DropTable(
                name: "SportsEvents");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.RenameColumn(
                name: "SportEventId",
                table: "Tickets",
                newName: "ConcertId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_SportEventId",
                table: "Tickets",
                newName: "IX_Tickets_ConcertId");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Tickets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Concert",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcertDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concert", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Concert_ConcertId",
                table: "Tickets",
                column: "ConcertId",
                principalTable: "Concert",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
