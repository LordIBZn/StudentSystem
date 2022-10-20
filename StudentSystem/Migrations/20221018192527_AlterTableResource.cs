using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.Migrations
{
    public partial class AlterTableResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_courses_CoursesId",
                table: "Resources");

            migrationBuilder.AlterColumn<int>(
                name: "CoursesId",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "studentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CoursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_studentCourses_courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentCourses_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_CoursesId",
                table: "studentCourses",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_courses_CoursesId",
                table: "Resources",
                column: "CoursesId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_courses_CoursesId",
                table: "Resources");

            migrationBuilder.DropTable(
                name: "studentCourses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Resources");

            migrationBuilder.AlterColumn<int>(
                name: "CoursesId",
                table: "Resources",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_courses_CoursesId",
                table: "Resources",
                column: "CoursesId",
                principalTable: "courses",
                principalColumn: "Id");
        }
    }
}
