using Microsoft.EntityFrameworkCore.Migrations;

namespace P119FrontToBack.Migrations
{
    public partial class AddMyPropertyToSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Sliders");
        }
    }
}
