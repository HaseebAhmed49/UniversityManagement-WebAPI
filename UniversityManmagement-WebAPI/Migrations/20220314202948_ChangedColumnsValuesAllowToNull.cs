using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityManmagement_WebAPI.Migrations
{
    public partial class ChangedColumnsValuesAllowToNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructor_Courses_CourseId",
                table: "Course_Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructor_Instructors_InstructorId",
                table: "Course_Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Instructor",
                table: "Course_Instructor");

            migrationBuilder.RenameTable(
                name: "Course_Instructor",
                newName: "Course_Instructors");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Instructor_InstructorId",
                table: "Course_Instructors",
                newName: "IX_Course_Instructors_InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Instructor_CourseId",
                table: "Course_Instructors",
                newName: "IX_Course_Instructors_CourseId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Grade",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Instructors",
                table: "Course_Instructors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructors_Courses_CourseId",
                table: "Course_Instructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructors_Instructors_InstructorId",
                table: "Course_Instructors",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructors_Courses_CourseId",
                table: "Course_Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructors_Instructors_InstructorId",
                table: "Course_Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Instructors",
                table: "Course_Instructors");

            migrationBuilder.RenameTable(
                name: "Course_Instructors",
                newName: "Course_Instructor");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Instructors_InstructorId",
                table: "Course_Instructor",
                newName: "IX_Course_Instructor_InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Instructors_CourseId",
                table: "Course_Instructor",
                newName: "IX_Course_Instructor_CourseId");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Instructor",
                table: "Course_Instructor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_Courses_CourseId",
                table: "Course_Instructor",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_Instructors_InstructorId",
                table: "Course_Instructor",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
