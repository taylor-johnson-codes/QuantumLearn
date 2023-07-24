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
                new Answer { Id = 21, QuizNum = 3, QuestionId = 10, Text = "It can help in the creation of quantum-resistant cryptographic methods", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 22, QuizNum = 3, QuestionId = 10, Text = "It can assist in generating more complex passwords", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 23, QuizNum = 3, QuestionId = 10, Text = "It can help in understanding classical computers better", IsCorrect = false, OptionNum = 3 },
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
                new Answer { Id = 36, QuizNum = 4, QuestionId = 16, Text = "The state of one qubit is completely unrelated to the state of another", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 37, QuizNum = 4, QuestionId = 16, Text = "The state of one qubit is directly related to the state of another, no matter how far apart they are", IsCorrect = true, OptionNum = 2 },
                new Answer { Id = 38, QuizNum = 4, QuestionId = 16, Text = "The qubits are physically tangled with each other", IsCorrect = false, OptionNum = 3 },
                // Quiz 4 Question 6
                new Answer { Id = 39, QuizNum = 4, QuestionId = 17, Text = "Superposition and entanglement", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 40, QuizNum = 4, QuestionId = 17, Text = "Superposition and division", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 41, QuizNum = 4, QuestionId = 17, Text = "Entanglement and multiplication", IsCorrect = false, OptionNum = 3 },

                // Quiz 5 Question 1
                new Answer { Id = 42, QuizNum = 5, QuestionId = 18, Text = "True", IsCorrect = true, OptionNum =  1 },
                new Answer { Id = 43, QuizNum = 5, QuestionId = 18, Text = "False", IsCorrect = false, OptionNum =  2 },
                // Quiz 5 Question 2
                new Answer { Id = 44, QuizNum = 5, QuestionId = 19, Text = "True", IsCorrect = false, OptionNum =  1 },
                new Answer { Id = 45, QuizNum = 5, QuestionId = 19, Text = "False", IsCorrect = true, OptionNum =  2 },
                // Quiz 5 Question 3
                new Answer { Id = 46, QuizNum = 5, QuestionId = 20, Text = "True", IsCorrect = true, OptionNum =  1 },
                new Answer { Id = 47, QuizNum = 5, QuestionId = 20, Text = "False", IsCorrect = false, OptionNum =  2 },
                // Quiz 5 Question 4
                new Answer { Id = 48, QuizNum = 5, QuestionId = 21, Text = "Sports and entertainment", IsCorrect = false, OptionNum =  1 },
                new Answer { Id = 49, QuizNum = 5, QuestionId = 21, Text = "Physics and engineering", IsCorrect = true, OptionNum =  2 },
                new Answer { Id = 50, QuizNum = 5, QuestionId = 21, Text = "History and geography", IsCorrect = false, OptionNum =  3 },
                // Quiz 5 Question 5
                new Answer { Id = 51, QuizNum = 5, QuestionId = 22, Text = "They are used to describe the state of qubits", IsCorrect = true, OptionNum =  1 },
                new Answer { Id = 52, QuizNum = 5, QuestionId = 22, Text = "They are used to power the quantum computer", IsCorrect = false, OptionNum =  2 },
                new Answer { Id = 53, QuizNum = 5, QuestionId = 22, Text = "They are used to construct the physical hardware of a quantum computer", IsCorrect = false, OptionNum =  3 },
                // Quiz 5 Question 6
                new Answer { Id = 54, QuizNum = 5, QuestionId = 23, Text = "A real part and a simple part", IsCorrect = false, OptionNum =  1 },
                new Answer { Id = 55, QuizNum = 5, QuestionId = 23, Text = "A real part and an imaginary part", IsCorrect = true, OptionNum =  2 },
                new Answer { Id = 56, QuizNum = 5, QuestionId = 23, Text = "An imaginary part and a multiple part", IsCorrect = false, OptionNum =  3 },

                // Quiz 6 Question 1
                new Answer { Id = 57, QuizNum = 6, QuestionId = 24, Text = "True", IsCorrect = false, OptionNum =  1 },
                new Answer { Id = 58, QuizNum = 6, QuestionId = 24, Text = "False", IsCorrect = true, OptionNum =  2 },
                // Quiz 6 Question 2
                new Answer { Id = 59, QuizNum = 6, QuestionId = 25, Text = "True", IsCorrect = true, OptionNum =  1 },
                new Answer { Id = 60, QuizNum = 6, QuestionId = 25, Text = "False", IsCorrect = false, OptionNum =  2 },
                // Quiz 6 Question 3
                new Answer { Id = 61, QuizNum = 6, QuestionId = 26, Text = "It retains its superposition state", IsCorrect = false, OptionNum =  1 },
                new Answer { Id = 62, QuizNum = 6, QuestionId = 26, Text = "It forgets about its superposition state and acts like a regular bit until unobserved again", IsCorrect = true, OptionNum =  2 },
                new Answer { Id = 63, QuizNum = 6, QuestionId = 26, Text = "It permanently remains in the chosen state", IsCorrect = false, OptionNum =  3 },

                // Quiz 7 Question 1
                new Answer { Id = 64, QuizNum = 7, QuestionId = 27, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 65, QuizNum = 7, QuestionId = 27, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 7 Question 2
                new Answer { Id = 66, QuizNum = 7, QuestionId = 28, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 67, QuizNum = 7, QuestionId = 28, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 7 Question 3
                new Answer { Id = 68, QuizNum = 7, QuestionId = 29, Text = "Superposition", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 69, QuizNum = 7, QuestionId = 29, Text = "Either heads or tails", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 70, QuizNum = 7, QuestionId = 29, Text = "Neither heads nor tails", IsCorrect = false, OptionNum = 3 },
                // Quiz 7 Question 4
                new Answer { Id = 71, QuizNum = 7, QuestionId = 30, Text = "Can be predetermined", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 72, QuizNum = 7, QuestionId = 30, Text = "Is always heads", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 73, QuizNum = 7, QuestionId = 30, Text = "Is probabilistic, depending on α and β", IsCorrect = true, OptionNum = 3 },
                // Quiz 7 Question 5
                new Answer { Id = 74, QuizNum = 7, QuestionId = 31, Text = "The chances of finding a qubit in a particular state when we measure it", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 75, QuizNum = 7, QuestionId = 31, Text = "Determining the state of the qubit before measurement", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 76, QuizNum = 7, QuestionId = 31, Text = "Changing the state of a qubit after measurement", IsCorrect = false, OptionNum = 3 },

                // Quiz 8 Question 1
                new Answer { Id = 77, QuizNum = 8, QuestionId = 32, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 78, QuizNum = 8, QuestionId = 32, Text = "False", IsCorrect = false, OptionNum = 2 },
                // Quiz 8 Question 2
                new Answer { Id = 79, QuizNum = 8, QuestionId = 33, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 80, QuizNum = 8, QuestionId = 33, Text = "False", IsCorrect = false, OptionNum = 2 },
                // Quiz 8 Question 3
                new Answer { Id = 81, QuizNum = 8, QuestionId = 34, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 82, QuizNum = 8, QuestionId = 34, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 8 Question 4
                new Answer { Id = 83, QuizNum = 8, QuestionId = 35, Text = "The physical size of the qubit", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 84, QuizNum = 8, QuestionId = 35, Text = "An extra piece of hidden information that affects how qubits interact", IsCorrect = true, OptionNum = 2 },
                new Answer { Id = 85, QuizNum = 8, QuestionId = 35, Text = "The speed at which a qubit oscillates", IsCorrect = false, OptionNum = 3 },

                // Quiz 9 Question 1
                new Answer { Id = 86, QuizNum = 9, QuestionId = 36, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 87, QuizNum = 9, QuestionId = 36, Text = "False", IsCorrect = false, OptionNum = 2 },
                // Quiz 9 Question 2
                new Answer { Id = 88, QuizNum = 9, QuestionId = 37, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 89, QuizNum = 9, QuestionId = 37, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 9 Question 3
                new Answer { Id = 90, QuizNum = 9, QuestionId = 38, Text = "Positive numbers", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 91, QuizNum = 9, QuestionId = 38, Text = "Negative numbers", IsCorrect = false, OptionNum = 2 },
                new Answer { Id = 92, QuizNum = 9, QuestionId = 38, Text = "Complex numbers", IsCorrect = true, OptionNum = 3 },

                // Quiz 10 Question 1
                new Answer { Id = 93, QuizNum = 10, QuestionId = 39, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 94, QuizNum = 10, QuestionId = 39, Text = "False", IsCorrect = false, OptionNum = 2 },
                // Quiz 10 Question 2
                new Answer { Id = 95, QuizNum = 10, QuestionId = 40, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 96, QuizNum = 10, QuestionId = 40, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 10 Question 3
                new Answer { Id = 97, QuizNum = 10, QuestionId = 41, Text = "True", IsCorrect = false, OptionNum = 1 },
                new Answer { Id = 98, QuizNum = 10, QuestionId = 41, Text = "False", IsCorrect = true, OptionNum = 2 },
                // Quiz 10 Question 4
                new Answer { Id = 99, QuizNum = 10, QuestionId = 42, Text = "True", IsCorrect = true, OptionNum = 1 },
                new Answer { Id = 100, QuizNum = 10, QuestionId = 42, Text = "False", IsCorrect = false, OptionNum = 2 }

                /*
                // Quiz 11 Question 
                new Answer { Id = , QuizNum = 11, QuestionId = , Text = "", IsCorrect = false, OptionNum =  },
                // Quiz 12 Question 
                new Answer { Id = , QuizNum = 12, QuestionId = , Text = "", IsCorrect = false, OptionNum =  },
                // Quiz 13 Question 
                new Answer { Id = , QuizNum = 13, QuestionId = , Text = "", IsCorrect = false, OptionNum =  },
           */ );
        }
    }
}
