using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;

namespace BFPMIS
{
    public partial class frmMainMenu : Form
    {
        MySqlConnection mycon = new MySqlConnection("server=localhost; database=bfpdb; uid=root;");

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
            frmuserLogin frm = new frmuserLogin();
            frm.Show();
            frm.txtUsername.Text = "";
            frm.txtPassword.Text = "";
            frm.txtUsername.Focus();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
      
    }
}
