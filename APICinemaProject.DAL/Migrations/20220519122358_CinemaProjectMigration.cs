using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class CinemaProjectMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieMovieGenre",
                columns: table => new
                {
                    MovieGenresGenreID = table.Column<int>(type: "int", nullable: false),
                    MoviesMovieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieMovieGenre", x => new { x.MovieGenresGenreID, x.MoviesMovieID });
                    table.ForeignKey(
                        name: "FK_MovieMovieGenre_movieGenres_MovieGenresGenreID",
                        column: x => x.MovieGenresGenreID,
                        principalTable: "movieGenres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieMovieGenre_movies_MoviesMovieID",
                        column: x => x.MoviesMovieID,
                        principalTable: "movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieGenre_MoviesMovieID",
                table: "MovieMovieGenre",
                column: "MoviesMovieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieMovieGenre");
        }
    }
}
