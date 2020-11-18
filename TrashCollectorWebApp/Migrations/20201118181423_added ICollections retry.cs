using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedICollectionsretry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f3f9b3a-e6c5-4649-a0ff-73fc1b54cac6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e754120a-ae7b-4749-8a76-ab643be65a14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6cb2a9f-b849-40b7-a892-fcb0c75bd10c");

            migrationBuilder.AddColumn<int>(
                name: "PickUP_ID",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customer_ID1",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnrolled",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PickUP_ID",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae5edb55-4e2e-4cdd-ad7a-c19958c93f1e", "a19f2a0c-9f57-4acc-b4cf-3f377109c584", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57c8e820-1646-4daf-948e-35c8a2009bfd", "c9c715ad-fe3c-4297-8199-253aa09d9cea", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec068b3c-bbca-4120-b52a-9ad50e40846e", "b98a9423-67e2-4ba2-bff2-b21d36bab53a", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PickUP_ID",
                table: "Employees",
                column: "PickUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Customer_ID1",
                table: "Customers",
                column: "Customer_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PickUP_ID",
                table: "Customers",
                column: "PickUP_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Customers_Customer_ID1",
                table: "Customers",
                column: "Customer_ID1",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PickUp_PickUP_ID",
                table: "Customers",
                column: "PickUP_ID",
                principalTable: "PickUp",
                principalColumn: "PickUP_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PickUp_PickUP_ID",
                table: "Employees",
                column: "PickUP_ID",
                principalTable: "PickUp",
                principalColumn: "PickUP_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Customers_Customer_ID1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PickUp_PickUP_ID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PickUp_PickUP_ID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PickUP_ID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Customer_ID1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PickUP_ID",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57c8e820-1646-4daf-948e-35c8a2009bfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae5edb55-4e2e-4cdd-ad7a-c19958c93f1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec068b3c-bbca-4120-b52a-9ad50e40846e");

            migrationBuilder.DropColumn(
                name: "PickUP_ID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Customer_ID1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsEnrolled",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PickUP_ID",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6cb2a9f-b849-40b7-a892-fcb0c75bd10c", "5f2be7ca-525c-41f8-bb8a-be7dd8852de3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e754120a-ae7b-4749-8a76-ab643be65a14", "6b23780d-56c9-41a7-91b1-86b5c7617236", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f3f9b3a-e6c5-4649-a0ff-73fc1b54cac6", "ee4c1c36-42b6-413e-a6c9-4f3d579f517b", "Employee", "EMPLOYEE" });
        }
    }
}
