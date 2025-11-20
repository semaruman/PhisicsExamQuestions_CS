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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void firstModeButton_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            Hide();
        }

        private void secondModeButton_Click(object sender, EventArgs e)
        {
            ResultsTableForm resultsTableForm = new ResultsTableForm();
            resultsTableForm.Show();
            Hide();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            AddUserQuestionForm addUserQuestionForm = new AddUserQuestionForm();
            addUserQuestionForm.Show();
            Hide();
        }

        private void deleteLastQuestionButton_Click(object sender, EventArgs e)
        {
            var questionTable = new DataQuestions(FilePath.GetQuestionsFilePath());
            var questions = questionTable.LoadArray();
            questions.RemoveAt(questions.Count - 1);
            questionTable.SaveArray(questions);
            MessageBox.Show("Последний добавленный вопрос был успешно удалён!");
        }

        private void GoToProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
