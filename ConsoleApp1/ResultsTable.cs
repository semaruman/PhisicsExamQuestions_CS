using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhisicsExamQuestionsConsoleApp
{
    public class ResultsTable
    {
        public readonly string Path;
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

        public void AddToTable(User user, int trueAnswersCounter)
        {
            string content = $"{user.Name}\t{trueAnswersCounter}\t\t\t\t{user.Result}";

            using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(content);
            }
        }
    }
}