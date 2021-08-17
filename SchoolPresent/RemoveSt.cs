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
    public partial class RemoveSt : Form
    {
        string StName = "در حافظه موجود نیست", StnameUrl = "در حافظه موجود نیست", StNumberUrl = "در حافظه موجود نیست",
               Stabsent = "در حافظه موجود نیست", Stpresent = "در حافظه موجود نیست", stphone = "در حافظه موجود نیست";
        string NameSt, itemsR;
        Color lblResultColor;

        public RemoveSt()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text != "")
            {
                if (File.Exists(@"data\stname\" + cmbSearch.Text + ".txt") == true)
                {
                    StName = cmbSearch.Text;
                    StnameUrl = File.ReadAllText(@"data\stname\" + StName + ".txt");
                    if (File.Exists(@"data\stnumber\" + StName + "Number" + ".txt") == true)
                    {
                        StNumberUrl = File.ReadAllText(@"data\stnumber\" + StName + "Number" + ".txt");
                    }
                    if(File.Exists(@"data\absent\" + StName + "absent" + ".txt"))
                    {
                        Stabsent = File.ReadAllText(@"data\absent\" + StName + "absent" + ".txt");
                    }
                    if(File.Exists(@"data\present\" + StName + "present" + ".txt"))
                    {
                        Stpresent = File.ReadAllText(@"data\present\" + StName + "present" + ".txt");
                    }
                    // Search student and Showing result
                    lblResualt.ForeColor = lblResultColor;
                    lblResualt.Text = StnameUrl;
                    cmbSearch.Text = "";
                    cmbSearch.Focus();
                    btnRemove.Enabled = true;
                    txtShowReport.Enabled = true;
                    // Show Reports On txtShowReport
                    txtShowReport.Text = "نام کامل :   " + StnameUrl + Environment.NewLine + "-------------" + Environment.NewLine + "شماره دانش آموزی :   " + StNumberUrl +
                    Environment.NewLine + "-------------" + Environment.NewLine + "تعداد روز های غیاب :   " + Stabsent + Environment.NewLine + "-------------" + 
                    Environment.NewLine + "تعداد روز عای حضور :   " + Stpresent;
                }
                else
                    MessageBox.Show("این دانش آموز در حافظه موجود نیست", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("لطفا نام کامل دانش آموز را وارد کنید", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try {
                if (StnameUrl == lblResualt.Text)
                {
                    if (File.Exists(@"data\stname\" + StName + ".txt") == true)
                    {
                        // delete the name data
                        File.Delete(@"data\stname\" + StName + ".txt");
                        StnameUrl = "";

                        // delete number in number's folder
                        if (File.Exists(@"data\numbers\" + StNumberUrl + ".txt"))
                        {
                            File.Delete(@"data\numbers\" + StNumberUrl + ".txt");
                        }

                        // delete st number
                        if (File.Exists(@"data\stnumber\" + StName + "Number" + ".txt"))
                        {
                            File.Delete(@"data\stnumber\" + StName + "Number" + ".txt");
                            StNumberUrl = "";
                        }

                        // delete st absent
                        if (File.Exists(@"data\absent\" + StName + "absent" + ".txt") == true)
                        {
                            File.Delete(@"data\absent\" + StName + "absent" + ".txt");
                        }

                        // delete st present
                        if (File.Exists(@"data\present\" + StName + "present" + ".txt") == true)
                        {
                            File.Delete(@"data\present\" + StName + "present" + ".txt");
                        }

                        //delete today absent
                        if (File.Exists(@"data\todayabsent\" + StName + "todayabsent" + ".txt") == true)
                        {
                            File.Delete(@"data\todayabsent\" + StName + "todayabsent" + ".txt");
                        }

                        //delete phone number
                        if (File.Exists(@"data\phone number\" + StName + ".txt"))
                        {
                            stphone = File.ReadAllText(@"data\phone number\" + StName + ".txt");
                            File.Delete(@"data\phone number\" + StName + ".txt");
                        }

                        //delete phone number in saver\phone's folder
                        if (File.Exists(@"data\saver\phone\" + stphone + ".txt"))
                        {
                            File.Delete(@"data\saver\phone\" + stphone + ".txt");
                        }

                        // delete date of st absents
                        if (Directory.Exists(@"data\stdate\" + StName + "date"))
                        {
                            var files = Directory.GetFiles(@"data\stdate\" + StName + "date").Select(Path.GetFileName).ToArray();
                            foreach (var file in files)
                            {
                                File.Delete(@"data\stdate\" + StName + "date\\" + file);
                            }
                            Directory.Delete(@"data\stdate\" + StName + "date");
                        }

                        // Form Design Codes
                        lblResualt.Text = "_______";
                        txtShowReport.Clear();
                        txtShowReport.Enabled = false;
                        btnRemove.Enabled = false;
                        lblSuccess.Visible = true;
                        cmbSearch.Focus();
                        cmbSearch.Items.Clear();
                        RemoveSt_Load(sender, e);
                    }
                    else
                        MessageBox.Show("این دانش آموز در حافظه وجود ندارد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("خطایی به این دلیل رخ داده: /n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        #region lbl Succcess.Visible = false
        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
        }
        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
        }
        #endregion

        private void RemoveSt_Load(object sender, EventArgs e)
        {
            lblResultColor = lblResualt.ForeColor;
            lblResualt.ForeColor = Color.Black;
            var files = Directory.GetFiles(@"data\stname").Select(Path.GetFileName).ToArray();
            foreach (var item in files)
            {
                string items = item;
                itemsR = items.Replace(".txt", "");
                cmbSearch.Items.Add(itemsR);
                NameSt = itemsR;
            }
        }
    }
}
