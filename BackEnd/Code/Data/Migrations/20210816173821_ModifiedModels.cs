using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ModifiedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhone",
                table: "Customers",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerEmail",
                table: "Customers",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "Customers",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "CustomerAddress", "CustomerEmail", "CustomerPhone", "FullName", "IsDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[] { new Guid("96b0fd6b-2c43-4ba2-8b8c-c64f7fabfa26"), null, null, null, "201 Abdel Salam Aref Street, Louran", "mohammedhassan97@gmail.com", "+20112272171", "Mohammed Hassan Ismail", null, null, null });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "IsDeleted", "ModificationDate", "ModifiedBy", "SupplierEmail", "SupplierName", "SupplierPhone" },
                values: new object[] { new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"), null, null, null, false, null, null, "alimohamed96@gmail.com", "Ali Mohammed Ahmed", "+201220073453" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "IsDeleted", "ModificationDate", "ModifiedBy", "SupplierEmail", "SupplierName", "SupplierPhone" },
                values: new object[] { new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"), null, null, null, false, null, null, "hassankhalil97@gmail.com", "Hassan Khalil Hemdan", "+201113272171" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("96b0fd6b-2c43-4ba2-8b8c-c64f7fabfa26"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhone",
                table: "Customers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerEmail",
                table: "Customers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "Customers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }
    }
}
