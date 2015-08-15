using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace BFPMIS
{
    class MySQLConnect
    {
        private MySqlConnection con;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString { get; set; }

        public MySQLConnect()
        {
            Initialize();
        }

        public void Initialize()
        {
            try
            {
                server = "localhost";
                database = "bfpdb";
                uid = "root";
                password = " ";

                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                con = new MySqlConnection(connectionString);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void openConnection()
        {
            try
            {
                con.Open();
                MessageBox.Show("Database Connected..");
            }
            catch (MySqlException e)
            {

                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to the server. Contact Administrator" + e.Number.ToString());
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }
        public void addUser(User _data)
        {
            transactdb("INSERT INTO usertbl (username, password, lastname, firstname, middlename, gender, usertype) VALUES ('" + _data.username + "' , '" + _data.password + "' , '" + _data.lastname + "', '" + _data.firstname + "', '" + _data.middlename + "', '" + _data.gender + "', '" + _data.usertype + "')");
        }

        public void updateUser(int _ndex, User _user)
        {
            transactdb("UPDATE `bfpdb`, `usertbl` SET `lastname` = '" + _user.lastname + "', `firstname` = '" + _user.firstname + "',  `middlename` = '" + _user.middlename + "',  `gender` = '" + _user.gender + "',  `usertype` = '" + _user.usertype + "',  `username` = '" + _user.username + "',  `password` = '" + _user.password + "'");
        
        }
        public void addApplicant(client _data)
        {
            string format = "yyyy-MM-dd HH:MM:ss";
            transactdb("INSERT INTO clienttbl (application_date, business_id, bp_no, mobile_no, landline_no, business_name, taxpayer_name, address, brgy, occupancy_type, building_height, floor_area, cm_used) VALUES ('" + _data.ApplicationDate.ToString(format) + "', '" + _data.BussinessID + "', '" + _data.BussinessPermitNo + "', '" + _data.MobileNo + "', '" + _data.LandlineNo + "', '" + _data.BussinessName + "', '" + _data.TaxPayerName + "', '" + _data.Address + "', '" + _data.Brgy + "', '" + _data.OccupancyType + "', '" + _data.BuildingHeight + "', '" + _data.FloorArea + "', '" + _data.ConstructionMaterialUsed + "')");
        }

        public void safeDelete(int ndex)
        {
            transactdb("UPDATE `bfpdb`, `clienttbl` SET `isDeleted` = '1' WHERE `ndex` = " + ndex);
        
        }
        private void transactdb(string _query)
        {

            string query = _query;

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        internal void updateUser(User myUser)
        {
            throw new NotImplementedException();
        }


        public DataTable loaddata(string _sqlquery)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = _sqlquery;

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                adap.Fill(dt);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error While Loading Data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;

        }
    }
}
