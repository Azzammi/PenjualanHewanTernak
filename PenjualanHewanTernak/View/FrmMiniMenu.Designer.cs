namespace PenjualanHewanTernak.View
{
    partial class FrmMiniMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jENISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEWANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jENISToolStripMenuItem,
            this.gRADEToolStripMenuItem,
            this.hEWANToolStripMenuItem,
            this.hargaToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // jENISToolStripMenuItem
            // 
            this.jENISToolStripMenuItem.Name = "jENISToolStripMenuItem";
            this.jENISToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jENISToolStripMenuItem.Text = "JENIS";
            this.jENISToolStripMenuItem.Click += new System.EventHandler(this.jENISToolStripMenuItem_Click);
            // 
            // gRADEToolStripMenuItem
            // 
            this.gRADEToolStripMenuItem.Name = "gRADEToolStripMenuItem";
            this.gRADEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gRADEToolStripMenuItem.Text = "GRADE";
            this.gRADEToolStripMenuItem.Click += new System.EventHandler(this.gRADEToolStripMenuItem_Click);
            // 
            // hEWANToolStripMenuItem
            // 
            this.hEWANToolStripMenuItem.Name = "hEWANToolStripMenuItem";
            this.hEWANToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hEWANToolStripMenuItem.Text = "HEWAN";
            this.hEWANToolStripMenuItem.Click += new System.EventHandler(this.hEWANToolStripMenuItem_Click);
            // 
            // hargaToolStripMenuItem
            // 
            this.hargaToolStripMenuItem.Name = "hargaToolStripMenuItem";
            this.hargaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hargaToolStripMenuItem.Text = "Harga";
            this.hargaToolStripMenuItem.Click += new System.EventHandler(this.hargaToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // FrmMiniMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 243);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMiniMenu";
            this.Text = "FrmMiniMenu";
            this.Load += new System.EventHandler(this.FrmMiniMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jENISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRADEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEWANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hargaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}