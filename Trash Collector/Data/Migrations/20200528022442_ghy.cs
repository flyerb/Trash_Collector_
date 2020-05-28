using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class ghy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "549e23fa-6987-4187-9656-3ed7009f4869");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de29f003-251f-4284-87a6-1bab13eea8ea");

            migrationBuilder.AlterColumn<string>(
                name: "weeklyPickupDay",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eefc7139-1520-4173-9f55-925d633f9b44", "cf68092f-d0b6-4c89-9590-474f1f80f906", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc14fb7b-ef0b-4385-8dc2-e5aa9b6aabb8", "b949db19-772f-4b8c-8d6a-dbd900ccf117", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc14fb7b-ef0b-4385-8dc2-e5aa9b6aabb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eefc7139-1520-4173-9f55-925d633f9b44");

            migrationBuilder.AlterColumn<DateTime>(
                name: "weeklyPickupDay",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "549e23fa-6987-4187-9656-3ed7009f4869", "94cecf11-c430-4dc7-b54e-6a08d1d6da3c", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de29f003-251f-4284-87a6-1bab13eea8ea", "c5b62327-d994-46a8-9fe3-73fab9b25d79", "Customer", "CUSTOMER" });
        }
    }
}
