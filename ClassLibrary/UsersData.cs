using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PhisicsExamQuestions.Common
{
    public static class UsersData
    {
        private static List<User> Users = new List<User>();

        public static void SaveArray(List<User> array)
        {
            string json = JsonSerializer.Serialize(array);
            File.WriteAllText(FilePath.GetUsersFilePath(), json);
        }
        public static void AddUser(User user)
        {
            Users.Add(user);
            SaveArray(Users);
        }

        public static List<User> GetUsersList()
        {
            if (File.Exists(FilePath.GetUsersFilePath()))
            {
                string json = File.ReadAllText(FilePath.GetUsersFilePath());
                return JsonSerializer.Deserialize<List<User>>(json);
            }
            return new List<User>(); // возвращаем пустой список если файла нет
        }
    }
}
