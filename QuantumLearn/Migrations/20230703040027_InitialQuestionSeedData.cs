using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuantumLearn.Migrations
{
    public partial class InitialQuestionSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Who developed an algorithm for factoring large numbers efficiently on a quantum computer, sparking major interest in quantum computing?" },
                    { 2, "When did the era of Commercial Quantum Computing begin?" },
                    { 3, "The basic unit of information in a quantum computer is the bit, which can be either a 0 or a 1." },
                    { 4, "Qubits, unlike bits, can be processed in parallel due to their ability to be in multiple states at once." },
                    { 5, "In a classical computer, each bit is dependent on the others, a concept referred to as entanglement." },
                    { 6, "Computations on a classical computer are probabilistic, which means the output can vary for a given input and a given set of instructions." },
                    { 7, "Quantum computers can potentially handle much larger amounts of data than classical computers because a qubit can hold an infinite number of possible values." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
