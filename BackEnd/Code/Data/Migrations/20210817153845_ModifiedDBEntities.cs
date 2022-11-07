using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ModifiedDBEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "AssociatedCompanyID", "CategoryImagePath", "CategoryName", "CreatedBy", "CreationDate", "IsDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("46810525-690d-4629-8f34-4c3001f1c39d"), null, "C://Users//AmrSherief//PointOfSale", "Beverages", new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(7650), false, new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(7683), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") },
                    { new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"), null, "C://Users//AmrSherief//PointOfSale", "Dairy", new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8553), false, new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8561), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") },
                    { new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"), null, "C://Users//AmrSherief//PointOfSale", "Meat", new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8591), false, new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8594), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") },
                    { new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"), null, "C://Users//AmrSherief//PointOfSale", "Personal Care", new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8608), false, new DateTime(2021, 8, 17, 17, 38, 44, 897, DateTimeKind.Local).AddTicks(8610), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") }
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "AssociatedCompanyID", "CategoryID", "CreatedBy", "CreationDate", "DiscountPercentage", "IsDeleted", "ModificationDate", "ModifiedBy", "Price", "ProductDetails", "ProductImagePath", "ProductName", "Stock", "SupplierID" },
                values: new object[,]
                {
                    { new Guid("877accec-b867-436a-9c2e-3f315b0ca780"), null, new Guid("46810525-690d-4629-8f34-4c3001f1c39d"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(851), 2, false, new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(854), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 10m, "coca cola can 200ml", "C://Users//AmrSherief//Desktop//PointOfSale", "coca cola", 200, new Guid("34b3885b-bf26-43b4-a214-b54b7f682796") },
                    { new Guid("7715f4f8-f8e6-41ca-98ab-e4f3a602a3ea"), null, new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(766), 5, false, new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(775), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 20m, "about 4pcs/kg", "C://Users//AmrSherief//Desktop//PointOfSale", "old romano cheese", 150, new Guid("33b3885b-bf26-43b4-a214-b54b7f682696") },
                    { new Guid("59be586f-3d0f-49de-82c5-a407752c5f43"), null, new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 899, DateTimeKind.Local).AddTicks(8093), 10, false, new DateTime(2021, 8, 17, 17, 38, 44, 899, DateTimeKind.Local).AddTicks(8121), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 50m, "about 20pcs/kg", "C://Users//AmrSherief//Desktop//PointOfSale", "beef sausage", 100, new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf") },
                    { new Guid("b100e997-ceb9-493c-b0e8-74c9475b07ed"), null, new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(838), 3, false, new DateTime(2021, 8, 17, 17, 38, 44, 900, DateTimeKind.Local).AddTicks(839), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 15m, "soap with flower scent", "C://Users//AmrSherief//Desktop//PointOfSale", "dove soap", 50, new Guid("34b3995b-bf26-43b4-a214-b54b7f682786") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("46810525-690d-4629-8f34-4c3001f1c39d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("098b6065-11ea-4a8e-961c-247f846329b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6589), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("1e22e307-a365-4e17-9f1b-1120a2da601f"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6571), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2ea"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6504), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2eb"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(5437), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6930), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3885b-bf26-43b4-a214-b54b7f682796"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6984), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3995b-bf26-43b4-a214-b54b7f682786"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6993), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 17, 17, 30, 0, 623, DateTimeKind.Local).AddTicks(5573), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(4407) });
        }
    }
}
