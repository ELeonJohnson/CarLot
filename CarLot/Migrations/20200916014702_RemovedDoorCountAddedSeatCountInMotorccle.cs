using Microsoft.EntityFrameworkCore.Migrations;

namespace CarLot.Migrations
{
    public partial class RemovedDoorCountAddedSeatCountInMotorccle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoorCount",
                table: "Motorcycles");

            migrationBuilder.AddColumn<string>(
                name: "SeatCount",
                table: "Motorcycles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5627bedb-50c5-4162-98d8-dd7b82675f62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ed51eab2-0741-4c4d-ad26-87d7cee5e61c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "69d2e6a4-4805-4387-9d1d-1fb9984da2af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "39f1b808-51bc-41f2-a1f3-a42dbe75bbb1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatCount",
                table: "Motorcycles");

            migrationBuilder.AddColumn<string>(
                name: "DoorCount",
                table: "Motorcycles",
                type: "nvarchar(max)",
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
    }
}
