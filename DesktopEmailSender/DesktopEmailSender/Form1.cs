using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailSender;

namespace DesktopEmailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            MailClient oMailClient = new MailClient();
            oMailClient.SendEmail(inptPrimatelj.Text, inptNaslovPoruke.Text, inptTijeloPoruke.Text);
            outptMailPoslan.Text = Convert.ToString("Mail uspjesno poslan");
        }
    }
}
