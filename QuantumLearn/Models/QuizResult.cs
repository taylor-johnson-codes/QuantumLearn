namespace QuantumLearn.Models
{
    public class QuizResult
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuizNum { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
