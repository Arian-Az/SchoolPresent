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
using System.Net.Mail;
using System.Net;
using System.Globalization;

namespace SchoolPresent
{
    public partial class ReportStudents : Form
    {
        string ab;
        public ReportStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string pathString = System.IO.Path.Combine("data//", "SubFolder");
            //System.IO.Directory.CreateDirectory(pathString);
            var files = Directory.GetFiles(@"data/stname").Select(Path.GetFileName).ToArray();
            foreach (var item in files)
            {
                string items = item;
                string itemsR = items.Replace(".txt", "");
                comboBox1.Items.Add(itemsR);
            }
            //MailMessage mail = new MailMessage("arian.azizian20@gmail.com", "arian.azizian@hotmail.com");
            //SmtpClient client = new SmtpClient();
            //client.Port = 25;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Host = "smtp.google.com";
            //mail.Subject = "this is a test subject";
            //mail.Body = "this is a test body";
            //client.Send(mail);
            /*
            string smtpAddress = "smtp.live.com";
            int portNumber = 587;
            bool enableSSL = true;

            string emailFrom = "arian.azizian@hotmail.com";
            string password = "arian.1380";
            string emailTo = "arian.azizian20@gmail.com";
            string subject = "Hello";
            string body = "Hello, I'm just writing this to say Hi!";

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                // Can set to false, if you are sending pure text.

            //    mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
               // mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
            */

            //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            //MailMessage mailMessage = new MailMessage();
            //mailMessage.From = new MailAddress("arian.azizian@hotmail.com", "Schools");
            //mailMessage.To.Add("arian.azizian20@gmail.com");
            //mailMessage.Subject = "hi";
            //mailMessage.Body = "hiiiiiiiiiii";

            //mailMessage.IsBodyHtml = false;
            //NetworkCredential credential = new NetworkCredential("arian.azizian@hotmail.com", "atian.1380");
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = credential;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Port = 587;
            //smtp.EnableSsl = true;

            //smtp.Host = "smtp.live.com";

            //smtp.Send(mailMessage);



            NewMethod();
        }

        private void NewMethod()
        {
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
            int a;
            DayOfWeek dd;
            dd = farsi.GetDayOfWeek(DateTime.Now);
            switch (dd.ToString())
            {
                case "Saturday":
                    label4.Text = rooz[0].ToString();
                    ab = rooz[0].ToString();
                    break;
                case "Sunday":
                    label4.Text = rooz[1].ToString();
                    ab = rooz[1].ToString();
                    break;
                case "Monday":
                    label4.Text = rooz[2].ToString();
                    ab = rooz[2].ToString();
                    break;
                case "Tuesday":
                    label4.Text = rooz[3].ToString();
                    ab = rooz[3].ToString();
                    break;
                case "Wednesday":
                    label4.Text = rooz[4].ToString();
                    ab = rooz[4].ToString();
                    break;
                case "Thursday":
                    label4.Text = rooz[5].ToString();
                    ab = rooz[5].ToString();
                    break;
                case "Friday":
                    label4.Text = rooz[6].ToString();
                    ab = rooz[6].ToString();
                    break;
            }
            a = farsi.GetDayOfMonth(DateTime.Now);
            ab += " " + Convert.ToString(a);
            a = farsi.GetMonth(DateTime.Now);
            ab += " " + fasl[a - 1];
            a = farsi.GetYear(DateTime.Now);
            ab += " " + Convert.ToString(a);
            MessageBox.Show(ab);
        }

        private void ReportStudents_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = textBox1.Text;
            int x = str.IndexOf("0");
            if (x == 0)
            {
                MessageBox.Show(x.ToString());
            }
            else { MessageBox.Show("Test");}
        }
    }
    }
