using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuantumLearn.Models;

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
                new Answer { Id = 6, QuizNum = 1, QuestionId = 2, Text = "2010s - Present", IsCorrect = true, OptionNum = 3 },

                // Quiz 2 Question 1
                new Answer { Id = 7, QuizNum = 2, QuestionId = 3, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 8, QuizNum = 2, QuestionId = 3, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 2 Question 2
                new Answer { Id = 9, QuizNum = 2, QuestionId = 4, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 10, QuizNum = 2, QuestionId = 4, Text = "False", IsCorrect = false, OptionNum = 2 },
                // Quiz 2 Question 3
                new Answer { Id = 11, QuizNum = 2, QuestionId = 5, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 12, QuizNum = 2, QuestionId = 5, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 2 Question 4
                new Answer { Id = 13, QuizNum = 2, QuestionId = 6, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 14, QuizNum = 2, QuestionId = 6, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 2 Question 5
                new Answer { Id = 15, QuizNum = 2, QuestionId = 7, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 16, QuizNum = 2, QuestionId = 7, Text = "False", IsCorrect = false, OptionNum = 2 }

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
