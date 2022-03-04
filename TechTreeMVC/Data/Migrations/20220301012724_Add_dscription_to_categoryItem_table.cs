using Microsoft.EntityFrameworkCore.Migrations;

namespace TechTreeMVC.Data.Migrations
{
    public partial class Add_dscription_to_categoryItem_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CategoryItem",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CategoryItem");
        }
    }
}
