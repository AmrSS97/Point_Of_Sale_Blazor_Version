using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ModifiedProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Bills_BillID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Products_ProductID",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ProductImageName",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ProductID",
                table: "Items",
                newName: "IX_Items_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Item_BillID",
                table: "Items",
                newName: "IX_Items_BillID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bills_BillID",
                table: "Items",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bills_BillID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_ProductID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ProductID",
                table: "Item",
                newName: "IX_Item_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Items_BillID",
                table: "Item",
                newName: "IX_Item_BillID");

            migrationBuilder.AddColumn<string>(
                name: "ProductImageName",
                table: "Products",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Bills_BillID",
                table: "Item",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Products_ProductID",
                table: "Item",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
