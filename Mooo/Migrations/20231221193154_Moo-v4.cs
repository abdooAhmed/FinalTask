using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mooo.Migrations
{
    /// <inheritdoc />
    public partial class Moov4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Dapartments_DepartmentId",
                table: "Sections");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Sections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Dapartments_DepartmentId",
                table: "Sections",
                column: "DepartmentId",
                principalTable: "Dapartments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Dapartments_DepartmentId",
                table: "Sections");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Sections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Dapartments_DepartmentId",
                table: "Sections",
                column: "DepartmentId",
                principalTable: "Dapartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
