namespace _0104_01
{
    partial class Admin
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
            this.kullanıcıKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıHaraketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaHaraketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıKaydıToolStripMenuItem,
            this.kullanıcıHaraketleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıKaydıToolStripMenuItem
            // 
            this.kullanıcıKaydıToolStripMenuItem.Name = "kullanıcıKaydıToolStripMenuItem";
            this.kullanıcıKaydıToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.kullanıcıKaydıToolStripMenuItem.Text = "Kullanıcı Kaydı";
            this.kullanıcıKaydıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıKaydıToolStripMenuItem_Click);
            // 
            // kullanıcıHaraketleriToolStripMenuItem
            // 
            this.kullanıcıHaraketleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankaHaraketleriToolStripMenuItem});
            this.kullanıcıHaraketleriToolStripMenuItem.Name = "kullanıcıHaraketleriToolStripMenuItem";
            this.kullanıcıHaraketleriToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.kullanıcıHaraketleriToolStripMenuItem.Text = "Kullanıcı Haraketleri";
            // 
            // bankaHaraketleriToolStripMenuItem
            // 
            this.bankaHaraketleriToolStripMenuItem.Name = "bankaHaraketleriToolStripMenuItem";
            this.bankaHaraketleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bankaHaraketleriToolStripMenuItem.Text = "Banka Haraketleri";
            this.bankaHaraketleriToolStripMenuItem.Click += new System.EventHandler(this.bankaHaraketleriToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıHaraketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaHaraketleriToolStripMenuItem;
    }
}