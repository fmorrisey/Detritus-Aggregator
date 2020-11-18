using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedziptoemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6173e3f-2671-45da-bb95-9165efaaac34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdf7086-5d50-4540-9971-cc2ce1f40e87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd0e4201-61de-464a-9234-d2fcded7bac6");

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd0e4201-61de-464a-9234-d2fcded7bac6", "4f021cde-7136-463e-9024-e92b1077f286", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6173e3f-2671-45da-bb95-9165efaaac34", "95b503c2-80b0-4a7b-a06c-191c3910fea6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afdf7086-5d50-4540-9971-cc2ce1f40e87", "22532c2f-69a9-4745-94a6-3d9ffbeb93ae", "Employee", "EMPLOYEE" });
        }
    }
}
