using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuizDemo.Models
{
    public class QuizDbContext : DbContext
    {

        public QuizDbContext(): base("DefaultConnection")
        {
            Database.SetInitializer<QuizDbContext>(new CreateDatabaseIfNotExists<QuizDbContext>());
            
        }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
    }
}