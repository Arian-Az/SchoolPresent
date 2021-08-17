using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolPresent
{
    public partial class EditStudentInfo : Form
    {
        string NameSt, itemsR, itemsRf, Stnum, StnumFD, Stname, PhoneNumber;

        public EditStudentInfo()
        {
            InitializeComponent();
        }

        private void EditStudentInfo_Load(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(@"data\stname").Select(Path.GetFileName).ToArray();
            foreach (var item in files)
            {
                string items = item;
                itemsR = items.Replace(".txt", "");
                cmbSearchStudent.Items.Add(itemsR);
                NameSt = itemsR;
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (cmbSearchStudent.Text != "")
            {

                if (File.Exists(@"data\stname\" + cmbSearchStudent.Text + ".txt") && File.ReadAllText(@"data\stname\" + cmbSearchStudent.Text + ".txt") == cmbSearchStudent.Text)
                {
                    // database Shows
                    Stname = cmbSearchStudent.Text;
                    lblStFullName.Text = Stname;
                    txtNewFullName.Text = Stname;
                    txtNewFullName.ForeColor = Color.Gray;
                    if (File.Exists(@"data\stnumber\" + Stname + "Number" + ".txt"))
                    {
                        Stnum = File.ReadAllText(@"data\stnumber\" + Stname + "Number" + ".txt");
                        lblStNumber.Text = Stnum;
                        txtNewNumber.Text = Stnum;
                        txtNewNumber.ForeColor = Color.Gray;
                    }
                    if(File.Exists(@"data\phone number\" + Stname + ".txt"))
                    {
                        PhoneNumber = File.ReadAllText(@"data\phone number\" + Stname + ".txt");
                        lblPhoneNumber.Text = PhoneNumber;
                        txtPhoneNumber.Text = PhoneNumber;
                        txtPhoneNumber.ForeColor = Color.Gray;
                    }
                    // enable true / false and other settings
                    lblSuccess.Visible = false;
                    pnlNewInfo.Enabled = true;
                }
                else { MessageBox.Show("این دانش آموز در حافظه موجود نیست!", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else
            { MessageBox.Show("لطفا نام کامل دانش آموز را وارد نمایید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        #region pnl Textboxes Enter an Leave
        // Enter , Leave and KeyPress event of 3 Textboxes in pnl
        private void txtNewFullName_Enter(object sender, EventArgs e)
        {
            if (txtNewFullName.Text == lblStFullName.Text || txtNewFullName.Text == "")
            {
                txtNewFullName.Clear();
                txtNewFullName.ForeColor = Color.Black;
            }
            else
            {
                txtNewFullName.ForeColor = Color.Black;
            }
        }

        private void txtNewNumber_Enter(object sender, EventArgs e)
        {
            if (txtNewNumber.Text == lblStNumber.Text || txtNewNumber.Text == "")
            {
                txtNewNumber.Clear();
                txtNewNumber.ForeColor = Color.Black;
            }
            else
            { txtNewNumber.ForeColor = Color.Black; }
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == lblPhoneNumber.Text || txtPhoneNumber.Text == "")
            {
                txtPhoneNumber.Clear();
                txtPhoneNumber.ForeColor = Color.Black;
            }
            else { txtPhoneNumber.ForeColor = Color.Black; }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                e.KeyChar = '\0';
            }
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {

        }
        // End of Enter , Leave and KeyPress of 3 Textboxes in pnl
        private void txtNewFullName_Leave(object sender, EventArgs e)
        {
            if (txtNewFullName.Text == "" || txtNewFullName.Text == lblStFullName.Text)
            {
                txtNewFullName.ForeColor = Color.Gray;
                txtNewFullName.Text = lblStFullName.Text;
            }
        }

        private void txtNewNumber_Leave(object sender, EventArgs e)
        {
            if (txtNewNumber.Text == "" || txtNewNumber.Text == lblStNumber.Text)
            {
                txtNewNumber.ForeColor = Color.Gray;
                txtNewNumber.Text = lblStNumber.Text;
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "" || txtPhoneNumber.Text==lblPhoneNumber.Text)
            {
                txtNewFullName.ForeColor = Color.Gray;
                txtPhoneNumber.Text = lblPhoneNumber.Text;
            }
        }
        #endregion End of pnl Texboxes Enter and Leave

        private void btnRecordingNew_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.TextLength != txtPhoneNumber.MaxLength) { MessageBox.Show("شماره تلفن همراه 11 رقمی است ( صفر قبل از پیشوند نیز حساب مشود ) ، شماره ای که شما وارد کردید 11 رقم نیست لطفا آن را ویرایش کنید و سپس دکمه ثبت را بزنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); return;}
            if (txtNewFullName.Text != "" && txtNewNumber.Text != "" && txtPhoneNumber.Text != "")
            {
                if (txtNewFullName.Text != lblStFullName.Text || txtNewNumber.Text != lblStNumber.Text || txtPhoneNumber.Text != lblPhoneNumber.Text)
                {
                    // database settings
                    string Name = lblStFullName.Text;
                    int abSaver = int.Parse(File.ReadAllText(@"data\absent\" + Name + "absent" + ".txt"));
                    int peSaver = int.Parse(File.ReadAllText(@"data\present\" + Name + "present" + ".txt"));

                    // name changing
                    if (txtNewFullName.Text != lblStFullName.Text)
                    {
                        var NameSaver = txtNewFullName.Text;
                        if (File.Exists(@"data\stname\" + NameSaver + ".txt") != true)
                        {
                            File.Delete(@"data\stname\" + Stname + ".txt");
                            Stname = txtNewFullName.Text;
                            File.WriteAllText(@"data\stname\" + Stname + ".txt", Stname);
                        }
                        else { MessageBox.Show("دانش آموزی با این اسم و فامیل قبلا ثبت شده است ، اگر دانش آموز دیگری نیز با این اسم وجود دارد میتوانید نام گذاری را به صورت زیر انجام دهید :\n\n" + NameSaver + 1 + "\n" + NameSaver + 2, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    }
                    // present and absent and today absent name changing
                    // absent changing
                    File.Delete(@"data\absent\" + Name + "absent" + ".txt");
                    File.WriteAllText(@"data\absent\" + Stname + "absent" + ".txt", abSaver.ToString());
                    if (File.Exists(@"data\todayabsent\" + Name + "todayabsent" + ".txt"))
                    {
                        File.Delete(@"data\todayabsent\" + Name + "todayabsent" + ".txt");
                        File.WriteAllText(@"data\todayabsent\" + Stname + "todayabsent" + ".txt", Stname);
                    }

                    // present changing
                    File.Delete(@"data\present\" + Name + "present" + ".txt");
                    File.WriteAllText(@"data\present\" + Stname + "present" + ".txt", peSaver.ToString());

                    // number changing in stnumber
                    
                       
                            StnumFD = txtNewNumber.Text;
                            File.Delete(@"data\stnumber\" + Name + "Number" + ".txt");
                            File.WriteAllText(@"data\stnumber\" + Stname + "Number" + ".txt", StnumFD);

                    

                    // numbers' folder
                    if (File.Exists(@"data\numbers\" + Stnum + ".txt"))
                    {
                        File.WriteAllText(@"data\numbers\" + StnumFD + ".txt", StnumFD);
                        File.Delete(@"data\numbers\" + Stnum + ".txt");
                    }

                    // phone number changing
                    

                        
                            if (File.Exists(@"data\phone number\" + Name + ".txt"))
                            {
                                PhoneNumber = txtPhoneNumber.Text;
                        File.Delete(@"data\phone number\" + Name + ".txt");
                        File.WriteAllText(@"data\phone number\" + Stname + ".txt", PhoneNumber);
                            }
                            else { File.WriteAllText(@"data\phone number\" + Stname + ".txt", PhoneNumber); }
                        


                    // chang name of date folder
                    if (Directory.Exists(@"data\stdate" + "\\" + Name + "date"))
                    {
                        if (txtNewFullName.Text != lblStFullName.Text)
                        {
                            string PathNewFolder = System.IO.Path.Combine(@"data\stdate\", Stname + "date");
                            Directory.CreateDirectory(PathNewFolder);
                            var folders = Directory.EnumerateFiles(@"data\stdate\" + Name + "date");

                            foreach (var item in folders)
                            {
                                string items = item;
                                itemsRf = File.ReadAllText(item);
                                File.WriteAllText(@"data\stdate\" + Stname + "date\\" + itemsRf + ".txt", itemsRf);
                            }
                            folders = Directory.EnumerateFiles(@"data\stdate\" + Name + "date");
                            foreach (var item in folders)
                            {
                                File.Delete(item);
                            }
                            Directory.Delete(@"data\stdate\" + Name + "date");
                        }
                    }

                    // other informatinos
                    lblSuccess.Visible = true;
                    lblStFullName.Text = "";
                    lblStNumber.Text = "";
                    lblPhoneNumber.Text = "";
                    txtNewFullName.Clear();
                    txtNewNumber.Clear();
                    txtPhoneNumber.Clear();
                    cmbSearchStudent.Text = "";
                    cmbSearchStudent.Focus();
                    pnlNewInfo.Enabled = false;
                    cmbSearchStudent.Items.Clear();
                    EditStudentInfo_Load(sender, e);
                }
                else { MessageBox.Show("اطلاعات وارد شده همان اطلاعات قبلیست لطفا اطلاعات جدیدی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            }
            else
                MessageBox.Show("نام و یا شماره دانش آموزی جدید را وارد نکرده اید ، در صورتی که مایل هستید هر یک از این دو تغییر نکند همان مشخصه قبلی را وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
