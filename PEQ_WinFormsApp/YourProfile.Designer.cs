namespace PEQ_WinFormsApp
{
    partial class YourProfile
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
            yourProfileTitle = new Label();
            totalAttemtsLabel = new Label();
            theBestScoreLabel = new Label();
            backButton = new Button();
            logoutProfileButton = new Button();
            SuspendLayout();
            // 
            // yourProfileTitle
            // 
            yourProfileTitle.AutoSize = true;
            yourProfileTitle.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yourProfileTitle.Location = new Point(268, 38);
            yourProfileTitle.Name = "yourProfileTitle";
            yourProfileTitle.Size = new Size(265, 39);
            yourProfileTitle.TabIndex = 2;
            yourProfileTitle.Text = "Имя пользователя";
            // 
            // totalAttemtsLabel
            // 
            totalAttemtsLabel.AutoSize = true;
            totalAttemtsLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalAttemtsLabel.Location = new Point(12, 120);
            totalAttemtsLabel.Name = "totalAttemtsLabel";
            totalAttemtsLabel.Size = new Size(136, 23);
            totalAttemtsLabel.TabIndex = 3;
            totalAttemtsLabel.Text = "Всего попыток: ";
            // 
            // theBestScoreLabel
            // 
            theBestScoreLabel.AutoSize = true;
            theBestScoreLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            theBestScoreLabel.Location = new Point(12, 160);
            theBestScoreLabel.Name = "theBestScoreLabel";
            theBestScoreLabel.Size = new Size(192, 23);
            theBestScoreLabel.TabIndex = 4;
            theBestScoreLabel.Text = "Наилучший результат: ";
            // 
            // backButton
            // 
            backButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backButton.Location = new Point(311, 447);
            backButton.Name = "backButton";
            backButton.Size = new Size(126, 59);
            backButton.TabIndex = 8;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // logoutProfileButton
            // 
            logoutProfileButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logoutProfileButton.Location = new Point(611, 511);
            logoutProfileButton.Name = "logoutProfileButton";
            logoutProfileButton.Size = new Size(161, 38);
            logoutProfileButton.TabIndex = 9;
            logoutProfileButton.Text = "Выйти из профиля";
            logoutProfileButton.UseVisualStyleBackColor = true;
            logoutProfileButton.Click += logoutProfileButton_Click;
            // 
            // YourProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(logoutProfileButton);
            Controls.Add(backButton);
            Controls.Add(theBestScoreLabel);
            Controls.Add(totalAttemtsLabel);
            Controls.Add(yourProfileTitle);
            Name = "YourProfile";
            Text = "YourProfile";
            Load += YourProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label yourProfileTitle;
        private Label totalAttemtsLabel;
        private Label theBestScoreLabel;
        private Button backButton;
        private Button logoutProfileButton;
    }
}