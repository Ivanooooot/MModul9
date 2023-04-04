using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class CreateAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e71d461-63e3-4aa5-be93-d701a5a1f913",
                column: "ConcurrencyStamp",
                value: "6e7a3434-0cc1-4380-9c00-afea6f122449");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6217999e-a9fb-448b-b163-e2305fc44f50",
                column: "ConcurrencyStamp",
                value: "79c05017-c3fb-4b18-8494-b96a929364d3");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "66412151-dd0c-4b69-82c8-0f4256e78f00", 0, "Stara Cesta bb", "c02cc838-ad96-4e63-90f4-17b2a8a2f311", "mico@admin.com", false, "Mićo", "Programerić", false, null, "MICO@ADMIN.COM", "MICO@ADMIN.COM", "AQAAAAEAACcQAAAAEE11qU5QYMNGTRwamJN5UwdYETyXcRJw54PnwwxzA/TtXghYgbfjEe6IpzEHF/RKow==", null, false, "a30c085b-69e9-4190-90e0-018590cbd2a0", false, "mico@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6217999e-a9fb-448b-b163-e2305fc44f50", "66412151-dd0c-4b69-82c8-0f4256e78f00" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6217999e-a9fb-448b-b163-e2305fc44f50", "66412151-dd0c-4b69-82c8-0f4256e78f00" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66412151-dd0c-4b69-82c8-0f4256e78f00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e71d461-63e3-4aa5-be93-d701a5a1f913",
                column: "ConcurrencyStamp",
                value: "188951f0-9561-41e7-8b64-dac97ad60e8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6217999e-a9fb-448b-b163-e2305fc44f50",
                column: "ConcurrencyStamp",
                value: "70d761d1-c12c-4070-9402-ea62a335e0e2");
        }
    }
}
