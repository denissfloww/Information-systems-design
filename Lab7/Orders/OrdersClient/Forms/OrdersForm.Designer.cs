namespace OrdersClient.Forms
{
    partial class OrdersForm
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
            this.tcOrder = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblPlan = new MetroFramework.Controls.MetroLabel();
            this.planGrid = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tcOrder.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tcOrder
            // 
            this.tcOrder.Controls.Add(this.metroTabPage1);
            this.tcOrder.Controls.Add(this.metroTabPage2);
            this.tcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOrder.Location = new System.Drawing.Point(20, 60);
            this.tcOrder.Name = "tcOrder";
            this.tcOrder.SelectedIndex = 0;
            this.tcOrder.Size = new System.Drawing.Size(899, 549);
            this.tcOrder.Style = MetroFramework.MetroColorStyle.Green;
            this.tcOrder.TabIndex = 0;
            this.tcOrder.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblPlan);
            this.metroTabPage1.Controls.Add(this.planGrid);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(891, 507);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "t";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(376, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(108, 19);
            this.lblPlan.TabIndex = 3;
            this.lblPlan.Text = "План-график на";
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // planGrid
            // 
            this.planGrid.AllowUserToAddRows = false;
            this.planGrid.AllowUserToDeleteRows = false;
            this.planGrid.AllowUserToResizeColumns = false;
            this.planGrid.AllowUserToResizeRows = false;
            this.planGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.planGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planGrid.Location = new System.Drawing.Point(-1, 45);
            this.planGrid.MultiSelect = false;
            this.planGrid.Name = "planGrid";
            this.planGrid.ReadOnly = true;
            this.planGrid.RowHeadersVisible = false;
            this.planGrid.Size = new System.Drawing.Size(889, 462);
            this.planGrid.TabIndex = 2;
            this.planGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planGrid_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(891, 507);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 629);
            this.Controls.Add(this.tcOrder);
            this.Name = "OrdersForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Реестр учёта выданных заказ-нарядов";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.tcOrder.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcOrder;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView planGrid;
        private MetroFramework.Controls.MetroLabel lblPlan;
    }
}