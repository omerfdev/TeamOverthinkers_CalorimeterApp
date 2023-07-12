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
	public partial class RemoveFood : Form
	{
		public RemoveFood()
		{
			InitializeComponent();
		}
		BusinessLayer bl = new BusinessLayer();
		private void BringFoods()
		{
			int mealID = Meals.MealId;

			var foodList = bl.User_Food_Meal.SearchFoodHistory(SignIn.UserID).Where(x => x.MealID == mealID).ToList();
			for (int i = 0; i < foodList.Count; i++)
			{
				System.Windows.Forms.GroupBox grp = new System.Windows.Forms.GroupBox() { Width = 90, Height = 112 };
				flowLayoutPanel1.Controls.Add(grp);
				CyberGroupBox cbrGrp = new CyberGroupBox() { Width = 60, Height = 70, Dock = DockStyle.Top, BackColor = Color.Transparent, ColorBackground = Color.FromArgb(223, 231, 195), BackgroundImage = Image.FromFile("..\\..\\..\\Image\\background.png") };
				grp.Controls.Add(cbrGrp);
				PictureBox pb = new PictureBox()
				{
					BackgroundImage = Image.FromFile(foodList[i].Foods.FoodImagePath),
					Width = 60,
					Height = 75,
					Dock = DockStyle.Top,
					Tag = foodList[i].Foods.ID,
					Cursor = Cursors.Hand,
					BackgroundImageLayout = ImageLayout.Stretch,
				};
				pb.Click += Click;
				cbrGrp.Controls.Add(pb);
				grp.Controls.Add(new Label() { Text = foodList[i].Foods.FoodName, ForeColor = Color.Black, Font = new Font(Font, FontStyle.Bold), Dock = DockStyle.Bottom, BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter });
			}
		}
		private void RemoveFood_Load(object sender, EventArgs e)
		{
			BringFoods();
		}
		private void Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			User_Food_Meal ufm = new User_Food_Meal();
			Foods foods = bl.Foods.Search((int)pictureBox.Tag);
		}
	}
}
