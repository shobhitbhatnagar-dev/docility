using Microsoft.EntityFrameworkCore.Migrations;

namespace Docility.API.Migrations
{
    public partial class addtypeintegervalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Values",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Values");
        }
    }
}
