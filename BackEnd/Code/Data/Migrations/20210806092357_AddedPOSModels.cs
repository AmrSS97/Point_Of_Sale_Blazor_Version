using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedPOSModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<int>(nullable: false),
                    CustomerAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    FeatureName = table.Column<string>(nullable: true),
                    FeatureNameAr = table.Column<string>(nullable: true),
                    MenuIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureID);
                });

            migrationBuilder.CreateTable(
                name: "NotificationActions",
                columns: table => new
                {
                    NotificationActionID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    TitleEn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationActions", x => x.NotificationActionID);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    NotificationTypeID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.NotificationTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    RoleNameAr = table.Column<string>(nullable: true),
                    IsSystemRole = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierEmail = table.Column<string>(nullable: true),
                    SupplierPhone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Rights",
                columns: table => new
                {
                    RightID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    RightCode = table.Column<string>(nullable: true),
                    FeatureID = table.Column<Guid>(nullable: false),
                    RightOrder = table.Column<int>(nullable: false),
                    RightName = table.Column<string>(nullable: true),
                    RightNameAr = table.Column<string>(nullable: true),
                    MenuIcon = table.Column<string>(nullable: true),
                    RightURL = table.Column<string>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rights", x => x.RightID);
                    table.ForeignKey(
                        name: "FK_Rights_Features_FeatureID",
                        column: x => x.FeatureID,
                        principalTable: "Features",
                        principalColumn: "FeatureID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotificationSettings",
                columns: table => new
                {
                    NotificationSettingID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    NotificationActionID = table.Column<Guid>(nullable: false),
                    NotificationTypeID = table.Column<Guid>(nullable: false),
                    TemplateName = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSettings", x => x.NotificationSettingID);
                    table.ForeignKey(
                        name: "FK_NotificationSettings_NotificationActions_NotificationActionID",
                        column: x => x.NotificationActionID,
                        principalTable: "NotificationActions",
                        principalColumn: "NotificationActionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationSettings_NotificationTypes_NotificationTypeID",
                        column: x => x.NotificationTypeID,
                        principalTable: "NotificationTypes",
                        principalColumn: "NotificationTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    RoleID = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(maxLength: 250, nullable: false),
                    UserName = table.Column<string>(maxLength: 150, nullable: false),
                    UserEmail = table.Column<string>(maxLength: 255, nullable: true),
                    UserPassword = table.Column<string>(maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    CategoryID = table.Column<Guid>(nullable: false),
                    SupplierID = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDetails = table.Column<string>(nullable: true),
                    ProductImagePath = table.Column<string>(nullable: true),
                    ProductImageName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleRights",
                columns: table => new
                {
                    RoleRightID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    RoleID = table.Column<Guid>(nullable: false),
                    RightID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleRights", x => x.RoleRightID);
                    table.ForeignKey(
                        name: "FK_RoleRights_Rights_RightID",
                        column: x => x.RightID,
                        principalTable: "Rights",
                        principalColumn: "RightID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleRights_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    UserID = table.Column<Guid>(nullable: false),
                    CustomerID = table.Column<Guid>(nullable: false),
                    BillDate = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<string>(nullable: true),
                    TotalValue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_Bills_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    PurchaseOrderID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    ProductID = table.Column<Guid>(nullable: false),
                    SupplierID = table.Column<Guid>(nullable: false),
                    PurchasedQuantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.PurchaseOrderID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleID = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    AssociatedCompanyID = table.Column<Guid>(nullable: true),
                    ProductID = table.Column<Guid>(nullable: false),
                    SoldQuantity = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleID);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Bills_SaleID",
                        column: x => x.SaleID,
                        principalTable: "Bills",
                        principalColumn: "BillID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "FeatureName", "FeatureNameAr", "MenuIcon", "ModificationDate", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("6899c2c5-5860-4994-a7e2-d061aed3e0c4"), null, null, null, "Security", "نظام الحماية", "icon-wrench", null, null },
                    { new Guid("5e3d5747-9a45-4541-86ad-03c5bc659714"), null, null, null, "Control Panel", "لوحة التحكم", "icon-settings", null, null }
                });

            migrationBuilder.InsertData(
                table: "NotificationActions",
                columns: new[] { "NotificationActionID", "ActionName", "AssociatedCompanyID", "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy", "TitleEn" },
                values: new object[,]
                {
                    { new Guid("0160f613-f583-4a5f-a15a-4461afaef8be"), "ForgetPassword", null, null, null, null, null, "Forget password" },
                    { new Guid("ceb98ab9-8390-4ebb-999d-be6de77b21c6"), "VerifyUser", null, null, null, null, null, "Verify user" }
                });

            migrationBuilder.InsertData(
                table: "NotificationTypes",
                columns: new[] { "NotificationTypeID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy", "TypeName" },
                values: new object[,]
                {
                    { new Guid("c8d58b31-3fa8-44ab-b24f-fa85ad33c954"), null, null, null, null, null, "Email" },
                    { new Guid("f5702875-5374-4b55-87dd-3da62895f6fb"), null, null, null, null, null, "SMS" },
                    { new Guid("c74cedbf-53bc-4020-b168-46bd6fde0ddf"), null, null, null, null, null, "InAppNotification" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "IsSystemRole", "ModificationDate", "ModifiedBy", "RoleName", "RoleNameAr" },
                values: new object[] { new Guid("7232fe79-deab-41dc-a54d-f83d388d4f09"), null, null, null, true, null, null, "admin", null });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "NotificationSettingID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy", "NotificationActionID", "NotificationTypeID", "Subject", "TemplateName" },
                values: new object[,]
                {
                    { new Guid("46d44ee1-f477-435f-b0b2-87ae3b80b6d0"), null, null, null, null, null, new Guid("0160f613-f583-4a5f-a15a-4461afaef8be"), new Guid("c8d58b31-3fa8-44ab-b24f-fa85ad33c954"), "Change password", "ForgetPassword" },
                    { new Guid("a1c8df0c-ccfa-4e41-889a-8851247c2fd0"), null, null, null, null, null, new Guid("ceb98ab9-8390-4ebb-999d-be6de77b21c6"), new Guid("c8d58b31-3fa8-44ab-b24f-fa85ad33c954"), "Verify user", "verification" },
                    { new Guid("672cf768-aff5-41fd-84c4-2d0b8fa81996"), null, null, null, null, null, new Guid("ceb98ab9-8390-4ebb-999d-be6de77b21c6"), new Guid("f5702875-5374-4b55-87dd-3da62895f6fb"), "Verify user", "verificationSMS" }
                });

            migrationBuilder.InsertData(
                table: "Rights",
                columns: new[] { "RightID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "FeatureID", "IsVisible", "MenuIcon", "ModificationDate", "ModifiedBy", "RightCode", "RightName", "RightNameAr", "RightOrder", "RightURL" },
                values: new object[,]
                {
                    { new Guid("4edc50ca-a7c0-4278-8930-707ec2e5919c"), null, null, null, new Guid("6899c2c5-5860-4994-a7e2-d061aed3e0c4"), true, "icon-docs", null, null, "roles", "Manage Roles", "ادارة الادوار", 1, "#/pages/roles" },
                    { new Guid("78831e46-adab-41ed-a9de-4d5229ccb15f"), null, null, null, new Guid("6899c2c5-5860-4994-a7e2-d061aed3e0c4"), true, "icon-users", null, null, "users", "Manage Users", "ادارة المستخدمين", 2, "#/pages/users" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "FullName", "IsActive", "ModificationDate", "ModifiedBy", "RoleID", "UserEmail", "UserName", "UserPassword" },
                values: new object[] { new Guid("d1364e8b-58e2-423b-a048-03ffd7ef6253"), null, null, null, " Admin", true, null, null, new Guid("7232fe79-deab-41dc-a54d-f83d388d4f09"), "admin@admin.com", "admin", "ꉟ뺾" });

            migrationBuilder.InsertData(
                table: "RoleRights",
                columns: new[] { "RoleRightID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy", "RightID", "RoleID" },
                values: new object[] { new Guid("0de0622b-97db-4edd-acfa-a5adeb81673b"), null, null, null, null, null, new Guid("4edc50ca-a7c0-4278-8930-707ec2e5919c"), new Guid("7232fe79-deab-41dc-a54d-f83d388d4f09") });

            migrationBuilder.InsertData(
                table: "RoleRights",
                columns: new[] { "RoleRightID", "AssociatedCompanyID", "CreatedBy", "CreationDate", "ModificationDate", "ModifiedBy", "RightID", "RoleID" },
                values: new object[] { new Guid("8ac6ded6-4c93-4d95-8396-b526925d322d"), null, null, null, null, null, new Guid("78831e46-adab-41ed-a9de-4d5229ccb15f"), new Guid("7232fe79-deab-41dc-a54d-f83d388d4f09") });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CustomerID",
                table: "Bills",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserID",
                table: "Bills",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationSettings_NotificationActionID",
                table: "NotificationSettings",
                column: "NotificationActionID");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationSettings_NotificationTypeID",
                table: "NotificationSettings",
                column: "NotificationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_ProductID",
                table: "PurchaseOrders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SupplierID",
                table: "PurchaseOrders",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Rights_FeatureID",
                table: "Rights",
                column: "FeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleRights_RightID",
                table: "RoleRights",
                column: "RightID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleRights_RoleID",
                table: "RoleRights",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductID",
                table: "Sales",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationSettings");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "RoleRights");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "NotificationActions");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "Rights");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
