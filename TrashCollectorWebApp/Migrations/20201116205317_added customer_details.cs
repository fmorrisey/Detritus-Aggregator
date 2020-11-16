using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedcustomer_details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c96cba3-bba9-40b0-aed3-a63a290db862");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e992584-92c6-471b-afd2-038bbf2231cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62c123d7-3e9f-4bfe-92bd-344c02dec851");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8efe8ab9-57bf-45bc-966c-6e1092757e99", "75750410-8ac3-4f4f-b446-d6c6c1abe69e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6223ed9d-74b6-42d1-97ff-623d0d6b3e64", "16c63981-1368-4b25-ae2c-1e467adcd41e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbff1430-1b4f-4ce0-8920-a741b3647553", "a3abc286-078b-46ea-ae04-ab735fe5d4b0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6223ed9d-74b6-42d1-97ff-623d0d6b3e64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8efe8ab9-57bf-45bc-966c-6e1092757e99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbff1430-1b4f-4ce0-8920-a741b3647553");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e992584-92c6-471b-afd2-038bbf2231cd", "1fdcf17c-ef6c-41ff-bd4a-a0e4a47b8e98", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62c123d7-3e9f-4bfe-92bd-344c02dec851", "73f62e8e-3ce5-4bdb-a7ca-24d165bfd623", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c96cba3-bba9-40b0-aed3-a63a290db862", "f088b20d-61e8-4792-b3ff-ba2e6d47a4a7", "Employee", "EMPLOYEE" });
        }
    }
}
