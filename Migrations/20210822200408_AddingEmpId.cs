using Microsoft.EntityFrameworkCore.Migrations;

namespace Screens.Migrations
{
    public partial class AddingEmpId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpId",
                table: "AddUser",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "AddUser");
        }
    }
}
