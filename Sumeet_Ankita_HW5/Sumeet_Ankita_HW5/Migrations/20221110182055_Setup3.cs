using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sumeet_Ankita_HW5.Migrations
{
    public partial class Setup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDetailsID",
                table: "Orders",
                newName: "OrderDetailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDetailID",
                table: "Orders",
                newName: "OrderDetailsID");
        }
    }
}
