using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class IdentityRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0335539-973f-42d8-8714-6c16152a47c1");

            migrationBuilder.DropColumn(
                name: "zipCodeId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "zipCode",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e1b8b1e-a451-4a51-8adc-e9ca0d594bcc", "8375f6b6-a3d5-4ada-9b1c-cd0b0dec7b0a", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e0a569b-dd56-46dc-a5c3-1c0fe1ff5ca7", "f29d6d7c-903d-4c0c-aac0-3d0fd3ffa1e0", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e0a569b-dd56-46dc-a5c3-1c0fe1ff5ca7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e1b8b1e-a451-4a51-8adc-e9ca0d594bcc");

            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "zipCodeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0335539-973f-42d8-8714-6c16152a47c1", "aa0512b3-b7d1-4028-a01a-6259c5538f85", "Employee", "EMPLOYEE" });
        }
    }
}
