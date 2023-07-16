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
                new Answer { Id = 1, QuizNum = 1, QuestionId = 1, Text = "Paul Benioff", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 2, QuizNum = 1, QuestionId = 1, Text = "Peter Shor", IsCorrect = true, OptionNum = 2 },
                new Answer { Id = 3, QuizNum = 1, QuestionId = 1, Text = "David Deutsch", IsCorrect = false, OptionNum = 3 },
                // Quiz 1 Question 2
                new Answer { Id = 4, QuizNum = 1, QuestionId = 2, Text = "1990s - 1999", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 5, QuizNum = 1, QuestionId = 2, Text = "2000s - 2009", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 6, QuizNum = 1, QuestionId = 2, Text = "2010s - Present", IsCorrect = true, OptionNum = 3 }

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
