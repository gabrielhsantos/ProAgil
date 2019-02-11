﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgil.WebAPI.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Eventos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Eventos");
        }
    }
}