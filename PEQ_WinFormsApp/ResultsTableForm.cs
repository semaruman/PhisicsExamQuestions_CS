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
            string[] strings = resTable.GetTable().Split('\n');
            for (int i = 0; i < strings.Length; i++)
            {
                string[] str = strings[i].Split("/");
                resultsTableDataGridView.Rows.Add(str);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Close();
        }

        private void tableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
