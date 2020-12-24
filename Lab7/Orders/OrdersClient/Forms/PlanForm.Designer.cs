namespace OrdersClient.Forms
{
    partial class PlanForm
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
            this.planGrid = new System.Windows.Forms.DataGridView();
            this.lblPlan = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.planGrid)).BeginInit();
            this.SuspendLayout();
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
            this.planGrid.Location = new System.Drawing.Point(5, 112);
            this.planGrid.MultiSelect = false;
            this.planGrid.Name = "planGrid";
            this.planGrid.ReadOnly = true;
            this.planGrid.RowHeadersVisible = false;
            this.planGrid.Size = new System.Drawing.Size(821, 403);
            this.planGrid.TabIndex = 3;
            this.planGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planGrid_CellClick);
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(361, 74);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(108, 19);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "План-график на";
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 535);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.planGrid);
            this.Name = "PlanForm";
            this.Text = "План-график";
            this.Load += new System.EventHandler(this.PlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView planGrid;
        private MetroFramework.Controls.MetroLabel lblPlan;
    }
}