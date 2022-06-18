namespace WindowsFormsApp2EMLAKörneği
{
    partial class Form1
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
            this.apartmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dubleksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmanToolStripMenuItem,
            this.villaToolStripMenuItem,
            this.dubleksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apartmanToolStripMenuItem
            // 
            this.apartmanToolStripMenuItem.Name = "apartmanToolStripMenuItem";
            this.apartmanToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.apartmanToolStripMenuItem.Text = "Apartman";
            this.apartmanToolStripMenuItem.Click += new System.EventHandler(this.apartmanToolStripMenuItem_Click);
            // 
            // villaToolStripMenuItem
            // 
            this.villaToolStripMenuItem.Name = "villaToolStripMenuItem";
            this.villaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.villaToolStripMenuItem.Text = "Villa ";
            this.villaToolStripMenuItem.Click += new System.EventHandler(this.villaToolStripMenuItem_Click);
            // 
            // dubleksToolStripMenuItem
            // 
            this.dubleksToolStripMenuItem.Name = "dubleksToolStripMenuItem";
            this.dubleksToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.dubleksToolStripMenuItem.Text = "Dubleks";
            this.dubleksToolStripMenuItem.Click += new System.EventHandler(this.dubleksToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apartmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dubleksToolStripMenuItem;
    }
}

