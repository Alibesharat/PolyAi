using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Primal_e.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "Ic",
                table: "Users",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "Ic");
        }
    }
}
