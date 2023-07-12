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

namespace CalorimeterUI
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void Home_Load(object sender, EventArgs e)
		{
			BusinessLayer bl = new BusinessLayer();
			Users user = new Users();
			int id = SignIn.UserID;
			user = bl.Users.Search(id);
			string firstName = user.FirstName.Substring(0, 1).ToUpper() + user.FirstName.Substring(1);
			lblWelcome.Text = "Welcome" + $" {firstName}";
			lblDateTimeNow.Text = DateTime.Now.ToString("d");
			UI_Methods.Methods.CalculateTargetedCalorie();
			crcProgressCarbon.Percentage = (int)UI_Methods.Methods.TotalCarbonhydrateValue;
			crcProgressProtein.Percentage = (int)UI_Methods.Methods.TotalProteinValue;
			crcProgressFat.Percentage = (int)UI_Methods.Methods.TotalFatValue;
			crcProgressCalorie.Percentage = (int)UI_Methods.Methods.TotalCalorieValue;
		}
	}
}
