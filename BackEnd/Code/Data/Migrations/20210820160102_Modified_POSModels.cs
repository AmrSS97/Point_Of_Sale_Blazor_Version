using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Modified_POSModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("59be586f-3d0f-49de-82c5-a407752c5f43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("7715f4f8-f8e6-41ca-98ab-e4f3a602a3ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("877accec-b867-436a-9c2e-3f315b0ca780"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("b100e997-ceb9-493c-b0e8-74c9475b07ed"));

            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "PurchaseOrders",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<double>(
                name: "TotalValue",
                table: "Bills",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("46810525-690d-4629-8f34-4c3001f1c39d"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 297, DateTimeKind.Local).AddTicks(9430), new DateTime(2021, 8, 20, 18, 1, 1, 297, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1562), new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1201), new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1532), new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("098b6065-11ea-4a8e-961c-247f846329b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(1566), new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("1e22e307-a365-4e17-9f1b-1120a2da601f"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(1547), new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2ea"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(1521), new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2eb"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(849), new DateTime(2021, 8, 20, 18, 1, 1, 296, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "AssociatedCompanyID", "CategoryID", "CreatedBy", "CreationDate", "DiscountPercentage", "IsDeleted", "ModificationDate", "ModifiedBy", "Price", "ProductDetails", "ProductImagePath", "ProductName", "Stock", "SupplierID" },
                values: new object[,]
                {
                    { new Guid("7d4edeb4-6125-4e55-b048-54d36e494c2b"), null, new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(408), 10, false, new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(443), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 50.0, "about 20pcs/kg", "C://Users//AmrSherief//Desktop//PointOfSale", "beef sausage", 100, new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf") },
                    { new Guid("5fe0698c-0b07-444d-9927-0604438280b8"), null, new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(7818), 5, false, new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(7839), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 20.0, "about 4pcs/kg", "C://Users//AmrSherief//Desktop//PointOfSale", "old romano cheese", 150, new Guid("33b3885b-bf26-43b4-a214-b54b7f682696") },
                    { new Guid("1e912fee-ddae-496d-a1c1-35e71491ab66"), null, new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(8007), 3, false, new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(8013), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 15.0, "soap with flower scent", "C://Users//AmrSherief//Desktop//PointOfSale", "dove soap", 50, new Guid("34b3995b-bf26-43b4-a214-b54b7f682786") },
                    { new Guid("bde7c71c-770c-4549-83e3-0df753954a74"), null, new Guid("46810525-690d-4629-8f34-4c3001f1c39d"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(8064), 2, false, new DateTime(2021, 8, 20, 18, 1, 1, 302, DateTimeKind.Local).AddTicks(8067), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 10.0, "coca cola can 200ml", "C://Users//AmrSherief//Desktop//PointOfSale", "coca cola", 200, new Guid("34b3885b-bf26-43b4-a214-b54b7f682796") }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 294, DateTimeKind.Local).AddTicks(1920), new DateTime(2021, 8, 20, 18, 1, 1, 294, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3885b-bf26-43b4-a214-b54b7f682796"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 294, DateTimeKind.Local).AddTicks(1970), new DateTime(2021, 8, 20, 18, 1, 1, 294, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3995b-bf26-43b4-a214-b54b7f682786"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 294, DateTimeKind.Local).AddTicks(1979), new DateTime(2021, 8, 20, 18, 1, 1, 294, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 20, 18, 1, 1, 293, DateTimeKind.Local).AddTicks(386), new DateTime(2021, 8, 20, 18, 1, 1, 293, DateTimeKind.Local).AddTicks(9458) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("1e912fee-ddae-496d-a1c1-35e71491ab66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("5fe0698c-0b07-444d-9927-0604438280b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("7d4edeb4-6125-4e55-b048-54d36e494c2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("bde7c71c-770c-4549-83e3-0df753954a74"));

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "PurchaseOrders",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalValue",
                table: "Bills",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("46810525-690d-4629-8f34-4c3001f1c39d"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(7650), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8608), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8553), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8591), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("098b6065-11ea-4a8e-961c-247f846329b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(1606), new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("1e22e307-a365-4e17-9f1b-1120a2da601f"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(1591), new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2ea"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(1556), new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2eb"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(655), new DateTime(2021, 8, 17, 17, 38, 44, 896, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "AssociatedCompanyID", "CategoryID", "CreatedBy", "CreationDate", "DiscountPercentage", "IsDeleted", "ModificationDate", "ModifiedBy", "Price", "ProductDetails", "ProductImagePath", "ProductName", "Stock", "SupplierID" },
                values: new object[,]
                {
                    { new Guid("59be586f-3d0f-49de-82c5-a407752c5f43"), null, new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 899, DateTimeKind.Local).AddTicks(8093), 10, false, new DateTime(2021, 8, 17, 17, 38, 44, 899, DateTimeKind.Local).AddTicks(8121), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 50m, "about 20pcs/kg", "C://Users//AmrSherief//Desktop//PointOfSale", "beef sausage", 100, new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf") },
                    { new Guid("7715f4f8-f8e6-41ca-98ab-e4f3a602a3ea"), null, new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(766), 5, false, new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(775), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 20m, "about 4pcs/kg", "C://Users//AmrSherief//Desktop//PointOfSale", "old romano cheese", 150, new Guid("33b3885b-bf26-43b4-a214-b54b7f682696") },
                    { new Guid("b100e997-ceb9-493c-b0e8-74c9475b07ed"), null, new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(838), 3, false, new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(839), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 15m, "soap with flower scent", "C://Users//AmrSherief//Desktop//PointOfSale", "dove soap", 50, new Guid("34b3995b-bf26-43b4-a214-b54b7f682786") },
                    { new Guid("877accec-b867-436a-9c2e-3f315b0ca780"), null, new Guid("46810525-690d-4629-8f34-4c3001f1c39d"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(851), 2, false, new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(854), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 10m, "coca cola can 200ml", "C://Users//AmrSherief//Desktop//PointOfSale", "coca cola", 200, new Guid("34b3885b-bf26-43b4-a214-b54b7f682796") }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 893, DateTimeKind.Local).AddTicks(2026), new DateTime(2021, 8, 17, 17, 38, 44, 893, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3885b-bf26-43b4-a214-b54b7f682796"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 893, DateTimeKind.Local).AddTicks(2119), new DateTime(2021, 8, 17, 17, 38, 44, 893, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3995b-bf26-43b4-a214-b54b7f682786"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 893, DateTimeKind.Local).AddTicks(2139), new DateTime(2021, 8, 17, 17, 38, 44, 893, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 38, 44, 891, DateTimeKind.Local).AddTicks(7585), new DateTime(2021, 8, 17, 17, 38, 44, 892, DateTimeKind.Local).AddTicks(8822) });
        }
    }
}
