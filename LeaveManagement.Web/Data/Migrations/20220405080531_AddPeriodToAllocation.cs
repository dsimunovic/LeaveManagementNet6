using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b63cee-482f-460c-89a1-26aafba2d333",
                column: "ConcurrencyStamp",
                value: "733b4e23-e74d-4c89-8531-2a6ad26c19f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b63cee-482f-460c-89a1-26aafba2d336",
                column: "ConcurrencyStamp",
                value: "d7e78f88-51cf-46de-94a5-2f967fc0b858");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b71d9170-e714-473c-9a7f-9742e8c383f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "382ac883-3d19-4aab-acfd-092247aace1f", "AQAAAAEAACcQAAAAEKCy9GdMSLhvdc4YEwScbQA96pSJUzzhUtG99uanUmiRbshAUs1BkRgnNTIY5xeYBQ==", "86b1276a-740b-473a-850d-064a1bc5ed75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f107d1d-fdfc-4d53-a096-b68294eb0d69", "AQAAAAEAACcQAAAAEE77s+hMb+R/Bsg+FWxnZT/nWT37aaQzkzs/zgIl3k6OB0XPdGvA2aJON93pAmO7Fw==", "1a873bbc-2daf-4940-ba37-289b939ec268" });
        }
    }
}
