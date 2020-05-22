using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class packageConfirmation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e0a569b-dd56-46dc-a5c3-1c0fe1ff5ca7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e1b8b1e-a451-4a51-8adc-e9ca0d594bcc");

            migrationBuilder.AddColumn<bool>(
                name: "pickUpComplete",
                table: "Employees",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e1b8b1e-a451-4a51-8adc-e9ca0d594bcc", "8375f6b6-a3d5-4ada-9b1c-cd0b0dec7b0a", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e0a569b-dd56-46dc-a5c3-1c0fe1ff5ca7", "f29d6d7c-903d-4c0c-aac0-3d0fd3ffa1e0", "Customer", "CUSTOMER" });
        }
    }
}
