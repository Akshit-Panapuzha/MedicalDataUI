using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MedicalDataUI
{
	public partial class Claimant : Form
	{
		Claimants claimant;
		public Claimant()
		{
			InitializeComponent();
			claimant = new Claimants();
		}

		private void Save_Click(object sender, EventArgs e)
		{
            claimant.requestType = "NewClaimant";
            claimant.firstName = firstname.Text;
            claimant.lastName = lastname.Text;
            claimant.dateOfBirth = Convert.ToDateTime(dateOfBirh.Text);
            claimant.addr1 = addr1.Text;
            claimant.addr2 = addr2.Text;
            claimant.zip = Convert.ToInt32(zip.Text);
            claimant.copayment = Convert.ToDecimal(coPayment.Text);
            claimant.policyLimit = Convert.ToDecimal(policyLimit.Text);
            string fileName = "\\\\192.168.1.100\\Med-Import\\" + claimant.lastName + Guid.NewGuid() + ".xml";
            TextWriter xmlWriter = new StreamWriter(fileName);

            XmlSerializer xmlSerializer = new XmlSerializer(claimant.GetType());
            xmlSerializer.Serialize(xmlWriter, claimant);
            xmlWriter.Close();
        }
	}
}
