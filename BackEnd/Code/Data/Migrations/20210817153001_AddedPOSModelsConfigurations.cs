using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedPOSModelsConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("96b0fd6b-2c43-4ba2-8b8c-c64f7fabfa26"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "CustomerAddress", "CustomerEmail", "CustomerPhone", "FullName", "IsDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2eb"), null, new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(5437), "205 Sorya Street,Roushdy", "hassanmohammed67@hotmail.com", "+201256262161", "Hassan Mohammed Ahmed", false, new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(5465), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") },
                    { new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2ea"), null, new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6504), "205 Sorya Street,Roushdy", "hassanmohammed67@hotmail.com", "+201256262161", "Hassan Mohammed Ahmed", false, new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6519), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") },
                    { new Guid("1e22e307-a365-4e17-9f1b-1120a2da601f"), null, new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6571), "208 Sorya Street,Roushdy", "khalihassan_77@hotmail.com", "+201257262161", "Khalid Hassan Ahmed", false, new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6574), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") },
                    { new Guid("098b6065-11ea-4a8e-961c-247f846329b6"), null, new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6589), "203 Horeya Street,Sidi gaber", "gehanmohammed98@gmail.com", "+201256263361", "Gehan Mohamed Khalil", false, new DateTime(2021, 8, 17, 17, 30, 0, 626, DateTimeKind.Local).AddTicks(6591), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"),
                columns: new[] { "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy" },
                values: new object[] { new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6930), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6945), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                columns: new[] { "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy" },
                values: new object[] { new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 623, DateTimeKind.Local).AddTicks(5573), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(4407), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253") });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "IsDeleted", "ModificationDate", "ModifiedBy", "SupplierEmail", "SupplierName", "SupplierPhone" },
                values: new object[,]
                {
                    { new Guid("34b3885b-bf26-43b4-a214-b54b7f682796"), null, new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6984), false, new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6985), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), "ammar_mohamed@hotmail.com", "Ammar Mohamed Ahmed", "+01445676898" },
                    { new Guid("34b3995b-bf26-43b4-a214-b54b7f682786"), null, new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6993), false, new DateTime(2021, 8, 17, 17, 30, 0, 624, DateTimeKind.Local).AddTicks(6994), new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), "galal_sayed@hotmail.com", "Galal Sayed Ahmed", "+01245676878" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("098b6065-11ea-4a8e-961c-247f846329b6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("1e22e307-a365-4e17-9f1b-1120a2da601f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2ea"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("31a2cb54-a26e-460d-a92c-d7645bc6d2eb"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3885b-bf26-43b4-a214-b54b7f682796"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("34b3995b-bf26-43b4-a214-b54b7f682786"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "CustomerAddress", "CustomerEmail", "CustomerPhone", "FullName", "IsDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[] { new Guid("96b0fd6b-2c43-4ba2-8b8c-c64f7fabfa26"), null, null, new DateTime(2021, 8, 16, 20, 1, 44, 526, DateTimeKind.Local).AddTicks(8303), "201 Abdel Salam Aref Street, Louran", "mohammedhassan97@gmail.com", "+20112272171", "Mohammed Hassan Ismail", false, new DateTime(2021, 8, 16, 20, 1, 44, 527, DateTimeKind.Local).AddTicks(9368), null });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("33b3885b-bf26-43b4-a214-b54b7f682696"),
                columns: new[] { "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: new Guid("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                columns: new[] { "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy" },
                values: new object[] { null, null, null, null });
        }
    }
}
