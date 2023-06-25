using QuantumLearn.Areas.Identity.Data;

namespace QuantumLearn.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }

        // from ChatGPT
        public virtual Question Questions { get; set; }

        // formatting I copied from https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio
        //public ICollection<Question> Questions { get; set; }
    }
}
