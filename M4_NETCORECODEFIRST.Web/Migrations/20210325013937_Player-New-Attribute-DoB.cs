﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace M4_NETCORECODEFIRST.Web.Migrations
{
    public partial class PlayerNewAttributeDoB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                table: "Player",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoB",
                table: "Player");
        }
    }
}
