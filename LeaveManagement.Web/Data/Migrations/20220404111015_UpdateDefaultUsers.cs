using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "382ac883-3d19-4aab-acfd-092247aace1f", true, "EMAIL@EMAIL.COM", "AQAAAAEAACcQAAAAEKCy9GdMSLhvdc4YEwScbQA96pSJUzzhUtG99uanUmiRbshAUs1BkRgnNTIY5xeYBQ==", "86b1276a-740b-473a-850d-064a1bc5ed75", "email@email.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8f107d1d-fdfc-4d53-a096-b68294eb0d69", true, "DOROTEA.SIMUNOVIC@HOTMAIL.COM", "AQAAAAEAACcQAAAAEE77s+hMb+R/Bsg+FWxnZT/nWT37aaQzkzs/zgIl3k6OB0XPdGvA2aJON93pAmO7Fw==", "1a873bbc-2daf-4940-ba37-289b939ec268", "dorotea.simunovic@hotmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b63cee-482f-460c-89a1-26aafba2d333",
                column: "ConcurrencyStamp",
                value: "ba812933-d6d0-49f4-940b-de165d1dab51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b63cee-482f-460c-89a1-26aafba2d336",
                column: "ConcurrencyStamp",
                value: "00eab499-f6fe-401a-a7e4-9da7b3472888");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b71d9170-e714-473c-9a7f-9742e8c383f5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "79278b6e-0bd4-47ab-a458-107478d52704", false, null, "AQAAAAEAACcQAAAAEI42Z9BrYtychYChan4ccxtzDSDUTSwfK3FgKImdPghZ49MCOxUXIorMgN2QiWPHlw==", "3ad4eecc-2330-47d3-b1b5-648317988ee1", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0b6a4350-c1b2-46e3-a645-d907599ec1e6", false, null, "AQAAAAEAACcQAAAAEOjnmnJzVKwARJOdN7RSndZ28JdAyJzrzNRt/CoCOSBe4fqEIiUpXEJzAYNd84up7g==", "2ce64210-df20-4682-b26f-8c70d524cf36", null });
        }
    }
}
