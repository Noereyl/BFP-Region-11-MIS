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
    public partial class frmupdateUser : Form
    {

        MySQLConnect db = new MySQLConnect();

        public frmupdateUser()
        {
            InitializeComponent();
           
            
        }

        private void frmupdateUser_Load(object sender, EventArgs e)
        {
            
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        public void userUpdate()
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the transaction?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
