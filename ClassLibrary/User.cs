using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhisicsExamQuestions.Common
{
    public class User
    {
        public string Name {  get; set; }

        public string Result {  get; set; }
        public string Password {  get; set; }

        public int TotalAttempts = 0;

        public int TheBestScore = 0;

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}