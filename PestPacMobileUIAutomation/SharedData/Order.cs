using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.Workwave.Mobile.SharedData
{
    public class Order
    {

        public bool DetailsNeeded { get; set; }
        public string Status { get; set; }
        public string OrderNumber { get; set; }
        public string OrderName { get; set; }
        public string CustomFieldName { get; set; }
        public string CustomFieldType { get; set; }
        public string CustomFieldValue { get; set; }
        public string WorkOrderCustomFields { get; set; }
        

    }
}
