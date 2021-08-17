namespace SchoolPresent
{
    partial class RemoveSt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveSt));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblResualt = new System.Windows.Forms.Label();
            this.txtShowReport = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.lblSuccess = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(459, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کامل دانش آموز را وارد کنید:";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.ImageKey = "Search.jpg";
            this.btnSearch.Location = new System.Drawing.Point(12, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "پیدا کردن";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.BackColor = System.Drawing.Color.Transparent;
            this.lblNS.Location = new System.Drawing.Point(568, 138);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(98, 18);
            this.lblNS.TabIndex = 3;
            this.lblNS.Text = "نام دانش آموز:";
            // 
            // lblResualt
            // 
            this.lblResualt.AutoSize = true;
            this.lblResualt.BackColor = System.Drawing.Color.Transparent;
            this.lblResualt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResualt.Location = new System.Drawing.Point(363, 138);
            this.lblResualt.Name = "lblResualt";
            this.lblResualt.Size = new System.Drawing.Size(64, 18);
            this.lblResualt.TabIndex = 4;
            this.lblResualt.Text = "_______";
            // 
            // txtShowReport
            // 
            this.txtShowReport.BackColor = System.Drawing.Color.White;
            this.txtShowReport.Enabled = false;
            this.txtShowReport.Location = new System.Drawing.Point(12, 181);
            this.txtShowReport.Multiline = true;
            this.txtShowReport.Name = "txtShowReport";
            this.txtShowReport.ReadOnly = true;
            this.txtShowReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowReport.Size = new System.Drawing.Size(651, 317);
            this.txtShowReport.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Enabled = false;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.ImageKey = "Remove.jpg";
            this.btnRemove.ImageList = this.img;
            this.btnRemove.Location = new System.Drawing.Point(512, 447);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(151, 74);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "حذف کردن";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "Remove.jpg");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(269, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "راهنمای این قسمت";
            this.tip.SetToolTip(this.label2, "برای دیدن راهنمای حذف دانش آموز این قسمت را کلیک کنید");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tip
            // 
            this.tip.IsBalloon = true;
            this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tip.ToolTipTitle = "توضیح:";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSuccess.Location = new System.Drawing.Point(226, 475);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(206, 18);
            this.lblSuccess.TabIndex = 8;
            this.lblSuccess.Text = "دانش آموز با موفقیت حذف شد.";
            this.lblSuccess.Visible = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(138, 55);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(315, 26);
            this.cmbSearch.TabIndex = 9;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            this.cmbSearch.TextChanged += new System.EventHandler(this.cmbSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::SchoolPresent.Properties.Resources.go_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 455);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 58);
            this.btnBack.TabIndex = 10;
            this.tip.SetToolTip(this.btnBack, "بازگشت به صفحه اصلی");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RemoveSt
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SchoolPresent.Properties.Resources.Pattern_BeautifulUse;
            this.ClientSize = new System.Drawing.Size(675, 533);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtShowReport);
            this.Controls.Add(this.lblResualt);
            this.Controls.Add(this.lblNS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RemoveSt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم حذف دانش آموز";
            this.Load += new System.EventHandler(this.RemoveSt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.Label lblResualt;
        private System.Windows.Forms.TextBox txtShowReport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ImageList img;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnBack;
    }
}