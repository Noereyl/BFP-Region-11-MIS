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
                    frmMainMenu main = new frmMainMenu();
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            Login();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            this.Close();
        }

        private void changePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmChangePassword changePass = new frmChangePassword();
            changePass.Show();
            changePass.txtUserName.Text = "";
            changePass.txtNewPassword.Text = "";
            changePass.txtOldPassword.Text = "";
            changePass.txtConfirmPassword.Text = "";
        }

      
    }
}