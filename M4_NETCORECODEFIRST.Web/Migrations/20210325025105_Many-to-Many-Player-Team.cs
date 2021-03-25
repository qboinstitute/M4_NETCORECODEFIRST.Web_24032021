﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace M4_NETCORECODEFIRST.Web.Migrations
{
    public partial class ManytoManyPlayerTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_SoccerPosition_SoccerPositionId",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "SoccerPositionId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerTeam",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTeam", x => new { x.PlayerId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_PlayerTeam_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTeam_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTeam_TeamId",
                table: "PlayerTeam",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_SoccerPosition_SoccerPositionId",
                table: "Player",
                column: "SoccerPositionId",
                principalTable: "SoccerPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_SoccerPosition_SoccerPositionId",
                table: "Player");

            migrationBuilder.DropTable(
                name: "PlayerTeam");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.AlterColumn<int>(
                name: "SoccerPositionId",
                table: "Player",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_SoccerPosition_SoccerPositionId",
                table: "Player",
                column: "SoccerPositionId",
                principalTable: "SoccerPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
