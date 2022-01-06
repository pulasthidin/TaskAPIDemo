using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 10, 21, 19, 334, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 1, 11, 10, 21, 19, 337, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 10, 21, 19, 337, DateTimeKind.Local).AddTicks(2163), new DateTime(2022, 1, 8, 10, 21, 19, 337, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 10, 21, 19, 337, DateTimeKind.Local).AddTicks(2170), new DateTime(2022, 1, 9, 10, 21, 19, 337, DateTimeKind.Local).AddTicks(2171) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 10, 20, 26, 891, DateTimeKind.Local).AddTicks(9321), new DateTime(2022, 1, 11, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(8997), new DateTime(2022, 1, 8, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 1, 6, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(9004), new DateTime(2022, 1, 9, 10, 20, 26, 894, DateTimeKind.Local).AddTicks(9004) });
        }
    }
}
