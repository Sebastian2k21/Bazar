using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bazar.Migrations
{
    public partial class Ini7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3087acd6-3b79-426a-ad68-d12ef842485b",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEAbi+9WRSqBgnIOLoL7vi2TF4kgeGYb5YZ88rIOSiCT18ifCYtpQxKMg6zY7P2zANQ==", "c16da9d5-b17a-4023-80dd-401984011951" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d9c392-94a9-4faa-bf54-296d6c871ced",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEHvw5YO/T6rcTbFKL2Th77jmhQRlvPwsEvbhRLylXS9ZhyygDWUpLWws+w08Y+q3Vw==", "cf14ba40-f500-4f2a-b02c-034d652600e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc05fc2b-da9e-431d-a9dc-254c620de471",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAED6bI0jSYM5CCIpoLngbBbSZXkWu3bIDWSoDgA2KbwTli2/m9A//6DFfCWRSCNrQmg==", "e99fc8a7-2b14-46b6-bcf7-bf14ae7563eb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3087acd6-3b79-426a-ad68-d12ef842485b",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEFZaToNFpAT/hy/ScnsEDrzl9PGX5rdeeFpM9GI5SU2V64RZQ0R+v5FwDFGlf9KSig==", "82016181-dbc4-4f6b-b4f4-53297bfb9c5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d9c392-94a9-4faa-bf54-296d6c871ced",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEExNLNE7nskCM/jM3hVLv1zSc7F96F9sTodmD6YjIE9B4D8TKpMR68rnHJPla7/ChQ==", "1480f580-4641-49b6-a714-3cac2f7dcf0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc05fc2b-da9e-431d-a9dc-254c620de471",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEDo84zAKn8N2uEqsaNdjtldrYs4sdpSvq33kGRcXXGOQNlnQqNs+l010M4nr7q/Row==", "0dbe07ca-b085-49a3-9cb3-42f7319afa09" });
        }
    }
}
