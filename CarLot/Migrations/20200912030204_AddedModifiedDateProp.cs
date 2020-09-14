using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarLot.Migrations
{
    public partial class AddedModifiedDateProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SUVs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Motorcycles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Buses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b6798b54-8996-445f-aed6-0407c5befbc7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3ad1508a-fecb-4402-850a-f4be847f8d5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "22fccb0c-96ca-42ef-806b-3a3eb388338e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "df45cc14-6a32-44ec-8c41-41cecb526585");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SUVs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Motorcycles");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Buses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "63c364b9-6760-426a-8657-6bf2497675b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8942de2e-1752-4e8c-8189-5803feb0b3a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c6008622-84fa-40a3-9ed5-53929a12b743");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9b988bb7-0beb-4f1d-9cfe-557aa0a9bd9f");
        }
    }
}
