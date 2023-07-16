namespace QuantumLearn.Models
{
    public class Question
    {
        public int Id { get; set; }  // primary key
        public string Text { get; set; }
        public int QuizNum { get; set; }

        /* I NEED 2-5 DIFFERENT ANSWER IDS/FOREIGN KEYS SO I DONT THINK THIS WILL WORK FOR ME
        // two answers are the minimum options required for True/False questions
        public int AnsOption1 { get; set; }
        public int AnsOption2 { get; set; }
        public int? AnsOption3 { get; set; }
        public int? AnsOption4 { get; set; }
        public int? AnsOption5 { get; set; 
        */ 

        // one question is linked to multiple answers (for True/False and multiple choice)
        public virtual ICollection<Answer> Answers { get; set; }

        // from https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio
        // When ICollection<Answer> is used, EF Core creates a HashSet<Answer> collection by default.
        // Other collection types can be used, such as List<Answer> or HashSet<Answer>.
    }
}
