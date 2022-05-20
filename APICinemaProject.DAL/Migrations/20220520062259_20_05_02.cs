using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class _20_05_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Actors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
