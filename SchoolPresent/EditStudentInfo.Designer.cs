namespace SchoolPresent
{
    partial class EditStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentInfo));
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStFullName = new System.Windows.Forms.Label();
            this.lblStNumber = new System.Windows.Forms.Label();
            this.pnlNewInfo = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRecordingNew = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.cmbSearchStudent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlNewInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStudent.Location = new System.Drawing.Point(4, 32);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(119, 31);
            this.btnSearchStudent.TabIndex = 1;
            this.btnSearchStudent.Text = "پیدا کردن";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(390, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کامل دانش آموز را وارد نمایید :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(528, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کامل :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(459, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره دانش آموزی :";
            // 
            // lblStFullName
            // 
            this.lblStFullName.AutoSize = true;
            this.lblStFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblStFullName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStFullName.Location = new System.Drawing.Point(332, 93);
            this.lblStFullName.Name = "lblStFullName";
            this.lblStFullName.Size = new System.Drawing.Size(0, 18);
            this.lblStFullName.TabIndex = 5;
            // 
            // lblStNumber
            // 
            this.lblStNumber.AutoSize = true;
            this.lblStNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblStNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStNumber.Location = new System.Drawing.Point(315, 146);
            this.lblStNumber.Name = "lblStNumber";
            this.lblStNumber.Size = new System.Drawing.Size(0, 18);
            this.lblStNumber.TabIndex = 6;
            // 
            // pnlNewInfo
            // 
            this.pnlNewInfo.BackgroundImage = global::SchoolPresent.Properties.Resources.images;
            this.pnlNewInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewInfo.Controls.Add(this.txtPhoneNumber);
            this.pnlNewInfo.Controls.Add(this.label7);
            this.pnlNewInfo.Controls.Add(this.btnRecordingNew);
            this.pnlNewInfo.Controls.Add(this.txtNewNumber);
            this.pnlNewInfo.Controls.Add(this.label6);
            this.pnlNewInfo.Controls.Add(this.txtNewFullName);
            this.pnlNewInfo.Controls.Add(this.label5);
            this.pnlNewInfo.Controls.Add(this.label4);
            this.pnlNewInfo.Enabled = false;
            this.pnlNewInfo.Location = new System.Drawing.Point(12, 190);
            this.pnlNewInfo.Name = "pnlNewInfo";
            this.pnlNewInfo.Size = new System.Drawing.Size(586, 277);
            this.pnlNewInfo.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(37, 141);
            this.txtPhoneNumber.MaxLength = 11;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(366, 26);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(431, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "شماره موبایل والد :";
            // 
            // btnRecordingNew
            // 
            this.btnRecordingNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordingNew.ImageKey = "images (18).jpg";
            this.btnRecordingNew.ImageList = this.imageList1;
            this.btnRecordingNew.Location = new System.Drawing.Point(232, 184);
            this.btnRecordingNew.Name = "btnRecordingNew";
            this.btnRecordingNew.Size = new System.Drawing.Size(119, 81);
            this.btnRecordingNew.TabIndex = 4;
            this.btnRecordingNew.UseVisualStyleBackColor = true;
            this.btnRecordingNew.Click += new System.EventHandler(this.btnRecordingNew_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images (18).jpg");
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Location = new System.Drawing.Point(37, 95);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(366, 26);
            this.txtNewNumber.TabIndex = 2;
            this.txtNewNumber.Enter += new System.EventHandler(this.txtNewNumber_Enter);
            this.txtNewNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            this.txtNewNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtNewNumber.Leave += new System.EventHandler(this.txtNewNumber_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(433, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "شماره دانش آموز :";
            // 
            // txtNewFullName
            // 
            this.txtNewFullName.Location = new System.Drawing.Point(37, 47);
            this.txtNewFullName.Name = "txtNewFullName";
            this.txtNewFullName.Size = new System.Drawing.Size(366, 26);
            this.txtNewFullName.TabIndex = 1;
            this.txtNewFullName.Enter += new System.EventHandler(this.txtNewFullName_Enter);
            this.txtNewFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            this.txtNewFullName.Leave += new System.EventHandler(this.txtNewFullName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(421, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "نام کامل دانش آموز :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(445, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "فرم ویرایش :";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSuccess.Location = new System.Drawing.Point(126, 111);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(313, 18);
            this.lblSuccess.TabIndex = 19;
            this.lblSuccess.Text = "مشخصات جدید دانش آموز با موفقیت ذخیره شد.";
            this.lblSuccess.Visible = false;
            // 
            // cmbSearchStudent
            // 
            this.cmbSearchStudent.FormattingEnabled = true;
            this.cmbSearchStudent.Location = new System.Drawing.Point(126, 34);
            this.cmbSearchStudent.Name = "cmbSearchStudent";
            this.cmbSearchStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchStudent.Size = new System.Drawing.Size(264, 26);
            this.cmbSearchStudent.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(208, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "تلفن والد :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(86, 146);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(0, 18);
            this.lblPhoneNumber.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::SchoolPresent.Properties.Resources.go_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 93);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 58);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EditStudentInfo
            // 
            this.AcceptButton = this.btnSearchStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SchoolPresent.Properties.Resources.Pattern_BeautifulUse;
            this.ClientSize = new System.Drawing.Size(610, 479);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSearchStudent);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.pnlNewInfo);
            this.Controls.Add(this.lblStNumber);
            this.Controls.Add(this.lblStFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchStudent);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditStudentInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش مشخصات دانش آموز";
            this.Load += new System.EventHandler(this.EditStudentInfo_Load);
            this.pnlNewInfo.ResumeLayout(false);
            this.pnlNewInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStFullName;
        private System.Windows.Forms.Label lblStNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlNewInfo;
        private System.Windows.Forms.Button btnRecordingNew;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblSuccess;
        public System.Windows.Forms.ComboBox cmbSearchStudent;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnBack;
    }
}