using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLib.Migrations
{
    /// <inheritdoc />
    public partial class Book2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "titile",
                table: "Books",
                newName: "title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Books",
                newName: "titile");
        }
    }
}
