using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class ChangedtoRoleID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers");

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

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customer_Accounts",
                columns: table => new
                {
                    Account_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_ID = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Accounts", x => x.Account_ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2af98b14-e693-4935-b235-fc4ae35c2dbe", "242b3317-03e2-42b2-954b-b1b4674e68ff", "Admin", "ADMIN" },
                    { "0e348e26-0c96-4816-8780-e6a7f365cb2d", "bdea37e4-09d6-4e80-947a-75ca1866b201", "Customer", "CUSTOMER" },
                    { "ecae6745-5053-465b-a038-34ccd02d0b95", "4953fc5f-df21-4818-aaef-5cae6fe98383", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Customer_Accounts",
                columns: new[] { "Account_ID", "Balance", "Customer_ID" },
                values: new object[] { 1, 0m, null });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityRoleId",
                table: "Customers",
                column: "IdentityRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetRoles_IdentityRoleId",
                table: "Customers",
                column: "IdentityRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetRoles_IdentityRoleId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Customer_Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Customers_IdentityRoleId",
                table: "Customers");

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

            migrationBuilder.DropColumn(
                name: "IdentityRoleId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
