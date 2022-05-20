using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class _20_05_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LoyaltyPrograms_CustomerID",
                table: "LoyaltyPrograms",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_LoyaltyPrograms_OrderID",
                table: "LoyaltyPrograms",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_LoyaltyPrograms_Customers_CustomerID",
                table: "LoyaltyPrograms",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoyaltyPrograms_Orders_OrderID",
                table: "LoyaltyPrograms",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoyaltyPrograms_Customers_CustomerID",
                table: "LoyaltyPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_LoyaltyPrograms_Orders_OrderID",
                table: "LoyaltyPrograms");

            migrationBuilder.DropIndex(
                name: "IX_LoyaltyPrograms_CustomerID",
                table: "LoyaltyPrograms");

            migrationBuilder.DropIndex(
                name: "IX_LoyaltyPrograms_OrderID",
                table: "LoyaltyPrograms");
        }
    }
}
