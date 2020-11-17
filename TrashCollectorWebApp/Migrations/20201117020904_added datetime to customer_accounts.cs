using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addeddatetimetocustomer_accounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5edd94f4-e901-405f-acda-cc72e32dd289");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "820d968b-a733-4ac1-93e8-bfb60a2bf9be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8ea263a-1f1e-4c5c-ad70-7a0ba7079a5d");

            migrationBuilder.AddColumn<DateTime>(
                name: "OneTimePickUp",
                table: "Customer_PickUp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReccuringPickUp",
                table: "Customer_PickUp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9b4d52f-f442-46d8-a156-47fda96bee71", "1cb8d1e6-2fbc-4756-95d5-7d3b8815d156", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93377231-c14a-4de3-9f0d-8ce08d3925eb", "cc17c3e4-5c8e-4b76-924f-50775d2dbf4e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b093f40-f2f7-4ae4-9c8e-4264ec127a62", "fd3931f8-235b-4f94-af9c-6d7ce2ccd40b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b093f40-f2f7-4ae4-9c8e-4264ec127a62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93377231-c14a-4de3-9f0d-8ce08d3925eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9b4d52f-f442-46d8-a156-47fda96bee71");

            migrationBuilder.DropColumn(
                name: "OneTimePickUp",
                table: "Customer_PickUp");

            migrationBuilder.DropColumn(
                name: "ReccuringPickUp",
                table: "Customer_PickUp");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "820d968b-a733-4ac1-93e8-bfb60a2bf9be", "2b69758c-fc1b-4508-836f-158841ac29cc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8ea263a-1f1e-4c5c-ad70-7a0ba7079a5d", "9a9e238d-31ea-448e-a9c4-3decfadc8c36", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5edd94f4-e901-405f-acda-cc72e32dd289", "4087dd68-ce22-45df-b25c-594b3010c77e", "Employee", "EMPLOYEE" });
        }
    }
}
