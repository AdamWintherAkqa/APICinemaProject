using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class actor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_Actor_ActorsActorID",
                table: "ActorMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_movies_MoviesMovieID",
                table: "ActorMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_CandyShopOrder_candyShops_CandyShopsCandyID",
                table: "CandyShopOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_CandyShopOrder_orders_OrdersOrderID",
                table: "CandyShopOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieMovieGenre_movieGenres_MovieGenresGenreID",
                table: "MovieMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieMovieGenre_movies_MoviesMovieID",
                table: "MovieMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_GenreID",
                table: "movies");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderSeat_orders_OrdersOrderID",
                table: "OrderSeat");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderSeat_seats_SeatsSeatID",
                table: "OrderSeat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_seats",
                table: "seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movies",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movieGenres",
                table: "movieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_merchandises",
                table: "merchandises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_loyaltyPrograms",
                table: "loyaltyPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_halls",
                table: "halls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genres",
                table: "genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_candyShops",
                table: "candyShops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "seats",
                newName: "Seats");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "movies",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "movieGenres",
                newName: "MovieGenres");

            migrationBuilder.RenameTable(
                name: "merchandises",
                newName: "Merchandises");

            migrationBuilder.RenameTable(
                name: "loyaltyPrograms",
                newName: "LoyaltyPrograms");

            migrationBuilder.RenameTable(
                name: "halls",
                newName: "Halls");

            migrationBuilder.RenameTable(
                name: "genres",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "candyShops",
                newName: "CandyShops");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.RenameIndex(
                name: "IX_movies_GenreID",
                table: "Movies",
                newName: "IX_Movies_GenreID");

            migrationBuilder.RenameColumn(
                name: "CandyType",
                table: "CandyShops",
                newName: "CandyShopType");

            migrationBuilder.RenameColumn(
                name: "CandyPrice",
                table: "CandyShops",
                newName: "CandyShopPrice");

            migrationBuilder.RenameColumn(
                name: "CandyName",
                table: "CandyShops",
                newName: "CandyShopName");

            migrationBuilder.RenameColumn(
                name: "CandyID",
                table: "CandyShops",
                newName: "CandyShopID");

            migrationBuilder.RenameColumn(
                name: "CandyShopsCandyID",
                table: "CandyShopOrder",
                newName: "CandyShopsCandyShopID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seats",
                table: "Seats",
                column: "SeatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieGenres",
                table: "MovieGenres",
                column: "GenreID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchandises",
                table: "Merchandises",
                column: "MerchandiseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoyaltyPrograms",
                table: "LoyaltyPrograms",
                column: "LoyaltyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Halls",
                table: "Halls",
                column: "HallID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandyShops",
                table: "CandyShops",
                column: "CandyShopID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "ActorID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_Actors_ActorsActorID",
                table: "ActorMovie",
                column: "ActorsActorID",
                principalTable: "Actors",
                principalColumn: "ActorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_Movies_MoviesMovieID",
                table: "ActorMovie",
                column: "MoviesMovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandyShopOrder_CandyShops_CandyShopsCandyShopID",
                table: "CandyShopOrder",
                column: "CandyShopsCandyShopID",
                principalTable: "CandyShops",
                principalColumn: "CandyShopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandyShopOrder_Orders_OrdersOrderID",
                table: "CandyShopOrder",
                column: "OrdersOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieMovieGenre_MovieGenres_MovieGenresGenreID",
                table: "MovieMovieGenre",
                column: "MovieGenresGenreID",
                principalTable: "MovieGenres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieMovieGenre_Movies_MoviesMovieID",
                table: "MovieMovieGenre",
                column: "MoviesMovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreID",
                table: "Movies",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderSeat_Orders_OrdersOrderID",
                table: "OrderSeat",
                column: "OrdersOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderSeat_Seats_SeatsSeatID",
                table: "OrderSeat",
                column: "SeatsSeatID",
                principalTable: "Seats",
                principalColumn: "SeatID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_Actors_ActorsActorID",
                table: "ActorMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_Movies_MoviesMovieID",
                table: "ActorMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_CandyShopOrder_CandyShops_CandyShopsCandyShopID",
                table: "CandyShopOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_CandyShopOrder_Orders_OrdersOrderID",
                table: "CandyShopOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieMovieGenre_MovieGenres_MovieGenresGenreID",
                table: "MovieMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieMovieGenre_Movies_MoviesMovieID",
                table: "MovieMovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderSeat_Orders_OrdersOrderID",
                table: "OrderSeat");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderSeat_Seats_SeatsSeatID",
                table: "OrderSeat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seats",
                table: "Seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieGenres",
                table: "MovieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Merchandises",
                table: "Merchandises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoyaltyPrograms",
                table: "LoyaltyPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Halls",
                table: "Halls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandyShops",
                table: "CandyShops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Seats",
                newName: "seats");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "movies");

            migrationBuilder.RenameTable(
                name: "MovieGenres",
                newName: "movieGenres");

            migrationBuilder.RenameTable(
                name: "Merchandises",
                newName: "merchandises");

            migrationBuilder.RenameTable(
                name: "LoyaltyPrograms",
                newName: "loyaltyPrograms");

            migrationBuilder.RenameTable(
                name: "Halls",
                newName: "halls");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "genres");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameTable(
                name: "CandyShops",
                newName: "candyShops");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_GenreID",
                table: "movies",
                newName: "IX_movies_GenreID");

            migrationBuilder.RenameColumn(
                name: "CandyShopType",
                table: "candyShops",
                newName: "CandyType");

            migrationBuilder.RenameColumn(
                name: "CandyShopPrice",
                table: "candyShops",
                newName: "CandyPrice");

            migrationBuilder.RenameColumn(
                name: "CandyShopName",
                table: "candyShops",
                newName: "CandyName");

            migrationBuilder.RenameColumn(
                name: "CandyShopID",
                table: "candyShops",
                newName: "CandyID");

            migrationBuilder.RenameColumn(
                name: "CandyShopsCandyShopID",
                table: "CandyShopOrder",
                newName: "CandyShopsCandyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_seats",
                table: "seats",
                column: "SeatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                table: "movies",
                column: "MovieID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movieGenres",
                table: "movieGenres",
                column: "GenreID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_merchandises",
                table: "merchandises",
                column: "MerchandiseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_loyaltyPrograms",
                table: "loyaltyPrograms",
                column: "LoyaltyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_halls",
                table: "halls",
                column: "HallID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genres",
                table: "genres",
                column: "GenreID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_candyShops",
                table: "candyShops",
                column: "CandyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "ActorID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_Actor_ActorsActorID",
                table: "ActorMovie",
                column: "ActorsActorID",
                principalTable: "Actor",
                principalColumn: "ActorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_movies_MoviesMovieID",
                table: "ActorMovie",
                column: "MoviesMovieID",
                principalTable: "movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandyShopOrder_candyShops_CandyShopsCandyID",
                table: "CandyShopOrder",
                column: "CandyShopsCandyID",
                principalTable: "candyShops",
                principalColumn: "CandyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandyShopOrder_orders_OrdersOrderID",
                table: "CandyShopOrder",
                column: "OrdersOrderID",
                principalTable: "orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieMovieGenre_movieGenres_MovieGenresGenreID",
                table: "MovieMovieGenre",
                column: "MovieGenresGenreID",
                principalTable: "movieGenres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieMovieGenre_movies_MoviesMovieID",
                table: "MovieMovieGenre",
                column: "MoviesMovieID",
                principalTable: "movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_GenreID",
                table: "movies",
                column: "GenreID",
                principalTable: "genres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderSeat_orders_OrdersOrderID",
                table: "OrderSeat",
                column: "OrdersOrderID",
                principalTable: "orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderSeat_seats_SeatsSeatID",
                table: "OrderSeat",
                column: "SeatsSeatID",
                principalTable: "seats",
                principalColumn: "SeatID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
