using Microsoft.EntityFrameworkCore.Migrations;

namespace LiveBoard.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "83b0c84d-c0a8-4b3d-9bef-07a64b198f84", "ed02b603-ea4a-4c51-94dc-546288139aaf" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName", "NotesNoteId", "Role", "UserClassId" },
                values: new object[] { "c91bb9bf-46e0-4ece-94fe-005fccca8262", 0, "2953e41f-24ae-4216-a854-c4aa3bbd7ae3", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHPNhRKTfad1jJaBTP9oNw/z87qNxyF2CMeBxIsHxdd2my0Pj9c0DMR+IMETO03x8Q==", null, false, "eb888c74-5fbe-4852-ac64-98c272534cc5", false, "admin@admin.com", "admin", "admin", null, "Teacher", null });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 1,
                column: "UserId",
                value: "c91bb9bf-46e0-4ece-94fe-005fccca8262");

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 2,
                column: "UserId",
                value: "c91bb9bf-46e0-4ece-94fe-005fccca8262");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 1,
                column: "UserId",
                value: "c91bb9bf-46e0-4ece-94fe-005fccca8262");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 2,
                column: "UserId",
                value: "c91bb9bf-46e0-4ece-94fe-005fccca8262");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 3,
                column: "UserId",
                value: "c91bb9bf-46e0-4ece-94fe-005fccca8262");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 4,
                column: "UserId",
                value: "c91bb9bf-46e0-4ece-94fe-005fccca8262");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c91bb9bf-46e0-4ece-94fe-005fccca8262", "2953e41f-24ae-4216-a854-c4aa3bbd7ae3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName", "NotesNoteId", "Role", "UserClassId" },
                values: new object[] { "83b0c84d-c0a8-4b3d-9bef-07a64b198f84", 0, "ed02b603-ea4a-4c51-94dc-546288139aaf", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEH554miP5gZCffQ6Nu9y30RuHjd8ra0CW0VawQEZ8xPnnviRtPgXHt09hFTTSYaSNg==", null, false, "0bc78609-91aa-403e-bd75-0b63322bd54f", false, "admin@admin.com", "admin", "admin", null, "Teacher", null });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 1,
                column: "UserId",
                value: "83b0c84d-c0a8-4b3d-9bef-07a64b198f84");

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 2,
                column: "UserId",
                value: "83b0c84d-c0a8-4b3d-9bef-07a64b198f84");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 1,
                column: "UserId",
                value: "83b0c84d-c0a8-4b3d-9bef-07a64b198f84");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 2,
                column: "UserId",
                value: "83b0c84d-c0a8-4b3d-9bef-07a64b198f84");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 3,
                column: "UserId",
                value: "83b0c84d-c0a8-4b3d-9bef-07a64b198f84");

            migrationBuilder.UpdateData(
                table: "UserClass",
                keyColumn: "UserClassId",
                keyValue: 4,
                column: "UserId",
                value: "83b0c84d-c0a8-4b3d-9bef-07a64b198f84");
        }
    }
}
