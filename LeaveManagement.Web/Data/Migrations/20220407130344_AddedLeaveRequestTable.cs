using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
