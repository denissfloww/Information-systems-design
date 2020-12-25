namespace OrdersClient.Forms
{
    partial class AddOrderForm
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
            this.tbPlace = new MetroFramework.Controls.MetroTextBox();
            this.lblPlace = new MetroFramework.Controls.MetroLabel();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.lblCatch = new MetroFramework.Controls.MetroLabel();
            this.tbCatch = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.btnPlan = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tbPlace
            // 
            // 
            // 
            // 
            this.tbPlace.CustomButton.Image = null;
            this.tbPlace.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.tbPlace.CustomButton.Name = "";
            this.tbPlace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPlace.CustomButton.TabIndex = 1;
            this.tbPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPlace.CustomButton.UseSelectable = true;
            this.tbPlace.CustomButton.Visible = false;
            this.tbPlace.Enabled = false;
            this.tbPlace.Lines = new string[0];
            this.tbPlace.Location = new System.Drawing.Point(154, 166);
            this.tbPlace.MaxLength = 32767;
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.PasswordChar = '\0';
            this.tbPlace.ReadOnly = true;
            this.tbPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPlace.SelectedText = "";
            this.tbPlace.SelectionLength = 0;
            this.tbPlace.SelectionStart = 0;
            this.tbPlace.ShortcutsEnabled = true;
            this.tbPlace.Size = new System.Drawing.Size(183, 23);
            this.tbPlace.TabIndex = 1;
            this.tbPlace.UseSelectable = true;
            this.tbPlace.Visible = false;
            this.tbPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(65, 166);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(47, 19);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Место";
            this.lblPlace.Visible = false;
            // 
            // dtDate
            // 
            this.dtDate.Enabled = false;
            this.dtDate.Location = new System.Drawing.Point(154, 131);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(183, 29);
            this.dtDate.TabIndex = 3;
            this.dtDate.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCatch
            // 
            this.lblCatch.AutoSize = true;
            this.lblCatch.Location = new System.Drawing.Point(27, 195);
            this.lblCatch.Name = "lblCatch";
            this.lblCatch.Size = new System.Drawing.Size(85, 19);
            this.lblCatch.TabIndex = 5;
            this.lblCatch.Text = "Цель отлова";
            // 
            // tbCatch
            // 
            // 
            // 
            // 
            this.tbCatch.CustomButton.Image = null;
            this.tbCatch.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tbCatch.CustomButton.Name = "";
            this.tbCatch.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.tbCatch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCatch.CustomButton.TabIndex = 1;
            this.tbCatch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCatch.CustomButton.UseSelectable = true;
            this.tbCatch.CustomButton.Visible = false;
            this.tbCatch.Lines = new string[0];
            this.tbCatch.Location = new System.Drawing.Point(154, 195);
            this.tbCatch.MaxLength = 32767;
            this.tbCatch.Multiline = true;
            this.tbCatch.Name = "tbCatch";
            this.tbCatch.PasswordChar = '\0';
            this.tbCatch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCatch.SelectedText = "";
            this.tbCatch.SelectionLength = 0;
            this.tbCatch.SelectionStart = 0;
            this.tbCatch.ShortcutsEnabled = true;
            this.tbCatch.Size = new System.Drawing.Size(183, 61);
            this.tbCatch.TabIndex = 6;
            this.tbCatch.UseSelectable = true;
            this.tbCatch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCatch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(75, 131);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 19);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Дата";
            this.lblDate.Visible = false;
            // 
            // btnPlan
            // 
            this.btnPlan.Location = new System.Drawing.Point(101, 82);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(170, 23);
            this.btnPlan.TabIndex = 8;
            this.btnPlan.Text = "Выбрать дату и место";
            this.btnPlan.UseSelectable = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(373, 120);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbCatch);
            this.Controls.Add(this.lblCatch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.tbPlace);
            this.Name = "AddOrderForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Добавление заказ-наряда";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbPlace;
        private MetroFramework.Controls.MetroLabel lblPlace;
        private MetroFramework.Controls.MetroDateTime dtDate;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel lblCatch;
        private MetroFramework.Controls.MetroTextBox tbCatch;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroButton btnPlan;
    }
}