using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuantumLearn.Models;

// The Answer table with properties is already in the database; this is to add seed data to it.
// Resource used: https://code-maze.com/migrations-and-seed-data-efcore/

namespace QuantumLearn.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasData(
                // Quiz 1 Question 1
                new Answer { Id = 1, Text = "Paul Benioff", IsCorrect = false, QuestionId = 1 },
                new Answer { Id = 2, Text = "Peter Shor", IsCorrect = true, QuestionId = 1 },
                new Answer { Id = 3, Text = "David Deutsch", IsCorrect = false, QuestionId = 1 },
                // Quiz 1 Question 2
                new Answer { Id = 4, Text = "1990s - 1999", IsCorrect = false, QuestionId = 2 },
                new Answer { Id = 5, Text = "2000s - 2009", IsCorrect = false, QuestionId = 2 },
                new Answer { Id = 6, Text = "2010s - Present", IsCorrect = true, QuestionId = 2 }

                // Quiz 2
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
