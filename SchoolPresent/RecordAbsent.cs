using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolPresent
{
    public partial class RecordAbsent : Form
    {
        string stName = "", stNum = "", itemsR, MyTimeSaver;
        int getNumberAb, getStAb;


        public RecordAbsent()
        {
            InitializeComponent();
        }

        #region// true / false visible of lblSuccess
        private void cmbSearchStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(  lblSuccess.Visible == true) { lblSuccess.Visible = false; }
        }

        private void cmbSearchStudent_TextChanged(object sender, EventArgs e)
        {
            cmbSearchStudent_SelectedIndexChanged(sender, e);
        }
        #endregion

        private void RecordAbsent_Load(object sender, EventArgs e)
        {
            //student name goes to in cmbSearchStudent.items 
            var files = Directory.GetFiles(@"data\stname").Select(Path.GetFileName).ToArray();
            foreach (var item in files)
            {
                string items = item;
                itemsR = items.Replace(".txt", "");
                cmbSearchStudent.Items.Add(itemsR);
            }
        }
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (cmbSearchStudent.Text != "")
            {
                if (File.Exists("data\\stname\\"+cmbSearchStudent.Text+".txt") == true)
                {
                    stName = File.ReadAllText("data\\stname\\" + cmbSearchStudent.Text + ".txt");
                    if (File.Exists("data\\stnumber\\" + cmbSearchStudent.Text + "Number" + ".txt"))
                    {
                        stNum = File.ReadAllText("data\\stnumber\\" + cmbSearchStudent.Text + "Number" + ".txt");
                        lblStudentNumber.Text = stNum;
                    }
                    if(File.Exists("data\\absent\\" + cmbSearchStudent.Text + "absent" + ".txt"))
                    {
                        int absaver = int.Parse(File.ReadAllText("data\\absent\\" + cmbSearchStudent.Text + "absent" + ".txt"));
                        lblAbsentday.Text = absaver.ToString();
                    }
                    if (File.Exists("data\\present\\" + cmbSearchStudent.Text + "present" + ".txt"))
                    {
                        int pesaver = int.Parse(File.ReadAllText("data\\present\\" + cmbSearchStudent.Text + "present" + ".txt"));
                        lblPresentday.Text = pesaver.ToString();
                    }
                    lblStudentName.Text = stName;
                    //lbl Visible For show
                    lblAbsentday.Visible = true;
                    lblPresentday.Visible = true;
                    lbldaytextP.Visible = true;
                    lbldaytextA.Visible = true;
                }
                else
                    MessageBox.Show("این دانش آموز در حافظه موجود نیست!");

            }
            else
                MessageBox.Show("لطفا نام کامل دانش آموز را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecording_Click(object sender, EventArgs e)
        {
            if(cmbSearchStudent.Text != "" && lblStudentName.Text == "" || cmbSearchStudent.Text != "" && stName!=cmbSearchStudent.Text) { btnSearchStudent_Click(sender, e); return; }

            if (stName != "" && stName == lblStudentName.Text)
            {
                string PathNewFolder = Path.Combine(@"data\stdate\", stName + "date");

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
                        MyTimeSaver = rooz[0].ToString();
                        break;
                    case "Sunday":
                        MyTimeSaver = rooz[1].ToString();
                        break;
                    case "Monday":
                        MyTimeSaver = rooz[2].ToString();
                        break;
                    case "Tuesday":
                        MyTimeSaver = rooz[3].ToString();
                        break;
                    case "Wednesday":
                        MyTimeSaver = rooz[4].ToString();
                        break;
                    case "Thursday":
                        MyTimeSaver = rooz[5].ToString();
                        break;
                    case "Friday":
                        MyTimeSaver = rooz[6].ToString();
                        break;
                }
                year = farsi.GetDayOfMonth(DateTime.Now);
                MyTimeSaver += " " + Convert.ToString(year);
                year = farsi.GetMonth(DateTime.Now);
                MyTimeSaver += " " + fasl[year - 1];
                year = farsi.GetYear(DateTime.Now);
                MyTimeSaver += " " + Convert.ToString(year);
                #endregion

                if (Directory.Exists(@"data\stdate\" + stName + "date") != true)
                {
                    Directory.CreateDirectory(PathNewFolder);
                    File.WriteAllText(@"data\stdate\" + stName + "date" + "\\" + MyTimeSaver + ".txt"  , MyTimeSaver);
                }

                else
                {
                    if (File.Exists(@"data\stdate\" + stName + "date" + "\\" + MyTimeSaver + ".txt") != true)
                    {
                        File.WriteAllText(@"data\stdate\" + stName + "date" + "\\" + MyTimeSaver + ".txt", MyTimeSaver);
                    }
                    else { MessageBox.Show("غیبت امروز این دانش آموز را قبلا ثبت کرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                }

                // recotding absent day number
                getNumberAb = int.Parse(File.ReadAllText(@"data\absent\" + stName + "absent" + ".txt"));
                getNumberAb++;
                File.WriteAllText(@"data\absent\" + stName+ "absent" + ".txt", getNumberAb.ToString());
                File.WriteAllText(@"data\todayabsent\" + stName + "todayabsent" + ".txt", stName);

                // lable visible true/false and clear settings
                cmbSearchStudent.Text = "";
                lblAbsentday.Visible = false;
                lblPresentday.Visible = false;
                lbldaytextP.Visible = false;
                lbldaytextA.Visible = false;
                lblStudentName.Text = "";
                lblStudentNumber.Text = "";
                lblSuccess.Visible = true;
                stName = "";
            }
            else {
                MessageBox.Show("لطفا نام کامل دانش آموز را وارد نمایید و سپس دکمه پیدا کردن را بزنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cmbSearchStudent.Text != "")
                    btnSearchStudent.Focus();
                else
                    cmbSearchStudent.Focus();
            }
        }

        private void chkgetEnabled_CheckedChanged(object sender, EventArgs e)
        {
                if (chkgetEnabled.Checked)
                {
                    lbltext.Enabled = true;
                    lbltext1.Enabled = true;
                    numAddDays.Enabled = true;
                    numRemoveDays.Enabled = true;
                    btnAddDays.Enabled = true;
                    btnRemoveDays.Enabled = true;
                }
                else
                {
                    lbltext.Enabled = false;
                    lbltext1.Enabled = false;
                    numAddDays.Enabled = false;
                    numRemoveDays.Enabled = false;
                    btnAddDays.Enabled = false;
                    btnRemoveDays.Enabled = false;
                }
            }

        // Add dayse from absent days
        private void btnAddDays_Click(object sender, EventArgs e)
        {
            getStAb = int.Parse(numAddDays.Value.ToString());
            if (stName != "")
            {
                if (getStAb != 0)
                {
                    getNumberAb = int.Parse(File.ReadAllText(@"data\absent\" + stName + "absent" + ".txt")) + getStAb;
                    File.WriteAllText(@"data\absent\" + stName + "absent" + ".txt", getNumberAb.ToString());
                    numAddDays.Value = 0;
                    numAddDays.Focus();
                    lblAbsentday.Text = File.ReadAllText(@"data\absent\" + stName + "absent" + ".txt");
                    MessageBox.Show("به روز های غیاب " + "< " + stName + " >" + " < " + getStAb + " >" + " روز اضافه شد");
                }
                else
                { MessageBox.Show("لطفا مقدار روزی که میخواهید اضافه کنید را مشخص کنید مقدار کنونی صفر است! لطفا آن را تغییر دهید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information); numAddDays.Focus(); }
            }
            else { MessageBox.Show("لطفا نام دانش آموز را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        // Remove dayse from absent days
        private void btnRemoveDays_Click(object sender, EventArgs e)
        {
            getStAb = int.Parse(numRemoveDays.Value.ToString());
            if (stName != "")
            {
                if (getStAb != 0)
                {
                    getNumberAb = int.Parse(File.ReadAllText(@"data\absent\" + stName + "absent" + ".txt")) - getStAb;
                    File.WriteAllText(@"data\absent\" + stName + "absent" + ".txt", getNumberAb.ToString());
                    numRemoveDays.Value = 0;
                    numRemoveDays.Focus();
                    lblAbsentday.Text = File.ReadAllText(@"data\absent\" + stName + "absent" + ".txt");
                    MessageBox.Show("از روز های غیاب " + "< " + stName + " >" + " < " + getStAb + " >" + " روز کم شد");
                }
                else
                { MessageBox.Show("لطفا مقدار روزی که میخواهید اضافه کنید را مشخص کنید مقدار کنونی صفر است! لطفا آن را تغییر دهید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information); numAddDays.Focus(); }
            }
            else { MessageBox.Show("لطفا نام دانش آموز را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }    
}
