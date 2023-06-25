using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using QuantumLearn.Areas.Identity.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Linq;

namespace QuantumLearn.Models
{
    // use a static class so it can be used without creating an instance of it
    public static class SeedData
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            // ensures any pending migrations are being applied to the database
            context.Database.Migrate();
            // from ASP.NET class slides: slide 15 of module8 - Entity Framwork Core - part1
            // also described here: https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli
            // SEE THIS MSFT LINK BEFORE DEPLOYING WEB APP; NEED TO CHANGE THE WAY IT'S MIGRATED 

            if (context.Questions.Count() == 0)  // UPDATE THIS PART AFTER ADD ALL OF THE SEED DATA SO IT ALL GETS ADDED
            {
                // -----------------------------------------------QUIZ 1 QUESTIONS----------------------------------------------- //

                List<Question> Quiz1QuestionsList = new List<Question>();

                Quiz1QuestionsList.Add(new Question()
                {
                    Id = 1,
                    Text = "1. Who developed an algorithm for factoring large numbers efficiently on a quantum computer, sparking major interest in quantum computing?"
                });

                Quiz1QuestionsList.Add(new Question()
                {
                    Id = 2,
                    Text = "2. When did the era of Commercial Quantum Computing begin?"
                });

                context.AddRange(Quiz1QuestionsList);

                // -----------------------------------------------QUIZ 2 QUESTIONS----------------------------------------------- //

                List<Question> Quiz2QuestionsList = new List<Question>();

                Quiz2QuestionsList.Add(new Question()
                {
                    Id = 3,
                    Text = "1. True or False: The basic unit of information in a quantum computer is the bit, which can be either a 0 or a 1."
                });

                Quiz2QuestionsList.Add(new Question()
                {
                    Id = 4,
                    Text = "2. True or False: Qubits, unlike bits, can be processed in parallel due to their ability to be in multiple states at once."
                });



                // THERE ARE MORE QUESTIONS TO ADD TO THIS LESSON



                context.AddRange(Quiz2QuestionsList);

                // -----------------------------------------------QUIZ 1 ANSWERS----------------------------------------------- //

                List<Answer> Quiz1AnswersList = new List<Answer>();

                // 1.Who developed an algorithm for factoring large numbers efficiently on a quantum computer, sparking major interest in quantum computing?
                Quiz1AnswersList.Add(new Answer()
                {
                    Id = 1,
                    QuestionId = 1, 
                    Text = "Paul Benioff",
                    IsCorrect = false,
                });

                Quiz1AnswersList.Add(new Answer()
                {
                    Id = 2,
                    QuestionId = 1,
                    Text = "Peter Shor",
                    IsCorrect = true,
                });

                Quiz1AnswersList.Add(new Answer()
                {
                    Id = 3,
                    QuestionId = 1,
                    Text = "David Deutsch",
                    IsCorrect = false,
                });

                // 2. When did the era of Commercial Quantum Computing begin?
                Quiz1AnswersList.Add(new Answer()
                {
                    Id = 4,
                    QuestionId = 2,
                    Text = "1990s-1999",
                    IsCorrect = false,
                });

                Quiz1AnswersList.Add(new Answer()
                {
                    Id = 5,
                    QuestionId = 2,
                    Text = "2000s-2009",
                    IsCorrect = false,
                });

                Quiz1AnswersList.Add(new Answer()
                {
                    Id = 6,
                    QuestionId = 2,
                    Text = "2010s-present",
                    IsCorrect = true,
                });

                context.AddRange(Quiz1AnswersList);

                // -----------------------------------------------QUIZ 2 ANSWERS----------------------------------------------- //

                List<Answer> Quiz2AnswersList = new List<Answer>();

                // 1. True or False: The basic unit of information in a quantum computer is the bit, which can be either a 0 or a 1.
                Quiz2AnswersList.Add(new Answer()
                {
                    Id = 7,
                    QuestionId = 3,
                    Text = "True",
                    IsCorrect = false,
                });

                Quiz2AnswersList.Add(new Answer()
                {
                    Id = 8,
                    QuestionId = 3,
                    Text = "False",
                    IsCorrect = true,
                });

                // 2. True or False: Qubits, unlike bits, can be processed in parallel due to their ability to be in multiple states at once.
                Quiz2AnswersList.Add(new Answer()
                {
                    Id = 9,
                    QuestionId = 4,
                    Text = "True",
                    IsCorrect = true,
                });

                Quiz2AnswersList.Add(new Answer()
                {
                    Id = 10,
                    QuestionId = 4,
                    Text = "False",
                    IsCorrect = false,
                });

                context.AddRange(Quiz2AnswersList);



                context.SaveChanges();
            }
        }
    }
}
