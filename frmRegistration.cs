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
    public partial class frmRegistration : Form
    {
        MySqlConnection mycon = new MySqlConnection("server=localhost; database=bfpdb; uid=root;");
        MySQLConnect db = new MySQLConnect();

        public frmRegistration()
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

        public void reset()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtMiddlename.Text = "";
            cmbGender.SelectedIndex = 0;
            cmbUsertype.SelectedIndex = 0;
            btnUpdate_record.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            txtUsername.Focus();
        }
        public void savingUser()
        { 
        try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                if (cmbUsertype.Text == "")
                {
                    MessageBox.Show("Please select usertype", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbUsertype.Focus();
                    return;
                }

                if (cmbGender.Text == "")
                {
                    MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbGender.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                if (txtLastname.Text == "")
                {
                    MessageBox.Show("Please enter your lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastname.Focus();
                    return;
                }
                if (txtFirstname.Text == "")
                {
                    MessageBox.Show("Please enter your firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstname.Focus();
                    return;
                }

                if (txtMiddlename.Text == "")
                {
                    MessageBox.Show("Please enter your middlename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMiddlename.Focus();
                    return;
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


        private void btnSave_Click_1(object sender, EventArgs e)
        {
           
            savingUser();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            { 
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            try
            {
                     mycon.Open();
                     MySqlCommand myCmd = new MySqlCommand();
                     myCmd.Connection = mycon;
                     myCmd.CommandText = "SELECT username FROM usertbl WHERE username = '" + txtUsername.Text + "'";
                     MySqlDataReader dr = myCmd.ExecuteReader();

                            if (dr.Read() == true)
                            {
                                MessageBox.Show("Username not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            if (!dr.Read() == true)
                            {
                                MessageBox.Show("Username available", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUsername.Focus();
                            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Autocomplete()
        {
            try
            {
                mycon.Open();
                MySqlCommand myCmd = new MySqlCommand("SELECT username FROM usertbl", mycon);  
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(myCmd);
                da.Fill(ds, "usertbl");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["Username"].ToString());

                }
                txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtUsername.AutoCompleteCustomSource = col;
                txtUsername.AutoCompleteMode = AutoCompleteMode.Suggest;

                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (cmbUsertype.Text == "")
            {
                MessageBox.Show("Please select usertype", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUsertype.Focus();
                return;
            }

            if (cmbGender.Text == "")
            {
                MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGender.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Please enter your lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastname.Focus();
                return;
            }
            if (txtFirstname.Text == "")
            {
                MessageBox.Show("Please enter your firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstname.Focus();
                return;
            }

            if (txtMiddlename.Text == "")
            {
                MessageBox.Show("Please enter your middlename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMiddlename.Focus();
                return;
            }
            try
            {
                mycon.Open();
                MySqlCommand myCmd = new MySqlCommand();
                myCmd.Connection = mycon;
                myCmd.CommandText = "UPDATE usertbl set password ='" + txtPassword.Text + "', lastname ='" + txtLastname.Text + "', firstname ='" + txtFirstname.Text + "', middlename ='" + txtMiddlename.Text + "' , gender = '" + cmbGender.Text + "' , usertype = '" + cmbUsertype.Text + "' WHERE username = '" + txtUsername.Text + "'";
                myCmd.ExecuteReader();
                mycon.Close();

                MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                btnUpdate_record.Enabled = false;
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
            }
        }
        

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void deleteUserRecord()
        {
            try
            {
                if (txtUsername.Text == "admin")
                {
                    MessageBox.Show("Admin Account cannot be deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int RowsAffected = 0;
                mycon.Open();
                MySqlCommand myCmd = new MySqlCommand();
                myCmd = mycon.CreateCommand();

                myCmd.CommandText = "DELETE FROM usertbl WHERE username = '" + txtUsername.Text + "'";
                myCmd.Connection = mycon;
                RowsAffected = myCmd.ExecuteNonQuery();
                
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted!", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Autocomplete();
                    reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    Autocomplete();
                }
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteUserRecord();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate_record.Enabled = true;
            try
            {
                txtUsername.Text = txtUsername.Text.TrimEnd();

                mycon.Open();
                MySqlCommand myCmd = new MySqlCommand();
                myCmd = mycon.CreateCommand();

                myCmd.CommandText = "SELECT password, lastname, firstname, middlename, gender, usertype FROM usertbl WHERE username = '" + txtUsername.Text.Trim() + "'";
                MySqlDataReader dr = myCmd.ExecuteReader();

                if (dr.Read())
                {
                    txtPassword.Text = (dr.GetString(0).Trim());
                    txtLastname.Text = (dr.GetString(1).Trim());
                    txtFirstname.Text = (dr.GetString(2).Trim());
                    txtMiddlename.Text = (dr.GetString(3).Trim());
                    cmbGender.Text = (dr.GetString(4).Trim());
                    cmbUsertype.Text = (dr.GetString(5).Trim());
                }

                if ((dr != null))
                {
                    dr.Close();
                }
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
