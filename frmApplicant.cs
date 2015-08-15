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
    public partial class frmApplicant : Form
    {
        MySQLConnect db = new MySQLConnect();

        public frmApplicant()
        {
            InitializeComponent();
            comboBoxitems();
        }

 
        private void frmApplicant_Load(object sender, EventArgs e)
        {

        }


        public void comboBoxitems()
        {
            cmbOccupancytype.Items.Add("Assembly");
            cmbOccupancytype.Items.Add("Business");
            cmbOccupancytype.Items.Add("Detention and Correctional");
            cmbOccupancytype.Items.Add("Educational");
            cmbOccupancytype.Items.Add("Health Care");
            cmbOccupancytype.Items.Add("Industrial");
            cmbOccupancytype.Items.Add("Mercantile");
            cmbOccupancytype.Items.Add("Miscellaneous");
            cmbOccupancytype.Items.Add("Residential");
            cmbOccupancytype.Items.Add("Storage");
            cmbOccupancytype.Items.Add("Small/General");
            cmbOccupancytype.Items.Add("Gasoline");
            cmbOccupancytype.Items.Add("Theatre");
            cmbOccupancytype.SelectedIndex = 0;
            cmbcmUsed.Items.Add("Wood and Concrete");
            cmbcmUsed.Items.Add("Concrete");
            cmbcmUsed.SelectedIndex = 0;
        }
        public void savingApplicant()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBiD.Text) || string.IsNullOrEmpty(txtBPN.Text) || string.IsNullOrEmpty(txtBusName.Text) || string.IsNullOrEmpty(txtLandline.Text) ||
                    string.IsNullOrEmpty(txtMobile.Text) || string.IsNullOrEmpty(txtTPN.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtBrgy.Text) ||
                     string.IsNullOrEmpty(txtBdgHeight.Text) || string.IsNullOrEmpty(grpFloor.Text))
                {
                    MessageBox.Show("Some fields are empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }
                else
                {
                    client newClient = new client();

                    newClient.ApplicationDate = dateTimeApplication.Value;
                    newClient.BussinessID = txtBiD.Text;
                    newClient.BussinessPermitNo = txtBPN.Text;
                    newClient.BussinessName = txtBusName.Text; 
                    newClient.TaxPayerName = txtTPN.Text;
                    newClient.Address = txtAddress.Text;
                    newClient.Brgy = txtBrgy.Text;
                    newClient.MobileNo = txtMobile.Text;
                    newClient.LandlineNo = txtLandline.Text;
                    newClient.BuildingHeight = txtBdgHeight.Text;
                    newClient.FloorArea = txtfloorArea.Text;
                    newClient.OccupancyType = cmbOccupancytype.Text;
                    newClient.ConstructionMaterialUsed = cmbcmUsed.Text;
                    db.addApplicant(newClient);
                    txtBiD.Clear();
                    txtBPN.Clear();
                    txtBrgy.Clear();
                    txtBusName.Clear();
                    txtLandline.Clear();
                    txtMobile.Clear();
                    txtTPN.Clear();
                    txtAddress.Clear();
                    txtfloorArea.Clear();
                    txtBdgHeight.Clear();
                    this.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savingApplicant();
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
