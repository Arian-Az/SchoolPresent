using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolPresent
{
    public partial class MainForm : Form
    {
        string date ="";
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetDate()
        {
            #region Geting Name Of Persian Days and Years
            string[] fasl = new string[12];
            fasl[0] = "فروردين";
            fasl[1] = "ارديبهشت";
            fasl[2] = "خرداد";
            fasl[3] = "تير";
            fasl[4] = "مرداد";
            fasl[5] = "شهريور";
            fasl[6] = "مهر";
            fasl[7] = "آبان";
            fasl[8] = "آذر";
            fasl[9] = "دي";
            fasl[10] = "بهمن";
            fasl[11] = "اسفند";
            string[] rooz = new string[7];
            rooz[0] = "شنبه"; rooz[1] = "يکشنبه"; rooz[2] = "دوشنبه"; rooz[3] = "سه شنبه"; rooz[4] = "چهارشنبه"; rooz[5] = "پنج شنبه"; rooz[6] = "جمعه";
            PersianCalendar farsi = new PersianCalendar();
            int year;
            DayOfWeek dd;
            dd = farsi.GetDayOfWeek(DateTime.Now);
            switch (dd.ToString())
            {
                case "Saturday":
                    date = rooz[0].ToString();
                    break;
                case "Sunday":
                    date = rooz[1].ToString();
                    break;
                case "Monday":
                    date = rooz[2].ToString();
                    break;
                case "Tuesday":
                    date = rooz[3].ToString();
                    break;
                case "Wednesday":
                    date = rooz[4].ToString();
                    break;
                case "Thursday":
                    date = rooz[5].ToString();
                    break;
                case "Friday":
                    date = rooz[6].ToString();
                    break;
            }
            year = farsi.GetDayOfMonth(DateTime.Now);
            date += " " + Convert.ToString(year);
            year = farsi.GetMonth(DateTime.Now);
            date += " " + fasl[year - 1];
            year = farsi.GetYear(DateTime.Now);
            date += " " + Convert.ToString(year);
            #endregion
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var ads = new AddNewStudent();
            ads.ShowDialog();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            var rst = new RemoveSt();
            rst.ShowDialog();
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            var recab = new RecordAbsent();
            recab.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var est = new EditStudentInfo();
            est.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var ps = new ProgramSettings();
            ps.ShowDialog();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            var showreport = new ShowReport();
            showreport.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetDate();
            File.WriteAllText(@"data\other data\nowdate\" + date + ".txt", date);
            string lastDate = "";
            var files = Directory.GetFiles(@"data\other data\nowdate\").Select(Path.GetFileName).ToArray();
            foreach (var file in files)
            {
                lastDate = File.ReadAllText(@"data\other data\nowdate\" + file);
            }

            if (lastDate == date)
            {
            }
            else
            {
                Directory.Delete(@"data\todayabsent", true);
                Directory.CreateDirectory(@"data\todayabsent");
                File.Delete(@"data\other data\nowdate\" + lastDate + ".txt");
                File.WriteAllText(@"data\other data\nowdate\" + date + ".txt", date);
            }
            //try
            //{
            //    if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            //    {
            //        WebClient client = new WebClient();
            //        Stream stream = client.OpenRead("http://bayanbox.ir/view/8855031141492125960/new-version.txt");
            //        StreamReader reader = new StreamReader(stream);
            //        string content = reader.ReadToEnd();
            //        if (content != "1")
            //        {
            //         // MessageBox.Show("Test");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(":خطایی به این دلیل رخ داده \n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            var reset = new ResetForm();
            reset.ShowDialog();
        }

        private void lkl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://nanenoghli.blog.ir/page/%D8%AA%D9%85%D8%A7%D8%B3-%D8%A8%D8%A7-%D9%85%D8%A7");
        }
    }
}
