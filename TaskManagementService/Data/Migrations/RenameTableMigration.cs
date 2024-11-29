using Microsoft.EntityFrameworkCore.Migrations;

public partial class RenameCompanyTable : Migration
{
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