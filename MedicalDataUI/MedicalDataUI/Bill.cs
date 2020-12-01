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
    public partial class Bill : Form
    {
        Bills bill;
        public Bill()
        {
             bill = new Bills();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            bill.requestType = "NewClaim";
            //bill.invoice = Convert.ToDateTime(invoice.Text);
            bill.diagnosis = diagnosis.Text;
            string fileName = "\\\\192.168.1.100\\Med-Import\\" + Guid.NewGuid() + ".xml";
            TextWriter xmlWriter = new StreamWriter(fileName);

            XmlSerializer xmlSerializer = new XmlSerializer(bill.GetType());
            xmlSerializer.Serialize(xmlWriter, bill);
            xmlWriter.Close();
        }
    }
}
