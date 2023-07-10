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
	public partial class ForgetPassword : Form
	{
		public ForgetPassword()
		{
			InitializeComponent();
		}

		#region Forget Password Load
		private void ForgetPassword_Load(object sender, EventArgs e)
		{
			pcEmail.Visible = false;
			if (SignIn.DarkMode)
			{
				this.BackColor = Color.FromArgb(23, 31, 5);
				lblMail.ForeColor = Color.DarkKhaki;
			}
			else
			{
				this.BackColor = Color.FromArgb(225, 233, 196);
				lblMail.ForeColor = Color.Olive;
			}
			this.Size = new Size(420, 450);
			this.Location = this.Owner.Location;
			this.Left += 300;
		}
		#endregion

		#region Back to main page
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

		private void btnSend_Click(object sender, EventArgs e)
		{
			string password = $"Your new Password is: <b>{Methods.GeneratePassword()}</b>. You can change your password at user information tab.";
			Methods.SendEmail(password, "", txtEmail.Text);
		}
		

		#region Email Validation process
		private void txtEmail_TextChanged(object sender, EventArgs e)
		{
			Methods.EmailValidation(txtEmail, errorProviderForgetPassword, pcEmail);
		}
		#endregion



	}
}
