using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Contracts",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RestaurantMeetings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(maxLength: 255, nullable: false),
                    Person = table.Column<string>(maxLength: 255, nullable: true),
                    Note = table.Column<string>(maxLength: 4000, nullable: true),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantMeetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantMeetings_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantMeetings_RestaurantId",
                table: "RestaurantMeetings",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantMeetings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Contracts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8za25b-t9cb-469f-a165-708677289502",
                column: "ConcurrencyStamp",
                value: "1e23961f-ae6d-4674-ab02-d2802e42f893");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f8fad5b-d9cb-469f-a165-70867728950e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4b8e77-c611-45cc-9f93-0cf4b03565e9", "AQAAAAEAACcQAAAAEDwHtBHMOwJf4sVyKuBqF3k2pu4AjwiXtud1GTG0wr6VDSdjkWlfZe94oogr17ITuA==", "a49e1451-e034-428c-9046-381406a8e1a8" });
        }
    }
}
