namespace PEQ_WinFormsApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionContentLabel = new Label();
            userAnswerTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(317, 407);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(163, 69);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionNumberLabel.Location = new Point(350, 9);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(101, 23);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionContentLabel
            // 
            questionContentLabel.AutoSize = true;
            questionContentLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionContentLabel.Location = new Point(52, 91);
            questionContentLabel.Name = "questionContentLabel";
            questionContentLabel.Size = new Size(153, 23);
            questionContentLabel.TabIndex = 2;
            questionContentLabel.Text = "Текст вопроса №1";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userAnswerTextBox.Location = new Point(350, 316);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(100, 31);
            userAnswerTextBox.TabIndex = 3;
            userAnswerTextBox.TextChanged += userAnswerTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(254, 274);
            label1.Name = "label1";
            label1.Size = new Size(295, 23);
            label1.TabIndex = 4;
            label1.Text = "Введите правильный номер ответа:";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionContentLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Name = "mainForm";
            Text = "Тест по физике";
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionContentLabel;
        private TextBox userAnswerTextBox;
        private Label label1;
    }
}
