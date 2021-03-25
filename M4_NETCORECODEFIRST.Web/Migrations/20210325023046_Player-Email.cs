using Microsoft.EntityFrameworkCore.Migrations;

namespace M4_NETCORECODEFIRST.Web.Migrations
{
    public partial class PlayerEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailPlayer",
                table: "Player",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailPlayer",
                table: "Player");
        }
    }
}
