using System;
using System.IO;
using PhisicsExamQuestions.Common;

namespace PhisicsExamQuestionsConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = UserInit();
            ResultsTable table = new ResultsTable(FilePath.GetResultsFilePath());
            DataQuestions questionsTable = new DataQuestions(FilePath.GetQuestionsFilePath());
            List<Question> questions = questionsTable.LoadArray();
            Test test = new Test(questions, table, user);

            string menuValue;
            while (true)
            {
                Console.WriteLine("\tВыберете опцию");
                Console.WriteLine("1 - пройти тест");
                Console.WriteLine("2 - вывести таблицу результатов");
                Console.WriteLine("3 - добавить свой вопрос");
                Console.WriteLine("4 - удалить последний вопрос");
                Console.WriteLine("0 - выход из программы");
                menuValue = Console.ReadLine();

                if (menuValue == "1")
                {
                    Console.Clear();
                    test.Take();
                    questions = questionsTable.LoadArray();
                    test.Questions = questions;
                    Console.Clear();
                }
                else if (menuValue == "2")
                {
                    Console.Clear();
                    table.PrintTable();
                }
                else if (menuValue == "3")
                {
                    Console.Clear();
                    AddUserQuestion(questions);
                    questionsTable.SaveArray(questions);
                    Console.Clear();
                }
                else if (menuValue == "4")
                {
                    Console.Clear();
                    questions.RemoveAt(questions.Count - 1);
                    questionsTable.SaveArray(questions);
                    Console.WriteLine("Вопрос успешно удалён!");
                    Console.ReadLine();
                    Console.Clear();
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
        
        /*
        // Сначала все вопросы писал здессь. 
        // Потом сделал возможность добавлять вопросы во время выполнения программы.
        // Все вопросы находятся в базе данных формата json (questions.json)
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
        */

        static User UserInit()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.Clear();

            return new User(name, "1");
        }

        static void AddUserQuestion(List<Question> questions)
        {
            Console.WriteLine("Введите содержимое вопроса:");
            string content = Console.ReadLine();

            Console.WriteLine("Введите 1-ый вариант ответа:");
            content += "\n1 - " + Console.ReadLine();

            Console.WriteLine("Введите 2-ый вариант ответа:");
            content += "\n2 - " + Console.ReadLine();

            Console.WriteLine("Введите 3-ый вариант ответа:");
            content += "\n3 - " + Console.ReadLine();

            Console.WriteLine("Введите правильный ответ на вопрос:");
            string answer = Console.ReadLine();

            questions.Add(new Question(content, answer));
        }
    }
}