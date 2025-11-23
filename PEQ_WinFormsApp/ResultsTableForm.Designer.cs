namespace PEQ_WinFormsApp
{
    partial class ResultsTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultsTableTitleLabel = new Label();
            exitButton = new Button();
            resultsTableDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            trueAnswersCountColumn = new DataGridViewTextBoxColumn();
            readyColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsTableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsTableTitleLabel
            // 
            resultsTableTitleLabel.AutoSize = true;
            resultsTableTitleLabel.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultsTableTitleLabel.Location = new Point(256, 43);
            resultsTableTitleLabel.Name = "resultsTableTitleLabel";
            resultsTableTitleLabel.Size = new Size(295, 39);
            resultsTableTitleLabel.TabIndex = 0;
            resultsTableTitleLabel.Text = "Таблица результатов";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(304, 485);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(143, 64);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resultsTableDataGridView
            // 
            resultsTableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsTableDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, trueAnswersCountColumn, readyColumn });
            resultsTableDataGridView.Location = new Point(226, 116);
            resultsTableDataGridView.Name = "resultsTableDataGridView";
            resultsTableDataGridView.Size = new Size(343, 363);
            resultsTableDataGridView.TabIndex = 3;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Имя";
            NameColumn.Name = "NameColumn";
            // 
            // trueAnswersCountColumn
            // 
            trueAnswersCountColumn.HeaderText = "Кол-во правильных ответов";
            trueAnswersCountColumn.Name = "trueAnswersCountColumn";
            // 
            // readyColumn
            // 
            readyColumn.HeaderText = "Готовность";
            readyColumn.Name = "readyColumn";
            // 
            // ResultsTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(resultsTableDataGridView);
            Controls.Add(exitButton);
            Controls.Add(resultsTableTitleLabel);
            Name = "ResultsTableForm";
            Text = "Таблица результатов";
            Load += ResultsTableForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsTableDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultsTableTitleLabel;
        private Button exitButton;
        private DataGridView resultsTableDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn trueAnswersCountColumn;
        private DataGridViewTextBoxColumn readyColumn;
    }
}