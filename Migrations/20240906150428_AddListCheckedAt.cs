using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor_todo.Migrations
{
    /// <inheritdoc />
    public partial class AddListCheckedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CheckedAt",
                table: "TodoLists",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckedAt",
                table: "TodoLists");
        }
    }
}
