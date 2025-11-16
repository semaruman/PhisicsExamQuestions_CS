using System;
using System.Collections.Generic;

namespace PhisicsExamQuestionsConsoleApp
{
    public class Question
    {
        public string Content {  get; set; }

        public string Answer {  get; set; }
        public Question(string content, string answer)
        {
            Content = content;
            Answer = answer;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
