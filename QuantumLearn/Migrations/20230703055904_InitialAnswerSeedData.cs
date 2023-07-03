using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuantumLearn.Migrations
{
    public partial class InitialAnswerSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, false, 1, "Paul Benioff" },
                    { 2, true, 1, "Peter Shor" },
                    { 3, false, 1, "David Deutsch" },
                    { 4, false, 2, "1990s - 1999" },
                    { 5, false, 2, "2000s - 2009" },
                    { 6, true, 2, "2010s - Present" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
