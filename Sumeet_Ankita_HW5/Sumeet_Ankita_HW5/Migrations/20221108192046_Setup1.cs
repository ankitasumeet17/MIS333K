using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sumeet_Ankita_HW5.Migrations
{
    public partial class Setup1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    ProductPrice = table.Column<int>(type: "int", nullable: true),
                    OrderID1 = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Orders_OrderID1",
                        column: x => x.OrderID1,
                        principalTable: "Orders",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "ProductSupplier",
                columns: table => new
                {
                    ProductsProductID = table.Column<int>(type: "int", nullable: false),
                    SuppliersSupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSupplier", x => new { x.ProductsProductID, x.SuppliersSupplierID });
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Products_ProductsProductID",
                        column: x => x.ProductsProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSupplier_Suppliers_SuppliersSupplierID",
                        column: x => x.SuppliersSupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderID1",
                table: "Orders",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductID",
                table: "Orders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSupplier_SuppliersSupplierID",
                table: "ProductSupplier",
                column: "SuppliersSupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductSupplier");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductPrice",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: true);
        }
    }
}
