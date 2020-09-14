using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarLot.Migrations
{
    public partial class AddedImageProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "SUVs",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Motorcycles",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Buses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "SUVs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Motorcycles");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Buses");
        }
    }
}
