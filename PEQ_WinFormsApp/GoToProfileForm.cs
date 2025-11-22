using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhisicsExamQuestions.Common;

namespace PEQ_WinFormsApp
{
    public partial class GoToProfileButton : Form
    {
        public GoToProfileButton()
        {
            InitializeComponent();
        }

        private void firstModeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Введите имя пользователя!", "Внимание!");
                return;
            }

            if (userInUsers(userNameTextBox.Text) != null)
            {
                if (userPasswordTextBox.Text == userInUsers(userNameTextBox.Text).Password)
                {
                    Program.user = userInUsers(userNameTextBox.Text);
                    MessageBox.Show($"Добро пожаловать, {Program.user.Name}", "Вход в профиль выполнен успешно");
                    YourProfile form = new YourProfile();
                    form.Show();
                    Close();
                    return;
                }
                else
                {
                    MessageBox.Show($"Неверный пароль!", "Вход в профиль не выполнен");
                    return;
                }
            }
            else
            {
                Program.user = new User(userNameTextBox.Text, userPasswordTextBox.Text);
                UsersData.AddUser(new User(userNameTextBox.Text, userPasswordTextBox.Text));
                MessageBox.Show($"Добро пожаловать, {Program.user.Name}", "Вы успешно зарегистрировались");
                YourProfile form = new YourProfile();
                form.Show();
                Close();
                return;
            }
        }

        private User userInUsers(string userName)
        {
            List<User> users = UsersData.GetUsersList();
            foreach (User user in users)
            {
                if (user.Name == userName)
                {
                    return user;
                }
            }
            return null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Close();
        }
    }
}
