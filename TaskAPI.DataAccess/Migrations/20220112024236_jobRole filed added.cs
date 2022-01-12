using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class jobRolefiledadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 12, 8, 12, 36, 5, DateTimeKind.Local).AddTicks(2009), new DateTime(2022, 1, 17, 8, 12, 36, 14, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 12, 8, 12, 36, 14, DateTimeKind.Local).AddTicks(7308), new DateTime(2022, 1, 14, 8, 12, 36, 14, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 12, 8, 12, 36, 14, DateTimeKind.Local).AddTicks(7329), new DateTime(2022, 1, 15, 8, 12, 36, 14, DateTimeKind.Local).AddTicks(7332) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 19, 35, 21, 317, DateTimeKind.Local).AddTicks(279), new DateTime(2022, 1, 11, 19, 35, 21, 320, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 19, 35, 21, 320, DateTimeKind.Local).AddTicks(5082), new DateTime(2022, 1, 8, 19, 35, 21, 320, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 19, 35, 21, 320, DateTimeKind.Local).AddTicks(5089), new DateTime(2022, 1, 9, 19, 35, 21, 320, DateTimeKind.Local).AddTicks(5090) });
        }
    }
}
