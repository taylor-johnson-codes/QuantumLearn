namespace QuantumLearn.Models
{
    public class Answer
    {
        public int Id { get; set; }  // primary key
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int OptionNum { get; set; }
        public int QuizNum { get; set; }
        public int QuestionId { get; set; }  // foreign key
    }
}
