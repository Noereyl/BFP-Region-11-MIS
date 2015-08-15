using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BFPMIS
{
    class InspectionOrder
    {
        public DateTime IOdate { get; set; }
        public int IOno { get; set; }
        public string FSIname { get; set; }
        public string proceed { get; set; }
        public string purpose { get; set; }
        public DateTime duration { get; set; }
        public string Remarks { get; set; }
        public DateTime InspectionDate { get; set; }

        public void InspectionOrder1()
        {
        }

    }
}
