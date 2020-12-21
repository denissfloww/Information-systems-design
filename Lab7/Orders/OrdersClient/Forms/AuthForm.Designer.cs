namespace OrdersClient
{
    partial class AuthForm
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
            this.lbUserName = new MetroFramework.Controls.MetroLabel();
            this.tbUserName = new MetroFramework.Controls.MetroTextBox();
            this.btnAuth = new MetroFramework.Controls.MetroButton();
            this.lbPassword = new MetroFramework.Controls.MetroLabel();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(96, 91);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(47, 19);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Логин";
            // 
            // tbUserName
            // 
            // 
            // 
            // 
            this.tbUserName.CustomButton.Image = null;
            this.tbUserName.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbUserName.CustomButton.Name = "";
            this.tbUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUserName.CustomButton.TabIndex = 1;
            this.tbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUserName.CustomButton.UseSelectable = true;
            this.tbUserName.CustomButton.Visible = false;
            this.tbUserName.Lines = new string[] {
        "test"};
            this.tbUserName.Location = new System.Drawing.Point(208, 91);
            this.tbUserName.MaxLength = 32767;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.ShortcutsEnabled = true;
            this.tbUserName.Size = new System.Drawing.Size(150, 23);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "test";
            this.tbUserName.UseSelectable = true;
            this.tbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(283, 185);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 23);
            this.btnAuth.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAuth.TabIndex = 2;
            this.btnAuth.Text = "Войти";
            this.btnAuth.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAuth.UseSelectable = true;
            this.btnAuth.UseStyleColors = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(96, 138);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(54, 19);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Пароль";
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[] {
        "1"};
            this.tbPassword.Location = new System.Drawing.Point(208, 138);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(150, 23);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "1";
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserName);
            this.Name = "AuthForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbUserName;
        private MetroFramework.Controls.MetroTextBox tbUserName;
        private MetroFramework.Controls.MetroButton btnAuth;
        private MetroFramework.Controls.MetroLabel lbPassword;
        private MetroFramework.Controls.MetroTextBox tbPassword;
    }
}

