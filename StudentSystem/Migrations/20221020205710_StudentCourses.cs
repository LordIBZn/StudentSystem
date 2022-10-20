using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSystem.Migrations
{
    public partial class StudentCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_courses_CoursesId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_courses_CoursesId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_studentCourses_courses_CoursesId",
                table: "studentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_studentCourses_Student_StudentId",
                table: "studentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "studentCourses",
                newName: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_studentCourses_CoursesId",
                table: "StudentCourses",
                newName: "IX_StudentCourses_CoursesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Courses_CoursesId",
                table: "Homeworks",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Courses_CoursesId",
                table: "Resources",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CoursesId",
                table: "StudentCourses",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Student_StudentId",
                table: "StudentCourses",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Courses_CoursesId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Courses_CoursesId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CoursesId",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Student_StudentId",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "studentCourses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "courses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_CoursesId",
                table: "studentCourses",
                newName: "IX_studentCourses_CoursesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_courses_CoursesId",
                table: "Homeworks",
                column: "CoursesId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_courses_CoursesId",
                table: "Resources",
                column: "CoursesId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentCourses_courses_CoursesId",
                table: "studentCourses",
                column: "CoursesId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentCourses_Student_StudentId",
                table: "studentCourses",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
