using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDataUI
{
	public class Claimants
	{
        public string requestType
        {
            get; set;
        }
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }
        public DateTime dateOfBirth
        {
            get; set;
        }
        public string addr1
        {
            get; set;
        }
        public string addr2
        {
            get; set;
        }
        public int zip
        {
            get; set;
        }
        public Decimal copayment
        {
            get; set;
        }
        public Decimal policyLimit
        {
            get; set;
        }

        public Claimants()
        {

        }

        public bool CreateXML()
        {
            return true;
        }
    }
}
