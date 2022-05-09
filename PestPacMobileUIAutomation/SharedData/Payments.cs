using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.Workwave.Mobile.SharedData
{
    public class Payments
    {
        public string PaymentType { get; set; }
        public bool PayTotalDue { get; set; }
        public string PaymentAmount { get; set; }
        public string PaymentReference { get; set; }
        public string Option { get; set; }
        public string SaveOption { get; set; }
        public string CardNumber { get; set; }
    }
}
