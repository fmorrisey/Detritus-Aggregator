using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class inital2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_Address_ID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Address_ID",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e976292-b835-4b2c-901a-a46d0f269a7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d0ea04d-0381-4620-889f-e45aff2b35c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5849624-397d-496e-953c-2bde9b6369f6");

            migrationBuilder.DropColumn(
                name: "Address_ID",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Line_1",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Line_2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2fba6728-5407-4e74-9285-69beefbbb20a", "2a845a15-c335-4d64-bfc2-f6ff024e65fa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "356b3db5-4613-4e05-be9b-3e423be37af5", "1f1f60d8-820e-4ef4-82e0-69940760733d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c40e9ec0-a8bb-43b2-9fbf-7f37d527214b", "66508759-0706-47f6-b376-85fc409ef2e5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fba6728-5407-4e74-9285-69beefbbb20a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356b3db5-4613-4e05-be9b-3e423be37af5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c40e9ec0-a8bb-43b2-9fbf-7f37d527214b");

            migrationBuilder.DropColumn(
                name: "Line_1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Line_2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Address_ID",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d0ea04d-0381-4620-889f-e45aff2b35c8", "2c7100da-9771-4db6-b59d-16972f4e843f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e976292-b835-4b2c-901a-a46d0f269a7a", "93e53ffc-e536-4616-8bba-383e88b43fad", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5849624-397d-496e-953c-2bde9b6369f6", "80e1f063-2a91-4311-853f-22347230bb45", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Address_ID",
                table: "Customers",
                column: "Address_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_Address_ID",
                table: "Customers",
                column: "Address_ID",
                principalTable: "Addresses",
                principalColumn: "Address_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
