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
    public partial class ResetForm : Form
    {
        public ResetForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblWait.Visible = false;
            lblSuccess.Visible = false;
            DialogResult x =MessageBox.Show("آیا مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
            }
            else
            {
                return;
            }

            if (rdbDeleteForNewYear.Checked == true)
            {
                lblWait.Visible = true;
                if (Directory.Exists(@"data\absent"))
                {
                    // Delete Absent Count
                    var absentPath = @"data\absent\";
                    bool isAbsentEmpty = !Directory.EnumerateFiles(absentPath).Any();
                    if (!isAbsentEmpty)
                    {
                        var files = Directory.GetFiles(@"data\absent").Select(Path.GetFileName).ToArray();
                        foreach (var abCount in files)
                        {
                            File.Delete(@"data\absent\" + abCount);
                        }
                    }

                    //Delete Present Count
                    var presentPath = @"data\present\";
                    bool isPresentEmpty = !Directory.EnumerateFiles(presentPath).Any();
                    if (!isPresentEmpty)
                    {
                        var files = Directory.GetFiles(@"data\present").Select(Path.GetFileName).ToArray();
                        foreach (var prCount in files)
                        {
                            File.Delete(@"data\present\" + prCount);
                        }
                    }

                    //Delete Absent Dates
                    var datePath = @"data\stdate\";
                    bool isDateEmpty = !Directory.EnumerateDirectories(datePath).Any();
                    if (!isDateEmpty)
                    {
                        Directory.Delete(@"data\stdate", true);
                        Directory.CreateDirectory(@"data\stdate");
                    }
                    lblWait.Visible = false;
                    lblSuccess.Visible = true;
                }
            }
            else if(rdbDeleteAll.Checked == true)
            {
                lblWait.Visible = true;
                if (Directory.Exists(@"data\absent"))
                {
                    Directory.Delete(@"data\absent", true);
                    Directory.CreateDirectory(@"data\absent");
                }
                if (Directory.Exists(@"data\numbers"))
                {
                    Directory.Delete(@"data\numbers", true);
                    Directory.CreateDirectory(@"data\numbers");
                }
                if (Directory.Exists(@"data\phone number"))
                {
                    Directory.Delete(@"data\phone number", true);
                    Directory.CreateDirectory(@"data\phone number");
                }
                if (Directory.Exists(@"data\present"))
                {
                    Directory.Delete(@"data\present", true);
                    Directory.CreateDirectory(@"data\present");
                }
                if (Directory.Exists(@"data\phone number"))
                {
                    Directory.Delete(@"data\saver\phone", true);
                    Directory.CreateDirectory(@"data\saver\phone");
                }
                if (Directory.Exists(@"data\stdate"))
                {
                    Directory.Delete(@"data\stdate", true);
                    Directory.CreateDirectory(@"data\stdate");
                }
                if (Directory.Exists(@"data\stname"))
                {
                    Directory.Delete(@"data\stname", true);
                    Directory.CreateDirectory(@"data\stname");
                }
                if (Directory.Exists(@"data\stnumber"))
                {
                    Directory.Delete(@"data\stnumber", true);
                    Directory.CreateDirectory(@"data\stnumber");
                }
                if (Directory.Exists(@"data\todayabsent"))
                {
                    Directory.Delete(@"data\todayabsent", true);
                    Directory.CreateDirectory(@"data\todayabsent");
                }
                if(Directory.Exists(@"data\other data\nowdate"))
                {
                    Directory.Delete(@"data\other data\nowdate", true);
                    Directory.CreateDirectory(@"data\other data\nowdate");
                }
                lblWait.Visible = false;
                lblSuccess.Visible = true;
            }
        }

        private void rdbDeleteAll_Click(object sender, EventArgs e)
        {
            lblWait.Visible = false;
            lblSuccess.Visible = false;
        }
    }
}
