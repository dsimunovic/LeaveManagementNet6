using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32b63cee-482f-460c-89a1-26aafba2d333", "ba812933-d6d0-49f4-940b-de165d1dab51", "Administrator", "ADMINISTRATOR" },
                    { "62b63cee-482f-460c-89a1-26aafba2d336", "00eab499-f6fe-401a-a7e4-9da7b3472888", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b71d9170-e714-473c-9a7f-9742e8c383f5", 0, "79278b6e-0bd4-47ab-a458-107478d52704", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@email.com", false, "Obican", "User", false, null, "EMAIL@EMAIL.COM", null, "AQAAAAEAACcQAAAAEI42Z9BrYtychYChan4ccxtzDSDUTSwfK3FgKImdPghZ49MCOxUXIorMgN2QiWPHlw==", null, false, "3ad4eecc-2330-47d3-b1b5-648317988ee1", null, false, null },
                    { "e0ef63a3-d590-4849-a1f3-dcd55520c29d", 0, "0b6a4350-c1b2-46e3-a645-d907599ec1e6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dorotea.simunovic@hotmail.com", false, "Dorotea", "Simunovic", false, null, "DOROTEA.SIMUNOVIC@HOTMAIL.COM", null, "AQAAAAEAACcQAAAAEOjnmnJzVKwARJOdN7RSndZ28JdAyJzrzNRt/CoCOSBe4fqEIiUpXEJzAYNd84up7g==", null, false, "2ce64210-df20-4682-b26f-8c70d524cf36", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "62b63cee-482f-460c-89a1-26aafba2d336", "b71d9170-e714-473c-9a7f-9742e8c383f5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "32b63cee-482f-460c-89a1-26aafba2d333", "e0ef63a3-d590-4849-a1f3-dcd55520c29d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62b63cee-482f-460c-89a1-26aafba2d336", "b71d9170-e714-473c-9a7f-9742e8c383f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32b63cee-482f-460c-89a1-26aafba2d333", "e0ef63a3-d590-4849-a1f3-dcd55520c29d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b63cee-482f-460c-89a1-26aafba2d333");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b63cee-482f-460c-89a1-26aafba2d336");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b71d9170-e714-473c-9a7f-9742e8c383f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d");
        }
    }
}
