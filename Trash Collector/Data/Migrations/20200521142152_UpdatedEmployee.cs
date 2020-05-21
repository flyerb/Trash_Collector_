using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class UpdatedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_employeesEmployeeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_employeesEmployeeId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c798f286-88cc-4c91-9b21-82b222a05ac3");

            migrationBuilder.DropColumn(
                name: "currentDay",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "employeesEmployeeId",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0335539-973f-42d8-8714-6c16152a47c1", "aa0512b3-b7d1-4028-a01a-6259c5538f85", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0335539-973f-42d8-8714-6c16152a47c1");

            migrationBuilder.AddColumn<DateTime>(
                name: "currentDay",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "employeesEmployeeId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c798f286-88cc-4c91-9b21-82b222a05ac3", "e4b5ef62-9e6d-4e69-8e2a-b0e8cd326417", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_employeesEmployeeId",
                table: "Employees",
                column: "employeesEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_employeesEmployeeId",
                table: "Employees",
                column: "employeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
