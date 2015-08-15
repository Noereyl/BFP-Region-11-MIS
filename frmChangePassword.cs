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
    public partial class frmChangePassword : Form
    {
        MySqlConnection mycon = new MySqlConnection("server=localhost; database=bfpdb; uid=root;");
        
        
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmuserLogin form = new frmuserLogin();
            form.txtUsername.Text = "";
            form.txtPassword.Text = "";
            form.progressBar.Visible = false;
            form.txtUsername.Focus();
            form.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = 0;
                if ((txtUserName.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }
                if ((txtOldPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPassword.Focus();
                    return;
                }
                if ((txtNewPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                    return;
                }
                if ((txtConfirmPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please confirm new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPassword.Focus();
                    return;
                }
                if ((txtNewPassword.TextLength < 5))
                {
                    MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }
                else if ((txtNewPassword.Text != txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtOldPassword.Focus();
                    return;
                }
                else if ((txtOldPassword.Text == txtNewPassword.Text))
                {
                    MessageBox.Show("Password is same..Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }

                mycon.Open();
                MySqlCommand myCmd = new MySqlCommand();
                myCmd.Connection = mycon;
                myCmd.CommandText = "update usertbl set password = '" + txtNewPassword.Text + "'where username='" + txtUserName.Text + "' and password = '" + txtOldPassword.Text + "'";
                //MySqlDataReader dr = myCmd.ExecuteReader();
                RowsAffected = myCmd.ExecuteNonQuery();

                if ((RowsAffected > 1))
                {
                   MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtUserName.Focus(); 
                }
                else
                {
                    MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    txtUserName.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    frmuserLogin login = new frmuserLogin();
                    login.Show();
                    login.txtUsername.Text = "";
                    login.txtPassword.Text = "";
                    login.progressBar.Visible = false;
                    login.txtUsername.Focus();
                }
                if ((mycon.State == ConnectionState.Open))
                {
                    mycon.Close();
                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }

    }
