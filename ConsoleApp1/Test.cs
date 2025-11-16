using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhisicsExamQuestionsConsoleApp
{
    public class Test
    {
        private List<Question> questions;
        private ResultsTable resTable;
        private User currentUser;

        public Test(List<Question> questions, ResultsTable resTable, User currentUser)
        {
            this.questions = questions;
            this.resTable = resTable;
            this.currentUser = currentUser;
        }

        public void Take()
        {

            int trueAnswersCounter = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                int questionNumber = GetQuestionNumber(questions);
                Console.WriteLine($"Вопрос {i + 1}: {questions[questionNumber]}");
                questions[questionNumber].Content = "-";

                string userAnswer = Console.ReadLine();
                if (userAnswer == questions[questionNumber].Answer)
                {
                    trueAnswersCounter++;
                }

                Console.Clear();
            }
            currentUser.Result = GetResults(trueAnswersCounter, questions.Count);

            Console.WriteLine($"{currentUser.Name}, по результатам теста вы {currentUser.Result}");

            resTable.AddToTable(currentUser, trueAnswersCounter);

            Console.ReadLine();
            Console.Clear();
        }

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        private int GetQuestionNumber(List<Question> questions)
        {
            Random rnd = new Random();
            int questionNumber;
            while (true)
            {
                questionNumber = rnd.Next(questions.Count);
                // знаком "-" отмечаю использованные вопросы
                if (questions[questionNumber].Content == "-") // если вопрос был задан, то пропускаю
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