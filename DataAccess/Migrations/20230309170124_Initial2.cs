using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ContractProducts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ContractProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "bee3298a-8499-40c0-a9e2-774ae4580f4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "223563e4-0ead-4008-8021-dd05b1a270a7", "AQAAAAEAACcQAAAAEGDTclGtY/ZXZHu+kmya5UtSbiNjaxLJAInApQ6BFx8BKFAUjXiSbDh08fFtB8ZuPw==", "ae7c556c-227f-4268-aa28-36defa8fc38a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ContractProducts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ContractProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "41c513b1-cb24-4576-8411-c64105214a83");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b45a763-ce56-4c47-813a-5278a4b846ec", "AQAAAAEAACcQAAAAEJS/1Y4XkqVaVKoHyU8llyDoCwM39MvsJPjuC0/3ft+7HK2U0WkvDVpvr7cTfkcaMw==", "0f177867-cc6d-4f83-a429-16b161e94a83" });
        }
    }
}
