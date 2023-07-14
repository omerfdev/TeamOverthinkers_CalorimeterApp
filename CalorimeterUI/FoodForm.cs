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
	public partial class FoodForm : Form
	{
		public FoodForm()
		{
			InitializeComponent();
		}
		BusinessLayer bl = new BusinessLayer();
		Foods selectedFood;

		#region PictureBox Click Event Process
		/// <summary>
		/// Method gives Click Events.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			Foods foods = bl.Foods.Search((int)pictureBox.Tag);
			selectedFood = foods;
			lblFoodName.Text = foods.FoodName;
			lblFoodDescription.Text = $"({foods.FoodDescription})";
			txtAmount.Text = "100";
			lblShowCalories.Text = (selectedFood.Calories * decimal.Parse(txtAmount.Text) / 100).ToString() + " Kcal";
		}
		#endregion

		#region Button Add Process
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
		#endregion

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
			UI_Methods.Methods.OnlyNumberTextBox(txtAmount);
			if (txtAmount.Text.Length > 0)
			{
				lblShowCalories.Text = (selectedFood.Calories * decimal.Parse(txtAmount.Text) / 100).ToString() + " Kcal";
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

		#region Food Form Load Process
		private void FoodForm_Load(object sender, EventArgs e)
		{
			FillFoods();
			txtAmount.Enabled = false;
		}
		#endregion

		#region flwFood Add Into Foods Process 
		/// <summary>
		/// Method gives flwFood Add Into Food
		/// </summary>
		private void FillFoods()
		{
			int categoryID = Categories.CategoryID;
			var foodCount = bl.Foods.GetAll().Where(x => x.CategoryID == categoryID).Count();
			for (int i = 0; i < foodCount; i++)
			{
				System.Windows.Forms.GroupBox grp = new System.Windows.Forms.GroupBox() { Width = 90, Height = 112 };
				flwFood.Controls.Add(grp);
				CyberGroupBox cbrGrp = new CyberGroupBox() { Width = 60, Height = 70, Dock = DockStyle.Top, BackColor = Color.Transparent, ColorBackground = Color.FromArgb(223, 231, 195), BackgroundImage = Image.FromFile("..\\..\\..\\Image\\background.png") };
				grp.Controls.Add(cbrGrp);
				Foods foods = (Foods)bl.Foods.GetAll().Where(x => x.CategoryID == categoryID).ElementAt(i);
				PictureBox pb = new PictureBox()
				{
					BackgroundImage = Image.FromFile(foods.FoodImagePath),
					Width = 60,
					Height = 75,
					Dock = DockStyle.Top,
					Tag = foods.ID,
					Cursor = Cursors.Hand,
					BackgroundImageLayout = ImageLayout.Stretch,
				};
				pb.Click += Click;
				cbrGrp.Controls.Add(pb);
				grp.Controls.Add(new Label() { Text = foods.FoodName, ForeColor = Color.Black, Font = new Font(Font, FontStyle.Bold), Dock = DockStyle.Bottom, BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter });
			}
		}
		#endregion
	}
}
