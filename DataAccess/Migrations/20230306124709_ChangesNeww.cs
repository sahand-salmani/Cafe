using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ChangesNeww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrePayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(maxLength: 2080, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrePayments_Employees_EmployeeId",
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
                value: "9fe069f4-1684-4847-880b-ed2061b09d25");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4b2df9b-67a6-4e46-8e6a-168833cf23d4", "AQAAAAEAACcQAAAAELvx/fRKk3nmXfhniOwjohZBgR+jUuBG2aTOklyXfJhrEvTNKtcZvdGw8/MahKn2qw==", "1a0d14c2-6406-42f4-ab93-6240ed0e884e" });

            migrationBuilder.CreateIndex(
                name: "IX_PrePayments_EmployeeId",
                table: "PrePayments",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrePayments");

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
        }
    }
}
