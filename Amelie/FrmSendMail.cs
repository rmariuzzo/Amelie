using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Amelie
{
    public partial class FrmSendMail : Form
    {
        public FrmSendMail()
        {
            InitializeComponent();
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            try
            {
                MailMessage mail = new MailMessage(TxtFrom.Text, TxtFrom.Text);
                SmtpClient client = new SmtpClient();

                client.Host = TxtHost.Text;
                client.Port = Convert.ToInt32(TxtPort.Text);

                if (CbUseCredentials.Checked)
                {
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential(TxtUsername.Text, TxtPassword.Text);
                }

                mail.Subject = TxtSubject.Text;
                mail.Body = TxtBody.Text;
                client.Send(mail);

                MessageBox.Show("Mail sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail not sent:\n\n" + ex);
            }

            this.Enabled = true;
        }

        private void CbUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            var controls = new Control[] { LbUsername, TxtUsername, LbPassword, TxtPassword };
            foreach (var c in controls) c.Enabled = CbUseCredentials.Checked;
        }
    }
}
