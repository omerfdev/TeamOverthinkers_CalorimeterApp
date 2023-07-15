using BLL;
using Entities;
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
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			BusinessLayer bl = new BusinessLayer();
			Users user = new Users();
			user = bl.Users.Search(SignIn.UserID);
			if (Methods.GenerateHash(txtOldPassword.Text) == user.Password)
			{
				if (txtNewPassword.Text == txtNewPwAgain.Text)
				{
					if (Methods.PasswordCheckMethod(txtNewPassword.Text, txtNewPwAgain.Text))
					{
						user.Password = Methods.GenerateHash(txtNewPassword.Text);
						bl.Users.Update(user);
						MessageBox.Show("Your password has been changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("New passwords don't match.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Old Password is incorrect.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
		}
	}
}
