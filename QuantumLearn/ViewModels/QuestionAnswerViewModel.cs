﻿using QuantumLearn.Models;

namespace QuantumLearn.ViewModels
{
    public class QuestionAnswerViewModel
    {
        public List<Question> QuestionList { get; set; }
        public List<Answer> AnswerList { get; set; }
        public List<QuizResult> QuizResultList { get; set; }
        public int QuizNum { get; set; }
    }
}

// ViewModel resource: https://dotnettutorials.net/lesson/view-model-asp-net-mvc/