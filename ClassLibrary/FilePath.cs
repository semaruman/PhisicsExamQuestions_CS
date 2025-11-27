using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisicsExamQuestions.Common
{
    public static class FilePath
    {
        public static string GetResultsFilePath()
        {
            return @"results.txt";
        }
        public static string GetQuestionsFilePath()
        {
            return @"questions.json";
        }
        public static string GetUsersFilePath()
        {
            return @"users.json";
        }
    }
}
