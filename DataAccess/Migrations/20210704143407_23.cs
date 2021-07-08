using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_IdUser",
                table: "Comment",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_IdUser",
                table: "Comment",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_IdUser",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_IdUser",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Comment");
        }
    }
}
