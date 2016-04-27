namespace QuizDemo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuizDemo.Models.QuizDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuizDemo.Models.QuizDbContext context)
        {
            context.Questions.Add(new Models.Question()
            {
                QuestionCategory = Models.QuestionCategory.Sport,
                QuestionContent = "W jakim klubie gra Mario Balotelli",
                Score = 50,
                QuestionId = 1,
                Answers = new List<Models.Answer>()
                {
                    new Models.Answer()
                    {
                        Content="Ac Milan",
                        IsCorrect=true,
                        QuestionId=1
                    },
                    new Models.Answer()
                    {
                        Content="Wis³a Kraków",
                        IsCorrect = false,
                        QuestionId=1
                    },
                    new Models.Answer()
                    {
                        Content="Sparta Praga",
                        IsCorrect = false,
                        QuestionId=1
                    },
                    new Models.Answer()
                    {
                        Content="Chelsea Londyn",
                        IsCorrect=false,
                        QuestionId=1
                    }
                }
            });


            context.Questions.Add(new Models.Question()
            {
                QuestionCategory = Models.QuestionCategory.Music,
                QuestionContent = "Wska¿ tytu³ piosenki gatunku rock",
                Score = 100,
                QuestionId = 2,
                Answers = new List<Models.Answer>()
                {
                    new Models.Answer()
                    {
                        Content="Babe - JB",
                        IsCorrect=false,
                        QuestionId=2
                    },
                    new Models.Answer()
                    {
                        Content="Paradise - Coldplay",
                        IsCorrect = false,
                        QuestionId=2
                    },
                    new Models.Answer()
                    {
                        Content="Umbrella - Rihanna",
                        IsCorrect = false,
                        QuestionId=2
                    },
                    new Models.Answer()
                    {
                        Content="One - Metallica",
                        IsCorrect=true,
                        QuestionId=2
                    }
                }
            });


        }
    }
}
