using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ModifiedModelsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ProductImagePath",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryImagePath",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("46810525-690d-4629-8f34-4c3001f1c39d"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(2414), new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(3130), new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(3097), new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(3121), new DateTime(2021, 8, 23, 8, 11, 45, 116, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("098b6065-11ea-4a8e-961c-247f846329b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(9696), new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("1e22e307-a365-4e17-9f1b-1120a2da601f"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(9677), new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2ea"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(9655), new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2eb"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(8928), new DateTime(2021, 8, 23, 8, 11, 45, 114, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "AssociatedCompanyID", "CategoryID", "CreatedBy", "CreationDate", "DiscountPercentage", "IsDeleted", "ModificationDate", "ModifiedBy", "Price", "ProductDetails", "ProductName", "Stock", "SupplierID" },
                values: new object[,]
                {
                    { new Guid("895a8a2b-2783-4c42-9248-9522cf798898"), null, new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(2334), 10, false, new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(2365), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 50.0, "about 20pcs/kg", "beef sausage", 100, new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf") },
                    { new Guid("f3dec3df-8898-4f78-a95c-f6875ebd55b2"), null, new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(5204), 5, false, new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(5213), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 20.0, "about 4pcs/kg", "old romano cheese", 150, new Guid("33b3885b-bf26-43b4-a214-b54b7f682696") },
                    { new Guid("1daaa0c4-18bd-4851-97a7-828a5774ac04"), null, new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(5316), 3, false, new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(5318), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 15.0, "soap with flower scent", "dove soap", 50, new Guid("34b3995b-bf26-43b4-a214-b54b7f682786") },
                    { new Guid("ee3855a9-ec30-4248-8648-10abc7178f6f"), null, new Guid("46810525-690d-4629-8f34-4c3001f1c39d"), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(5339), 2, false, new DateTime(2021, 8, 23, 8, 11, 45, 118, DateTimeKind.Local).AddTicks(5341), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), 10.0, "coca cola can 200ml", "coca cola", 200, new Guid("34b3885b-bf26-43b4-a214-b54b7f682796") }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 112, DateTimeKind.Local).AddTicks(4190), new DateTime(2021, 8, 23, 8, 11, 45, 112, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3885b-bf26-43b4-a214-b54b7f682796"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 112, DateTimeKind.Local).AddTicks(4303), new DateTime(2021, 8, 23, 8, 11, 45, 112, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3995b-bf26-43b4-a214-b54b7f682786"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 112, DateTimeKind.Local).AddTicks(4314), new DateTime(2021, 8, 23, 8, 11, 45, 112, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 23, 8, 11, 45, 110, DateTimeKind.Local).AddTicks(9908), new DateTime(2021, 8, 23, 8, 11, 45, 112, DateTimeKind.Local).AddTicks(1633) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("1daaa0c4-18bd-4851-97a7-828a5774ac04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("895a8a2b-2783-4c42-9248-9522cf798898"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("ee3855a9-ec30-4248-8648-10abc7178f6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("f3dec3df-8898-4f78-a95c-f6875ebd55b2"));

            migrationBuilder.AddColumn<string>(
                name: "ProductImagePath",
                table: "Products",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryImagePath",
                table: "Categories",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("46810525-690d-4629-8f34-4c3001f1c39d"),
                columns: new[] { "CategoryImagePath", "CreationDate", "ModificationDate" },
                values: new object[] { "C://Users//AmrSherief//PointOfSale", new DateTime(2021, 8, 20, 18, 1, 1, 297, DateTimeKind.Local).AddTicks(9430), new DateTime(2021, 8, 20, 18, 1, 1, 297, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("564a7f8c-f6c6-4e11-8420-c4e386fd9429"),
                columns: new[] { "CategoryImagePath", "CreationDate", "ModificationDate" },
                values: new object[] { "C://Users//AmrSherief//PointOfSale", new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1562), new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("c2ae1bde-9e68-403a-99ac-c1cd1d20f9b9"),
                columns: new[] { "CategoryImagePath", "CreationDate", "ModificationDate" },
                values: new object[] { "C://Users//AmrSherief//PointOfSale", new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1201), new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("e23b1970-fc07-458a-85a3-9ed6e63d4486"),
                columns: new[] { "CategoryImagePath", "CreationDate", "ModificationDate" },
                values: new object[] { "C://Users//AmrSherief//PointOfSale", new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1532), new DateTime(2021, 8, 20, 18, 1, 1, 298, DateTimeKind.Local).AddTicks(1538) });

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
    }
}
