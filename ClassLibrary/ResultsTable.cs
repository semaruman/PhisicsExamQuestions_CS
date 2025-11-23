using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace PhisicsExamQuestions.Common
{
    public class ResultsTable
    {
        public readonly string Path = FilePath.GetResultsFilePath();
        public ResultsTable(string path)
        {
            this.Path = path;
        }
        public void PrintTable()
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadLine();
            Console.Clear();
        }
        public string GetTable()
        {
            using (StreamReader sr = new StreamReader(Path))
            {
                string text = sr.ReadToEnd();
                return text;
            }
        }

        public void AddToTable(User user, int trueAnswersCounter)
        {
            //string content = $"{user.Name}\t{trueAnswersCounter}\t\t\t\t{user.Result}";
            string content = $"{user.Name} / {trueAnswersCounter} / {user.Result}";

            using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(content);
            }
        }
    }
}