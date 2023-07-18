using BLL;
using BLL.BLL;
using CalorimeterUI;
using Entities;
using System.Data;
using Categories = Entities.Categories;

namespace AdminCategory
{
	public partial class Category : Form
	{
		public Category()
		{
			InitializeComponent();
		}
		BusinessLayer bll = new BusinessLayer();
		
		#region Category Form Load Event Process 
		private void Category_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
			GridFill();
			chkIsActive.Checked = true;
			txtCategoryID.Enabled = false;
			txtCategoryImagePath.Enabled = false;

		}
		#endregion

		#region dgvCategories Fill
		/// <summary>
		/// Method gives dgvCategories  data Fill process.
		/// </summary>
		private void GridFill()
		{
			dgvCategories.DataSource = null;

			var result = bll.Categories.GetAll().Select(x => new { x.ID, x.CategoryName, x.CategoryDescription, x.ImagePath, x.IsActive }).ToList();
			var result2 = bll.CategoryDetails.GetAll().Select(x => new { x.ID, x.IsAllergen, x.IsGlutenFree, x.HasLactose, x.IsVegaterian }).ToList();

			var joinedResult = result.Join(result2, r => r.ID, r2 => r2.ID, (r, r2) => new
			{
				r.ID,
				r.CategoryName,
				r.CategoryDescription,
				r.ImagePath,
				r.IsActive,
				r2.IsAllergen,
				r2.IsGlutenFree,
				r2.HasLactose,
				r2.IsVegaterian
			}).ToList();

			dgvCategories.DataSource = joinedResult;

		}
		#endregion

