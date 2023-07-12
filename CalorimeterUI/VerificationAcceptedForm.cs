using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorimeterUI
{
	public partial class VerificationAcceptedForm : Form
	{
		public VerificationAcceptedForm()
		{
			InitializeComponent();
		}

		private void VerificationAcceptedForm_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode)
			{
				lblVerified.ForeColor = Color.DarkKhaki;
				lblVerifiedInfo.ForeColor = Color.DarkKhaki;
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\darkbackground.png");
			}
			else if (SignIn.DarkMode == false)
			{
				lblVerified.ForeColor = Color.Olive;
				lblVerifiedInfo.ForeColor = Color.Olive;
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\background.png");
			}
			this.Size = new Size(420, 450);
			this.Location = this.Owner.Location;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
