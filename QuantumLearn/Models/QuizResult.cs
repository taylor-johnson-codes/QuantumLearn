namespace QuantumLearn.Models
{
    public class QuizResult
    {
        public int Id { get; set; }  // primary key
        public string UserId { get; set; }
        public int QuizNum { get; set; }
        public int QuestionId { get; set; }  // foreign key
        public int AnswerId { get; set; }  // foreign key

        // one quiz result is NOT linked to multiple questions or multiple answers, so I don't think I need these collections
        //public ICollection<Question> Questions { get; set; }
        //public ICollection<Answer> Answers { get; set; }
    }
}
