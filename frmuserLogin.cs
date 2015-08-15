using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BFPMIS
{
    public partial class frmuserLogin : Form
    {
        MySqlConnection mycon = new MySqlConnection("server=localhost; database=bfpdb; uid=root;");
        public frmuserLogin()
        {
            InitializeComponent();
        }

        public void Login()
        { 
            try
            {
                mycon.Open();
                MySqlCommand myCmd = new MySqlCommand();
                myCmd.Connection = mycon;
                myCmd.CommandText = "SELECT * FROM usertbl WHERE password = '" + txtPassword.Text + "' AND username = '" +  txtUsername.Text + "'";
                MySqlDataReader dr = myCmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    frmMain main = new frmMain();
                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password!", "Error!");
                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Login", ex.ToString());
            }
       }
        private void frmuserLogin_Load(object sender, EventArgs e)
        {
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}