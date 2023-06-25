using QuantumLearn.Areas.Identity.Data;

namespace QuantumLearn.Models
{
    public class QuizResult
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        // from ChatGPT
        public virtual Question Questions { get; set; }
        public virtual Answer Answers { get; set; }

        // formatting I copied from https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio
        //public ICollection<Question> Questions { get; set; }
        //public ICollection<Answer> Answers { get; set; }
    }
}
