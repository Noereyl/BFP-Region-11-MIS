using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BFPMIS
{
    class FireCodeFeePayment
    {
        public int OfficialReceiptNo { get; set; }
        public DateTime OfficiaReceiptDate { get; set; }
        public float FireCodeConstructiontax { get; set; }
        public float FireCodePenaltytax { get; set; }
        public float FireCodeRealtytax { get; set; }
        public float FireCodePremiumTax { get; set; }
        public float FireCodeSalestax { get; set; }
        public float FireCodeProceedstax { get; set; }
        public float FireSafetyInspectionfee { get; set; }
        public float StorageClearanceFee { get; set; }
        public float Conveyancelearancefee { get; set; }
        public float InstallationClearanceFee { get; set; }
        public float Otherclearancefees { get; set; }
        public float FireCodefees { get; set; }
        public float Totalfee { get; set; }

        public void FCFpayment()
        {
        }
    }
}
