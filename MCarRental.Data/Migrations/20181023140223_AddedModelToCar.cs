using Microsoft.EntityFrameworkCore.Migrations;

namespace MCarRental.Data.Migrations
{
    public partial class AddedModelToCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");
        }
    }
}
