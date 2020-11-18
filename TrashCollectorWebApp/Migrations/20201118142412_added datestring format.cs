using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addeddatestringformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Customer_PickUp_OneTime",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fcddfd1-df06-43b8-8542-eb4f897b83e2", "b7d8bcd8-8436-4d3e-aca8-d205b1d61294", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d57b2f21-318c-4182-b4f3-4f2c0b4ddf78", "cf032d06-1d73-4f9a-bc7f-da7c95795992", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6005dc15-faff-4075-b2ee-721efba36876", "76311746-71f7-4ef0-a7df-1de512459996", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fcddfd1-df06-43b8-8542-eb4f897b83e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6005dc15-faff-4075-b2ee-721efba36876");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57b2f21-318c-4182-b4f3-4f2c0b4ddf78");

            migrationBuilder.DropColumn(
                name: "Customer_PickUp_OneTime",
                table: "Customers");

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
    }
}
