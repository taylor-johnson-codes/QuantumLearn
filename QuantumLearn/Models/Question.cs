using QuantumLearn.Areas.Identity.Data;

namespace QuantumLearn.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        // one question is linked to multiple answers (for True/False and multiple choice)
        public virtual ICollection<Answer> Answers { get; set; }

        // from https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio
        // Other collection types can be used, such as List<Enrollment> or HashSet<Enrollment>.
        // When ICollection<Enrollment> is used, EF Core creates a HashSet<Enrollment> collection by default.
    }
}
