using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFPMIS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {
            frmapplicantInfo applicant = new frmapplicantInfo();
            if (applicant.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                applicant.ShowDialog();
            }
        }

        

        private void inspectionOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationItem_Click(object sender, EventArgs e)
        {
            frmRegistration register = new frmRegistration();
            register.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmuserLogin userLogin = new frmuserLogin();
            userLogin.Show();
            userLogin.txtUsername.Text = "";
            userLogin.txtPassword.Text = "";
            userLogin.txtUsername.Focus();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration register = new frmRegistration();
            register.Show();
        }

        private void clientsItem_Click(object sender, EventArgs e)
        {
            frmApplicant client = new frmApplicant();
            client.Show();
        }

        
    }
}
