using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BFPMIS
{
    class FCFAssesment
    {
        public DateTime OPdate { get; set; }
        public int OPno { get; set; }
        public string Remarks { get; set; }
        public float paymentTax  { get; set; }
        public float AccountCodeTax { get; set; }
        public float AmountPaidTax  { get; set; }
        public float paymentFCF { get; set; }
        public float AccountCodeFCF { get; set; }
        public float AmountPaidFCF { get; set; }
        public string TotalAmount { get; set; }

        public void FCFAssesmentInfo()
        {
        }

    }
}
