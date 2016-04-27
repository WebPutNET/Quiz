using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizDemo.Models
{
    //TO DO Display attributes
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }
    }
}