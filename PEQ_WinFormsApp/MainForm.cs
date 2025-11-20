using System;
using PhisicsExamQuestions.Common;
using System.Collections.Generic;
using PhisicsExamQuestions;

namespace PEQ_WinFormsApp
{
    public partial class mainForm : Form
    {
        private List<Question> questions;
        private int questionNumber;
        private int trueAnswersCounter = 0;
        private int questionCounter = 1;
        public User user;
        private ResultsTable resTable = new ResultsTable(FilePath.GetResultsFilePath());

        public mainForm()
        {
            InitializeComponent();
        }
        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var questionTable = new DataQuestions(FilePath.GetQuestionsFilePath());

            user = new User("NoName");
            questions = questionTable.LoadArray();

            ShowNextQuestion();

        }

        private void ShowNextQuestion()
        {
            questionNumber = Test.GetQuestionNumber(questions);
            questionContentLabel.Text = questions[questionNumber].ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (questionCounter == questions.Count)
            {
                user.Result = Test.GetResults(trueAnswersCounter, questions.Count);
                resTable.AddToTable(user, trueAnswersCounter);
                MessageBox.Show($"{user.Name}, по результатам теста вы {user.Result}\nКоличество правильных ответов: {trueAnswersCounter} из {questions.Count}", "Ваш разультат тестирования!");
                MenuForm menu = new MenuForm();
                menu.Show();
                Close();
                return;
            }

            string userAnswer = userAnswerTextBox.Text;
            if (userAnswer == questions[questionNumber].Answer)
            {
                trueAnswersCounter++;
            }
            questions[questionNumber].Content = "-";

            questionNumberLabel.Text = $"Вопрос №{questionCounter + 1}";
            questionCounter++;
            userAnswerTextBox.Text = "";
            ShowNextQuestion();

            
        }
        

        private void userAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
