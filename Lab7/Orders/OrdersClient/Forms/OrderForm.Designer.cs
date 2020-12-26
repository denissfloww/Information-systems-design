namespace OrdersClient.Forms
{
    partial class OrderForm
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
            this.tbPerformerOrg = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateOrder = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtOrderCreated = new MetroFramework.Controls.MetroDateTime();
            this.tbCatchGoal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbNumMK = new MetroFramework.Controls.MetroTextBox();
            this.dtMK = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbClientOrg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtCatch = new MetroFramework.Controls.MetroDateTime();
            this.tbClintOrgAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbClinetOrgTel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tbPerformerOrgTel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbPerformerOrgAddress = new MetroFramework.Controls.MetroTextBox();
            this.btnExportOrder = new MetroFramework.Controls.MetroButton();
            this.tbCatchPlace = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnChangePlan = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbNum = new MetroFramework.Controls.MetroTextBox();
            this.btnScan = new MetroFramework.Controls.MetroButton();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tbScan = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // tbPerformerOrg
            // 
            // 
            // 
            // 
            this.tbPerformerOrg.CustomButton.Image = null;
            this.tbPerformerOrg.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbPerformerOrg.CustomButton.Name = "";
            this.tbPerformerOrg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPerformerOrg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPerformerOrg.CustomButton.TabIndex = 1;
            this.tbPerformerOrg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPerformerOrg.CustomButton.UseSelectable = true;
            this.tbPerformerOrg.CustomButton.Visible = false;
            this.tbPerformerOrg.Lines = new string[0];
            this.tbPerformerOrg.Location = new System.Drawing.Point(542, 190);
            this.tbPerformerOrg.MaxLength = 32767;
            this.tbPerformerOrg.Name = "tbPerformerOrg";
            this.tbPerformerOrg.PasswordChar = '\0';
            this.tbPerformerOrg.ReadOnly = true;
            this.tbPerformerOrg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPerformerOrg.SelectedText = "";
            this.tbPerformerOrg.SelectionLength = 0;
            this.tbPerformerOrg.SelectionStart = 0;
            this.tbPerformerOrg.ShortcutsEnabled = true;
            this.tbPerformerOrg.Size = new System.Drawing.Size(200, 23);
            this.tbPerformerOrg.TabIndex = 100;
            this.tbPerformerOrg.UseSelectable = true;
            this.tbPerformerOrg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPerformerOrg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.Color.Coral;
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnUpdateOrder.Location = new System.Drawing.Point(542, 485);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(200, 46);
            this.btnUpdateOrder.TabIndex = 3;
            this.btnUpdateOrder.Text = "Сохранить внесённые изменения";
            this.btnUpdateOrder.UseCustomBackColor = true;
            this.btnUpdateOrder.UseCustomForeColor = true;
            this.btnUpdateOrder.UseSelectable = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(433, 190);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Исполнитель";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(393, 416);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Дата выдачи заказа";
            // 
            // dtOrderCreated
            // 
            this.dtOrderCreated.Enabled = false;
            this.dtOrderCreated.Location = new System.Drawing.Point(542, 412);
            this.dtOrderCreated.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtOrderCreated.Name = "dtOrderCreated";
            this.dtOrderCreated.Size = new System.Drawing.Size(200, 29);
            this.dtOrderCreated.TabIndex = 6;
            // 
            // tbCatchGoal
            // 
            // 
            // 
            // 
            this.tbCatchGoal.CustomButton.Image = null;
            this.tbCatchGoal.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.tbCatchGoal.CustomButton.Name = "";
            this.tbCatchGoal.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.tbCatchGoal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCatchGoal.CustomButton.TabIndex = 1;
            this.tbCatchGoal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCatchGoal.CustomButton.UseSelectable = true;
            this.tbCatchGoal.CustomButton.Visible = false;
            this.tbCatchGoal.Lines = new string[0];
            this.tbCatchGoal.Location = new System.Drawing.Point(542, 347);
            this.tbCatchGoal.MaxLength = 32767;
            this.tbCatchGoal.Multiline = true;
            this.tbCatchGoal.Name = "tbCatchGoal";
            this.tbCatchGoal.PasswordChar = '\0';
            this.tbCatchGoal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCatchGoal.SelectedText = "";
            this.tbCatchGoal.SelectionLength = 0;
            this.tbCatchGoal.SelectionStart = 0;
            this.tbCatchGoal.ShortcutsEnabled = true;
            this.tbCatchGoal.Size = new System.Drawing.Size(200, 46);
            this.tbCatchGoal.TabIndex = 1;
            this.tbCatchGoal.UseSelectable = true;
            this.tbCatchGoal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCatchGoal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(437, 347);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Цель отлова";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(43, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Номер МК";
            // 
            // tbNumMK
            // 
            // 
            // 
            // 
            this.tbNumMK.CustomButton.Image = null;
            this.tbNumMK.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbNumMK.CustomButton.Name = "";
            this.tbNumMK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNumMK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNumMK.CustomButton.TabIndex = 1;
            this.tbNumMK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNumMK.CustomButton.UseSelectable = true;
            this.tbNumMK.CustomButton.Visible = false;
            this.tbNumMK.Lines = new string[0];
            this.tbNumMK.Location = new System.Drawing.Point(136, 123);
            this.tbNumMK.MaxLength = 32767;
            this.tbNumMK.Name = "tbNumMK";
            this.tbNumMK.PasswordChar = '\0';
            this.tbNumMK.ReadOnly = true;
            this.tbNumMK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNumMK.SelectedText = "";
            this.tbNumMK.SelectionLength = 0;
            this.tbNumMK.SelectionStart = 0;
            this.tbNumMK.ShortcutsEnabled = true;
            this.tbNumMK.Size = new System.Drawing.Size(200, 23);
            this.tbNumMK.TabIndex = 100;
            this.tbNumMK.UseSelectable = true;
            this.tbNumMK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNumMK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtMK
            // 
            this.dtMK.Enabled = false;
            this.dtMK.Location = new System.Drawing.Point(542, 117);
            this.dtMK.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtMK.Name = "dtMK";
            this.dtMK.Size = new System.Drawing.Size(200, 29);
            this.dtMK.TabIndex = 101;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(384, 123);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(138, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Дата заключения МК";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(67, 190);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "ОМСУ";
            // 
            // tbClientOrg
            // 
            // 
            // 
            // 
            this.tbClientOrg.CustomButton.Image = null;
            this.tbClientOrg.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbClientOrg.CustomButton.Name = "";
            this.tbClientOrg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbClientOrg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbClientOrg.CustomButton.TabIndex = 1;
            this.tbClientOrg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbClientOrg.CustomButton.UseSelectable = true;
            this.tbClientOrg.CustomButton.Visible = false;
            this.tbClientOrg.Lines = new string[0];
            this.tbClientOrg.Location = new System.Drawing.Point(136, 190);
            this.tbClientOrg.MaxLength = 32767;
            this.tbClientOrg.Name = "tbClientOrg";
            this.tbClientOrg.PasswordChar = '\0';
            this.tbClientOrg.ReadOnly = true;
            this.tbClientOrg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbClientOrg.SelectedText = "";
            this.tbClientOrg.SelectionLength = 0;
            this.tbClientOrg.SelectionStart = 0;
            this.tbClientOrg.ShortcutsEnabled = true;
            this.tbClientOrg.Size = new System.Drawing.Size(200, 23);
            this.tbClientOrg.TabIndex = 100;
            this.tbClientOrg.UseSelectable = true;
            this.tbClientOrg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbClientOrg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(33, 391);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Дата отлова";
            // 
            // dtCatch
            // 
            this.dtCatch.Enabled = false;
            this.dtCatch.Location = new System.Drawing.Point(136, 388);
            this.dtCatch.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtCatch.Name = "dtCatch";
            this.dtCatch.Size = new System.Drawing.Size(200, 29);
            this.dtCatch.TabIndex = 16;
            // 
            // tbClintOrgAddress
            // 
            // 
            // 
            // 
            this.tbClintOrgAddress.CustomButton.Image = null;
            this.tbClintOrgAddress.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbClintOrgAddress.CustomButton.Name = "";
            this.tbClintOrgAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbClintOrgAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbClintOrgAddress.CustomButton.TabIndex = 1;
            this.tbClintOrgAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbClintOrgAddress.CustomButton.UseSelectable = true;
            this.tbClintOrgAddress.CustomButton.Visible = false;
            this.tbClintOrgAddress.Lines = new string[0];
            this.tbClintOrgAddress.Location = new System.Drawing.Point(136, 232);
            this.tbClintOrgAddress.MaxLength = 32767;
            this.tbClintOrgAddress.Name = "tbClintOrgAddress";
            this.tbClintOrgAddress.PasswordChar = '\0';
            this.tbClintOrgAddress.ReadOnly = true;
            this.tbClintOrgAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbClintOrgAddress.SelectedText = "";
            this.tbClintOrgAddress.SelectionLength = 0;
            this.tbClintOrgAddress.SelectionStart = 0;
            this.tbClintOrgAddress.ShortcutsEnabled = true;
            this.tbClintOrgAddress.Size = new System.Drawing.Size(200, 23);
            this.tbClintOrgAddress.TabIndex = 100;
            this.tbClintOrgAddress.UseSelectable = true;
            this.tbClintOrgAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbClintOrgAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(70, 232);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 19);
            this.metroLabel10.TabIndex = 23;
            this.metroLabel10.Text = "Адрес";
            // 
            // tbClinetOrgTel
            // 
            // 
            // 
            // 
            this.tbClinetOrgTel.CustomButton.Image = null;
            this.tbClinetOrgTel.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbClinetOrgTel.CustomButton.Name = "";
            this.tbClinetOrgTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbClinetOrgTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbClinetOrgTel.CustomButton.TabIndex = 1;
            this.tbClinetOrgTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbClinetOrgTel.CustomButton.UseSelectable = true;
            this.tbClinetOrgTel.CustomButton.Visible = false;
            this.tbClinetOrgTel.Lines = new string[0];
            this.tbClinetOrgTel.Location = new System.Drawing.Point(136, 274);
            this.tbClinetOrgTel.MaxLength = 32767;
            this.tbClinetOrgTel.Name = "tbClinetOrgTel";
            this.tbClinetOrgTel.PasswordChar = '\0';
            this.tbClinetOrgTel.ReadOnly = true;
            this.tbClinetOrgTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbClinetOrgTel.SelectedText = "";
            this.tbClinetOrgTel.SelectionLength = 0;
            this.tbClinetOrgTel.SelectionStart = 0;
            this.tbClinetOrgTel.ShortcutsEnabled = true;
            this.tbClinetOrgTel.Size = new System.Drawing.Size(200, 23);
            this.tbClinetOrgTel.TabIndex = 100;
            this.tbClinetOrgTel.UseSelectable = true;
            this.tbClinetOrgTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbClinetOrgTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(54, 274);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(62, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "Телефон";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(460, 274);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 19);
            this.metroLabel12.TabIndex = 31;
            this.metroLabel12.Text = "Телефон";
            // 
            // tbPerformerOrgTel
            // 
            // 
            // 
            // 
            this.tbPerformerOrgTel.CustomButton.Image = null;
            this.tbPerformerOrgTel.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbPerformerOrgTel.CustomButton.Name = "";
            this.tbPerformerOrgTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPerformerOrgTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPerformerOrgTel.CustomButton.TabIndex = 1;
            this.tbPerformerOrgTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPerformerOrgTel.CustomButton.UseSelectable = true;
            this.tbPerformerOrgTel.CustomButton.Visible = false;
            this.tbPerformerOrgTel.Lines = new string[0];
            this.tbPerformerOrgTel.Location = new System.Drawing.Point(542, 274);
            this.tbPerformerOrgTel.MaxLength = 32767;
            this.tbPerformerOrgTel.Name = "tbPerformerOrgTel";
            this.tbPerformerOrgTel.PasswordChar = '\0';
            this.tbPerformerOrgTel.ReadOnly = true;
            this.tbPerformerOrgTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPerformerOrgTel.SelectedText = "";
            this.tbPerformerOrgTel.SelectionLength = 0;
            this.tbPerformerOrgTel.SelectionStart = 0;
            this.tbPerformerOrgTel.ShortcutsEnabled = true;
            this.tbPerformerOrgTel.Size = new System.Drawing.Size(200, 23);
            this.tbPerformerOrgTel.TabIndex = 100;
            this.tbPerformerOrgTel.UseSelectable = true;
            this.tbPerformerOrgTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPerformerOrgTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(476, 232);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(46, 19);
            this.metroLabel13.TabIndex = 29;
            this.metroLabel13.Text = "Адрес";
            // 
            // tbPerformerOrgAddress
            // 
            // 
            // 
            // 
            this.tbPerformerOrgAddress.CustomButton.Image = null;
            this.tbPerformerOrgAddress.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbPerformerOrgAddress.CustomButton.Name = "";
            this.tbPerformerOrgAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPerformerOrgAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPerformerOrgAddress.CustomButton.TabIndex = 1;
            this.tbPerformerOrgAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPerformerOrgAddress.CustomButton.UseSelectable = true;
            this.tbPerformerOrgAddress.CustomButton.Visible = false;
            this.tbPerformerOrgAddress.Lines = new string[0];
            this.tbPerformerOrgAddress.Location = new System.Drawing.Point(542, 232);
            this.tbPerformerOrgAddress.MaxLength = 32767;
            this.tbPerformerOrgAddress.Name = "tbPerformerOrgAddress";
            this.tbPerformerOrgAddress.PasswordChar = '\0';
            this.tbPerformerOrgAddress.ReadOnly = true;
            this.tbPerformerOrgAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPerformerOrgAddress.SelectedText = "";
            this.tbPerformerOrgAddress.SelectionLength = 0;
            this.tbPerformerOrgAddress.SelectionStart = 0;
            this.tbPerformerOrgAddress.ShortcutsEnabled = true;
            this.tbPerformerOrgAddress.Size = new System.Drawing.Size(200, 23);
            this.tbPerformerOrgAddress.TabIndex = 100;
            this.tbPerformerOrgAddress.UseSelectable = true;
            this.tbPerformerOrgAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPerformerOrgAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnExportOrder
            // 
            this.btnExportOrder.Location = new System.Drawing.Point(542, 552);
            this.btnExportOrder.Name = "btnExportOrder";
            this.btnExportOrder.Size = new System.Drawing.Size(200, 23);
            this.btnExportOrder.TabIndex = 32;
            this.btnExportOrder.Text = "Экспортировать заказ-наряд";
            this.btnExportOrder.UseSelectable = true;
            this.btnExportOrder.Click += new System.EventHandler(this.btnExportOrder_Click);
            // 
            // tbCatchPlace
            // 
            // 
            // 
            // 
            this.tbCatchPlace.CustomButton.Image = null;
            this.tbCatchPlace.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbCatchPlace.CustomButton.Name = "";
            this.tbCatchPlace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCatchPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCatchPlace.CustomButton.TabIndex = 1;
            this.tbCatchPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCatchPlace.CustomButton.UseSelectable = true;
            this.tbCatchPlace.CustomButton.Visible = false;
            this.tbCatchPlace.Lines = new string[0];
            this.tbCatchPlace.Location = new System.Drawing.Point(136, 347);
            this.tbCatchPlace.MaxLength = 32767;
            this.tbCatchPlace.Name = "tbCatchPlace";
            this.tbCatchPlace.PasswordChar = '\0';
            this.tbCatchPlace.ReadOnly = true;
            this.tbCatchPlace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCatchPlace.SelectedText = "";
            this.tbCatchPlace.SelectionLength = 0;
            this.tbCatchPlace.SelectionStart = 0;
            this.tbCatchPlace.ShortcutsEnabled = true;
            this.tbCatchPlace.Size = new System.Drawing.Size(200, 23);
            this.tbCatchPlace.TabIndex = 7;
            this.tbCatchPlace.UseSelectable = true;
            this.tbCatchPlace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCatchPlace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 347);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(93, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Место отлова";
            // 
            // btnChangePlan
            // 
            this.btnChangePlan.Location = new System.Drawing.Point(136, 432);
            this.btnChangePlan.Name = "btnChangePlan";
            this.btnChangePlan.Size = new System.Drawing.Size(200, 23);
            this.btnChangePlan.TabIndex = 2;
            this.btnChangePlan.Text = "Изменить место и дату отлова";
            this.btnChangePlan.UseSelectable = true;
            this.btnChangePlan.Click += new System.EventHandler(this.btnChangePlan_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 81);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Номер заказа";
            // 
            // tbNum
            // 
            // 
            // 
            // 
            this.tbNum.CustomButton.Image = null;
            this.tbNum.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbNum.CustomButton.Name = "";
            this.tbNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNum.CustomButton.TabIndex = 1;
            this.tbNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNum.CustomButton.UseSelectable = true;
            this.tbNum.CustomButton.Visible = false;
            this.tbNum.Lines = new string[0];
            this.tbNum.Location = new System.Drawing.Point(136, 81);
            this.tbNum.MaxLength = 32767;
            this.tbNum.Name = "tbNum";
            this.tbNum.PasswordChar = '\0';
            this.tbNum.ReadOnly = true;
            this.tbNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNum.SelectedText = "";
            this.tbNum.SelectionLength = 0;
            this.tbNum.SelectionStart = 0;
            this.tbNum.ShortcutsEnabled = true;
            this.tbNum.Size = new System.Drawing.Size(200, 23);
            this.tbNum.TabIndex = 100;
            this.tbNum.UseSelectable = true;
            this.tbNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(136, 552);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(200, 23);
            this.btnScan.TabIndex = 32;
            this.btnScan.Text = "Загрузить скан-образ";
            this.btnScan.UseSelectable = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(33, 510);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(82, 19);
            this.metroLabel14.TabIndex = 15;
            this.metroLabel14.Text = "Скан-образ";
            // 
            // tbScan
            // 
            // 
            // 
            // 
            this.tbScan.CustomButton.Image = null;
            this.tbScan.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbScan.CustomButton.Name = "";
            this.tbScan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbScan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbScan.CustomButton.TabIndex = 1;
            this.tbScan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbScan.CustomButton.UseSelectable = true;
            this.tbScan.CustomButton.Visible = false;
            this.tbScan.Lines = new string[0];
            this.tbScan.Location = new System.Drawing.Point(136, 510);
            this.tbScan.MaxLength = 32767;
            this.tbScan.Name = "tbScan";
            this.tbScan.PasswordChar = '\0';
            this.tbScan.ReadOnly = true;
            this.tbScan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbScan.SelectedText = "";
            this.tbScan.SelectionLength = 0;
            this.tbScan.SelectionStart = 0;
            this.tbScan.ShortcutsEnabled = true;
            this.tbScan.Size = new System.Drawing.Size(200, 23);
            this.tbScan.TabIndex = 7;
            this.tbScan.UseSelectable = true;
            this.tbScan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbScan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(551, 26);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(32, 32);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner1.TabIndex = 102;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.UseStyleColors = true;
            this.metroProgressSpinner1.Value = 25;
            this.metroProgressSpinner1.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 598);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.btnChangePlan);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnExportOrder);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.tbPerformerOrgTel);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tbPerformerOrgAddress);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.tbClinetOrgTel);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.tbClintOrgAddress);
            this.Controls.Add(this.dtCatch);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tbClientOrg);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dtMK);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tbNumMK);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbScan);
            this.Controls.Add(this.tbCatchPlace);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbCatchGoal);
            this.Controls.Add(this.dtOrderCreated);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.tbPerformerOrg);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Учетная карточка заказ-наряда по план-графику";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbPerformerOrg;
        private MetroFramework.Controls.MetroButton btnUpdateOrder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtOrderCreated;
        private MetroFramework.Controls.MetroTextBox tbCatchGoal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbNumMK;
        private MetroFramework.Controls.MetroDateTime dtMK;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbClientOrg;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dtCatch;
        private MetroFramework.Controls.MetroTextBox tbClintOrgAddress;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox tbClinetOrgTel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox tbPerformerOrgTel;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbPerformerOrgAddress;
        private MetroFramework.Controls.MetroButton btnExportOrder;
        private MetroFramework.Controls.MetroTextBox tbCatchPlace;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnChangePlan;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbNum;
        private MetroFramework.Controls.MetroButton btnScan;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox tbScan;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}