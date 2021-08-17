namespace SchoolPresent
{
    partial class ProgramSettings
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.tsmHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.تظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ایمیلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHomePage,
            this.تظیماتToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(670, 28);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // tsmHomePage
            // 
            this.tsmHomePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmHomePage.Name = "tsmHomePage";
            this.tsmHomePage.Size = new System.Drawing.Size(102, 24);
            this.tsmHomePage.Text = "صفحه اصلی";
            this.tsmHomePage.Click += new System.EventHandler(this.tsmHomePage_Click);
            // 
            // تظیماتToolStripMenuItem
            // 
            this.تظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ایمیلToolStripMenuItem});
            this.تظیماتToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.تظیماتToolStripMenuItem.Name = "تظیماتToolStripMenuItem";
            this.تظیماتToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.تظیماتToolStripMenuItem.Text = "تظیمات";
            // 
            // ایمیلToolStripMenuItem
            // 
            this.ایمیلToolStripMenuItem.Name = "ایمیلToolStripMenuItem";
            this.ایمیلToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.ایمیلToolStripMenuItem.Text = "ایمیل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "برای اعمال تنظیمات مورد نظرتان از منوی بالا استفاده نمایید\r\n";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::SchoolPresent.Properties.Resources.go_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(2, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 58);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SchoolPresent.Properties.Resources.Pattern_BeautifulUse;
            this.ClientSize = new System.Drawing.Size(670, 533);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "ProgramSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات برنامه";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsmHomePage;
        private System.Windows.Forms.ToolStripMenuItem تظیماتToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ایمیلToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.Button btnBack;
    }
}