using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class packageConfirmationEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2093451c-a498-457c-84ed-33766d64e5f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bda0a09-53e0-4082-b04a-729897f8d305");

            migrationBuilder.DropColumn(
                name: "pickUpComplete",
                table: "Employees");

            migrationBuilder.AddColumn<bool>(
                name: "pickUpComplete",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4c7638d-d675-4d96-8b12-3a6ad1c2b434", "efc2e6bf-4712-449f-beec-83746538cc60", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1597a9b9-2571-460b-8aac-937ae04a60ba", "59f054fb-d823-4e52-b527-a30976909473", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1597a9b9-2571-460b-8aac-937ae04a60ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c7638d-d675-4d96-8b12-3a6ad1c2b434");

            migrationBuilder.DropColumn(
                name: "pickUpComplete",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "pickUpComplete",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3bda0a09-53e0-4082-b04a-729897f8d305", "9b4c2325-7ee1-4447-88c7-1c29a607e057", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2093451c-a498-457c-84ed-33766d64e5f0", "5cc5d149-32b7-400e-a99d-8ba5c348c0ef", "Customer", "CUSTOMER" });
        }
    }
}
