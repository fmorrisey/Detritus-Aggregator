using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedtheonetimepickupandpickupconfirm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "329ffd3a-d98d-4beb-b90d-15339764743e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d109a488-9141-482e-bdca-27a241c4e79e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbee1989-f58a-4e6a-965d-6c801c787a3f");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "PickUp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Customer_PickUp_OneTime",
                table: "PickUp",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b110e8d4-cc4e-4844-ab58-f11fb53fef5f", "aaada375-3057-45e8-a56b-315698e990b1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ee3567f-a40a-467a-b6de-43ccc5bc25dd", "a5eea31a-1fc9-4c6b-8820-67d2789d73ad", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79aa1a45-b2dd-49a8-9e40-6b649ca50587", "f7c9382d-f688-491d-af81-c4f10872a9a3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee3567f-a40a-467a-b6de-43ccc5bc25dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79aa1a45-b2dd-49a8-9e40-6b649ca50587");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b110e8d4-cc4e-4844-ab58-f11fb53fef5f");

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "PickUp");

            migrationBuilder.DropColumn(
                name: "Customer_PickUp_OneTime",
                table: "PickUp");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "329ffd3a-d98d-4beb-b90d-15339764743e", "2f0e4a4d-b390-4408-9743-68416424147b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbee1989-f58a-4e6a-965d-6c801c787a3f", "0a1181cd-41d6-4ed8-a72b-5fd6f1d411c2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d109a488-9141-482e-bdca-27a241c4e79e", "07527466-f6de-4ff8-ac97-c505ccd740d2", "Employee", "EMPLOYEE" });
        }
    }
}
