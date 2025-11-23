namespace PEQ_WinFormsApp
{
    partial class GoToProfileButton
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
            label1 = new Label();
            userNameTextBox = new TextBox();
            label2 = new Label();
            userPasswordTextBox = new TextBox();
            firstModeButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(21, 47);
            label1.Name = "label1";
            label1.Size = new Size(388, 39);
            label1.TabIndex = 2;
            label1.Text = "Введите имя пользователя:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameTextBox.Location = new Point(47, 103);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(362, 31);
            userNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(21, 165);
            label2.Name = "label2";
            label2.Size = new Size(240, 39);
            label2.TabIndex = 5;
            label2.Text = "Введите пароль:";
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userPasswordTextBox.Location = new Point(47, 223);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(362, 31);
            userPasswordTextBox.TabIndex = 6;
            // 
            // firstModeButton
            // 
            firstModeButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstModeButton.Location = new Point(305, 399);
            firstModeButton.Name = "firstModeButton";
            firstModeButton.Size = new Size(159, 69);
            firstModeButton.TabIndex = 7;
            firstModeButton.Text = "Войти в профиль";
            firstModeButton.UseVisualStyleBackColor = true;
            firstModeButton.Click += firstModeButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(646, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 59);
            exitButton.TabIndex = 8;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // GoToProfileButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(exitButton);
            Controls.Add(firstModeButton);
            Controls.Add(userPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Name = "GoToProfileButton";
            Text = "Войти в профиль";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNameTextBox;
        private Label label2;
        private TextBox userPasswordTextBox;
        private Button firstModeButton;
        private Button exitButton;
    }
}