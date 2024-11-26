using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3.Migrations
{
    /// <inheritdoc />
    public partial class Task_idCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idCategory",
                table: "tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tasks_idCategory",
                table: "tasks",
                column: "idCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_tasks_categories_idCategory",
                table: "tasks",
                column: "idCategory",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tasks_categories_idCategory",
                table: "tasks");

            migrationBuilder.DropIndex(
                name: "IX_tasks_idCategory",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "idCategory",
                table: "tasks");
        }
    }
}
