using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sumeet_Ankita_HW5.Migrations
{
    public partial class Setup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsID",
                table: "Orders",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDetailsID",
                table: "Orders");
        }
    }
}
