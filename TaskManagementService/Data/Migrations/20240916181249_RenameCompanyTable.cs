using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementService.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "CompaniesTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "CompaniesTable",
                newName: "Companies");
        }
    }
}
