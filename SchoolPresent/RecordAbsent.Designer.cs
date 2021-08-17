namespace SchoolPresent
{
    partial class RecordAbsent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordAbsent));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnRemoveDays = new System.Windows.Forms.Button();
            this.lbltext1 = new System.Windows.Forms.Label();
            this.numRemoveDays = new System.Windows.Forms.NumericUpDown();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.chkgetEnabled = new System.Windows.Forms.CheckBox();
            this.btnRecording = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.btnAddDays = new System.Windows.Forms.Button();
            this.lbltext = new System.Windows.Forms.Label();
            this.numAddDays = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldaytextP = new System.Windows.Forms.Label();
            this.lblPresentday = new System.Windows.Forms.Label();
            this.lbldaytextA = new System.Windows.Forms.Label();
            this.lblAbsentday = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbSearchStudent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(419, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کامل دانش آموز را وارد نمایید:";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStudent.Location = new System.Drawing.Point(12, 41);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(138, 31);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "پیدا کردن";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnRemoveDays
            // 
            this.btnRemoveDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDays.Enabled = false;
            this.btnRemoveDays.ForeColor = System.Drawing.Color.Navy;
            this.btnRemoveDays.Location = new System.Drawing.Point(12, 480);
            this.btnRemoveDays.Name = "btnRemoveDays";
            this.btnRemoveDays.Size = new System.Drawing.Size(138, 31);
            this.btnRemoveDays.TabIndex = 38;
            this.btnRemoveDays.Text = "کم کردن";
            this.btnRemoveDays.UseVisualStyleBackColor = true;
            this.btnRemoveDays.Click += new System.EventHandler(this.btnRemoveDays_Click);
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.BackColor = System.Drawing.Color.Transparent;
            this.lbltext1.Enabled = false;
            this.lbltext1.ForeColor = System.Drawing.Color.Navy;
            this.lbltext1.Location = new System.Drawing.Point(474, 487);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(158, 18);
            this.lbltext1.TabIndex = 39;
            this.lbltext1.Text = "کم کردن روز های غیاب :";
            // 
            // numRemoveDays
            // 
            this.numRemoveDays.BackColor = System.Drawing.Color.White;
            this.numRemoveDays.Enabled = false;
            this.numRemoveDays.ForeColor = System.Drawing.Color.Teal;
            this.numRemoveDays.Location = new System.Drawing.Point(195, 485);
            this.numRemoveDays.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numRemoveDays.Name = "numRemoveDays";
            this.numRemoveDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numRemoveDays.Size = new System.Drawing.Size(223, 26);
            this.numRemoveDays.TabIndex = 37;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSuccess.Location = new System.Drawing.Point(186, 258);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(240, 18);
            this.lblSuccess.TabIndex = 36;
            this.lblSuccess.Text = "غیاب دانش آموز با موفیقت ذخیره شد";
            this.lblSuccess.Visible = false;
            // 
            // chkgetEnabled
            // 
            this.chkgetEnabled.AutoSize = true;
            this.chkgetEnabled.BackColor = System.Drawing.Color.Transparent;
            this.chkgetEnabled.Location = new System.Drawing.Point(385, 370);
            this.chkgetEnabled.Name = "chkgetEnabled";
            this.chkgetEnabled.Size = new System.Drawing.Size(244, 22);
            this.chkgetEnabled.TabIndex = 24;
            this.chkgetEnabled.Text = "اضافه و یا کم کردن روز های غیاب :";
            this.chkgetEnabled.UseVisualStyleBackColor = false;
            this.chkgetEnabled.CheckedChanged += new System.EventHandler(this.chkgetEnabled_CheckedChanged);
            // 
            // btnRecording
            // 
            this.btnRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecording.ImageKey = "images (1).png";
            this.btnRecording.ImageList = this.img;
            this.btnRecording.Location = new System.Drawing.Point(512, 208);
            this.btnRecording.Name = "btnRecording";
            this.btnRecording.Size = new System.Drawing.Size(117, 119);
            this.btnRecording.TabIndex = 22;
            this.tip.SetToolTip(this.btnRecording, "برای ثبت غیاب دانش آموز کلیک کنید");
            this.btnRecording.UseVisualStyleBackColor = true;
            this.btnRecording.Click += new System.EventHandler(this.btnRecording_Click);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "images (1).png");
            // 
            // btnAddDays
            // 
            this.btnAddDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDays.Enabled = false;
            this.btnAddDays.ForeColor = System.Drawing.Color.Navy;
            this.btnAddDays.Location = new System.Drawing.Point(12, 428);
            this.btnAddDays.Name = "btnAddDays";
            this.btnAddDays.Size = new System.Drawing.Size(138, 31);
            this.btnAddDays.TabIndex = 27;
            this.btnAddDays.Text = "اضافه کردن";
            this.btnAddDays.UseVisualStyleBackColor = true;
            this.btnAddDays.Click += new System.EventHandler(this.btnAddDays_Click);
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.BackColor = System.Drawing.Color.Transparent;
            this.lbltext.Enabled = false;
            this.lbltext.ForeColor = System.Drawing.Color.Navy;
            this.lbltext.Location = new System.Drawing.Point(456, 434);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(176, 18);
            this.lbltext.TabIndex = 35;
            this.lbltext.Text = "اضافه کردن روز های غیاب :";
            // 
            // numAddDays
            // 
            this.numAddDays.BackColor = System.Drawing.Color.White;
            this.numAddDays.Enabled = false;
            this.numAddDays.ForeColor = System.Drawing.Color.Teal;
            this.numAddDays.Location = new System.Drawing.Point(195, 432);
            this.numAddDays.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numAddDays.Name = "numAddDays";
            this.numAddDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numAddDays.Size = new System.Drawing.Size(223, 26);
            this.numAddDays.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(171, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "شماره دانش آموزی :";
            // 
            // lbldaytextP
            // 
            this.lbldaytextP.AutoSize = true;
            this.lbldaytextP.BackColor = System.Drawing.Color.Transparent;
            this.lbldaytextP.Location = new System.Drawing.Point(473, 148);
            this.lbldaytextP.Name = "lbldaytextP";
            this.lbldaytextP.Size = new System.Drawing.Size(24, 18);
            this.lbldaytextP.TabIndex = 33;
            this.lbldaytextP.Text = "روز";
            this.lbldaytextP.Visible = false;
            // 
            // lblPresentday
            // 
            this.lblPresentday.AutoSize = true;
            this.lblPresentday.BackColor = System.Drawing.Color.Transparent;
            this.lblPresentday.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPresentday.Location = new System.Drawing.Point(503, 148);
            this.lblPresentday.Name = "lblPresentday";
            this.lblPresentday.Size = new System.Drawing.Size(0, 18);
            this.lblPresentday.TabIndex = 32;
            // 
            // lbldaytextA
            // 
            this.lbldaytextA.AutoSize = true;
            this.lbldaytextA.BackColor = System.Drawing.Color.Transparent;
            this.lbldaytextA.Location = new System.Drawing.Point(156, 148);
            this.lbldaytextA.Name = "lbldaytextA";
            this.lbldaytextA.Size = new System.Drawing.Size(24, 18);
            this.lbldaytextA.TabIndex = 31;
            this.lbldaytextA.Text = "روز";
            this.lbldaytextA.Visible = false;
            // 
            // lblAbsentday
            // 
            this.lblAbsentday.AutoSize = true;
            this.lblAbsentday.BackColor = System.Drawing.Color.Transparent;
            this.lblAbsentday.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAbsentday.Location = new System.Drawing.Point(186, 148);
            this.lblAbsentday.Name = "lblAbsentday";
            this.lblAbsentday.Size = new System.Drawing.Size(0, 18);
            this.lblAbsentday.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(227, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "تعداد غیاب :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(544, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "تعداد حضور :";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStudentName.Location = new System.Drawing.Point(325, 98);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(0, 18);
            this.lblStudentName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(529, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "نام دانش آموز :";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStudentNumber.Location = new System.Drawing.Point(33, 98);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(0, 18);
            this.lblStudentNumber.TabIndex = 40;
            // 
            // tip
            // 
            this.tip.IsBalloon = true;
            this.tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tip.ToolTipTitle = "توضیحات :";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::SchoolPresent.Properties.Resources.go_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 238);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 58);
            this.btnBack.TabIndex = 42;
            this.tip.SetToolTip(this.btnBack, "بازگشت به صفحه اصلی");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbSearchStudent
            // 
            this.cmbSearchStudent.FormattingEnabled = true;
            this.cmbSearchStudent.Location = new System.Drawing.Point(156, 42);
            this.cmbSearchStudent.Name = "cmbSearchStudent";
            this.cmbSearchStudent.Size = new System.Drawing.Size(262, 26);
            this.cmbSearchStudent.TabIndex = 41;
            this.cmbSearchStudent.SelectedIndexChanged += new System.EventHandler(this.cmbSearchStudent_SelectedIndexChanged);
            this.cmbSearchStudent.TextChanged += new System.EventHandler(this.cmbSearchStudent_TextChanged);
            // 
            // RecordAbsent
            // 
            this.AcceptButton = this.btnSearchStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SchoolPresent.Properties.Resources.Pattern_BeautifulUse;
            this.ClientSize = new System.Drawing.Size(639, 531);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbSearchStudent);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.btnRemoveDays);
            this.Controls.Add(this.lbltext1);
            this.Controls.Add(this.numRemoveDays);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.chkgetEnabled);
            this.Controls.Add(this.btnRecording);
            this.Controls.Add(this.btnAddDays);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.numAddDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldaytextP);
            this.Controls.Add(this.lblPresentday);
            this.Controls.Add(this.lbldaytextA);
            this.Controls.Add(this.lblAbsentday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchStudent);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecordAbsent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت غیاب دانش آموز";
            this.Load += new System.EventHandler(this.RecordAbsent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnRemoveDays;
        private System.Windows.Forms.Label lbltext1;
        private System.Windows.Forms.NumericUpDown numRemoveDays;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.CheckBox chkgetEnabled;
        private System.Windows.Forms.Button btnRecording;
        private System.Windows.Forms.Button btnAddDays;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.NumericUpDown numAddDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldaytextP;
        private System.Windows.Forms.Label lblPresentday;
        private System.Windows.Forms.Label lbldaytextA;
        private System.Windows.Forms.Label lblAbsentday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.ImageList img;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.ComboBox cmbSearchStudent;
        private System.Windows.Forms.Button btnBack;
    }
}