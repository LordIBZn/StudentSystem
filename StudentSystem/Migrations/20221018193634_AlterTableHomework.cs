using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.Migrations
{
    public partial class AlterTableHomework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Homeworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StundetId",
                table: "Homeworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_StudentId",
                table: "Homeworks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Student_StudentId",
                table: "Homeworks",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Student_StudentId",
                table: "Homeworks");

            migrationBuilder.DropIndex(
                name: "IX_Homeworks_StudentId",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "StundetId",
                table: "Homeworks");
        }
    }
}
