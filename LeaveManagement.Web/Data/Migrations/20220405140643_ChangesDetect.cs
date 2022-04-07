using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ChangesDetect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b63cee-482f-460c-89a1-26aafba2d333",
                column: "ConcurrencyStamp",
                value: "fbd6bbf4-7d97-44ec-afab-58db329aa413");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b63cee-482f-460c-89a1-26aafba2d336",
                column: "ConcurrencyStamp",
                value: "08c1b807-9143-4a6d-a725-ab71168942ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b71d9170-e714-473c-9a7f-9742e8c383f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc160073-7033-4ec6-8b29-7a9080d1f633", "AQAAAAEAACcQAAAAEG8YHWCPH/z1w+mU7kBX5F1li0BlCLu3kV5J16WJPHmPQoHDItW/IBvfxpHHpDxfKQ==", "7d804450-da06-43c2-a009-65e0577d59bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9daf54f2-0675-4971-905f-b05fdd3ae0e7", "AQAAAAEAACcQAAAAEME/RThMrIbQ7ISoAfvyUxai4au+klqnz0J4YnzauKLI0mFrORfKdoLnR7zPST8IGg==", "dd073dd6-5fc0-42e4-bd68-3fc535a0bf1e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b63cee-482f-460c-89a1-26aafba2d333",
                column: "ConcurrencyStamp",
                value: "349ae6a8-9b68-4cb0-a27c-861ef4074e41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b63cee-482f-460c-89a1-26aafba2d336",
                column: "ConcurrencyStamp",
                value: "eef6b555-d269-4c01-ac5c-8ad4fba6a958");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b71d9170-e714-473c-9a7f-9742e8c383f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d2d04a5-31a0-47d6-8a3c-69150a3dce91", "AQAAAAEAACcQAAAAEKVBnbXDpF0ZotwbHtXK9N4lIoEysrGMHPLHgQ1RvNaFy56MsWhIss6v4p/DJFcNRw==", "6b8f79a1-04a4-46f8-9f41-e671e210a7c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84128fd3-5d7e-41ae-a063-806741bf9b54", "AQAAAAEAACcQAAAAEFvq6Z6RuijmBC6BQy6zxbQyL7UNxy/BlYRjWZPaSE6Jri2ZxUpfDZW7SH7Zgb31Og==", "722e0c3f-2a28-4c1c-8445-6f1df72d7ec3" });
        }
    }
}
