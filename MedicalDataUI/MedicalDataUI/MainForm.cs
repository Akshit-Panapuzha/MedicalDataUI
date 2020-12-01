using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalDataUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void CreatClaimScreen()
		{
			Claim claim = new Claim();
			claim.MdiParent = this;
			bool isOpen = false;
			foreach (Form childForm in Application.OpenForms)
			{
				if (childForm.Name == "Claim")
				{
					isOpen = true;
					break;
				}
			}
			if (!isOpen)
				claim.Show();
		}

		private void CreateClaimantScreen()
		{
			Claimant claimant = new Claimant();
			claimant.MdiParent = this;
			bool isOpen = false;
			foreach (Form childForm in Application.OpenForms)
			{
				if (childForm.Name == "Claimant")
				{
					isOpen = true;
					break;
				}
			}
			if (!isOpen)
				claimant.Show();
		}

		private void claimsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CreatClaimScreen();			
		}

		private void claimantToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CreateClaimantScreen();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			CreatClaimScreen();
		}
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			CreateClaimantScreen();
		}
	}
}
