using Microsoft.EntityFrameworkCore.Migrations;

namespace Learning.Migrations
{
    public partial class idInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdGame",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdGame",
                table: "Usuarios");
        }
    }
}
