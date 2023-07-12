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
	public partial class FoodForm : Form
	{
		public FoodForm()
		{
			InitializeComponent();
		}
		BusinessLayer bl = new BusinessLayer();
		Foods selectedFood;
		private void Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;

			Foods foods = bl.Foods.Search((int)pictureBox.Tag);

			selectedFood = foods;
			lblFoodName.Text = foods.FoodName;
			lblFoodDescription.Text = $"({foods.FoodDescription})";
			txtAmount.Text = "100";
			lblShowCalories.Text = (selectedFood.Calories * decimal.Parse(txtAmount.Text) / 100).ToString() + " kcal";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (lblFoodName.Text != string.Empty)
			{

				BusinessLayer bll = new BusinessLayer();

				User_Food_Meal user_Food_Meal = new User_Food_Meal()
				{
					UserID = SignIn.UserID,
					FoodID = selectedFood.ID,
					MealID = Meals.MealId,
					Amount = decimal.Parse(txtAmount.Text)
				};
				bll.User_Food_Meal.Add(user_Food_Meal);
				MessageBox.Show("Your meal has been added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please select a food first");
			}
			this.Close();
		}
		private void OnlyNumberTextBox(TextBox txt)
		{
			// put this method in TextBox_Changed
			if (System.Text.RegularExpressions.Regex.IsMatch(txt.Text, "[^0-9]"))
			{
				txt.Text = txt.Text.Remove(txt.Text.Length - 1);
				txt.SelectionStart = txt.Text.Length;
			}
		}
		#region 'Minimize' Button
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnMinimize_MouseEnter(object sender, EventArgs e)
		{
			btnMinimize.ForeColor = Color.DarkKhaki;
		}

		private void btnMinimize_MouseLeave(object sender, EventArgs e)
		{
			btnMinimize.ForeColor = Color.Olive;
		}
		#endregion

		#region Text Amount Changed Process
		private void txtAmount_TextChanged(object sender, EventArgs e)
		{
			OnlyNumberTextBox(txtAmount);
			if (txtAmount.Text.Length > 0)
			{
				lblShowCalories.Text = (selectedFood.Calories * decimal.Parse(txtAmount.Text) / 100).ToString() + " kcal";
			}
		}
		#endregion

		#region 'X' Button
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnExit_MouseEnter(object sender, EventArgs e)
		{
			btnExit.ForeColor = Color.DarkKhaki;
		}

		private void btnExit_MouseLeave(object sender, EventArgs e)
		{
			btnExit.ForeColor = Color.Olive;
		}
		#endregion
	}
}
