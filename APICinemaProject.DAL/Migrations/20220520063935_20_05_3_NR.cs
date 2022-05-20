using Microsoft.EntityFrameworkCore.Migrations;

namespace APICinemaProject.DAL.Migrations
{
    public partial class _20_05_3_NR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Orders_OrderID1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderID1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderID1",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderID1",
                table: "Orders",
                column: "OrderID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Orders_OrderID1",
                table: "Orders",
                column: "OrderID1",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
