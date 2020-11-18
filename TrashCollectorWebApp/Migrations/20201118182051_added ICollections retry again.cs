using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedICollectionsretryagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Customer_PickUp_Reccuring",
                table: "PickUp",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsEnrolled",
                table: "PickUp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OneTimePickUp",
                table: "PickUp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3479ccbd-4cb4-40c6-a431-1272b8bcf8c2", "aaf8f2aa-0049-44db-a251-fa7047757d2e", "Admin", "ADMIN" },
                    { "8e17525f-0e9a-4cda-b865-e3b00faab931", "24977ac6-b3f0-4a88-ad2c-d892e9f3e7de", "Customer", "CUSTOMER" },
                    { "ee1dbd28-3a22-44f2-a983-66bc9becf007", "a4287e01-83e3-4a89-b16b-3ae8dbeff775", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "PickUp",
                columns: new[] { "PickUP_ID", "ConfirmPickUp", "Customer_ID", "Customer_ID1", "Customer_PickUp_OneTime", "Customer_PickUp_Reccuring", "Customer_PickUp_Temp_End", "Customer_PickUp_Temp_Start", "IsEnrolled", "OneTimePickUp" },
                values: new object[] { 1, false, 1, null, null, "M", null, null, true, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3479ccbd-4cb4-40c6-a431-1272b8bcf8c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e17525f-0e9a-4cda-b865-e3b00faab931");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee1dbd28-3a22-44f2-a983-66bc9becf007");

            migrationBuilder.DeleteData(
                table: "PickUp",
                keyColumn: "PickUP_ID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsEnrolled",
                table: "PickUp");

            migrationBuilder.DropColumn(
                name: "OneTimePickUp",
                table: "PickUp");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_PickUp_Reccuring",
                table: "PickUp",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
        }
    }
}
