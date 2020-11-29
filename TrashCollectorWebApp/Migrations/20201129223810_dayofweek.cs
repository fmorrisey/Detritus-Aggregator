using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorWebApp.Migrations
{
    public partial class dayofweek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52b199d0-050e-4ed2-8b3f-f856c49e674f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b0b0c1-235a-497d-a2d6-71af2efe641b");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_PickUp_Reccuring",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekDay = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e7603f5b-2e87-4045-b44d-9e66312042d8", "930a9495-53ed-46ff-b7b1-7850ac09fc12", "Customer", "CUSTOMER" },
                    { "e5961b0d-bfd0-4ca2-89e1-896ab79b50e4", "1e1a94c1-aacb-476d-b5cd-fa28db6c9561", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "WeekDay" },
                values: new object[,]
                {
                    { 1, "Monday" },
                    { 2, "Tuesday" },
                    { 3, "Wednesday" },
                    { 4, "Thursday" },
                    { 5, "Friday" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DayId",
                table: "Customers",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Days_DayId",
                table: "Customers",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Days_DayId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DayId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5961b0d-bfd0-4ca2-89e1-896ab79b50e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7603f5b-2e87-4045-b44d-9e66312042d8");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_PickUp_Reccuring",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0b0b0c1-235a-497d-a2d6-71af2efe641b", "304f0d34-04b1-4fb1-83d9-62ac3f4af5f4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52b199d0-050e-4ed2-8b3f-f856c49e674f", "68cf3060-8777-4251-9072-bce6df7ad22f", "Employee", "EMPLOYEE" });
        }
    }
}
