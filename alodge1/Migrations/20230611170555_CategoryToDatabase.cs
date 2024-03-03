using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alodge1.Migrations
{
    /// <inheritdoc />
    public partial class CategoryToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Categories",
                newName: "price");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Categories",
                newName: "DisplayOrder");
        }
    }
}
