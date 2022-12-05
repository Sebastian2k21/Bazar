using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bazar.Migrations
{
    public partial class rolesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e91c187-f152-4ea9-a39d-e1615dbb6419", "3f629339-9f05-4651-9663-8df060be2db2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9244da6e-9e04-440a-b6ae-9d93cbea9aa5", "2075a85c-e5b3-45e7-8a81-2270fc6b3204", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e91c187-f152-4ea9-a39d-e1615dbb6419");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9244da6e-9e04-440a-b6ae-9d93cbea9aa5");
        }
    }
}
