using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BFPMIS
{
    class client
    {
        public DateTime ApplicationDate { get; set; }
        public string BussinessID { get; set; }
        public string BussinessPermitNo { get; set; }
        public string MobileNo { get; set; }
        public string LandlineNo { get; set; }
        public string BussinessName { get; set; }
        public string TaxPayerName { get; set; }
        public string Address { get; set; }
        public string Brgy { get; set; }
        public string OccupancyType { get; set; }
        public string BuildingHeight { get; set; }
        public string FloorArea { get; set; }
        public string ConstructionMaterialUsed { get; set; }
    }
}
