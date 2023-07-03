using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuantumLearn.Models;

// The Question table with properties is already in the database; this is to add seed data to it.
// Resource used: https://code-maze.com/migrations-and-seed-data-efcore/

namespace QuantumLearn.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
                // Quiz 1
                new Question { Id = 1, Text = "Who developed an algorithm for factoring large numbers efficiently on a quantum computer, sparking major interest in quantum computing?" },
                new Question { Id = 2, Text = "When did the era of Commercial Quantum Computing begin?" },
                // Quiz 2
                new Question { Id = 2, Text = "The basic unit of information in a quantum computer is the bit, which can be either a 0 or a 1." },
                new Question { Id = 2, Text = "Qubits, unlike bits, can be processed in parallel due to their ability to be in multiple states at once." },
                new Question { Id = 2, Text = "In a classical computer, each bit is dependent on the others, a concept referred to as entanglement." },
                new Question { Id = 2, Text = "Computations on a classical computer are probabilistic, which means the output can vary for a given input and a given set of instructions." },
                new Question { Id = 2, Text = "Quantum computers can potentially handle much larger amounts of data than classical computers because a qubit can hold an infinite number of possible values." }

                // Quiz 3
                // Quiz 4
                // Quiz 5
                // Quiz 6
                // Quiz 7
                // Quiz 8
                // Quiz 9
                // Quiz 10
                // Quiz 11
                // Quiz 12
                // Quiz 13
            );
        }
    }
}
