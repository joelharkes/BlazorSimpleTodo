using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor_todo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTodoItemColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TodoItems",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckedAt",
                table: "TodoItems",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckedAt",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TodoItems",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "TodoItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
