using BLL;
using Entities;
using ReaLTaiizor.Controls;
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
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}
		BusinessLayer bll = new BusinessLayer();

		private void Home_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
			Methods.TotalCalorieValue = 0;
			Methods.TotalFatValue = 0;
			Methods.TotalProteinValue = 0;
			Methods.TotalCarbonhydrateValue = 0;
			BusinessLayer bl = new BusinessLayer();
			Users user = new Users();
			int id = SignIn.UserID;
			user = bl.Users.Search(id);
			string firstName = user.FirstName.Substring(0, 1).ToUpper() + user.FirstName.Substring(1);
			lblWelcome.Text = "Welcome" + $" {firstName}";
			lblDateTimeNow.Text = DateTime.Now.ToString("d");
			UI_Methods.Methods.FillCircularProgressBars();
			Methods.CalculateTargetedCalorie();
			crcProgressCarbon.Percentage = (int)(Methods.TotalCarbonhydrateValue * 100 / Methods.TargetedCarbonhydrateValue);
			crcProgressProtein.Percentage = (int)(Methods.TotalProteinValue * 100 / Methods.TargetedProteinValue);
			crcProgressFat.Percentage = (int)(Methods.TotalFatValue * 100 / Methods.TargetedFatValue);
			crcProgressCalorie.Percentage = (int)(Methods.TotalCalorieValue * 100 / Methods.TargetedCalories);
			FavoriteFoods();
		}
		
		#region home Page Favourite Food Process
		/// <summary>
		/// Method gives Favorite Foods
		/// </summary>
		private void FavoriteFoods()
		{
			var FoodTable = bll.Foods.GetAll().ToList();
			var UFMTable = bll.User_Food_Meal.GetAll().Select(x => new { x.FoodID, x.Amount }).ToList();
			var top5Foods = UFMTable
				.Join(FoodTable, r4 => r4.FoodID, r3 => r3.ID, (r4, r3) => new { r3.FoodName, r3.FoodImagePath, TotalAmount = r4.Amount })
				.GroupBy(x => x.FoodName)
				.Select(group => new { group.Key, TotalAmount = group.Sum(x => x.TotalAmount), group.First().FoodImagePath })
				.OrderByDescending(x => x.TotalAmount)
				.Take(5)
				.Distinct()
				.ToList();

			for (int i = 0; i < top5Foods.Count; i++)
			{
				System.Windows.Forms.GroupBox grp = new System.Windows.Forms.GroupBox() { Width = 90, Height = 112, BackgroundImage = Image.FromFile("..\\..\\..\\Image\\background.png") };
				flwFood.Controls.Add(grp);
				CyberGroupBox cbrGrp = new CyberGroupBox() { Width = 60, Height = 70, Dock = DockStyle.Top, BackColor = Color.Transparent, ColorBackground = Color.FromArgb(223, 231, 195), BackgroundImage = Image.FromFile("..\\..\\..\\Image\\background.png") };
				grp.Controls.Add(cbrGrp);
				PictureBox pb = new PictureBox()
				{
					BackgroundImage = Image.FromFile(top5Foods[i].FoodImagePath),
					Width = 60,
					Height = 75,
					Dock = DockStyle.Top,
					BackgroundImageLayout = ImageLayout.Stretch,
				};
				cbrGrp.Controls.Add(pb);
				grp.Controls.Add(new Label() { Text = top5Foods[i].Key, ForeColor = Color.Black, Font = new Font(Font, FontStyle.Bold), Dock = DockStyle.Bottom, BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter });
			}
		}
		#endregion
	}
}
