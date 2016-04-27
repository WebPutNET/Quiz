using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizDemo.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public QuestionCategory QuestionCategory { get; set; }
        public string QuestionContent { get; set; }
        public int Score { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }


    }
}