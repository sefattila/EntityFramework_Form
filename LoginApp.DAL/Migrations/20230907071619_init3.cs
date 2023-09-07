using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginApp.DAL.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "text", maxLength: 300, nullable: false),
                    TextDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Texts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Account", "CreateDate", "DeleteDate", "FirstName", "LastName", "Password", "Status", "UpdateDate", "UserName" },
                values: new object[] { 1, 0, new DateTime(2023, 9, 7, 10, 16, 19, 552, DateTimeKind.Local).AddTicks(9665), null, "Ali", "Gündüz", "a.gunduz1", 2, null, "agunduz" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Account", "CreateDate", "DeleteDate", "FirstName", "LastName", "Password", "Status", "UpdateDate", "UserName" },
                values: new object[] { 2, 1, new DateTime(2023, 9, 7, 10, 16, 19, 552, DateTimeKind.Local).AddTicks(9680), null, "Emrah", "Yaşar", "e.yasar1", 2, null, "eyasar" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Account", "CreateDate", "DeleteDate", "FirstName", "LastName", "Password", "Status", "UpdateDate", "UserName" },
                values: new object[] { 3, 1, new DateTime(2023, 9, 7, 10, 16, 19, 552, DateTimeKind.Local).AddTicks(9683), null, "Savaş", "Kurt", "savas.kurt1903", 2, null, "skurt" });

            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Status", "TextDetail", "Title", "UpdateDate", "UserId" },
                values: new object[] { 1, new DateTime(2023, 9, 7, 10, 16, 19, 552, DateTimeKind.Local).AddTicks(9872), null, 0, "DenemeDeneme", "Dene", null, 2 });

            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Status", "TextDetail", "Title", "UpdateDate", "UserId" },
                values: new object[] { 2, new DateTime(2023, 9, 7, 10, 16, 19, 552, DateTimeKind.Local).AddTicks(9877), null, 0, "Beşiktaş", "Kulüp", null, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Texts_UserId",
                table: "Texts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Texts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
