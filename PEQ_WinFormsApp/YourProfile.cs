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
    public partial class YourProfile : Form
    {
        public YourProfile()
        {
            InitializeComponent();
        }

        private void YourProfile_Load(object sender, EventArgs e)
        {
            totalAttemtsLabel.Text += $" {Program.user.TotalAttempts}";
            theBestScoreLabel.Text += $" {Program.user.TheBestScore}";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var form = new MenuForm();
            form.Show();
            Close();
        }

        private void logoutProfileButton_Click(object sender, EventArgs e)
        {
            Program.user = new User("Untiled", "");
            var form = new MenuForm();
            form.Show();
            Close();
        }
    }
}
