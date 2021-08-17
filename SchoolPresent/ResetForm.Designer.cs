namespace SchoolPresent
{
    partial class ResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.rdbDeleteForNewYear = new System.Windows.Forms.RadioButton();
            this.rdbDeleteAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(59, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "این قسمت معمولا برای شروع سال جدید تحصیلی به کار میرود پس آگاهانه دست به پاک کردن" +
    " اطلاعات بزنید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(226, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "در صورتی بدون آگاهی اطلاعات را پاک کنید سازنده نرم افزار هیچ مسئولیتی ندارد.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-40, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(308, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "پاک کردن اطلاعات";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClear.Location = new System.Drawing.Point(12, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(716, 41);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "پاک کن";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSuccess.Location = new System.Drawing.Point(220, 316);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(338, 18);
            this.lblSuccess.TabIndex = 11;
            this.lblSuccess.Text = "اطلاعات مشخص شده با موفقیت حذف و پاک گردیدند";
            this.lblSuccess.Visible = false;
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.BackColor = System.Drawing.Color.Transparent;
            this.lblWait.Location = new System.Drawing.Point(308, 316);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(250, 18);
            this.lblWait.TabIndex = 12;
            this.lblWait.Text = "در حال حذف کردن لطفا شکیبا باشید...";
            this.lblWait.Visible = false;
            // 
            // rdbDeleteForNewYear
            // 
            this.rdbDeleteForNewYear.AutoSize = true;
            this.rdbDeleteForNewYear.BackColor = System.Drawing.Color.Transparent;
            this.rdbDeleteForNewYear.Checked = true;
            this.rdbDeleteForNewYear.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdbDeleteForNewYear.Location = new System.Drawing.Point(152, 194);
            this.rdbDeleteForNewYear.Name = "rdbDeleteForNewYear";
            this.rdbDeleteForNewYear.Size = new System.Drawing.Size(576, 40);
            this.rdbDeleteForNewYear.TabIndex = 13;
            this.rdbDeleteForNewYear.TabStop = true;
            this.rdbDeleteForNewYear.Text = "نو سازی برای سال جدید ، این گزینه فقط روز ها و تاریخ های غیاب و حضور را پاک میکند" +
    " و\r\n به اطلاعات نام ها، شماره دانش آموزی هاو... صدمه ای وارد نخواهد شد.";
            this.rdbDeleteForNewYear.UseVisualStyleBackColor = false;
            this.rdbDeleteForNewYear.Click += new System.EventHandler(this.rdbDeleteAll_Click);
            // 
            // rdbDeleteAll
            // 
            this.rdbDeleteAll.AutoSize = true;
            this.rdbDeleteAll.BackColor = System.Drawing.Color.Transparent;
            this.rdbDeleteAll.ForeColor = System.Drawing.Color.Crimson;
            this.rdbDeleteAll.Location = new System.Drawing.Point(73, 146);
            this.rdbDeleteAll.Name = "rdbDeleteAll";
            this.rdbDeleteAll.Size = new System.Drawing.Size(655, 22);
            this.rdbDeleteAll.TabIndex = 14;
            this.rdbDeleteAll.Text = "پاک کردن تمامی اطلاعات که شامل اسامی دانش آموزان تاریخ های غیاب و تعداد غیاب و غی" +
    "ره میشود";
            this.rdbDeleteAll.UseVisualStyleBackColor = false;
            this.rdbDeleteAll.Click += new System.EventHandler(this.rdbDeleteAll_Click);
            // 
            // ResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(740, 493);
            this.Controls.Add(this.rdbDeleteAll);
            this.Controls.Add(this.rdbDeleteForNewYear);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResetForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "پاک کردن اطلاعات نرم افزار";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.RadioButton rdbDeleteForNewYear;
        private System.Windows.Forms.RadioButton rdbDeleteAll;
    }
}