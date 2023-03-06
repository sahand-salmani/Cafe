using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangesFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contracts_RestaurantId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "IsMonthly",
                table: "ContractProducts");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Restaurants",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Positions",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApprovedForJob",
                table: "Interns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ContractType",
                table: "Contracts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    Restaurant = table.Column<string>(maxLength: 255, nullable: true),
                    Note = table.Column<string>(maxLength: 2080, nullable: true),
                    HappenedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "c1d61674-8530-4a9c-b3dc-5d6736c9e4c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c815953a-895b-4fd5-a272-a6c82cfe92f6", "AQAAAAEAACcQAAAAEMuE7hDsIg+ZZFLSIj0k0WbFa+GS91Sm/AGyghXiunu06jD/XjlhScmEyF7SJ3jeDw==", "dcfba434-7979-4b18-8af4-a38149ec6344" });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_Name",
                table: "Restaurants",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_Name",
                table: "Positions",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_RestaurantId",
                table: "Contracts",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Fails_EmployeeId",
                table: "Fails",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fails");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_Name",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Positions_Name",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_RestaurantId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "IsApprovedForJob",
                table: "Interns");

            migrationBuilder.DropColumn(
                name: "ContractType",
                table: "Contracts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Positions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMonthly",
                table: "ContractProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_RestaurantId",
                table: "Contracts",
                column: "RestaurantId",
                unique: true);
        }
    }
}
