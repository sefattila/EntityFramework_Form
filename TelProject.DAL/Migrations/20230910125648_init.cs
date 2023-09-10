using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelProject.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Town = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "FirstName", "LastName", "ModifiedDate", "Phone", "Status" },
                values: new object[] { 1, new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(315), null, "Sefa", "Attila", null, "552 828 1903", 0 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "FirstName", "LastName", "ModifiedDate", "Phone", "Status" },
                values: new object[] { 2, new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(323), null, "Ahmet", "Yılmaz", null, "552 828 1903", 0 });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressDetail", "City", "CreateDate", "DeletedDate", "ModifiedDate", "PersonId", "Status", "Town" },
                values: new object[] { 1, "YeşilYurt", "Kastamonu", new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(567), null, null, 1, 0, "Tosya" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressDetail", "City", "CreateDate", "DeletedDate", "ModifiedDate", "PersonId", "Status", "Town" },
                values: new object[] { 2, "Karanfil", "Ankara", new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(570), null, null, 1, 0, "Gölbaşı" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressDetail", "City", "CreateDate", "DeletedDate", "ModifiedDate", "PersonId", "Status", "Town" },
                values: new object[] { 3, "Taşyaka", "Muğla", new DateTime(2023, 9, 10, 15, 56, 47, 875, DateTimeKind.Local).AddTicks(571), null, null, 2, 0, "Fethiye" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
