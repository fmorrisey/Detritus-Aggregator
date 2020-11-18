using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedcurrenydatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0024cd94-c613-4c44-a2d5-dd0ac4fcd072");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c85816c-c798-400e-8a1e-08399a0bf89e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "834cdc08-f570-4fd9-ad4a-275f2359746e");

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Customers",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Customers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "834cdc08-f570-4fd9-ad4a-275f2359746e", "e94929bc-bea4-4f5d-853b-19b37903cac1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0024cd94-c613-4c44-a2d5-dd0ac4fcd072", "b53637bd-5a89-4d58-9932-e80cf4a7d660", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c85816c-c798-400e-8a1e-08399a0bf89e", "2cf35067-6223-447a-8a20-c4c5403a70c3", "Employee", "EMPLOYEE" });
        }
    }
}
