using Microsoft.EntityFrameworkCore.Migrations;

namespace MCarRental.Data.Migrations
{
    public partial class removedMark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mark",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mark",
                table: "Cars",
                nullable: true);
        }
    }
}