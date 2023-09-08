using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginApp.DAL.Migrations
{
    public partial class initBilge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 8, 9, 0, 37, 172, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 8, 9, 0, 37, 172, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 8, 9, 0, 37, 172, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 8, 9, 0, 37, 172, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 8, 9, 0, 37, 172, DateTimeKind.Local).AddTicks(1959));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 7, 20, 15, 14, 53, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 7, 20, 15, 14, 53, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 7, 20, 15, 14, 53, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 7, 20, 15, 14, 53, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 7, 20, 15, 14, 53, DateTimeKind.Local).AddTicks(9312));
        }
    }
}
