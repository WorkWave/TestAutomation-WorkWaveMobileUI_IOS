using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.Workwave.Mobile.SharedData
{
    public class WorkwaveData
    {
        public Login Login { get; set; }
        public Order Order { get; set; }
        public Attachment Attachment { get; set; }
        public Note Note { get; set; }
        public Services Services { get; set; }
        public Sketch Sketch { get; set; }
    }
}
