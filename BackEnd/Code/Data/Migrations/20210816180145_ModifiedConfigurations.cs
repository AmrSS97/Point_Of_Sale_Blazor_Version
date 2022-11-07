using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ModifiedConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("96b0fd6b-2c43-4ba2-8b8c-c64f7fabfa26"),
                columns: new[] { "CreationDate", "IsDeleted", "ModificationDate" },
                values: new object[] { new DateTime(2021, 8, 16, 20, 1, 44, 526, DateTimeKind.Local).AddTicks(8303), false, new DateTime(2021, 8, 16, 20, 1, 44, 527, DateTimeKind.Local).AddTicks(9368) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("96b0fd6b-2c43-4ba2-8b8c-c64f7fabfa26"),
                columns: new[] { "CreationDate", "IsDeleted", "ModificationDate" },
                values: new object[] { null, null, null });
        }
    }
}
