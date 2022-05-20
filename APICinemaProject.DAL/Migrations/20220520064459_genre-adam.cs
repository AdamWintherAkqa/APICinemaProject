using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class genreadam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreID",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "MovieMovieGenre");

            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false),
                    MoviesMovieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenreID, x.MoviesMovieID });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesMovieID",
                        column: x => x.MoviesMovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesMovieID",
                table: "GenreMovie",
                column: "MoviesMovieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => x.GenreID);
                });

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
                        name: "FK_MovieMovieGenre_MovieGenres_MovieGenresGenreID",
                        column: x => x.MovieGenresGenreID,
                        principalTable: "MovieGenres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieMovieGenre_Movies_MoviesMovieID",
                        column: x => x.MoviesMovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreID",
                table: "Movies",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieGenre_MoviesMovieID",
                table: "MovieMovieGenre",
                column: "MoviesMovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreID",
                table: "Movies",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
