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
            resultsTableContentLabel = new Label();
            exitButton = new Button();
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
            // resultsTableContentLabel
            // 
            resultsTableContentLabel.AutoSize = true;
            resultsTableContentLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultsTableContentLabel.Location = new Point(164, 111);
            resultsTableContentLabel.Name = "resultsTableContentLabel";
            resultsTableContentLabel.Size = new Size(71, 23);
            resultsTableContentLabel.TabIndex = 1;
            resultsTableContentLabel.Text = "Content";
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
            // ResultsTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(exitButton);
            Controls.Add(resultsTableContentLabel);
            Controls.Add(resultsTableTitleLabel);
            Name = "ResultsTableForm";
            Text = "ResultsTableForm";
            Load += ResultsTableForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultsTableTitleLabel;
        private Label resultsTableContentLabel;
        private Button exitButton;
    }
}