using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ModifiedSaleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Bills_SaleID",
                table: "Sales");

            migrationBuilder.AddColumn<Guid>(
                name: "BillID",
                table: "Sales",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BillID",
                table: "Sales",
                column: "BillID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Bills_BillID",
                table: "Sales",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Bills_BillID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_BillID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "BillID",
                table: "Sales");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Bills_SaleID",
                table: "Sales",
                column: "SaleID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
