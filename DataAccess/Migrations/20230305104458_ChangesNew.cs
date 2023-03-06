using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangesNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Restaurants",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "7bbc8bf7-f773-4dc9-8b02-c0d81585cbeb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e018575-0d77-47be-b4f8-58c31b0fe365", "AQAAAAEAACcQAAAAECN4YDSiqczAgyOd80aXbtBa5jwIu4fOFMCO+kiBqheUuFEmIvV+4vSWjfeFEeqhow==", "3e1cc4c0-b1c7-4176-a07c-2691cfb80f8c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Restaurants");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "dc5b975f-6181-46f6-a1d3-d9e0e01a6cb3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d1ba7f2-3c65-4a8f-87d2-772dc6e8973f", "AQAAAAEAACcQAAAAEBGmBd5QUgxrrjbVIxMulNysjeIC2f6SNHcXB7tPqMLvTOjFwM8eSCqPAzB5XzaKHQ==", "b49f611b-4a41-4ec9-9f72-5c0c04319205" });
        }
    }
}
