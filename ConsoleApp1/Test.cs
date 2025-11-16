using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhisicsExamQuestionsConsoleApp
{
    public class Test
    {
        public List<Question> Questions;
        private ResultsTable resTable;
        private User currentUser;

        public Test(List<Question> Questions, ResultsTable resTable, User currentUser)
        {
            this.Questions = Questions;
            this.resTable = resTable;
            this.currentUser = currentUser;
        }

        public void Take()
        {

            int trueAnswersCounter = 0;
            for (int i = 0; i < Questions.Count; i++)
            {
                int questionNumber = GetQuestionNumber(Questions);
                Console.WriteLine($"Вопрос {i + 1}: {Questions[questionNumber]}");
                Questions[questionNumber].Content = "-";

                string userAnswer = Console.ReadLine();
                if (userAnswer == Questions[questionNumber].Answer)
                {
                    trueAnswersCounter++;
                }

                Console.Clear();
            }
            currentUser.Result = GetResults(trueAnswersCounter, Questions.Count);

            Console.WriteLine($"{currentUser.Name}, по результатам теста вы {currentUser.Result}");

            resTable.AddToTable(currentUser, trueAnswersCounter);

            Console.ReadLine();
            Console.Clear();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        private int GetQuestionNumber(List<Question> Questions)
        {
            Random rnd = new Random();
            int questionNumber;
            while (true)
            {
                questionNumber = rnd.Next(Questions.Count);
                // знаком "-" отмечаю использованные вопросы
                if (Questions[questionNumber].Content == "-") // если вопрос был задан, то пропускаю
                {
                    continue;
                }
                else // иначе, если вопрос не был задан возвращаю его индекс
                {
                    return questionNumber;
                }
            }
        }
        private string GetResults(int trueAnswersCounter, int countQuestions)
        {
            if ((double)trueAnswersCounter / countQuestions >= 0.80)
            {
                return "Готов";
            }
            else if ((double)trueAnswersCounter / countQuestions >= 0.60)
            {
                return "Почти готов";
            }
            else if ((double)trueAnswersCounter / countQuestions >= 0.40)
            {
                return "Нормальный";
            }
            else
            {
                return "Совсем не готов";
            }
        }
    }
}