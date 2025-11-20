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
    public partial class AddUserQuestionForm : Form
    {
        private bool canExit = false;
        public AddUserQuestionForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            bool con1 = userQuestionContentTitleLabel.Text != "";
            bool con2 = userQuestionContent1TextBox.Text != "";
            bool con3 = userQuestionContent2TextBox.Text != "";
            bool con4 = userQuestionContent3TextBox.Text != "";

            if ((con1 || con2 || con3 || con4) && canExit == false)
            {
                MessageBox.Show("У вас есть несохраненный вопрос!\nПри последующем выходе он не будет сохранен");
                canExit = true;
            }
            else
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                Close();
            }     
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            string content = userQuestionContentTitleLabel.Text;

            content += "\n1 - " + userQuestionContent1TextBox.Text;

            content += "\n2 - " + userQuestionContent2TextBox.Text;

            content += "\n3 - " + userQuestionContent3TextBox.Text;

            string answer = addQuestionAnswerTextBox.Text;

            var questionTable = new DataQuestions(FilePath.GetQuestionsFilePath());
            var questions = questionTable.LoadArray();
            questions.Add(new Question(content, answer));
            questionTable.SaveArray(questions);
            MessageBox.Show("Вопрос добавлен успешно!");

            userQuestionContentTitleLabel.Text = "";
            userQuestionContent1TextBox.Text = "";
            userQuestionContent2TextBox.Text = "";
            userQuestionContent3TextBox.Text = "";
            addQuestionAnswerTextBox.Text = "";
        }
    }
}
