using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class def : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d59ce173-c7cb-4c06-babf-e18a14ec43e5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bbaa19f-1762-4357-bc90-41c59248e570", "ce6ed2ee-374f-4a4d-8126-e1a038166bc4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bbaa19f-1762-4357-bc90-41c59248e570");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce6ed2ee-374f-4a4d-8126-e1a038166bc4");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e71d461-63e3-4aa5-be93-d701a5a1f913", "188951f0-9561-41e7-8b64-dac97ad60e8e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6217999e-a9fb-448b-b163-e2305fc44f50", "70d761d1-c12c-4070-9402-ea62a335e0e2", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e71d461-63e3-4aa5-be93-d701a5a1f913");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6217999e-a9fb-448b-b163-e2305fc44f50");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4bbaa19f-1762-4357-bc90-41c59248e570", "4be66690-5058-44d0-8c50-515db7020b7c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d59ce173-c7cb-4c06-babf-e18a14ec43e5", "e6fbd5d7-37f9-40a9-bacd-b377df60b936", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ce6ed2ee-374f-4a4d-8126-e1a038166bc4", 0, "Stara Cesta bb", "d2fc56e4-b8d2-4da7-8522-8a59df7f19fb", "mico@admin.com", false, "Mićo", "Programerić", false, null, "MICO@ADMIN.COM", "MICO@ADMIN.COM", "AQAAAAEAACcQAAAAENX8wBQYTVe260Gx9e+FkmgqdzBgOIb/O2q0DZeyFgX/nLstb+4qlKmqYAwcCx4eZw==", null, false, "5e6f4ebd-5416-4773-aef0-8c1861562a53", false, "mico@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4bbaa19f-1762-4357-bc90-41c59248e570", "ce6ed2ee-374f-4a4d-8126-e1a038166bc4" });
        }
    }
}
