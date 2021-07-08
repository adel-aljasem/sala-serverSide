using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class weqra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_TotalOrder_IdOrder",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IdOrder",
                table: "TotalOrder");

            migrationBuilder.RenameColumn(
                name: "IdOrder",
                table: "Order",
                newName: "TotalOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_IdOrder",
                table: "Order",
                newName: "IX_Order_TotalOrderId");

            migrationBuilder.AddColumn<int>(
                name: "IdTotalOrder",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_TotalOrder_TotalOrderId",
                table: "Order",
                column: "TotalOrderId",
                principalTable: "TotalOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_TotalOrder_TotalOrderId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IdTotalOrder",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "TotalOrderId",
                table: "Order",
                newName: "IdOrder");

            migrationBuilder.RenameIndex(
                name: "IX_Order_TotalOrderId",
                table: "Order",
                newName: "IX_Order_IdOrder");

            migrationBuilder.AddColumn<int>(
                name: "IdOrder",
                table: "TotalOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_TotalOrder_IdOrder",
                table: "Order",
                column: "IdOrder",
                principalTable: "TotalOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
