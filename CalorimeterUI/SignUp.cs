using BLL;
using DrakeUI.Framework;
using Entities;
using ReaLTaiizor.Controls;
using static CalorimeterUI.UI_Methods;

namespace CalorimeterUI
{
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
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


		public void btnSignUp_Click(object sender, EventArgs e)
		{
			bool IsTextboxNull = false;
			IsTextboxNull = FillControl(IsTextboxNull);
			if (IsTextboxNull)
			{
				MessageBox.Show("Please fill all the necessary informations");
			}
			else if (!Methods.PasswordCheckMethod(txtPwd.Text, txtRePwd.Text))
			{
			}
			else
			{
				Methods.VerificationCode = Methods.RandomVerificationCode();
				string body = $"Please use the code here to verify your account <b>{Methods.VerificationCode}</b>";
				Methods.SendEmail(body, txtName.Text, txtMail.Text);

				EmailVerificationForm evf = new EmailVerificationForm();
				evf.Owner = this;
				evf.ShowDialog();
				string hashedPass = Methods.GenerateHash(txtPwd.Text);
				if (evf.ItIsAMatch)
				{
					BusinessLayer bl = new BusinessLayer();
					bl.Users.Add(new Users()
					{
						FirstName = txtName.Text,
						LastName = txtSurname.Text,
						Email = txtMail.Text,
						Password = hashedPass
					});
					BusinessLayer._db.SaveChanges();
				}
			}

		}

		#region Form Fill Check
		public bool FillControl(bool control)
		{
			foreach (var item in this.Controls)
			{
				if (item is DungeonTextBox)
				{
					DungeonTextBox dtb = (DungeonTextBox)item;
					if (dtb.Text.IsNullOrEmpty())
					{
						return control = true;
					}
				}
			}
			if (control)
				return true;
			else return false;
		}
		#endregion

		#region Sign Up Form Load
		private void SignUp_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode)
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\backgroundDark.png");
				if (txtPwd.UseSystemPasswordChar == true)
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\hideDarkMode.png");

				}
				else
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\ShowDarkMode.png");
				}
			}
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\background.png");
				if (txtPwd.UseSystemPasswordChar == true)
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\hide.png");
				}
				else
				{
					pbHidePw.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\Show.png");
				}
			}
			this.Size = new Size(420, 450);
			this.Location = this.Owner.Location;
			this.Left += 300;
		}
		#endregion

		#region Back To Form
		private void pbHidePw_Click(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == false)
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
			else if (SignIn.DarkMode == true)
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
	}
}
