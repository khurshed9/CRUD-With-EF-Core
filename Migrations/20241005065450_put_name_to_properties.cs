using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudWithEfCore.Migrations
{
    /// <inheritdoc />
    public partial class put_name_to_properties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "People",
                newName: "personName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "People",
                newName: "personAge");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "personName",
                table: "People",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "personAge",
                table: "People",
                newName: "Age");
        }
    }
}
