using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Personas.Migrations
{
    public partial class AddfechaNacimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "Persons",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "Persons");
        }
    }
}
