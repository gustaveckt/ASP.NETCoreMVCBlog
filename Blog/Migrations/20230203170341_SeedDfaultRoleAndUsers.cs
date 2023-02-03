using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    public partial class SeedDfaultRoleAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14a926ab-158b-4cbb-8adb-31a51d8d5e4a", "d9e14673-ef39-4ac0-8e98-9df595d83b91", "User", "USER" },
                    { "b7871b4d-f86b-41a6-8767-dc9ce09044a1", "142c3512-6d4b-4885-9f78-f211212eeb5d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "Pseudonym", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a8a16aaaa-bd7e-4db7-b472-b7be15ea5297", 0, "af2e580f-d402-4fc4-a8f9-b9339711ea59", "admin@figuil.com", false, "System", "Admin", false, null, "ADMIN@FIGUIL.COM", "ADMIN@FIGUIL.COM", "AQAAAAEAACcQAAAAEEQr2XuS3HOGrwwi2CmtxOb/RMGRdX5cLUwjQABPNbYjQ8bjrgKdshg6010lytSQjw==", null, false, null, "sysadmin", "f623206f-b92e-430d-a931-152312c83ced", false, "admin@figuil.com" },
                    { "f1ee4fa3-140a-493c-956c-b1aa7775c4f5", 0, "39dd0244-19c4-4ca9-a845-d6c882cce29a", "user@figuil.com", false, "System", "User", false, null, "USER@FIGUIL.COM", "USER@FIGUIL.COM", "AQAAAAEAACcQAAAAEPgCFSp+SSxuilEX3384jx3V4N06nb7rEMQt9b61ClLpS7juRZuwKZvEqF9MGtWYaA==", null, false, null, "sysuser", "ac4e5b85-92a4-44d8-b9ec-4e3e2f0ec0ce", false, "user@figuil.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b7871b4d-f86b-41a6-8767-dc9ce09044a1", "a8a16aaaa-bd7e-4db7-b472-b7be15ea5297" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "14a926ab-158b-4cbb-8adb-31a51d8d5e4a", "f1ee4fa3-140a-493c-956c-b1aa7775c4f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7871b4d-f86b-41a6-8767-dc9ce09044a1", "a8a16aaaa-bd7e-4db7-b472-b7be15ea5297" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14a926ab-158b-4cbb-8adb-31a51d8d5e4a", "f1ee4fa3-140a-493c-956c-b1aa7775c4f5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14a926ab-158b-4cbb-8adb-31a51d8d5e4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7871b4d-f86b-41a6-8767-dc9ce09044a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8a16aaaa-bd7e-4db7-b472-b7be15ea5297");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1ee4fa3-140a-493c-956c-b1aa7775c4f5");
        }
    }
}
