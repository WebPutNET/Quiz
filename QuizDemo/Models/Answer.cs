using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuizDemo.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
        public virtual Question Question { get; set; }
    }
}