using BLL;
using DAL;
using DrakeUI.Framework;
using Entities;
using System.Windows.Forms;
using static CalorimeterUI.UI_Methods;

namespace CalorimeterUI
{
	public partial class SignIn : Form
	{
		public SignIn()
		{
			InitializeComponent();
		}
		Context db = new Context();
		BusinessLayer bll = new BusinessLayer();

		#region Move Form
		private bool mouseDown;
		private Point lastLocation;

		private void SignIn_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void SignIn_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}

		private void SignIn_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}
		#endregion

		#region ToggleMode
		public static bool DarkMode;
		private void toggleMode_ToggledChanged()
		{
			if (toggleMode.Toggled == true)
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png");
				DarkMode = true;
				if (txtPwd.UseSystemPasswordChar == true)
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\hideDarkMode.png");
				}
				else
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\showDarkMode.png");
				}
			}
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
				DarkMode = false;
				if (txtPwd.UseSystemPasswordChar == true)
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\hide.png");
				}
				else
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\show.png");
				}
			}
		}
		#endregion

		#region Password Hide And Show
		private void pbHidePw_Click(object sender, EventArgs e)
		{
			if (DarkMode == false)
			{
				pbHidePw.BackgroundImage = null;
				if (txtPwd.UseSystemPasswordChar == false)
				{
					txtPwd.UseSystemPasswordChar = true;
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\hide.png");

				}
				else if (txtPwd.UseSystemPasswordChar == true)
				{
					txtPwd.UseSystemPasswordChar = false;
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\show.png");
				}
			}
			else if (DarkMode == true)
			{
				pbHidePw.BackgroundImage = null;
				if (txtPwd.UseSystemPasswordChar == false)
				{
					txtPwd.UseSystemPasswordChar = true;
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\hideDarkMode.png");

				}
				else if (txtPwd.UseSystemPasswordChar == true)
				{
					txtPwd.UseSystemPasswordChar = false;
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\showDarkMode.png");
				}
			}


		}
		#endregion

		#region Sign in Form Load
		private void SignIn_Load(object sender, EventArgs e)
		{
			Methods.UserInfoRememberCheck(chkRemember, txtMail, txtPwd);
			this.Top = 230;
			this.Left = 500;
		}
		#endregion

		#region Sign in process
		private void btnSignIn_Click(object sender, EventArgs e)
		{
			Methods.RememberMe(chkRemember, txtMail.Text, txtPwd.Text);
		}

		private void txtMail_TextChanged(object sender, EventArgs e)
		{
			Methods.EmailValidation(txtMail, errorProviderEmail, pcEmailVerification);
		}

		private void lblForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ForgetPassword rst = new ForgetPassword();
			rst.Owner = this;
			Methods.Visibility(dlblExitForm);
			Methods.Visibility(dlblDownForm);
			Methods.Visibility(toggleMode);
			rst.ShowDialog();
			this.Show();
			Methods.Visibility(dlblExitForm);
			Methods.Visibility(dlblDownForm);
			Methods.Visibility(toggleMode);
		}
		#endregion

		#region Form Exit and Down process
		private void dlblDownForm_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void dlblExitForm_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		private void dlblExitForm_MouseEnter(object sender, EventArgs e)
		{
			dlblExitForm.ForeColor = Color.DarkKhaki;
		}

		private void dlblExitForm_MouseLeave(object sender, EventArgs e)
		{
			dlblExitForm.ForeColor = Color.Olive;
		}

		private void dlblDownForm_MouseEnter(object sender, EventArgs e)
		{
			dlblDownForm.ForeColor = Color.DarkKhaki;
		}

		private void dlblDownForm_MouseLeave(object sender, EventArgs e)
		{
			dlblDownForm.ForeColor = Color.Olive;
		}
		#endregion


	}
}