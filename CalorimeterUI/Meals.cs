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

		private void Meals_Load(object sender, EventArgs e)
		{
			UI_Methods.Methods.TotalCalorieValue = 0;
			UI_Methods.Methods.TotalFatValue = 0;
			UI_Methods.Methods.TotalProteinValue = 0;
			UI_Methods.Methods.TotalCarbonhydrateValue = 0;

			btnAddBreakfast.Click += Click;
			btnAddLunch.Click += Click;
			btnAddDinner.Click += Click;
			btnAddSnacks.Click += Click;

			btnRemoveBreakfast.Click += RemoveClick;
			btnRemoveDinner.Click += RemoveClick;
			btnRemoveLunch.Click += RemoveClick;
			btnRemoveSnack.Click += RemoveClick;

			AddToGroupBox(flpBreakfast);
			AddToGroupBox(flpLunch);
			AddToGroupBox(flpDinner);
			AddToGroupBox(flpSnacks);

			BusinessLayer bl = new BusinessLayer();
			if (bl.User_Food_Meal.SearchFoodHistory(SignIn.UserID).Count() > 0)
			{
				ConfigureBars();
			}
		}
		private void Click(object sender, EventArgs e)
		{
			CyberButton btn = (CyberButton)sender;

			Categories addMeal = new Categories();
			MealId = Convert.ToInt32(btn.Tag);
			addMeal.Owner = this;
			addMeal.ShowDialog();
			flpBreakfast.Controls.Clear();
			flpDinner.Controls.Clear();
			flpLunch.Controls.Clear();
			flpSnacks.Controls.Clear();
			AddToGroupBox(flpBreakfast);
			AddToGroupBox(flpLunch);
			AddToGroupBox(flpDinner);
			AddToGroupBox(flpSnacks);
		}
		private void RemoveClick(object sender, EventArgs e)
		{
			CyberButton btn = (CyberButton)sender;
			RemoveFood removeFoods = new RemoveFood();
			MealId = Convert.ToInt32(btn.Tag);
			removeFoods.Owner = this;
			removeFoods.ShowDialog();
		}

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

		private void FillPanel(User_Food_Meal userMeal, FlowLayoutPanel flp)
		{
			Label label = new Label();
			label.Parent = flp;
			string text = userMeal.Foods?.FoodName + "-" + Math.Floor(userMeal.Foods.Calories * userMeal.Amount / 100).ToString() + " kcal";
			label.Text = text;
			label.AutoSize = true;
			flp.Controls.Add(label);
		}

		public void ConfigureBars()
		{
			UI_Methods.Methods.CalculateTargetedCalorie();


			parrotFlatProgressBar1.MaxValue = (int)UI_Methods.Methods.TargetedCarbonhydrateValue;
			parrotFlatProgressBar1.Value = (int)UI_Methods.Methods.TotalCarbonhydrateValue;

			parrotFlatProgressBar2.MaxValue = (int)UI_Methods.Methods.TargetedProteinValue;
			parrotFlatProgressBar2.Value = (int)UI_Methods.Methods.TotalProteinValue;

			parrotFlatProgressBar3.MaxValue = (int)UI_Methods.Methods.TargetedFatValue;
			parrotFlatProgressBar3.Value = (int)UI_Methods.Methods.TotalFatValue;

			int result = Convert.ToInt32(UI_Methods.Methods.TotalCalorieValue * 100 / UI_Methods.Methods.TargetedCalories);
			crclProgressBarDailyCalories.percentage = result;
		}
	}
}
