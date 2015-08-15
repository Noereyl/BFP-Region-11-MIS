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
    public partial class frmMain2 : Form
    {
        public frmMain2()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void menuEdit_Click(object sender, EventArgs e)
        {

        }
        private void menuUser_Click(object sender, EventArgs e)
        {
            frmUser addNew = new frmUser();
            if (addNew.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                addNew.ShowDialog();

            }
        }

        private void menuApplicant_Click(object sender, EventArgs e)
        {
            frmApplicant addNew = new frmApplicant();
            if (addNew.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                addNew.ShowDialog();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuNew_Click(object sender, EventArgs e)
        {

        }
    }
}
