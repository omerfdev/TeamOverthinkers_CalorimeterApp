using BLL;
using DrakeUI.Framework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorimeterUI
{
	public class Methods_HomeScreen
	{
		public static decimal TotalCarbonhydrateValue;
		public static decimal TotalProteinValue;
		public static decimal TotalFatValue;
		public static decimal TotalCalorieValue;

		public static decimal TargetedCarbonhydrateValue;
		public static decimal TargetedProteinValue;
		public static decimal TargetedFatValue;
		public static decimal TargetedCalories;

		public static void CalculateNutritionalValues(Foods foods, decimal amount)
		{
			TotalProteinValue += foods.ProteinValue * amount * 7.71m / 100;
			TotalCarbonhydrateValue += foods.CarbonHydrateValue * amount * 7.71m / 100;
			TotalFatValue += foods.FatValue * amount * 7.71m / 100;
			TotalCalorieValue += foods.Calories * amount / 100;
		}
		public static void CalculateTargetedCalorie()
		{
			Users user = new Users();
			BusinessLayer bl = new BusinessLayer();
			UserDetails ud = new UserDetails();
			user = bl.Users.Search(SignIn.UserID);
			ud = bl.UserDetails.Search(SignIn.UserID);

			if (ud.Gender == true)
			{
				TargetedCalories = (((10 * (ud.Weight)) + (6.25m * (ud.Height)) - (5 * (DateTime.Now.Year - ud.BirthDate.Year)) + 5) * ud.DailyActivity);
			}
			else if (ud.Gender == false)
			{
				TargetedCalories = (((10 * (ud.Weight)) + (6.25m * (ud.Height)) - (5 * (DateTime.Now.Year - ud.BirthDate.Year)) - 161) * ud.DailyActivity);
			}
			TargetedFatValue = TargetedCalories * 0.27m;
			TargetedCarbonhydrateValue = TargetedCalories * 0.50m;
			TargetedProteinValue = TargetedCalories * 0.23m;
		}
		public static void FillCMB(DrakeUIComboBox cmb)
		{
			List<DailyActivities> activities = new List<DailyActivities>()
			{
				new DailyActivities() { ActivityName = "Not Active At All", Ratio = 1.2m},
				new DailyActivities() { ActivityName = "Less Active", Ratio = 1.38m },
				new DailyActivities() { ActivityName = "Kind of active", Ratio = 1.55m },
				new DailyActivities() { ActivityName = "Active", Ratio = 1.73m },
				new DailyActivities() { ActivityName = "Sporty", Ratio = 1.9m }
			};
			cmb.DataSource = activities;
			cmb.DisplayMember = "ActivityName";
			cmb.ValueMember = "Ratio";
		}
	}
}
