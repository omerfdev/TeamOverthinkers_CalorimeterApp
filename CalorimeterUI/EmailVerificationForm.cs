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

		private void EmailVerificationForm_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode)
			{
				this.BackColor = Color.FromArgb(23, 31, 5);
			}
			else if (SignIn.DarkMode == false)
			{
				this.BackColor = Color.FromArgb(225, 233, 196);

			}
			this.Size = new Size(420, 450);
			this.Location = this.Owner.Location;
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (int.Parse(txtVerification.Text) == Methods.VerificationCode)
			{
				ItIsAMatch = true;
				this.Close();
			}
		}

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
