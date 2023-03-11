using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class NewField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HappensAt",
                table: "RestaurantMeetings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "0b4dfb3d-6275-4a1d-a69a-babec4383f3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5d497e6-9a93-430d-8bc5-6c85fdf5f57b", "AQAAAAEAACcQAAAAEMuuGF+2QLI2frNgpELWtwVe8y20qfLLcjoP0zDKfHJgivj70oSvhm834q8V+5H9gA==", "f060c76e-2fe5-42fc-aa96-beefefbc7579" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HappensAt",
                table: "RestaurantMeetings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "efb8a8b9-8baf-4437-bedf-314cbef66fd6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a432747a-b7b0-4ae0-9f9a-070abe1007d9", "AQAAAAEAACcQAAAAECRvIaa2fzVwlLGnX8WNdr7w4gVUJa8aE45od8gz3ao7RIgmYwHx6QiR7Fy+5Rmdag==", "8242672a-a728-4337-aa5e-417c191e2010" });
        }
    }
}
