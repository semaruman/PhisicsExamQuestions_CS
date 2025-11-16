using System;
using System.IO;

namespace PhisicsExamQuestionsConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string menuValue;
            while (true)
            {
                Console.WriteLine("\tВыберете опцию");
                Console.WriteLine("1 - пройти тест");
                Console.WriteLine("2 - вывести таблицу результатов");
                Console.WriteLine("0 - выход из программы");
                menuValue = Console.ReadLine();

                if (menuValue == "1")
                {
                    Console.Clear();
                    TakeTest();
                }
                else if (menuValue == "2")
                {
                    Console.Clear();
                    TakeTournamentTable();
                }
                else if (menuValue == "0")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        static void TakeTest()
        {
            string userName = GetUserName();

            string userChoice = "Да";

            while (userChoice.ToLower() != "нет" && userChoice.ToLower() != "no")
            {
                string[] results = GetResults();
                string[] questions = GetQuestions();
                string[] answers = GetAnswers();

                int trueAnswersCounter = 0;
                for (int i = 0; i < questions.Length; i++)
                {
                    int questionNumber = GetQuestionNumber(questions);
                    Console.WriteLine($"Вопрос {i + 1}: {questions[questionNumber]}");
                    questions[questionNumber] = "-";

                    string userAnswer = Console.ReadLine();
                    if (userAnswer == answers[questionNumber])
                    {
                        trueAnswersCounter++;
                    }

                    Console.Clear();
                }
                Console.WriteLine($"{userName}, по результатам теста вы {results[trueAnswersCounter]}");

                string content = $"{userName}\t{trueAnswersCounter}\t\t\t\t{results[trueAnswersCounter]}";
                using (StreamWriter sw = new StreamWriter(GetFilePath(), true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(content);
                }

                Console.WriteLine();
                Console.WriteLine("Хотите ещё раз пройти тест? (Введите нет или no, чтобы выйти)");
                userChoice = Console.ReadLine();
                Console.Clear();
            }
        }
        static void TakeTournamentTable()
        {
            using (StreamReader sr = new StreamReader(GetFilePath()))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadLine();
            Console.Clear();
        }
        static int GetQuestionNumber(string[] questions)
        {
            Random rnd = new Random();
            int questionNumber;
            while (true)
            {
                questionNumber = rnd.Next(questions.Length);
                // знаком "-" отмечаю использованные вопросы
                if (questions[questionNumber] == "-") // если вопрос был задан, то пропускаю
                {
                    continue;
                }
                else // иначе, если вопрос не был задан возвращаю его индекс
                {
                    return questionNumber;
                }
            }
        }

        static string[] GetQuestions()
        {
            string[] questions = new string[]
            {
                "Сколько будет два плюс два умноженние на два?",
                "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?",
                "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
                "Укол делают каждые полчаса, сколько нужно минут для трёх уколов?",
                "Пять свечей горело, две потухли. Сколько свечей осталось?"
            };
            return questions;
        }

        static string[] GetResults()
        {
            string[] results = new string[] {
                "Кретин",
                "Идиот",
                "Дурак",
                "Нормальный",
                "Умный",
                "Гений"
            };
            return results;
        }

        static string[] GetAnswers()
        {
            string[] answers = new string[]
            {
                "6",
                "9",
                "25",
                "60",
                "2"
            };
            return answers;
        }

        static string GetUserName()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.Clear();

            return name;
        }
        static string GetFilePath()
        {
            return @"D:\files_csharp\db.txt";
        }
    }
}