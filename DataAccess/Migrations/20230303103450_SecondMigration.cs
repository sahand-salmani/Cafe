using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FinishedAt",
                table: "Interns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartsAt",
                table: "Interns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinishedAt",
                table: "Interns");

            migrationBuilder.DropColumn(
                name: "StartsAt",
                table: "Interns");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "01ca6144-0fb1-4d3c-bc6b-8a03f100af8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "344f2f61-67b4-4f31-a19a-bf45f0af6239", "AQAAAAEAACcQAAAAEEvNwHF1lcYWEpR+nb1wC2DicQ/RBDnsU1eb3E1XHjSqP10FAHAaNBNsGmqs3ui0mw==", "0406d501-cd55-4dc6-a698-b9b17bd1fc0c" });
        }
    }
}
