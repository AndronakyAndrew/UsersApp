using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersApp.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedUsersAppDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Login");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Users",
                newName: "Name");
        }
    }
}
