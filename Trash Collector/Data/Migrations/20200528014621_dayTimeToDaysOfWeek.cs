using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class dayTimeToDaysOfWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1597a9b9-2571-460b-8aac-937ae04a60ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c7638d-d675-4d96-8b12-3a6ad1c2b434");

            migrationBuilder.AlterColumn<DateTime>(
                name: "weeklyPickupDay",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4c7638d-d675-4d96-8b12-3a6ad1c2b434", "efc2e6bf-4712-449f-beec-83746538cc60", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1597a9b9-2571-460b-8aac-937ae04a60ba", "59f054fb-d823-4e52-b527-a30976909473", "Customer", "CUSTOMER" });
        }
    }
}
