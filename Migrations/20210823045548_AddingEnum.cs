using Microsoft.EntityFrameworkCore.Migrations;

namespace Screens.Migrations
{
    public partial class AddingEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddProject_AddUser_FirstNameId",
                table: "AddProject");

            migrationBuilder.DropIndex(
                name: "IX_AddProject_FirstNameId",
                table: "AddProject");

            migrationBuilder.DropColumn(
                name: "FirstNameId",
                table: "AddProject");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AddProject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "priority",
                table: "AddProject",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AddProject");

            migrationBuilder.DropColumn(
                name: "priority",
                table: "AddProject");

            migrationBuilder.AddColumn<int>(
                name: "FirstNameId",
                table: "AddProject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AddProject_FirstNameId",
                table: "AddProject",
                column: "FirstNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddProject_AddUser_FirstNameId",
                table: "AddProject",
                column: "FirstNameId",
                principalTable: "AddUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
