namespace PEQ_WinFormsApp
{
    partial class AddUserQuestionForm
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
            addQuestionButton = new Button();
            exitButton = new Button();
            addQuestionTitleLabel = new Label();
            addQuestionContentLabel1 = new Label();
            userQuestionContentTitleLabel = new TextBox();
            addQuestionContentLabel2 = new Label();
            userQuestionContent1TextBox = new TextBox();
            addQuestionContentLabel3 = new Label();
            userQuestionContent2TextBox = new TextBox();
            addQuestionContentLabel4 = new Label();
            userQuestionContent3TextBox = new TextBox();
            addQuestionAnswerLabel = new Label();
            addQuestionAnswerTextBox = new TextBox();
            SuspendLayout();
            // 
            // addQuestionButton
            // 
            addQuestionButton.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionButton.Location = new Point(197, 457);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(163, 69);
            addQuestionButton.TabIndex = 1;
            addQuestionButton.Text = "Добавить вопрос";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(421, 457);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(163, 69);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // addQuestionTitleLabel
            // 
            addQuestionTitleLabel.AutoSize = true;
            addQuestionTitleLabel.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionTitleLabel.Location = new Point(259, 21);
            addQuestionTitleLabel.Name = "addQuestionTitleLabel";
            addQuestionTitleLabel.Size = new Size(254, 39);
            addQuestionTitleLabel.TabIndex = 3;
            addQuestionTitleLabel.Text = "Заполните анкету";
            // 
            // addQuestionContentLabel1
            // 
            addQuestionContentLabel1.AutoSize = true;
            addQuestionContentLabel1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionContentLabel1.Location = new Point(291, 71);
            addQuestionContentLabel1.Name = "addQuestionContentLabel1";
            addQuestionContentLabel1.Size = new Size(213, 23);
            addQuestionContentLabel1.TabIndex = 4;
            addQuestionContentLabel1.Text = "Заполните текст вопроса:";
            // 
            // userQuestionContentTitleLabel
            // 
            userQuestionContentTitleLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userQuestionContentTitleLabel.Location = new Point(66, 97);
            userQuestionContentTitleLabel.Name = "userQuestionContentTitleLabel";
            userQuestionContentTitleLabel.Size = new Size(655, 31);
            userQuestionContentTitleLabel.TabIndex = 5;
            // 
            // addQuestionContentLabel2
            // 
            addQuestionContentLabel2.AutoSize = true;
            addQuestionContentLabel2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionContentLabel2.Location = new Point(66, 160);
            addQuestionContentLabel2.Name = "addQuestionContentLabel2";
            addQuestionContentLabel2.Size = new Size(246, 23);
            addQuestionContentLabel2.TabIndex = 6;
            addQuestionContentLabel2.Text = "Введите 1-ый вариант ответа:";
            // 
            // userQuestionContent1TextBox
            // 
            userQuestionContent1TextBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userQuestionContent1TextBox.Location = new Point(66, 186);
            userQuestionContent1TextBox.Name = "userQuestionContent1TextBox";
            userQuestionContent1TextBox.Size = new Size(246, 31);
            userQuestionContent1TextBox.TabIndex = 7;
            // 
            // addQuestionContentLabel3
            // 
            addQuestionContentLabel3.AutoSize = true;
            addQuestionContentLabel3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionContentLabel3.Location = new Point(66, 234);
            addQuestionContentLabel3.Name = "addQuestionContentLabel3";
            addQuestionContentLabel3.Size = new Size(246, 23);
            addQuestionContentLabel3.TabIndex = 8;
            addQuestionContentLabel3.Text = "Введите 2-ый вариант ответа:";
            // 
            // userQuestionContent2TextBox
            // 
            userQuestionContent2TextBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userQuestionContent2TextBox.Location = new Point(66, 260);
            userQuestionContent2TextBox.Name = "userQuestionContent2TextBox";
            userQuestionContent2TextBox.Size = new Size(246, 31);
            userQuestionContent2TextBox.TabIndex = 9;
            // 
            // addQuestionContentLabel4
            // 
            addQuestionContentLabel4.AutoSize = true;
            addQuestionContentLabel4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionContentLabel4.Location = new Point(421, 160);
            addQuestionContentLabel4.Name = "addQuestionContentLabel4";
            addQuestionContentLabel4.Size = new Size(246, 23);
            addQuestionContentLabel4.TabIndex = 10;
            addQuestionContentLabel4.Text = "Введите 3-ый вариант ответа:";
            // 
            // userQuestionContent3TextBox
            // 
            userQuestionContent3TextBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userQuestionContent3TextBox.Location = new Point(421, 186);
            userQuestionContent3TextBox.Name = "userQuestionContent3TextBox";
            userQuestionContent3TextBox.Size = new Size(246, 31);
            userQuestionContent3TextBox.TabIndex = 11;
            // 
            // addQuestionAnswerLabel
            // 
            addQuestionAnswerLabel.AutoSize = true;
            addQuestionAnswerLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionAnswerLabel.Location = new Point(197, 343);
            addQuestionAnswerLabel.Name = "addQuestionAnswerLabel";
            addQuestionAnswerLabel.Size = new Size(451, 23);
            addQuestionAnswerLabel.TabIndex = 12;
            addQuestionAnswerLabel.Text = "Введите номер правильного вариант ответа на вопрос:";
            // 
            // addQuestionAnswerTextBox
            // 
            addQuestionAnswerTextBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addQuestionAnswerTextBox.Location = new Point(291, 387);
            addQuestionAnswerTextBox.Name = "addQuestionAnswerTextBox";
            addQuestionAnswerTextBox.Size = new Size(246, 31);
            addQuestionAnswerTextBox.TabIndex = 13;
            // 
            // AddUserQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(addQuestionAnswerTextBox);
            Controls.Add(addQuestionAnswerLabel);
            Controls.Add(userQuestionContent3TextBox);
            Controls.Add(addQuestionContentLabel4);
            Controls.Add(userQuestionContent2TextBox);
            Controls.Add(addQuestionContentLabel3);
            Controls.Add(userQuestionContent1TextBox);
            Controls.Add(addQuestionContentLabel2);
            Controls.Add(userQuestionContentTitleLabel);
            Controls.Add(addQuestionContentLabel1);
            Controls.Add(addQuestionTitleLabel);
            Controls.Add(exitButton);
            Controls.Add(addQuestionButton);
            Name = "AddUserQuestionForm";
            Text = "AddUserQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addQuestionButton;
        private Button exitButton;
        private Label addQuestionTitleLabel;
        private Label addQuestionContentLabel1;
        private TextBox userQuestionContentTitleLabel;
        private Label addQuestionContentLabel2;
        private TextBox userQuestionContent1TextBox;
        private Label addQuestionContentLabel3;
        private TextBox userQuestionContent2TextBox;
        private Label addQuestionContentLabel4;
        private TextBox userQuestionContent3TextBox;
        private Label addQuestionAnswerLabel;
        private TextBox addQuestionAnswerTextBox;
    }
}