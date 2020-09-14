using Microsoft.EntityFrameworkCore.Migrations;

namespace CarLot.Migrations
{
    public partial class AddedProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SellerNotes",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerNotes",
                table: "SUVs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerNotes",
                table: "Motorcycles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerNotes",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerNotes",
                table: "Buses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellerNotes",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "SellerNotes",
                table: "SUVs");

            migrationBuilder.DropColumn(
                name: "SellerNotes",
                table: "Motorcycles");

            migrationBuilder.DropColumn(
                name: "SellerNotes",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SellerNotes",
                table: "Buses");

            migrationBuilder.DropColumn(
                name: "About",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "AspNetUsers");
        }
    }
}
