using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week12_4_EduPlatform.Migrations
{
    /// <inheritdoc />
    public partial class Add_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students", columns: new[] { "Id", "FirstName", "LastName", "DateOfBirth", "Email" },
                values: new object[] { 1, "A", "B", new DateTime(2000, 1, 1), "a@b.com" }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students", keyColumn: "Id", keyValue: 1
                );
        }
    }
}
