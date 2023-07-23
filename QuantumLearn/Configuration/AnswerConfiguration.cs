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
                new Answer { Id = 16, QuizNum = 2, QuestionId = 7, Text = "False", IsCorrect = false, OptionNum = 2 },

                // Quiz 3 Question 1
                new Answer { Id = 17, QuizNum = 3, QuestionId = 8, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 18, QuizNum = 3, QuestionId = 8, Text = "False", IsCorrect = false, OptionNum = 2 },
                // Quiz 3 Question 2
                new Answer { Id = 19, QuizNum = 3, QuestionId = 9, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 20, QuizNum = 3, QuestionId = 9, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 3 Question 3
                new Answer { Id = 21, QuizNum = 3, QuestionId = 10, Text = "It can help in the creation of quantum-resistant cryptographic methods.", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 22, QuizNum = 3, QuestionId = 10, Text = "It can assist in generating more complex passwords.", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 23, QuizNum = 3, QuestionId = 10, Text = "It can help in understanding classical computers better.", IsCorrect = false, OptionNum = 3 },
                // Quiz 3 Question 4
                new Answer { Id = 24, QuizNum = 3, QuestionId = 11, Text = "Physics, computer science, mathematics, and information theory", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 25, QuizNum = 3, QuestionId = 11, Text = "Literature, music, art, and culinary", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 26, QuizNum = 3, QuestionId = 11, Text = "Politics, sociology, and philosophy", IsCorrect = false, OptionNum = 3 },

                // Quiz 4 Question 1
                new Answer { Id = 27, QuizNum = 4, QuestionId = 12, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 28, QuizNum = 4, QuestionId = 12, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 4 Question 2
                new Answer { Id = 29, QuizNum = 4, QuestionId = 13, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 30, QuizNum = 4, QuestionId = 13, Text = "False", IsCorrect = false, OptionNum = 2 },
                // Quiz 4 Question 3
                new Answer { Id = 31, QuizNum = 4, QuestionId = 14, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 32, QuizNum = 4, QuestionId = 14, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 4 Question 4
                new Answer { Id = 33, QuizNum = 4, QuestionId = 15, Text = "Quality bit", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 34, QuizNum = 4, QuestionId = 15, Text = "Quantum bit", IsCorrect = true, OptionNum = 2 },
                new Answer { Id = 35, QuizNum = 4, QuestionId = 15, Text = "Quick bit", IsCorrect = false, OptionNum = 3 },
                // Quiz 4 Question 5
                new Answer { Id = 36, QuizNum = 4, QuestionId = 16, Text = "The state of one qubit is completely unrelated to the state of another.", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 37, QuizNum = 4, QuestionId = 16, Text = "The state of one qubit is directly related to the state of another, no matter how far apart they are.", IsCorrect = true, OptionNum = 2 },
                new Answer { Id = 38, QuizNum = 4, QuestionId = 16, Text = "The qubits are physically tangled with each other.", IsCorrect = false, OptionNum = 3 },
                // Quiz 4 Question 6
                new Answer { Id = 39, QuizNum = 4, QuestionId = 17, Text = "Superposition and entanglement", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 40, QuizNum = 4, QuestionId = 17, Text = "Superposition and division", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 41, QuizNum = 4, QuestionId = 17, Text = "Entanglement and multiplication", IsCorrect = false, OptionNum = 3 }

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
