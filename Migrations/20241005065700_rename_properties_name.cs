using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudWithEfCore.Migrations
{
    /// <inheritdoc />
    public partial class rename_properties_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "People",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "personName",
                table: "People",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "personAge",
                table: "People",
                newName: "age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "gender",
                table: "People",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "People",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "People",
                newName: "personName");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "People",
                newName: "personAge");
        }
    }
}
