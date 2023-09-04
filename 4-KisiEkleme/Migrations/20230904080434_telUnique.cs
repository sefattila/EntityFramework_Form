using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4_KisiEkleme.Migrations
{
    public partial class telUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "Kisis",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Kisis_Tel",
                table: "Kisis",
                column: "Tel",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Kisis_Tel",
                table: "Kisis");

            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "Kisis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
