using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.Workwave.Mobile.SharedData
{
    public class Payment
    {
        public string ServiceType { get; set; }
        public string ServicePrice { get; set; }
        public string ServiceProduct { get; set; }
        public string ServiceProductPrice { get; set; }
        public string ServiceProductQuantity { get; set; }
        public int ServiceProductCount { get; set; }
        public string ServiceMaterial { get; set; }
        public string ServiceMaterialQuantity { get; set; }
        public string ServiceDiscountDescription { get; set; }
        public string ServiceDiscountAmount { get; set; }
        public string ServiceDiscountType { get; set; }
        public string TimeOfCreation { get; set; }
        public double OldDiscountAmount { get; set; }
        public string OldDiscountType { get; set; }
        public double OldServicePrice { get; set; }
        public bool RandomizePrice { get; set; }
        public bool VerifyServiceType { get; set; }
        public double PriceDifference { get; set; }
      


    }
}
