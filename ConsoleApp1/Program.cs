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
                Console.WriteLine($"{userName}, по результатам теста вы {GetResults(trueAnswersCounter, questions.Length)}");

                string content = $"{userName}\t{trueAnswersCounter}\t\t\t\t{GetResults(trueAnswersCounter, questions.Length)}";
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
                // 1 вопрос
                "Что такое диффузия?\n" +
                "1 - явление непрерывного хаотического движения частиц\n" +
                "2 - явление взаимного проникновения веществ друг в друга\n" +
                "3 - мера средней кинетической энергии частиц", 

                // 2 вопрос
                "Что такое Броуновское движение?\n" +
                "1 - мера средней кинетической энергии частиц\n" +
                "2 - результат многочисленных соударений быстро движущихся молекул со стенкой\n" +
                "3 - явление непрерывного хаотического движения частиц",

                // 3 вопрос
                "Как взаимодействуют молекулы в МКТ?\n" +
                "1 - силами притяжения и отталкивания\n" +
                "2 - силой упругости\n" +
                "3 - силой трения",
            };
            return questions;
        }
        static string[] GetAnswers()
        {
            string[] answers = new string[]
            {
                "2",
                "3",
                "1",
            };
            return answers;
        }
        static string GetResults(int trueAnswersCounter, int countQuestions)
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