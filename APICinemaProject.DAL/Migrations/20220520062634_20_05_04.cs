using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class _20_05_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Halls_MovieID",
                table: "Halls",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Movies_MovieID",
                table: "Halls",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Movies_MovieID",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_MovieID",
                table: "Halls");
        }
    }
}
