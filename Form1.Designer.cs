namespace AirProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.LoginLable = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EntryButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(195, 98);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(199, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(195, 163);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(199, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(268, 74);
            this.LoginLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(38, 13);
            this.LoginLable.TabIndex = 2;
            this.LoginLable.Text = "Логин";
            this.LoginLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(268, 140);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Пароль";
            // 
            // EntryButton
            // 
            this.EntryButton.Location = new System.Drawing.Point(319, 200);
            this.EntryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(74, 26);
            this.EntryButton.TabIndex = 4;
            this.EntryButton.Text = "Вход";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(195, 200);
            this.RegButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(116, 26);
            this.RegButton.TabIndex = 5;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.Button RegButton;
    }
}

