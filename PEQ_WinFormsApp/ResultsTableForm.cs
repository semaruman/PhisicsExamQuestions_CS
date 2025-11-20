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
    public partial class ResultsTableForm : Form
    {
        public ResultsTableForm()
        {
            InitializeComponent();
        }

        private void ResultsTableForm_Load(object sender, EventArgs e)
        {
            ResultsTable resTable = new ResultsTable(FilePath.GetResultsFilePath());
            resultsTableContentLabel.Text = resTable.GetTable();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Close();
        }
    }
}
