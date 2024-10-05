using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudWithEfCore.Migrations
{
    /// <inheritdoc />
    public partial class change_all_properties_action : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "People",
                type: "character varying(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "personsPrimaryKey",
                table: "People",
                column: "id");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "id", "age", "gender", "name" },
                values: new object[,]
                {
                    { 20, 30, "Male", "John Doe" },
                    { 21, 25, "Female", "Jane Doe" },
                    { 22, 35, "Male", "Mike Doe" }
                });

            migrationBuilder.AddCheckConstraint(
                name: "ageConstraint",
                table: "People",
                sql: "age > 10 and age < 60");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "personsPrimaryKey",
                table: "People");

            migrationBuilder.DropCheckConstraint(
                name: "ageConstraint",
                table: "People");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "People",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(6)",
                oldMaxLength: 6);

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "id");
        }
    }
}
