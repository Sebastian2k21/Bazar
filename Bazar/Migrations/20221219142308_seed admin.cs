using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bazar.Migrations
{
    public partial class seedadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cc05fc2b-da9e-431d-a9dc-254c620de471", 0, "7b8f4b5b-80dc-4275-8331-ca552dc9a2d7", "admin@bazar.pl", true, false, null, "ADMIN@BAZAR.PL", "ADMIN", "AQAAAAEAACcQAAAAEMEkAPyo1+erUmmvKPE4C5sSrwNo/B3TgN7UqCXfoVdGpO3EeVXodsYEaPzyo5uE/g==", null, false, "9cd5719e-04a6-41c4-91af-a762759806cc", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8e91c187-f152-4ea9-a39d-e1615dbb6419", "cc05fc2b-da9e-431d-a9dc-254c620de471" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e91c187-f152-4ea9-a39d-e1615dbb6419", "cc05fc2b-da9e-431d-a9dc-254c620de471" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc05fc2b-da9e-431d-a9dc-254c620de471");
        }
    }
}
