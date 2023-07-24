using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using QuantumLearn.Models;

namespace QuantumLearn.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
                // Quiz 1
                new Question { Id = 1, QuizNum = 1, Text = "Who developed an algorithm for factoring large numbers efficiently on a quantum computer, sparking major interest in quantum computing?" },
                new Question { Id = 2, QuizNum = 1, Text = "When did the era of Commercial Quantum Computing begin?" },

                // Quiz 2
                new Question { Id = 3, QuizNum = 2, Text = "The basic unit of information in a quantum computer is the bit, which can be either a 0 or a 1." },
                new Question { Id = 4, QuizNum = 2, Text = "Qubits, unlike bits, can be processed in parallel due to their ability to be in multiple states at once." },
                new Question { Id = 5, QuizNum = 2, Text = "In a classical computer, each bit is dependent on the others, a concept referred to as entanglement." },
                new Question { Id = 6, QuizNum = 2, Text = "Computations on a classical computer are probabilistic, which means the output can vary for a given input and a given set of instructions." },
                new Question { Id = 7, QuizNum = 2, Text = "Quantum computers can potentially handle much larger amounts of data than classical computers because a qubit can hold an infinite number of possible values." },

                // Quiz 3
                new Question { Id = 8, QuizNum = 3, Text = "Quantum computing provides many opportunities for contributing to new discoveries and innovations." },
                new Question { Id = 9, QuizNum = 3, Text = "Quantum computing doesn't have the potential to impact the field of machine learning." },
                new Question { Id = 10, QuizNum = 3, Text = "Why is understanding quantum computing crucial in the context of cryptography?" },
                new Question { Id = 11, QuizNum = 3, Text = "Quantum computing lies at the intersection of which fields?" },

                // Quiz 4
                new Question { Id = 12, QuizNum = 4, Text = "A qubit can be in one of two states: 0 or 1." },
                new Question { Id = 13, QuizNum = 4, Text = "Qubits can be in a state of 0, 1, or both at the same time due to a property in quantum mechanics known as superposition." },
                new Question { Id = 14, QuizNum = 4, Text = "In the quantum world, the exact state of a qubit can be known before measuring it." },
                new Question { Id = 15, QuizNum = 4, Text = "The term \"qubit\" comes from which phrase?" },
                new Question { Id = 16, QuizNum = 4, Text = "What does it mean when qubits are said to be entangled?" },
                new Question { Id = 17, QuizNum = 4, Text = "Which properties of qubits enable quantum computers to process a massive number of possibilities at once?" },

                // Quiz 5
                new Question { Id = 18, QuizNum = 5, Text = "The imaginary unit, denoted as \"i\", is defined as the square root of -1." },
                new Question { Id = 19, QuizNum = 5, Text = "When combined with real numbers, imaginary numbers form what are known as simple numbers." },
                new Question { Id = 20, QuizNum = 5, Text = "Quantum gates perform operations on qubits and are described using matrices that often involve complex numbers." },
                new Question { Id = 21, QuizNum = 5, Text = "The imaginary unit is widely used in:" },
                new Question { Id = 22, QuizNum = 5, Text = "In quantum computing, why are complex numbers and the imaginary unit essential?" },
                new Question { Id = 23, QuizNum = 5, Text = "What are complex numbers made up of?" },

                // Quiz 6
                new Question { Id = 24, QuizNum = 6, Text = "Until a qubit is measured, its exact state can be known." },
                new Question { Id = 25, QuizNum = 6, Text = "A qubit can be in a state where it's both heads and tails at the same time." },
                new Question { Id = 26, QuizNum = 6, Text = "What happens to a qubit after it's measured and \"chooses\" a state?" },

                // Quiz 7
                new Question { Id = 27, QuizNum = 7, Text = "The \"amount\" of α and β in a qubit's state does not affect the chances of seeing heads or tails when it is measured." },
                new Question { Id = 28, QuizNum = 7, Text = "Before a qubit is measured, it chooses to be in a definite state of either heads or tails." },
                new Question { Id = 29, QuizNum = 7, Text = "When a qubit is not being measured, it is in a state of:" },
                new Question { Id = 30, QuizNum = 7, Text = "The exact state of a qubit when we measure it:" },
                new Question { Id = 31, QuizNum = 7, Text = "Probability in quantum computing is about:" }

                /*
                // Quiz 8
                new Question { Id = , QuizNum = , Text = "" },
                
                // Quiz 9
                new Question { Id = , QuizNum = , Text = "" },
                
                // Quiz 10
                new Question { Id = , QuizNum = , Text = "" },

                // Quiz 11
                new Question { Id = , QuizNum = , Text = "" },

                // Quiz 12
                new Question { Id = , QuizNum = , Text = "" },

                // Quiz 13
                new Question { Id = , QuizNum = , Text = "" },
                */
            );
        }
    }
}
