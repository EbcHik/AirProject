namespace AirProject
{
    partial class RegForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.PaswLabel = new System.Windows.Forms.Label();
            this.RegAcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(236, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(427, 102);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(130, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Location = new System.Drawing.Point(236, 157);
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(138, 20);
            this.textBoxlogin.TabIndex = 3;
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.Location = new System.Drawing.Point(427, 157);
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.Size = new System.Drawing.Size(130, 20);
            this.textBoxPassw.TabIndex = 4;
            this.textBoxPassw.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(281, 83);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastNameLable
            // 
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.Location = new System.Drawing.Point(463, 83);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(56, 13);
            this.LastNameLable.TabIndex = 6;
            this.LastNameLable.Text = "Фамилия";
            this.LastNameLable.Click += new System.EventHandler(this.LastNameLable_Click);
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(281, 141);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(38, 13);
            this.LoginLable.TabIndex = 7;
            this.LoginLable.Text = "Логин";
            // 
            // PaswLabel
            // 
            this.PaswLabel.AutoSize = true;
            this.PaswLabel.Location = new System.Drawing.Point(463, 141);
            this.PaswLabel.Name = "PaswLabel";
            this.PaswLabel.Size = new System.Drawing.Size(51, 13);
            this.PaswLabel.TabIndex = 8;
            this.PaswLabel.Text = "  Пароль";
            this.PaswLabel.Click += new System.EventHandler(this.PaswLabel_Click);
            // 
            // RegAcceptButton
            // 
            this.RegAcceptButton.Location = new System.Drawing.Point(295, 214);
            this.RegAcceptButton.Name = "RegAcceptButton";
            this.RegAcceptButton.Size = new System.Drawing.Size(199, 23);
            this.RegAcceptButton.TabIndex = 9;
            this.RegAcceptButton.Text = "Зарегистрироваться";
            this.RegAcceptButton.UseVisualStyleBackColor = true;
            this.RegAcceptButton.Click += new System.EventHandler(this.RegAcceptButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegAcceptButton);
            this.Controls.Add(this.PaswLabel);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.LastNameLable);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBoxPassw);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LastNameLable;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label PaswLabel;
        private System.Windows.Forms.Button RegAcceptButton;
    }
}