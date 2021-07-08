using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class weqr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTotalOrder",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "IdOrder",
                table: "TotalOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOrder",
                table: "TotalOrder");

            migrationBuilder.AddColumn<int>(
                name: "IdTotalOrder",
                table: "Order",
                type: "int",
                nullable: true);
        }
    }
}
