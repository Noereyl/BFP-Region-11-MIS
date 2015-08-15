using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BFPMIS
{
    class FireSafetyCertificate
    {
        public DateTime FSICdate { get; set; }
        public int FSICno { get; set; }
        public string EstablishmentAddress { get; set; }
        public DateTime FSICdateRelease { get; set; }
        public float AmountPaid { get; set; }

        public void FSCinfo()
        {
        }
    }
}
