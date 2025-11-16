using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace PhisicsExamQuestionsConsoleApp
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
    }
}
