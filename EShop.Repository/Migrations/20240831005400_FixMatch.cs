using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Repository.Migrations
{
    /// <inheritdoc />
    public partial class FixMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchSchedules_Teams_Team1Id",
                table: "MatchSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchSchedules_Teams_Team2Id",
                table: "MatchSchedules");

            migrationBuilder.AlterColumn<Guid>(
                name: "Team2Id",
                table: "MatchSchedules",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Team1Id",
                table: "MatchSchedules",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "Team2Id",
                table: "MatchSchedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Team1Id",
                table: "MatchSchedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchSchedules_Teams_Team1Id",
                table: "MatchSchedules",
                column: "Team1Id",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchSchedules_Teams_Team2Id",
                table: "MatchSchedules",
                column: "Team2Id",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
