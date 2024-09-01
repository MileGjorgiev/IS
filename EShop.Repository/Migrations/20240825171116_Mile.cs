using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Mile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchSchedules_Team_Team1Id",
                table: "MatchSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchSchedules_Team_Team2Id",
                table: "MatchSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerOnTeam_Player_PlayerId",
                table: "PlayerOnTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerOnTeam_Team_TeamId",
                table: "PlayerOnTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerOnTeam",
                table: "PlayerOnTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "PlayerOnTeam",
                newName: "PlayerOnTeams");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "Players");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerOnTeam_TeamId",
                table: "PlayerOnTeams",
                newName: "IX_PlayerOnTeams_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerOnTeam_PlayerId",
                table: "PlayerOnTeams",
                newName: "IX_PlayerOnTeams_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_TeamId",
                table: "Players",
                newName: "IX_Players_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerOnTeams",
                table: "PlayerOnTeams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchSchedules_Teams_Team1Id",
                table: "MatchSchedules",
                column: "Team1Id",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchSchedules_Teams_Team2Id",
                table: "MatchSchedules",
                column: "Team2Id",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerOnTeams_Players_PlayerId",
                table: "PlayerOnTeams",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerOnTeams_Teams_TeamId",
                table: "PlayerOnTeams",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchSchedules_Teams_Team1Id",
                table: "MatchSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchSchedules_Teams_Team2Id",
                table: "MatchSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerOnTeams_Players_PlayerId",
                table: "PlayerOnTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerOnTeams_Teams_TeamId",
                table: "PlayerOnTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerOnTeams",
                table: "PlayerOnTeams");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Player");

            migrationBuilder.RenameTable(
                name: "PlayerOnTeams",
                newName: "PlayerOnTeam");

            migrationBuilder.RenameIndex(
                name: "IX_Players_TeamId",
                table: "Player",
                newName: "IX_Player_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerOnTeams_TeamId",
                table: "PlayerOnTeam",
                newName: "IX_PlayerOnTeam_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerOnTeams_PlayerId",
                table: "PlayerOnTeam",
                newName: "IX_PlayerOnTeam_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerOnTeam",
                table: "PlayerOnTeam",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchSchedules_Team_Team1Id",
                table: "MatchSchedules",
                column: "Team1Id",
                principalTable: "Team",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchSchedules_Team_Team2Id",
                table: "MatchSchedules",
                column: "Team2Id",
                principalTable: "Team",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerOnTeam_Player_PlayerId",
                table: "PlayerOnTeam",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerOnTeam_Team_TeamId",
                table: "PlayerOnTeam",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
