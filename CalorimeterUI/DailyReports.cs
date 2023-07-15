using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorimeterUI
{
	public partial class DailyReports : Form
	{
		public DailyReports()
		{
			InitializeComponent();
		}
		BusinessLayer bl = new BusinessLayer();

		#region Button WeaklyMeal Process

		private void btnWeeklyMeal_Click(object sender, EventArgs e)
		{
			var weeklyComparison = bl.User_Food_Meal.GetAll()
				.Join(bl.Meal.GetAll(), ufm => ufm.MealID, m => m.ID, (ufm, m) => new { Week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear((DateTime)ufm.CreateDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday), MealName = m.MealName })
					 .GroupBy(x => new { x.Week, x.MealName })
					 .Select(g => new { Week = g.Key.Week, MealName = g.Key.MealName, MealCount = g.Count() })
					 .ToList();
			dgvReports.DataSource = weeklyComparison;
		}
		#endregion

		#region Button MontlyMeal Process
		private void btnMonthlyMeal_Click(object sender, EventArgs e)
		{
			var result = bl.User_Food_Meal.GetAll();
			var monthlyComparison = result
				.Where(x => x.CreateDate.HasValue)
				.GroupBy(x => new { Month = x.CreateDate.Value.Month, x.MealID })
				.Select(g => new { Month = g.Key.Month, MealName = bl.Meal.Search(g.Key.MealID).MealName, MealCount = g.Count() })
				.ToList();
			dgvReports.DataSource = monthlyComparison;
		}
		#endregion

		#region Button WeeklyFoods Process
		private void btnWeeklyFoods_Click(object sender, EventArgs e)
		{
			var weeklyFoodComparison = bl.User_Food_Meal.GetAll()
			  .GroupBy(x => new { Week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear((DateTime)x.CreateDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday), x.FoodID })
			  .Select(g => new { Week = g.Key.Week, FoodName = bl.Foods.Search(g.Key.FoodID).FoodName, FoodCount = g.Count() })
			  .ToList();
			dgvReports.DataSource = weeklyFoodComparison;
		}
		#endregion

		#region Button MonthlyFoods Process 
		private void btnMonthlyFoods_Click(object sender, EventArgs e)
		{
			var monthlyFoodComparison = bl.User_Food_Meal.GetAll()
					.Where(x => x.CreateDate.HasValue)
					.GroupBy(x => new { Month = x.CreateDate.Value.Month, x.FoodID })
					.Select(g => new { Month = g.Key.Month, FoodName = bl.Foods.Search(g.Key.FoodID).FoodName, FoodCount = g.Count() })
					.ToList();
			dgvReports.DataSource = monthlyFoodComparison;
		}
		#endregion

		private void DailyReports_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
		}
	}
}
