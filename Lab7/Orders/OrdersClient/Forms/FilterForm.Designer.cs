namespace OrdersClient.Forms
{
    partial class FilterForm
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
            this.btnApply = new MetroFramework.Controls.MetroButton();
            this.cbField = new MetroFramework.Controls.MetroComboBox();
            this.tbValue = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(259, 151);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(200, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Применить";
            this.btnApply.UseSelectable = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbField
            // 
            this.cbField.FormattingEnabled = true;
            this.cbField.ItemHeight = 23;
            this.cbField.Items.AddRange(new object[] {
            "Номер",
            "Место",
            "Цель",
            "Дата создания",
            "Исполнитель"});
            this.cbField.Location = new System.Drawing.Point(37, 90);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(200, 29);
            this.cbField.TabIndex = 7;
            this.cbField.UseSelectable = true;
            // 
            // tbValue
            // 
            // 
            // 
            // 
            this.tbValue.CustomButton.Image = null;
            this.tbValue.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbValue.CustomButton.Name = "";
            this.tbValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbValue.CustomButton.TabIndex = 1;
            this.tbValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbValue.CustomButton.UseSelectable = true;
            this.tbValue.CustomButton.Visible = false;
            this.tbValue.Lines = new string[0];
            this.tbValue.Location = new System.Drawing.Point(259, 95);
            this.tbValue.MaxLength = 32767;
            this.tbValue.Name = "tbValue";
            this.tbValue.PasswordChar = '\0';
            this.tbValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbValue.SelectedText = "";
            this.tbValue.SelectionLength = 0;
            this.tbValue.SelectionStart = 0;
            this.tbValue.ShortcutsEnabled = true;
            this.tbValue.Size = new System.Drawing.Size(200, 23);
            this.tbValue.TabIndex = 8;
            this.tbValue.UseSelectable = true;
            this.tbValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 257);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.cbField);
            this.Controls.Add(this.btnApply);
            this.Name = "FilterForm";
            this.Text = "Выбирете поле и значение фильтра";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnApply;
        private MetroFramework.Controls.MetroComboBox cbField;
        private MetroFramework.Controls.MetroTextBox tbValue;
    }
}