﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace KidActivityManagement.Migrations
{
    public partial class AddIdentityToActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Activities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Activities");
        }
    }
}
