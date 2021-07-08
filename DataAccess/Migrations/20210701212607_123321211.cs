using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _123321211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "TotalOrder",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TotalOrder_IdUser",
                table: "TotalOrder",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_TotalOrder_AspNetUsers_IdUser",
                table: "TotalOrder",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TotalOrder_AspNetUsers_IdUser",
                table: "TotalOrder");

            migrationBuilder.DropIndex(
                name: "IX_TotalOrder_IdUser",
                table: "TotalOrder");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "TotalOrder");
        }
    }
}
