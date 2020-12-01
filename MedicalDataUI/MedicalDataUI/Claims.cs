using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDataUI
{
    public class Claims 
    {     
        public string requestType
        {
            get;set;
        }
        public int claimId {          
            get; set;
        }
        public int claimNumber
        {          
            get; set; 
        }
        public DateTime dateOfLoss
        {            
            get; set;
        }
        public string coverageType
        {            
            get; set;
        }
        public string insuranceCompanyName
        {
            get; set;
        }
        public string officeaddress1
        {        
            get; set;
        }
        public string officeaddress2
        {          
            get; set;
        }
        public int adjusterId
        {            
            get; set;
        }
        public int policyNumber
        {            
            get; set;
        }
        public DateTime policyEffectiveDate
        {            
            get; set;
        }
        public Decimal deductible
        {          
            get; set;
        }


        public Claims()
        {

        }

        public bool CreateXML()
        {
            return true;
        }

    }
}
