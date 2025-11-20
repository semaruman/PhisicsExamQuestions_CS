namespace PEQ_WinFormsApp
{
    partial class MenuForm
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
            menuTitleLabel = new Label();
            firstModeButton = new Button();
            secondModeButton = new Button();
            button1 = new Button();
            deleteLastQuestionButton = new Button();
            GoToProfileButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // menuTitleLabel
            // 
            menuTitleLabel.AutoSize = true;
            menuTitleLabel.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuTitleLabel.Location = new Point(286, 65);
            menuTitleLabel.Name = "menuTitleLabel";
            menuTitleLabel.Size = new Size(247, 39);
            menuTitleLabel.TabIndex = 1;
            menuTitleLabel.Text = "Выберете опцию";
            // 
            // firstModeButton
            // 
            firstModeButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstModeButton.Location = new Point(297, 165);
            firstModeButton.Name = "firstModeButton";
            firstModeButton.Size = new Size(216, 110);
            firstModeButton.TabIndex = 2;
            firstModeButton.Text = "Пройти тест";
            firstModeButton.UseVisualStyleBackColor = true;
            firstModeButton.Click += firstModeButton_Click;
            // 
            // secondModeButton
            // 
            secondModeButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            secondModeButton.Location = new Point(297, 368);
            secondModeButton.Name = "secondModeButton";
            secondModeButton.Size = new Size(200, 110);
            secondModeButton.TabIndex = 3;
            secondModeButton.Text = "Вывести таблицу результатов";
            secondModeButton.UseVisualStyleBackColor = true;
            secondModeButton.Click += secondModeButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(44, 368);
            button1.Name = "button1";
            button1.Size = new Size(200, 110);
            button1.TabIndex = 4;
            button1.Text = "Добавить свой вопрос";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addQuestionButton_Click;
            // 
            // deleteLastQuestionButton
            // 
            deleteLastQuestionButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteLastQuestionButton.Location = new Point(545, 368);
            deleteLastQuestionButton.Name = "deleteLastQuestionButton";
            deleteLastQuestionButton.Size = new Size(200, 110);
            deleteLastQuestionButton.TabIndex = 5;
            deleteLastQuestionButton.Text = "Удалить последний добавленный вопрос";
            deleteLastQuestionButton.UseVisualStyleBackColor = true;
            deleteLastQuestionButton.Click += deleteLastQuestionButton_Click;
            // 
            // GoToProfileButton
            // 
            GoToProfileButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoToProfileButton.Location = new Point(12, 12);
            GoToProfileButton.Name = "GoToProfileButton";
            GoToProfileButton.Size = new Size(126, 59);
            GoToProfileButton.TabIndex = 6;
            GoToProfileButton.Text = "Войти в профиль";
            GoToProfileButton.UseVisualStyleBackColor = true;
            GoToProfileButton.Click += GoToProfileButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(646, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 59);
            exitButton.TabIndex = 7;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(exitButton);
            Controls.Add(GoToProfileButton);
            Controls.Add(deleteLastQuestionButton);
            Controls.Add(button1);
            Controls.Add(secondModeButton);
            Controls.Add(firstModeButton);
            Controls.Add(menuTitleLabel);
            Name = "MenuForm";
            Text = "Тест по физике";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label menuTitleLabel;
        private Button firstModeButton;
        private Button secondModeButton;
        private Button button1;
        private Button deleteLastQuestionButton;
        private Button GoToProfileButton;
        private Button exitButton;
    }
}