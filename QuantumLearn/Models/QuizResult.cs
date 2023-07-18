namespace QuantumLearn.Models
{
    public class QuizResult
    {
        public int Id { get; set; }  // primary key
        public string UserId { get; set; }
        public int QuizNum { get; set; }
        public int QuestionId { get; set; }  // foreign key
        public int AnswerId { get; set; }  // foreign key
    }
}
