using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class MM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candyShops",
                columns: table => new
                {
                    CandyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandyPrice = table.Column<int>(type: "int", nullable: false),
                    CandyType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candyShops", x => x.CandyID);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerIsVIP = table.Column<bool>(type: "bit", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerGender = table.Column<bool>(type: "bit", nullable: false),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "halls",
                columns: table => new
                {
                    HallID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    AmountOfSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_halls", x => x.HallID);
                });

            migrationBuilder.CreateTable(
                name: "loyaltyPrograms",
                columns: table => new
                {
                    LoyaltyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loyaltyPrograms", x => x.LoyaltyID);
                });

            migrationBuilder.CreateTable(
                name: "merchandises",
                columns: table => new
                {
                    MerchandiseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchandiseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandiseColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchandisePrice = table.Column<int>(type: "int", nullable: false),
                    MerchandiseSize = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_merchandises", x => x.MerchandiseID);
                });

            migrationBuilder.CreateTable(
                name: "movieGenres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieGenres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    AgeCheck = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    SeatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HallID = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    SeatRowLetter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.SeatID);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoviePlayTime = table.Column<int>(type: "int", nullable: false),
                    MovieAgeLimit = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_movies_genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CandyShopOrder",
                columns: table => new
                {
                    CandyShopsCandyID = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandyShopOrder", x => new { x.CandyShopsCandyID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_CandyShopOrder_candyShops_CandyShopsCandyID",
                        column: x => x.CandyShopsCandyID,
                        principalTable: "candyShops",
                        principalColumn: "CandyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandyShopOrder_orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSeat",
                columns: table => new
                {
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false),
                    SeatsSeatID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSeat", x => new { x.OrdersOrderID, x.SeatsSeatID });
                    table.ForeignKey(
                        name: "FK_OrderSeat_orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSeat_seats_SeatsSeatID",
                        column: x => x.SeatsSeatID,
                        principalTable: "seats",
                        principalColumn: "SeatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandyShopOrder_OrdersOrderID",
                table: "CandyShopOrder",
                column: "OrdersOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_movies_GenreID",
                table: "movies",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSeat_SeatsSeatID",
                table: "OrderSeat",
                column: "SeatsSeatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandyShopOrder");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "halls");

            migrationBuilder.DropTable(
                name: "loyaltyPrograms");

            migrationBuilder.DropTable(
                name: "merchandises");

            migrationBuilder.DropTable(
                name: "movieGenres");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "OrderSeat");

            migrationBuilder.DropTable(
                name: "candyShops");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "seats");
        }
    }
}
