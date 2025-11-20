using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace PhisicsExamQuestions.Common
{
    public class DataQuestions
    {
        private string filePath;

        public void SaveArray(List<Question> array)
        {
            string json = JsonSerializer.Serialize(array);
            File.WriteAllText(filePath, json);
        }

        public List<Question> LoadArray()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Question>>(json);
            }
            return new List<Question>(); // возвращаем пустой массив если файла нет
        }
        public DataQuestions(string filePath)
        {
            this.filePath = filePath;
        }
        public DataQuestions()
        {
            this.filePath = @"D:\C#\PRO C#\4. PRO C# ООП на практике ВСЁ САМ\2. Урок 1. Приложение для тестирования пользователей. Начало\2.1 Начинаем разработку\questions.json";
        }
    }
}
