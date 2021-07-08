using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _123323 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalOrderId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TotalOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrder = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalOrder", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_TotalOrderId",
                table: "Order",
                column: "TotalOrderId");

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

            migrationBuilder.DropTable(
                name: "TotalOrder");

            migrationBuilder.DropIndex(
                name: "IX_Order_TotalOrderId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "TotalOrderId",
                table: "Order");
        }
    }
}
