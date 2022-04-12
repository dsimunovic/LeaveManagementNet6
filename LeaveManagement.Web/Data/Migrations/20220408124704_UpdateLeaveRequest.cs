using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b63cee-482f-460c-89a1-26aafba2d333",
                column: "ConcurrencyStamp",
                value: "476d476a-9e40-47fb-9d1c-8d4f1ba3e0dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b63cee-482f-460c-89a1-26aafba2d336",
                column: "ConcurrencyStamp",
                value: "d43ad1b0-f2c2-4ec0-b20e-48033fa7eec8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b71d9170-e714-473c-9a7f-9742e8c383f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "002e7f5e-5873-45f7-a48c-7c4660bbcb0a", "AQAAAAEAACcQAAAAEDF8zQctzqUoL4JJvoOUOUrL/m/ZUv0bJILJdPh2OUba/ZBNzgYTmsrrUrJR0XT4pQ==", "4332ba9c-0532-4c8b-a104-62c91b4867dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c453501b-b543-4c49-9c33-bf4f99cfae83", "AQAAAAEAACcQAAAAEITkhiJ32+c5bcBfA6EE02OtPtQuws4fha0p7hLnjyZo4St/wNJyf1sdjUw0smyCeQ==", "1f73de0e-98dc-4e2b-ae92-ab070ea7d694" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b63cee-482f-460c-89a1-26aafba2d333",
                column: "ConcurrencyStamp",
                value: "f3487b4d-df7a-42a4-91fc-058a7e04dc7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b63cee-482f-460c-89a1-26aafba2d336",
                column: "ConcurrencyStamp",
                value: "e2e8b8bf-7aae-4927-810e-0e01bc9dd694");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b71d9170-e714-473c-9a7f-9742e8c383f5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54bd62e5-287e-4cd7-931a-66b794e73611", "AQAAAAEAACcQAAAAEGVzUFWrfRW2gtmLyuW+Gn563+GluUdK4NVa0RZcg2VJoNNf74eDe7fKe78OGXGB8A==", "c3c42fd0-66d5-442b-8b9f-66757bf15ae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0ef63a3-d590-4849-a1f3-dcd55520c29d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5da67d0-710e-47de-b322-4f4c0743e740", "AQAAAAEAACcQAAAAEM40SKGT2636zLy+POxBzmbWG8w10YnOuR1bMDOM1YcdonEFha4lQ/ikAOIRKInlIw==", "dd5245f9-1ba5-4c65-b141-ca7eaeae6df8" });
        }
    }
}
