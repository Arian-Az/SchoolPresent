using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolPresent
{
    public partial class ShowReport : Form
    {
        string stName = "درحافظه موجود نیست",
            stNumber = "درحافظه موجود نیست",
            stPhoneNumber = "درحافظه موجود نیست",
            stAbsentCount = "درحافظه موجود نیست",
            stPresentCount = "درحافظه موجود نیست";
        PrintDocument document1 = new PrintDocument();
        PrintDocument document2 = new PrintDocument();
        PrintDialog dlgPrint1 = new PrintDialog();
        PrintDialog dlgPrint2 = new PrintDialog();
        public ShowReport()
        {
            InitializeComponent();
            document1.PrintPage += new PrintPageEventHandler(document_PrintPage1);
            document1.PrintPage += new PrintPageEventHandler(document_PrintPage2);
        }

        #region Print to Text Boxes

        // Get print event for btn print dates
        void document_PrintPage1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtAbsentDates.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 14, 14);
        }

        // Get print event for btn Informations
        void document_PrintPage2(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtInformations.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 14, 14);
        }

        // btn print dates
        private void btnPrintdate_Click(object sender, EventArgs e)
        {
            dlgPrint1.Document = document1;
            if (dlgPrint1.ShowDialog() == DialogResult.OK)
            {
                document1.Print();
            }
        }

        // btn print Info
        private void btnPrintInfo_Click(object sender, EventArgs e)
        {
            dlgPrint2.Document = document2;
            if (dlgPrint2.ShowDialog() == DialogResult.OK)
            {
                document2.Print();
            }
        }

        #endregion

        private void ShowReport_Load(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(@"data\stname").Select(Path.GetFileName).ToArray();
            foreach (var item in files)
            {
                string items = item.Replace(".txt", "");
                cmbSearch.Items.Add(items);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnTodayAbsent.Text == "بازگشت به حالت گزارش گیری")
            {
                pnlTodayAbsent.Visible = false;
                btnTodayAbsent.Text = "غیاب های امروز";
                btnTodayAbsent.ForeColor = Color.Black;
            }   
            // finding Student
            if (cmbSearch.Text != "")
            {
                if (File.Exists(@"data\stname\" + cmbSearch.Text + ".txt"))
                {

                    #region finding Students

                    stName = File.ReadAllText(@"data\stname\" + cmbSearch.Text + ".txt");
                    lblName.Text = stName;

                    //
                    if (File.Exists(@"data\stnumber\" + stName + "Number" + ".txt"))
                    {
                        stNumber = File.ReadAllText(@"data\stnumber\" + stName + "Number" + ".txt");
                        lblNumber.Text = stNumber;
                    }

                    //
                    if (File.Exists(@"data\phone number\" + stName + ".txt"))
                    {
                        stPhoneNumber = File.ReadAllText(@"data\phone number\" + stName + ".txt");
                        lblPhoneNumber.Text = stPhoneNumber;
                    }
                    #endregion  


                    #region Compeleting Informations TextBoxes
                    //Compeleting Informations TextBoxes
                    // txt Absent Dates
                    txtAbsentDates.Clear();
                    txtInformations.Clear();
                    if (Directory.Exists(@"data\stdate\" + stName + "date"))
                    {
                        var files = Directory.GetFiles(@"data\stdate\" + stName + "date").Select(Path.GetFileName).ToArray();
                        foreach (var file in files)
                        {
                            var date = file.Replace(".txt", "");
                            txtAbsentDates.Text += date + Environment.NewLine + Environment.NewLine;
                        }
                    }
                    // txt Informations
                    if (File.Exists(@"data\absent\" + stName + "absent" + ".txt"))
                    {
                        stAbsentCount = File.ReadAllText(@"data\absent\" + stName + "absent" + ".txt");
                    }
                    if (File.Exists(@"data\present\" + stName + "present" + ".txt"))
                    {
                        stPresentCount = File.ReadAllText(@"data\present\" + stName + "present" + ".txt");
                    }
                    txtInformations.Text = "نام و نام خانوادگی:  " + stName + Environment.NewLine + Environment.NewLine +
                                           "شماره دانش آموزی:  " + stNumber + Environment.NewLine + Environment.NewLine +
                                           "شماره والد:  " + stPhoneNumber + Environment.NewLine + Environment.NewLine +
                                           "تعداد روز غیاب:  " + stAbsentCount + Environment.NewLine + Environment.NewLine +
                                           "تعداد روز حضور:  " + stPresentCount + Environment.NewLine + Environment.NewLine;


                    #endregion

                }
                else
                    MessageBox.Show("این دانش آموز در حافظه موجود نیست!");

            }
            else
                MessageBox.Show("لطفا نام کامل دانش آموز را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
           

        }

        private void btnTodayAbsent_Click(object sender, EventArgs e)
        {
            if (btnTodayAbsent.Text == "بازگشت به حالت گزارش گیری")
            {
                pnlTodayAbsent.Visible = false;
                btnTodayAbsent.Text = "غیاب های امروز";
                btnTodayAbsent.ForeColor = Color.Black;
                return;
            }
            var path = @"data\todayabsent\";
            bool isEmpty = !Directory.EnumerateFiles(path).Any();
            if (isEmpty)
                MessageBox.Show("برای امروز غیبتی ثبت نشده است!", "پیام", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                pnlTodayAbsent.Visible = true;
                lsv.Items.Clear();
                var files = Directory.GetFiles(@"data\todayabsent").Select(Path.GetFileName).ToArray();
                foreach (var todayfile in files)
                {
                    var tdfile = File.ReadAllText(@"data\todayabsent\" + todayfile);
                    var lsvItems = lsv.Items.Add(tdfile);

                    if (File.Exists(@"data\stnumber\" + tdfile + "Number" + ".txt"))
                    {
                        var stnum = File.ReadAllText(@"data\stnumber\" + tdfile + "Number" + ".txt");
                        lsvItems.SubItems.Add(stnum);
                    }
                    else lsvItems.SubItems.Add("در حافظه موجود نیست!");

                    if (File.Exists(@"data\phone number\" + tdfile + ".txt"))
                    {
                        var phone = File.ReadAllText(@"data\phone number\" + tdfile + ".txt");
                        lsvItems.SubItems.Add(phone);
                    }
                    else lsvItems.SubItems.Add("در حافظه موجود نیست!");
                    btnTodayAbsent.Text = "بازگشت به حالت گزارش گیری";
                    btnTodayAbsent.ForeColor = Color.Red;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnTodayAbsent.Text == "بازگشت به حالت گزارش گیری")
            {
                pnlTodayAbsent.Visible = false;
                btnTodayAbsent.Text = "غیاب های امروز";
                btnTodayAbsent.ForeColor = Color.Black;
            }
            else
            {
                Close();
            }
        }

    }
}
