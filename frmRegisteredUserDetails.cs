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

namespace BFPMIS
{
    public partial class frmRegisteredUserDetails : Form
    {
        MySQLConnect connect = new MySQLConnect();
        public frmRegisteredUserDetails()
        {
            InitializeComponent();
        }
        

        private void frmRegisteredUserDetails_Load(object sender, EventArgs e)
        {

        }

   
        
    }
}
