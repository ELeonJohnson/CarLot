using Microsoft.EntityFrameworkCore.Migrations;

namespace CarLot.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "63c364b9-6760-426a-8657-6bf2497675b6", "Online Seller", "ONLINE SELLER" },
                    { 2, "8942de2e-1752-4e8c-8189-5803feb0b3a1", "Dealership", "DEALERSHIP" },
                    { 3, "c6008622-84fa-40a3-9ed5-53929a12b743", "Private Party", "PRIVATE PARTY" },
                    { 4, "9b988bb7-0beb-4f1d-9cfe-557aa0a9bd9f", "Buyer", "BUYER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
