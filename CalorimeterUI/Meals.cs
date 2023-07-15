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
	public partial class Meals : Form
	{
		public List<User_Food_Meal> UserMeals { get; set; }
		public static int MealId;
		public Meals()
		{
			InitializeComponent();
		}

		#region Meals Form Load Process 
		private void Meals_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
			dtNow.Value = DateTime.Now;
			btnAddBreakfast.Click += Click;
			btnAddLunch.Click += Click;
			btnAddDinner.Click += Click;
			btnAddSnacks.Click += Click;
			btnRemoveBreakfast.Click += RemoveClick;
			btnRemoveDinner.Click += RemoveClick;
			btnRemoveLunch.Click += RemoveClick;
			btnRemoveSnack.Click += RemoveClick;
		}
		#endregion

		#region Click Event Process
		/// <summary>
		/// Method gives Click Events. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Click(object sender, EventArgs e)
		{
			CyberButton btn = (CyberButton)sender;
			Categories addMeal = new Categories();
			MealId = Convert.ToInt32(btn.Tag);
			addMeal.Owner = this;
			addMeal.ShowDialog();
			AddToGroupBoxGroup();
			dtNow.Value = DateTime.Now;
		}
		#endregion

		#region Meals Form Add to GroupBoxGroup process.
		/// <summary>
		/// Method gives Meals Form Add To GroupBoxGroup
		/// </summary>
		private void AddToGroupBoxGroup()
		{
			flpBreakfast.Controls.Clear();
			flpDinner.Controls.Clear();
			flpLunch.Controls.Clear();
			flpSnacks.Controls.Clear();
			AddToGroupBox(flpBreakfast);
			AddToGroupBox(flpLunch);
			AddToGroupBox(flpDinner);
			AddToGroupBox(flpSnacks);
		}
		#endregion

		#region Meals Form Remove Click Event process 
		private void RemoveClick(object sender, EventArgs e)
		{
			CyberButton btn = (CyberButton)sender;
			RemoveFood removeFoods = new RemoveFood();
			MealId = Convert.ToInt32(btn.Tag);
			removeFoods.Owner = this;
			removeFoods.ShowDialog();
		}
		#endregion

		#region Meals Form Add to GroupBox process
		/// <summary>
		/// Method gives Add To GroupBox
		/// </summary>
		/// <param name="flp"></param>
		private void AddToGroupBox(FlowLayoutPanel flp)
		{
			int userid = SignIn.UserID;
			BusinessLayer bll = new BusinessLayer();
			UserMeals = bll.User_Food_Meal.SearchFoodHistory(userid).Where(x => x.MealID == Convert.ToInt32(flp.Tag)).ToList();
			for (int i = 0; i < UserMeals.Count; i++)
			{
				UI_Methods.Methods.CalculateNutritionalValues(UserMeals[i].Foods, UserMeals[i].Amount);
				FillPanel(UserMeals[i], flp);
			}
		}
		#endregion

		#region Fill Panel process
		private void FillPanel(User_Food_Meal userMeal, FlowLayoutPanel flp)
		{
			Label label = new Label();
			label.Parent = flp;
			string text = userMeal.Foods?.FoodName + "-" + Math.Floor(userMeal.Foods.Calories * userMeal.Amount / 100).ToString() + " Kcal";
			label.Text = text;
			label.AutoSize = true;
			flp.Controls.Add(label);
		}
		#endregion

		#region Configure Bars process
		public void ConfigureBars()
		{
			UI_Methods.Methods.CalculateTargetedCalorie();
			progressBarCarbonhydrate.MaxValue = (int)UI_Methods.Methods.TargetedCarbonhydrateValue;
			progressBarCarbonhydrate.Value = (int)UI_Methods.Methods.TotalCarbonhydrateValue;
			progressBarProtein.MaxValue = (int)UI_Methods.Methods.TargetedProteinValue;
			progressBarProtein.Value = (int)UI_Methods.Methods.TotalProteinValue;
			progressBarFat.MaxValue = (int)UI_Methods.Methods.TargetedFatValue;
			progressBarFat.Value = (int)UI_Methods.Methods.TotalFatValue;
			int result = Convert.ToInt32(UI_Methods.Methods.TotalCalorieValue * 100 / UI_Methods.Methods.TargetedCalories);
			crclProgressBarDailyCalories.percentage = result;
		}
		#endregion

		#region dtNow Value Changed process
		private void dtNow_ValueChanged(object sender, EventArgs e)
		{
			Methods.TotalCalorieValue = 0;
			Methods.TotalFatValue = 0;
			Methods.TotalProteinValue = 0;
			Methods.TotalCarbonhydrateValue = 0;
			ButtonEnabledDisabled();
			AddToGroupBoxGroup();
			ConfigureBars();
		}
		#endregion

		#region Button Enabled process
		private void ButtonEnabledDisabled()
		{
			if (dtNow.Value.Date != DateTime.Now.Date)
			{
				ButtonEnabledDisabledConfig(false);
			}
			else if (dtNow.Value.Date == DateTime.Now.Date)
			{
				ButtonEnabledDisabledConfig(true);
			}
		}
		#endregion

		#region Button Enabled Disabled Config process
		private void ButtonEnabledDisabledConfig(bool condition)
		{
			foreach (var item in this.Controls)
			{
				if (item is CyberButton)
				{
					CyberButton cbButton = (CyberButton)item;
					cbButton.Enabled = condition;
				}
			}
		}
		#endregion
	}
}
