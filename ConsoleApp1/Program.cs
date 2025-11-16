using System;
using System.IO;

namespace PhisicsExamQuestionsConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Question> questions = GetQuestions();
            User user = UserInit();
            ResultsTable table = new ResultsTable(GetFilePath());
            Test test = new Test(questions, table, user);

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
                    test.Take();
                }
                else if (menuValue == "2")
                {
                    Console.Clear();
                    table.PrintTable();
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
        
        static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>
            {
                // 1 вопрос
                new Question("Что такое диффузия?\n" +
                "1 - явление непрерывного хаотического движения частиц\n" +
                "2 - явление взаимного проникновения веществ друг в друга\n" +
                "3 - мера средней кинетической энергии частиц", "2"),
                

                // 2 вопрос
                new Question("Что такое Броуновское движение?\n" +
                "1 - мера средней кинетической энергии частиц\n" +
                "2 - результат многочисленных соударений быстро движущихся молекул со стенкой\n" +
                "3 - явление непрерывного хаотического движения частиц", "3"),

                // 3 вопрос
                new Question("Как взаимодействуют молекулы в МКТ?\n" +
                "1 - силами притяжения и отталкивания\n" +
                "2 - силой упругости\n" +
                "3 - силой трения", "1")
            };
            return questions;
        }

        static User UserInit()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.Clear();

            return new User(name);
        }
        static string GetFilePath()
        {
            return @"D:\files_csharp\db.txt";
        }
    }
}