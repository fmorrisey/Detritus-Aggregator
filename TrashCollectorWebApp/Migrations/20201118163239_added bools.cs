using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedbools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "109b9f3c-6e27-4a21-a422-f3ca20b4ef50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f1ff8c8-6c82-4168-8bfc-b8a8da66dfb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "837ea3ad-9c6e-45c9-a0a0-641d6dc77bd8");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OneTimePickUp",
                table: "Customers",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OneTimePickUp",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f1ff8c8-6c82-4168-8bfc-b8a8da66dfb8", "1faf229b-fe09-43d1-9382-5c3611335d50", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "837ea3ad-9c6e-45c9-a0a0-641d6dc77bd8", "54582e5e-8555-4043-9a92-03ff7bfbfa68", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "109b9f3c-6e27-4a21-a422-f3ca20b4ef50", "8964359a-096f-47a5-b92a-8d8a54747e93", "Employee", "EMPLOYEE" });
        }
    }
}
