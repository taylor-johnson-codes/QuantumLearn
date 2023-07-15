﻿namespace QuantumLearn.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int OptionNum { get; set; }
        public int QuestionId { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
