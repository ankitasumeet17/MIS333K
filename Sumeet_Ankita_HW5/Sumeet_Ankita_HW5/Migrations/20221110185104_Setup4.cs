using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sumeet_Ankita_HW5.Migrations
{
    public partial class Setup4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExtendedPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtendedPrice",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ProductPrice",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}