		#region Button Add Process
		private void btnCategoryAdd_Click(object sender, EventArgs e)
		{

			Categories category = new Categories();
			category.CategoryName = txtCategoryName.Text;
			category.CategoryDescription = txtCategoryDescription.Text;
			category.ImagePath = txtCategoryImagePath.Text;
			category.IsActive = chkIsActive.Checked;

			CategoryDetails categoryDetails = new CategoryDetails();
			categoryDetails.IsAllergen = chkIsAllergen.Checked;
			categoryDetails.IsGlutenFree = chkIsGlutenFree.Checked;
			categoryDetails.HasLactose = chkHasLactose.Checked;
			categoryDetails.IsVegaterian = chkIsVegaterian.Checked;
			try
			{
				if (pbCategory.Image != null)
				{
					if (pbCategory.Tag != null)
					{
						category.ImagePath = txtCategoryImagePath.Text;
						System.IO.File.Copy(pbCategory.Tag.ToString(), txtCategoryImagePath.Text, true);
					}

					bll.Categories.Add(category);

					categoryDetails.CategoryID = category.ID;
					bll.CategoryDetails.Add(categoryDetails);
					int categoryID = category.ID;
					string folderName = categoryID.ToString();
					string dosyaYolu = Path.Combine(@"..\..\..\Image\Images", folderName);
					Directory.CreateDirectory(dosyaYolu);
					MessageBox.Show("Directory Created.");
					MessageBox.Show("Added Successfully");
					ClearControls();
					GridFill();

				}
				else
				{
					MessageBox.Show("Please add a picture.");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("The product is not added.");
			}
		}
		#endregion

		#region Category Form Controls Input Clear Process
		/// <summary>
		/// Form Controls Clear.
		/// </summary>
		private void ClearControls()
		{
			txtCategoryID.Text = string.Empty;
			txtCategoryName.Text = string.Empty;
			txtCategoryDescription.Text = string.Empty;
			txtCategoryImagePath.Text = string.Empty;
			chkIsActive.Checked = true;
			chkIsAllergen.Checked = false;
			chkHasLactose.Checked = false;
			chkIsGlutenFree.Checked = false;
			chkIsVegaterian.Checked = false;
			pbCategory.Image = null;
		}
		#endregion

		#region Button Delete Process
		private void btnCategoryDelete_Click(object sender, EventArgs e)
		{
			int selectedID = GetSelectedIDFromDataGridView();
			Categories_BLL categoriesBLL = new Categories_BLL();
			Categories category = categoriesBLL.Search(selectedID);
			if (category != null)
			{
				categoriesBLL.Delete(category);
				pbCategory.Image = null;
				string imagePath = txtCategoryImagePath.Text;
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				File.Delete(imagePath);
				MessageBox.Show("Deleted successfully");
				string folderName = category.ID.ToString();
				string folderPath = Path.Combine(@"..\..\..\Image\Images", folderName);
				try
				{

					Directory.Delete(folderPath, true);

				}
				catch (Exception ex)
				{
					MessageBox.Show("Folder not deleted: " + ex.Message);
				}
				ClearControls();
				GridFill();
			}
			else
			{
				MessageBox.Show("Category not found");
			}
		}
		#endregion

		#region dgvCategories Selected row ID Process
		/// <summary>
		/// Method gives dgvCategory selected row ID
		/// </summary>
		/// <returns></returns>
		private int GetSelectedIDFromDataGridView()
		{
			int selectedID = 0;
			if (dgvCategories.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvCategories.SelectedRows[0];
				if (selectedRow.Cells["ID"].Value != null)
				{
					selectedID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
				}
			}
			return selectedID;
		}
		#endregion

		#region Button Update Process
		private void btnCategoryUpdate_Click(object sender, EventArgs e)
		{
			int rowIndex = dgvCategories.CurrentRow.Index;
			int selectedID = GetSelectedIDFromDataGridView();
			string categoryName = txtCategoryName.Text;
			string categoryDescription = txtCategoryDescription.Text;
			string imagePath = txtCategoryImagePath.Text;
			bool isActive = chkIsActive.Checked;
			bool isAllergen = chkIsAllergen.Checked;
			bool isGlutenFree = chkIsGlutenFree.Checked;
			bool hasLactose = chkHasLactose.Checked;
			bool isVegetarian = chkIsVegaterian.Checked;
			Categories_BLL categoriesBLL = new Categories_BLL();
			Categories category = categoriesBLL.Search(selectedID);
			if (category != null)
			{
				category.CategoryName = categoryName;
				category.CategoryDescription = categoryDescription;
				category.ImagePath = imagePath;
				category.IsActive = isActive;
				categoriesBLL.Update(category);
				pbCategory.Image = null;
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				File.Delete(imagePath);
				System.IO.File.Copy(pbCategory.Tag.ToString(), imagePath, true);
				MessageBox.Show("Updated Category Successfully");
			}
			else
			{
				MessageBox.Show("Category not found");
			}
			CategoryDetails_BLL categoryDetailsBLL = new CategoryDetails_BLL();
			CategoryDetails categoryDetails = categoryDetailsBLL.Search(selectedID);
			if (categoryDetails != null)
			{
				categoryDetails.IsAllergen = isAllergen;
				categoryDetails.IsGlutenFree = isGlutenFree;
				categoryDetails.HasLactose = hasLactose;
				categoryDetails.IsVegaterian = isVegetarian;
				categoryDetailsBLL.Update(categoryDetails);
				MessageBox.Show("Updated Category Details Successfully");
			}
			else
			{
				MessageBox.Show("Category Details");
			}
			GridFill();
			ClearControls();
		}
		#endregion

		#region Button Add Picture Process
		private void btnAddPicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Category Picture (jpg)|*.jpg";
			DialogResult result = ofd.ShowDialog();
			if (result == DialogResult.OK)
			{
				pbCategory.Image = Image.FromFile(ofd.FileName);
				string folderName = ofd.FileName;
				pbCategory.Tag = folderName;
				string categoryName = txtCategoryName.Text;
				txtCategoryImagePath.Text = "..\\..\\..\\Image\\Images\\categories\\" + categoryName + ".jpg";
			}
		}
		#endregion

		#region Button Resfesh Click Event Process
		private void btnCategoryRefresh_Click(object sender, EventArgs e)
		{
			GridFill();
			ClearControls();
		}
		#endregion

		#region dgvCategories Cell Mouse Double Click Event process
		private void dgvCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0 && rowIndex < dgvCategories.Rows.Count)
			{
				DataGridViewRow selectedRow = dgvCategories.Rows[rowIndex];
				txtCategoryName.Text = selectedRow.Cells["CategoryName"].Value.ToString();
				txtCategoryDescription.Text = selectedRow.Cells["CategoryDescription"].Value.ToString();
				txtCategoryImagePath.Text = selectedRow.Cells["ImagePath"].Value.ToString();
				txtCategoryID.Text = selectedRow.Cells["ID"].Value.ToString();
				chkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);
				chkIsAllergen.Checked = Convert.ToBoolean(selectedRow.Cells["IsAllergen"].Value);
				chkIsGlutenFree.Checked = Convert.ToBoolean(selectedRow.Cells["IsGlutenFree"].Value);
				chkHasLactose.Checked = Convert.ToBoolean(selectedRow.Cells["HasLactose"].Value);
				chkIsVegaterian.Checked = Convert.ToBoolean(selectedRow.Cells["IsVegaterian"].Value);
				pbCategory.Image = Image.FromFile(txtCategoryImagePath.Text);
			}
		}
		#endregion
	}
}