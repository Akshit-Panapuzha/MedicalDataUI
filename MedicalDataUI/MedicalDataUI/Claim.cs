using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MedicalDataUI
{
    public partial class Claim : Form
    {
        Claims claim;
        public Claim()
        {
            InitializeComponent();
            claim = new Claims();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            claim.requestType = "NewClaim";
            claim.claimNumber = Convert.ToInt32(claimNo.Text);
            claim.dateOfLoss = Convert.ToDateTime(dateOfLoss.Text);
            claim.coverageType = covType.Text;
            claim.insuranceCompanyName = CompName.Text;
            claim.officeaddress1 = officeAddress1.Text;
            claim.officeaddress2 = officeAddress2.Text;
            claim.adjusterId = Convert.ToInt32(adjusterID.Text);
            claim.policyNumber = Convert.ToInt32(policyNo.Text);
            claim.policyEffectiveDate = Convert.ToDateTime(polEffectiveDate.Text);
            claim.deductible = Convert.ToDecimal(deductible.Text);
            string fileName = "\\\\192.168.1.101\\Med-Import\\" + claim.claimNumber + Guid.NewGuid() + ".xml";
            TextWriter xmlWriter = new StreamWriter(fileName);

            XmlSerializer xmlSerializer = new XmlSerializer(claim.GetType());
            xmlSerializer.Serialize(xmlWriter, claim);
            xmlWriter.Close();
        }

        private void Claim_Load(object sender, EventArgs e)
        {

        }

        private void adjusterID_TextChanged(object sender, EventArgs e)
        {

        }

        private void claimNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void claimNo_Leave(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(claimNo.Text))
            {
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlConnection con = new SqlConnection("Data Source=Data;uid=akshit; password=12345; Initial Catalog=Medical;");
            string myQuery = "SELECT * FROM Claims Where claimno =" + Convert.ToInt32(claimNo.Text);
            con.Open();

            DataSet ds = new DataSet();
            adapter.SelectCommand = new SqlCommand(myQuery, con);
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dateOfLoss.Enabled = false;
                covType.Enabled = false;
                CompName.Enabled = false;
                officeAddress1.Enabled = false;
                officeAddress2.Enabled = false;
                adjusterID.Enabled = false;
                policyNo.Enabled = false;
                polEffectiveDate.Enabled = false;
                deductible.Enabled = false;
                SAVE.Enabled = false;

                dateOfLoss.Text = ds.Tables[0].Rows[0]["dateofloss"].ToString();
                covType.Text = ds.Tables[0].Rows[0]["coverageType"].ToString();
                CompName.Text = ds.Tables[0].Rows[0]["company"].ToString();
                officeAddress1.Text = ds.Tables[0].Rows[0]["officeaddr1"].ToString();
                officeAddress2.Text = ds.Tables[0].Rows[0]["officeaddr2"].ToString();
                adjusterID.Text = ds.Tables[0].Rows[0]["adjusterid"].ToString();
                policyNo.Text = ds.Tables[0].Rows[0]["policyno"].ToString();
                polEffectiveDate.Text = ds.Tables[0].Rows[0]["policyeffectivedate"].ToString();
                deductible.Text = ds.Tables[0].Rows[0]["deductible"].ToString();
            }
            con.Close();
        }

        private void CompName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            dateOfLoss.Enabled = true;
            covType.Enabled = true;
            CompName.Enabled = true;
            officeAddress1.Enabled = true;
            officeAddress2.Enabled = true;
            adjusterID.Enabled = true;
            policyNo.Enabled = true;
            polEffectiveDate.Enabled = true;
            deductible.Enabled = true;
            SAVE.Enabled = true;
        }
    }
}
