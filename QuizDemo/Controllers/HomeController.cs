using QuizDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizDemo.Controllers
{
    public class HomeController : Controller
    {
        private QuizDbContext dbContext = new QuizDbContext();
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult GetQuiz(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                SetQuestions();
                Session["user"] = new User()
                {
                    Score = 0,
                    UserName = userViewModel.UserName
                };
                return GetQuestion();
            }
            return View("Index", userViewModel);
        }

        public ActionResult GetQuestion(int questionNumber = 0, int questionAnswer = 0)
        {
            var questions = (List<Question>)Session["questions"];
            if (questionNumber != 0)
            {
                var user = (User)Session["user"];
                var answer = questions.ElementAt(questionNumber - 1).Answers.ElementAt(questionAnswer);
                if (answer.IsCorrect)
                {
                    user.Score += questions.ElementAt(questionNumber - 1).Score;
                    Session["user"] = user;
                }
            }

            if (questionNumber == questions.Count)
            {
                return PartialView("_Result", (User)Session["user"]);
            }

            var currentQuestion = questions.ElementAt(questionNumber);
            currentQuestion.Answers = currentQuestion.Answers.ToList();
            ViewBag.nextNumber = ++questionNumber;
            return PartialView("_Question", currentQuestion);
        }

        protected void SetQuestions()
        {
            if (Session["questions"] == null)
            {
                Session["questions"] = dbContext.Questions.Take(5).ToList();
            }

        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (dbContext != null)
        //    {
        //        dbContext.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}