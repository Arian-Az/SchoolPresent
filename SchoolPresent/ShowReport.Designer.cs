namespace SchoolPresent
{
    partial class ShowReport
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTodayAbsent = new System.Windows.Forms.Button();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.pnlTodayAbsent = new System.Windows.Forms.Panel();
            this.lsv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintInfo = new System.Windows.Forms.Button();
            this.btnPrintdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInformations = new System.Windows.Forms.TextBox();
            this.txtAbsentDates = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInfos.SuspendLayout();
            this.pnlTodayAbsent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(344, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "پیدا کردن";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(810, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کامل دانش آموز را وارد نمایید :";
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(444, 21);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(360, 26);
            this.cmbSearch.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::SchoolPresent.Properties.Resources.go_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 58);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTodayAbsent
            // 
            this.btnTodayAbsent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodayAbsent.Location = new System.Drawing.Point(135, 20);
            this.btnTodayAbsent.Name = "btnTodayAbsent";
            this.btnTodayAbsent.Size = new System.Drawing.Size(203, 31);
            this.btnTodayAbsent.TabIndex = 16;
            this.btnTodayAbsent.Text = "غیاب های امروز";
            this.btnTodayAbsent.UseVisualStyleBackColor = true;
            this.btnTodayAbsent.Click += new System.EventHandler(this.btnTodayAbsent_Click);
            // 
            // pnlInfos
            // 
            this.pnlInfos.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfos.Controls.Add(this.btnPrintInfo);
            this.pnlInfos.Controls.Add(this.btnPrintdate);
            this.pnlInfos.Controls.Add(this.label8);
            this.pnlInfos.Controls.Add(this.label7);
            this.pnlInfos.Controls.Add(this.txtInformations);
            this.pnlInfos.Controls.Add(this.txtAbsentDates);
            this.pnlInfos.Controls.Add(this.lblPhoneNumber);
            this.pnlInfos.Controls.Add(this.label6);
            this.pnlInfos.Controls.Add(this.lblNumber);
            this.pnlInfos.Controls.Add(this.label5);
            this.pnlInfos.Controls.Add(this.lblName);
            this.pnlInfos.Controls.Add(this.label2);
            this.pnlInfos.Location = new System.Drawing.Point(12, 69);
            this.pnlInfos.Name = "pnlInfos";
            this.pnlInfos.Size = new System.Drawing.Size(1016, 465);
            this.pnlInfos.TabIndex = 19;
            // 
            // pnlTodayAbsent
            // 
            this.pnlTodayAbsent.BackColor = System.Drawing.Color.Transparent;
            this.pnlTodayAbsent.Controls.Add(this.lsv);
            this.pnlTodayAbsent.Controls.Add(this.label3);
            this.pnlTodayAbsent.Location = new System.Drawing.Point(12, 69);
            this.pnlTodayAbsent.Name = "pnlTodayAbsent";
            this.pnlTodayAbsent.Size = new System.Drawing.Size(1016, 465);
            this.pnlTodayAbsent.TabIndex = 20;
            this.pnlTodayAbsent.Visible = false;
            // 
            // lsv
            // 
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsv.FullRowSelect = true;
            this.lsv.GridLines = true;
            this.lsv.HideSelection = false;
            this.lsv.Location = new System.Drawing.Point(3, 53);
            this.lsv.MultiSelect = false;
            this.lsv.Name = "lsv";
            this.lsv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lsv.RightToLeftLayout = true;
            this.lsv.Scrollable = false;
            this.lsv.Size = new System.Drawing.Size(1007, 409);
            this.lsv.TabIndex = 21;
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "دانش آموز :";
            this.columnHeader1.Width = 285;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "شماره دانش آموزی :";
            this.columnHeader2.Width = 285;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "شماره تلفن والد :";
            this.columnHeader3.Width = 240;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(852, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "لیست غیبت های امروز :";
            // 
            // btnPrintInfo
            // 
            this.btnPrintInfo.Location = new System.Drawing.Point(316, 413);
            this.btnPrintInfo.Name = "btnPrintInfo";
            this.btnPrintInfo.Size = new System.Drawing.Size(184, 35);
            this.btnPrintInfo.TabIndex = 27;
            this.btnPrintInfo.Text = "پرینت گرفتن از مشخصات";
            this.btnPrintInfo.UseVisualStyleBackColor = true;
            this.btnPrintInfo.Click += new System.EventHandler(this.btnPrintInfo_Click);
            // 
            // btnPrintdate
            // 
            this.btnPrintdate.Location = new System.Drawing.Point(832, 413);
            this.btnPrintdate.Name = "btnPrintdate";
            this.btnPrintdate.Size = new System.Drawing.Size(184, 35);
            this.btnPrintdate.TabIndex = 26;
            this.btnPrintdate.Text = "پرینت گرفتن از تاریخ غیاب";
            this.btnPrintdate.UseVisualStyleBackColor = true;
            this.btnPrintdate.Click += new System.EventHandler(this.btnPrintdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(422, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "مشخصات :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(906, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "تاریخ های غیاب :";
            // 
            // txtInformations
            // 
            this.txtInformations.BackColor = System.Drawing.Color.White;
            this.txtInformations.Location = new System.Drawing.Point(0, 114);
            this.txtInformations.Multiline = true;
            this.txtInformations.Name = "txtInformations";
            this.txtInformations.ReadOnly = true;
            this.txtInformations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformations.Size = new System.Drawing.Size(500, 351);
            this.txtInformations.TabIndex = 23;
            // 
            // txtAbsentDates
            // 
            this.txtAbsentDates.BackColor = System.Drawing.Color.White;
            this.txtAbsentDates.Location = new System.Drawing.Point(518, 114);
            this.txtAbsentDates.Multiline = true;
            this.txtAbsentDates.Name = "txtAbsentDates";
            this.txtAbsentDates.ReadOnly = true;
            this.txtAbsentDates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAbsentDates.Size = new System.Drawing.Size(498, 351);
            this.txtAbsentDates.TabIndex = 22;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(157, 15);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(13, 18);
            this.lblPhoneNumber.TabIndex = 21;
            this.lblPhoneNumber.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(273, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "شماره موبایل والد :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumber.Location = new System.Drawing.Point(432, 15);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 18);
            this.lblNumber.TabIndex = 19;
            this.lblNumber.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(585, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "شماره دانش آموزی :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(750, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 18);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(946, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "نام کامل :";
            // 
            // ShowReport
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SchoolPresent.Properties.Resources.Pattern_BeautifulUse;
            this.ClientSize = new System.Drawing.Size(1040, 546);
            this.Controls.Add(this.pnlTodayAbsent);
            this.Controls.Add(this.pnlInfos);
            this.Controls.Add(this.btnTodayAbsent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShowReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آمار گیری";
            this.Load += new System.EventHandler(this.ShowReport_Load);
            this.pnlInfos.ResumeLayout(false);
            this.pnlInfos.PerformLayout();
            this.pnlTodayAbsent.ResumeLayout(false);
            this.pnlTodayAbsent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTodayAbsent;
        private System.Windows.Forms.Panel pnlInfos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAbsentDates;
        private System.Windows.Forms.TextBox txtInformations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrintdate;
        private System.Windows.Forms.Button btnPrintInfo;
        private System.Windows.Forms.Panel pnlTodayAbsent;
        private System.Windows.Forms.ListView lsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}