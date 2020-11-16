using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class Changedtochangedintergervalueforforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e348e26-0c96-4816-8780-e6a7f365cb2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2af98b14-e693-4935-b235-fc4ae35c2dbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecae6745-5053-465b-a038-34ccd02d0b95");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_ID",
                table: "Customer_Accounts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f553eac5-e0c6-4900-8c09-0e4dd08ce7f4", "74968000-8699-4f04-956e-e93c0e1b88de", "Admin", "ADMIN" },
                    { "595dfa03-4c42-42cc-8fd6-5b8b3999bc05", "78103ee3-0345-4dce-b972-51bf71fa9758", "Customer", "CUSTOMER" },
                    { "e16b8c84-7df9-41c7-aeba-672d75906bba", "b723be29-445f-4098-b5fe-1a7477324be6", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "Customer_Accounts",
                keyColumn: "Account_ID",
                keyValue: 1,
                column: "Customer_ID",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "595dfa03-4c42-42cc-8fd6-5b8b3999bc05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e16b8c84-7df9-41c7-aeba-672d75906bba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f553eac5-e0c6-4900-8c09-0e4dd08ce7f4");

            migrationBuilder.AlterColumn<string>(
                name: "Customer_ID",
                table: "Customer_Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2af98b14-e693-4935-b235-fc4ae35c2dbe", "242b3317-03e2-42b2-954b-b1b4674e68ff", "Admin", "ADMIN" },
                    { "0e348e26-0c96-4816-8780-e6a7f365cb2d", "bdea37e4-09d6-4e80-947a-75ca1866b201", "Customer", "CUSTOMER" },
                    { "ecae6745-5053-465b-a038-34ccd02d0b95", "4953fc5f-df21-4818-aaef-5cae6fe98383", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "Customer_Accounts",
                keyColumn: "Account_ID",
                keyValue: 1,
                column: "Customer_ID",
                value: null);
        }
    }
}
