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
    public partial class frmapplicantInfo : Form
    {
        public int ndex { get; set; }

        MySQLConnect mydb = new MySQLConnect();

        public frmapplicantInfo()
        {
            InitializeComponent();
        }

        private void frmapplicantInfo_Load(object sender, EventArgs e)
        {
            LoadDataToListView();
        }

        private void LoadDataToListView()
        {
            lvItem.Items.Clear();
            DataTable mydt = mydb.loaddata("SELECT id, business_id, bp_no, business_name, taxpayer_name FROM clienttbl WHERE isDeleted = 0 ORDER BY id DESC");
            for (int i = 0; i < mydt.Rows.Count; i++)
            {

                DataRow dr = mydt.Rows[i];
               
                //string appDate = (dr["application_date"].ToString());
                //ListViewItem listitem = new ListViewItem(dr["ndex"].ToString());
                //listitem.SubItems.Add(appDate);
                ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                listitem.SubItems.Add(dr["business_id"].ToString());
                listitem.SubItems.Add(dr["bp_no"].ToString());
                listitem.SubItems.Add(dr["business_name"].ToString());
                listitem.SubItems.Add(dr["taxpayer_name"].ToString());
                lvItem.Items.Add(listitem);
            }

           
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            frmApplicant addNew = new frmApplicant();
            if (addNew.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                client addNewClient = new client();
                
                //addNew.ShowDialog();
                //LoadDataToListView();
            }
        }

        private void lvItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
