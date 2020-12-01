using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDataUI
{
    class Bills
    {
        public string requestType
        {
            get; set;
        }
        public DateTime invoiceDate
        {
            get; set;
        }

        public string diagnosis
        {
            get; set;
        }

        public int invoiceNo;

        public Bills()
        {

        }

        public bool CreateXML()
        {
            return true;
        }
    }
}
