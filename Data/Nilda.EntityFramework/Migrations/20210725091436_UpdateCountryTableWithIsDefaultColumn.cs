using Microsoft.EntityFrameworkCore.Migrations;

namespace Nilda.EntityFrameworkCore.Migrations
{
    public partial class UpdateCountryTableWithIsDefaultColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDefault",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDefault",
                table: "Countries");
        }
    }
}
