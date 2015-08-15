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
    public partial class frmMain : Form
    {
        public frmMain()
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
    }
}
