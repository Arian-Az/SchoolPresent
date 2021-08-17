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
    public partial class AddNewStudent : Form
    {
        string StSaveNameUrl = "";
        string StSaveNumUr = "";
        string StSavePhoneUrl = "";
        string newpa = "0";
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            #region txt ifs
            if (txtFullName.Text == "")
            {
                MessageBox.Show("لطفا نام کامل دانش آموز را وارد نمایید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Focus();
                return;
            }

            if (txtStudentNumber.Text == "")
            {
                MessageBox.Show("لطفا شماره دانش آموزی را وارد نمایید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentNumber.Focus();
                return;
            }

            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("لطفا شماره تلفن همراه سرپرست دانش آموز را وارد نمایید","پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
                return;
            }

            var phone = txtPhoneNumber.Text;
            var pha = phone.IndexOf("0");

            if(pha != 0) { MessageBox.Show("لطفا قبل از پیشوند شماره همراه صفر را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (txtPhoneNumber.TextLength != txtPhoneNumber.MaxLength)
            { MessageBox.Show("شماره تلفن همراه 11 رقمی است ( صفر قبل از پیشوند نیز حساب مشود ) ، شماره ای که شما وارد کردید 11 رقم نیست لطفا آن را ویرایش کنید و سپس دکمه ثبت را بزنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            #endregion End of txt ifs

            if (txtFullName.Text != "" || txtStudentNumber.Text != "")
            {

                if (File.Exists(@"data\stname\" + txtFullName.Text + ".txt") != true)
                {
                    if (File.Exists(@"data\numbers\" + txtStudentNumber.Text + ".txt") != true)
                    {
                        StSavePhoneUrl = txtPhoneNumber.Text;
                        if (File.Exists(@"data\saver\phone\" + StSavePhoneUrl + ".txt") != true)
                        {
                            StSaveNameUrl = txtFullName.Text;
                            StSaveNumUr = txtStudentNumber.Text;
                            StSavePhoneUrl = txtPhoneNumber.Text;
                            File.WriteAllText(@"data\stname\" + StSaveNameUrl + ".txt", StSaveNameUrl);
                            File.WriteAllText(@"data\stnumber\" + StSaveNameUrl + "Number" + ".txt", StSaveNumUr);
                            File.WriteAllText(@"data\absent\" + StSaveNameUrl + "absent" + ".txt", newpa);
                            File.WriteAllText(@"data\present\" + StSaveNameUrl + "present" + ".txt", newpa);
                            File.WriteAllText(@"data\numbers\" + StSaveNumUr + ".txt", StSaveNumUr);
                            File.WriteAllText(@"data\phone number\" + StSaveNameUrl + ".txt", StSavePhoneUrl);
                            File.WriteAllText(@"data\saver\phone\" + StSavePhoneUrl + ".txt", StSavePhoneUrl);
                        }
                        else { MessageBox.Show("این شماره موبایل قبلا برای دانش آموز دیگری ثبت شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information); txtPhoneNumber.Clear(); txtPhoneNumber.Focus(); return; }
                    }
                    else { MessageBox.Show("این شماره دانش آموزی قبلا برای دانش آموز دیگری ثبت شده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information); txtStudentNumber.Clear(); txtStudentNumber.Focus(); return; }
                }
                else
                {
                    MessageBox.Show("نام این دانش آموز قبلا ثبت شده است.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFullName.Clear();
                    txtStudentNumber.Clear();
                    txtFullName.Focus();
                    return;
                }
               
                lblSeccess.Visible = true;
                txtFullName.Clear();
                txtStudentNumber.Clear();
                txtPhoneNumber.Clear();
                lblSeccess.Visible = true;
                txtFullName.Focus();
            }
           

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            lblSeccess.Visible = false;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                e.KeyChar = '\0';
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
