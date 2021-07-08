using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _12332121 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdUser",
                table: "Order",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_IdUser",
                table: "Order",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_IdUser",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_IdUser",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Order");
        }
    }
}
