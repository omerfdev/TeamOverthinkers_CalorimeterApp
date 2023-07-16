using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CalorimeterUI.UI_Methods;

namespace CalorimeterUI
{
	public partial class EmailVerificationForm : Form
	{
		public EmailVerificationForm()
		{
			InitializeComponent();
		}
		public bool ItIsAMatch = false;

		#region Email Verification Form Load
		private void EmailVerificationForm_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
		}

		#endregion

		#region Send Verification Code
		private void btnSend_Click(object sender, EventArgs e)
		{
			if (int.Parse(txtVerification.Text) == Methods.VerificationCode)
			{
				ItIsAMatch = true;
				this.Close();
			}
		}
		#endregion

		#region Back To main page
		private void pbBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void pbBack_MouseEnter(object sender, EventArgs e)
		{
			pbBack.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\darkkhakiBack.png");
		}

		private void pbBack_MouseLeave(object sender, EventArgs e)
		{
			pbBack.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\oliveBack.png");
		}
		#endregion
	}
}
