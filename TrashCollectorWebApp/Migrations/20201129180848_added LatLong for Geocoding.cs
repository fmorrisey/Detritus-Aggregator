using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class addedLatLongforGeocoding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Customers_Customer_ID1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PickUp_PickUP_ID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PickUp_PickUP_ID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "PickUp");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PickUP_ID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Customer_ID1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PickUP_ID",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5030c7b5-fdb9-4eec-af08-8196c79fa13a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a61e75e6-fd59-430e-b2e9-93ccaf3f4b90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5e96afa-fd2b-4bb8-9ffe-deddd521af5e");

            migrationBuilder.DropColumn(
                name: "PickUP_ID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Customer_ID1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PickUP_ID",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3f6154c-51de-4f16-9629-8a1e2a13f61e", "17f0a5bf-8ba5-4dd5-9a6e-caa57606cf35", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c482870-47f8-43b6-ae45-2f90dd8952d4", "698a750f-e396-4258-aaa5-f9a3019628e5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c482870-47f8-43b6-ae45-2f90dd8952d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f6154c-51de-4f16-9629-8a1e2a13f61e");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "PickUP_ID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customer_ID1",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PickUP_ID",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PickUp",
                columns: table => new
                {
                    PickUP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPickUp = table.Column<bool>(type: "bit", nullable: false),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Customer_ID1 = table.Column<int>(type: "int", nullable: true),
                    Customer_PickUp_OneTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Customer_PickUp_Reccuring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_PickUp_Temp_End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Customer_PickUp_Temp_Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsEnrolled = table.Column<bool>(type: "bit", nullable: false),
                    OneTimePickUp = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickUp", x => x.PickUP_ID);
                    table.ForeignKey(
                        name: "FK_PickUp_Customers_Customer_ID1",
                        column: x => x.Customer_ID1,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a61e75e6-fd59-430e-b2e9-93ccaf3f4b90", "76660801-6a8c-4244-9305-23fb0d062f08", "Admin", "ADMIN" },
                    { "5030c7b5-fdb9-4eec-af08-8196c79fa13a", "43ca060c-e024-4691-8cfc-da2a196e402b", "Customer", "CUSTOMER" },
                    { "d5e96afa-fd2b-4bb8-9ffe-deddd521af5e", "863d28b5-48d8-4530-a992-6e05a4dac7b6", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "PickUp",
                columns: new[] { "PickUP_ID", "ConfirmPickUp", "Customer_ID", "Customer_ID1", "Customer_PickUp_OneTime", "Customer_PickUp_Reccuring", "Customer_PickUp_Temp_End", "Customer_PickUp_Temp_Start", "IsEnrolled", "OneTimePickUp" },
                values: new object[] { 1, false, 1, null, null, "M", null, null, true, false });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PickUP_ID",
                table: "Employees",
                column: "PickUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Customer_ID1",
                table: "Customers",
                column: "Customer_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PickUP_ID",
                table: "Customers",
                column: "PickUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PickUp_Customer_ID1",
                table: "PickUp",
                column: "Customer_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Customers_Customer_ID1",
                table: "Customers",
                column: "Customer_ID1",
                principalTable: "Customers",
                principalColumn: "Customer_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PickUp_PickUP_ID",
                table: "Customers",
                column: "PickUP_ID",
                principalTable: "PickUp",
                principalColumn: "PickUP_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PickUp_PickUP_ID",
                table: "Employees",
                column: "PickUP_ID",
                principalTable: "PickUp",
                principalColumn: "PickUP_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
