using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class _20_05_1_NR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderID1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.InstructorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seats_HallID",
                table: "Seats",
                column: "HallID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MovieID",
                table: "Orders",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderID1",
                table: "Orders",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_InstructorID",
                table: "Movies",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Instructor_InstructorID",
                table: "Movies",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "InstructorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Movies_MovieID",
                table: "Orders",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Orders_OrderID1",
                table: "Orders",
                column: "OrderID1",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Halls_HallID",
                table: "Seats",
                column: "HallID",
                principalTable: "Halls",
                principalColumn: "HallID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Instructor_InstructorID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Movies_MovieID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Orders_OrderID1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Halls_HallID",
                table: "Seats");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Seats_HallID",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MovieID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderID1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Movies_InstructorID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "OrderID1",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
