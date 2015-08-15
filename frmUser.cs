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
    public partial class frmUser : Form
    {
        MySQLConnect db = new MySQLConnect();

        public frmUser()
        {
            InitializeComponent();
            comboBoxitems();
        }


        public void comboBoxitems() 
        {
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");
            cmbGender.SelectedIndex = 0;
            cmbUsertype.Items.Add("Customer Relation Officer");
            cmbUsertype.Items.Add("Fire Code Fee Assessor");
            cmbUsertype.Items.Add("Collecting Officer");
            cmbUsertype.Items.Add("Chief FSES");
            cmbUsertype.Items.Add("City Fire Marshall");
            cmbUsertype.Items.Add("Fire Safety Inspector");
            cmbUsertype.SelectedIndex = 0;
        }


        private void frmUser_Load(object sender, EventArgs e)
        {
          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            savingUser();
        }

        public void savingUser()
        { 
        try
            {
                if (string.IsNullOrEmpty(txtLastname.Text) || string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtMiddlename.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Some fields are empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else {
                User myUser = new User();
                myUser.lastname = txtLastname.Text;
                myUser.firstname = txtFirstname.Text;
                myUser.middlename = txtMiddlename.Text;
                myUser.gender = cmbGender.Text;
                myUser.username = txtUsername.Text;
                myUser.password = txtPassword.Text;
                myUser.usertype = cmbUsertype.Text;
                db.addUser(myUser);

                txtLastname.Clear();
                txtFirstname.Clear();
                txtMiddlename.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
                this.Close();
                }
            }

        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the transaction?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private bool isValid()
        {
            if (string.IsNullOrEmpty(txtLastname.Text) ||
                string.IsNullOrEmpty(txtFirstname.Text) ||
                string.IsNullOrEmpty(txtMiddlename.Text) ||
                 string.IsNullOrEmpty(txtUsername.Text) ||
                 string.IsNullOrEmpty(txtPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void whileTyping(object sender, EventArgs e)
        {
            btnSave.Enabled = isValid();
        }

    }
}
