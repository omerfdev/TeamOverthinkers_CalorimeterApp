using BLL;
using BLL.BLL;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminConsole
{
	public partial class Food : Form
	{
		public Food()
		{
			InitializeComponent();
		}
		BusinessLayer bll = new BusinessLayer();

		#region Food Form Load Process
		private void Food_Load(object sender, EventArgs e)
		{
			DGVFill();
			txtFoodID.Enabled = false;
			txtFoodImagePath.Enabled = false;
			txtFoodCategoryID.Enabled = false;
		}
		#endregion

		#region dgvFood Data Fill Process
		/// <summary>
		/// Method gives dgvFood data fill. 
		/// </summary>
		private void DGVFill()
		{
			dgvFood.DataSource = null;
			var result = bll.Foods.GetAll().Select(x => new { x.ID, x.FoodName, x.CategoryID, x.CarbonHydrateValue, x.ProteinValue, x.FatValue, x.Calories, x.FoodImagePath, x.FoodDescription, x.IsActive }).ToList();
			dgvFood.DataSource = result;
		}
		#endregion

		#region Button Add Process
		private void btnCategoryAdd_Click(object sender, EventArgs e)
		{
			Foods food = new Foods();
			food.CategoryID = int.Parse(txtFoodCategoryID.Text);
			food.FoodName = txtFoodName.Text;
			food.FoodImagePath = txtFoodImagePath.Text;
			food.FoodDescription = txtFoodDescription.Text;
			food.CarbonHydrateValue = nmrCarbonhydrateValue.Value;
			food.ProteinValue = nmrProteinValue.Value;
			food.FatValue = nmrFatValue.Value;
			food.Calories = nmrCalories.Value;
			food.IsActive = chkIsActive.Checked;

			try
			{
				if (pictureBox1.Image != null)
				{
					if (pictureBox1.Tag != null)
					{
						food.FoodImagePath = txtFoodImagePath.Text;
						System.IO.File.Copy(pictureBox1.Tag.ToString(), txtFoodImagePath.Text, true);
					}
					bll.Foods.Add(food);
					MessageBox.Show("Added successfully.");
					DGVFill();
					ClearControls();
				}
				else
				{
					MessageBox.Show("Please add a picture.");
				}

			}
			catch (Exception)
			{
				MessageBox.Show("The food is not added.");
			}
		}
		#endregion

		#region Button Delete Process
		private void btnCategoryDelete_Click(object sender, EventArgs e)
		{
			int selectedID = GetSelectedIDFromDataGridView();
			Foods_BLL foods_BLL = new Foods_BLL();
			Foods food = foods_BLL.Search(selectedID);
			if (food != null)
			{
				foods_BLL.Delete(food);
				MessageBox.Show("The food is deleted.");
			}
			else
			{
				MessageBox.Show("the food does not found.");
			}

			pictureBox1.Image = null;
			string imagePath = txtFoodImagePath.Text;
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
			File.Delete(imagePath);
			ClearControls();
			DGVFill();
		}
		#endregion

		#region Button Update Process
		private void btnCategoryUpdate_Click(object sender, EventArgs e)
		{
			int rowIndex = dgvFood.CurrentRow.Index;
			int selectedID = GetSelectedIDFromDataGridView();
			string foodName = txtFoodName.Text;
			string foodDescription = txtFoodDescription.Text;
			string imagePath = txtFoodImagePath.Text;
			bool isActive = chkIsActive.Checked;
			decimal calory = nmrCalories.Value;
			decimal fat = nmrFatValue.Value;
			decimal protein = nmrProteinValue.Value;
			decimal chdrate = nmrCarbonhydrateValue.Value;
			Foods_BLL foods_BLL = new Foods_BLL();
			Foods food = foods_BLL.Search(selectedID);

			if (food != null)
			{
				food.FoodName = foodName;
				food.FoodDescription = foodDescription;
				food.FoodImagePath = imagePath;
				food.IsActive = isActive;
				food.Calories = calory;
				food.FatValue = fat;
				food.ProteinValue = protein;
				food.CarbonHydrateValue = chdrate;
				pictureBox1.Image = null;
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				File.Delete(imagePath);
				System.IO.File.Copy(pictureBox1.Tag.ToString(), food.FoodImagePath, true);
				foods_BLL.Update(food);
				MessageBox.Show("The food is updated successfully");
			}
			else
			{
				MessageBox.Show("The food is not found");
			}
			ClearControls();
			DGVFill();
		}
		#endregion

		#region Food Form Controls Inputs Clear Process
		/// <summary>
		/// Method gives Food Form Controls Input Clear
		/// </summary>
		private void ClearControls()
		{
			txtFoodID.Text = string.Empty;
			txtFoodCategoryID.Text = string.Empty;
			txtFoodImagePath.Text = string.Empty;
			txtFoodDescription.Text = string.Empty;
			txtFoodName.Text = string.Empty;
			nmrCalories.Value = 0;
			nmrCarbonhydrateValue.Value = 0;
			nmrFatValue.Value = 0;
			nmrProteinValue.Value = 0;
			chkIsActive.Checked = true;
			pictureBox1.Image = null;
		}
		#endregion

		#region dgvFood Selected Row ID
		/// <summary>
		/// Method gives dgvFood selected row ID
		/// </summary>
		/// <returns></returns>
		private int GetSelectedIDFromDataGridView()
		{
			int selectedID = 0;

			if (dgvFood.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFood.SelectedRows[0];

				if (selectedRow.Cells["ID"].Value != null)
				{
					selectedID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
				}
			}
			return selectedID;
		}
		#endregion

		#region Button Add Picture Process
		private void btnAddPicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Food Picture (jpg)|*.jpg";
			DialogResult result = ofd.ShowDialog();
			if (result == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(ofd.FileName);
				string dosyaYolu = ofd.FileName;
				pictureBox1.Tag = dosyaYolu;
				string foodCategoryID = txtFoodCategoryID.Text;
				string foodName = txtFoodName.Text;
				txtFoodImagePath.Text = "..\\..\\..\\Image\\Images\\" + foodCategoryID + "\\" + foodName + ".jpg";
			}
		}
		#endregion

		#region Button Refresh Process
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ClearControls();
			DGVFill();
		}
		#endregion

		#region Button Category Name Show Process
		private void btnCategoryNameShow_Click(object sender, EventArgs e)
		{
			string text = "";
			var result = bll.Categories.GetAll().Select(x => new { x.ID, x.CategoryName }).ToList();
			foreach (var item in result)
			{
				text = text + item.ID + ": " + item.CategoryName + "\n";
			}
			MessageBox.Show(text);
			txtFoodCategoryID.Enabled = true;
		}
		#endregion

		#region dgvFood Cell Mouse Double Click Process
		private void dgvFood_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0 && rowIndex < dgvFood.Rows.Count)
			{
				DataGridViewRow selectedRow = dgvFood.Rows[rowIndex];
				txtFoodID.Text = selectedRow.Cells["ID"].Value.ToString();
				txtFoodName.Text = selectedRow.Cells["FoodName"].Value.ToString();
				txtFoodCategoryID.Text = selectedRow.Cells["CategoryID"].Value.ToString();
				txtFoodImagePath.Text = selectedRow.Cells["FoodImagePath"].Value.ToString();
				txtFoodDescription.Text = selectedRow.Cells["FoodDescription"].Value.ToString();
				chkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);
				nmrCalories.Value = Convert.ToDecimal(selectedRow.Cells["Calories"].Value);
				nmrCarbonhydrateValue.Value = Convert.ToDecimal(selectedRow.Cells["CarbonhydrateValue"].Value);
				nmrFatValue.Value = Convert.ToDecimal(selectedRow.Cells["FatValue"].Value);
				nmrProteinValue.Value = Convert.ToDecimal(selectedRow.Cells["ProteinValue"].Value);
				pictureBox1.Image = Image.FromFile(txtFoodImagePath.Text);
			}
		}
		#endregion
	}
}
