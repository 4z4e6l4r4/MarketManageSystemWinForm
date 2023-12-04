namespace MarketYönetimSistemi
{
    partial class UserPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MarketTabPage = new System.Windows.Forms.TabPage();
            this.marketDgv = new System.Windows.Forms.DataGridView();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.MarketTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MarketTabPage);
            this.tabControl1.Controls.Add(this.OrdersTabPage);
            this.tabControl1.Location = new System.Drawing.Point(6, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // MarketTabPage
            // 
            this.MarketTabPage.BackColor = System.Drawing.Color.AntiqueWhite;
            this.MarketTabPage.Controls.Add(this.marketDgv);
            this.MarketTabPage.Location = new System.Drawing.Point(4, 25);
            this.MarketTabPage.Name = "MarketTabPage";
            this.MarketTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MarketTabPage.Size = new System.Drawing.Size(777, 404);
            this.MarketTabPage.TabIndex = 0;
            this.MarketTabPage.Text = "Market";
            // 
            // marketDgv
            // 
            this.marketDgv.BackgroundColor = System.Drawing.Color.LightCoral;
            this.marketDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marketDgv.Location = new System.Drawing.Point(23, 31);
            this.marketDgv.Name = "marketDgv";
            this.marketDgv.RowHeadersWidth = 51;
            this.marketDgv.RowTemplate.Height = 24;
            this.marketDgv.Size = new System.Drawing.Size(605, 341);
            this.marketDgv.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.BackColor = System.Drawing.Color.AntiqueWhite;
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(777, 404);
            this.OrdersTabPage.TabIndex = 1;
            this.OrdersTabPage.Text = "Orders";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.MarketTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marketDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MarketTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.DataGridView marketDgv;
    }
}