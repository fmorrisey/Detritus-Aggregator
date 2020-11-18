using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class changeddatestringformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Customer_PickUp_Reccuring",
                table: "PickUp",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Customer_PickUp_Reccuring",
                table: "PickUp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
