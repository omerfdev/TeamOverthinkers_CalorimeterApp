using BLL;
using BLL.BLL;
using Entities;
using System.Data;

namespace AdminCategory
{
	public partial class Category : Form
	{
		public Category()
		{
			InitializeComponent();
		}
		BusinessLayer bll = new BusinessLayer();
		private void Category_Load(object sender, EventArgs e)
		{
			GridFill();
			chkIsActive.Checked = true;
			txtCategoryID.Enabled = false;
			txtCategoryImagePath.Enabled = false;

		}

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


					// Yeni klasörün adýný Category.ID'ye eþit olarak belirleyin
					int categoryID = category.ID; // Varsayýlan olarak guncellenecekCategory olarak kabul edelim
					string klasorAdi = categoryID.ToString();

					// Klasörün oluþturulacaðý dosya yolunu belirleyin
					string dosyaYolu = Path.Combine(@"..\..\..\Resources\Images", klasorAdi);

					// Klasörü oluþturun (varsa tekrar oluþturmayacak)
					Directory.CreateDirectory(dosyaYolu);

					// Ýþlem tamamlandý mesajýný kullanýcýya bildir
					MessageBox.Show("Klasör oluþturuldu.");


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

		private void btnCategoryDelete_Click(object sender, EventArgs e)
		{


			int selectedID = GetSelectedIDFromDataGridView();


			Categories_BLL categoriesBLL = new Categories_BLL();
			Categories category = categoriesBLL.Search(selectedID);
			if (category != null)
			{
				//delete category:
				categoriesBLL.Delete(category);

				//delete picture:
				pbCategory.Image = null;
				string imagePath = txtCategoryImagePath.Text;
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				File.Delete(imagePath);


				MessageBox.Show("Deleted successfully");


				// To delete folder:
				string folderName = category.ID.ToString();
				string folderPath = Path.Combine(@"..\..\..\Resources\Images", folderName);

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

			// Update category
			Categories_BLL categoriesBLL = new Categories_BLL();
			Categories category = categoriesBLL.Search(selectedID);
			if (category != null)
			{
				category.CategoryName = categoryName;
				category.CategoryDescription = categoryDescription;
				category.ImagePath = imagePath;
				category.IsActive = isActive;

				categoriesBLL.Update(category);


				//delete old picture:
				pbCategory.Image = null;
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				File.Delete(imagePath);
				//add new picture:
				System.IO.File.Copy(pbCategory.Tag.ToString(), imagePath, true);

				MessageBox.Show("Updated Category Successfully");
			}
			else
			{
				MessageBox.Show("Category not found");
			}

			// Update Category Details
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

		private void btnAddPicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Category Picture (jpg)|*.jpg";
			DialogResult result = ofd.ShowDialog();
			if (result == DialogResult.OK)
			{
				//bring picture to picturebox:
				pbCategory.Image = Image.FromFile(ofd.FileName);

				//assign path of picture to tag of picturebox:
				string dosyaYolu = ofd.FileName;
				pbCategory.Tag = dosyaYolu;


				//bring path to txtFoodImagePath' e :
				string categoryName = txtCategoryName.Text;
				txtCategoryImagePath.Text = "..\\..\\..\\Resources\\Images\\categories\\" + categoryName + ".jpg";


			}
		}

		private void btnCategoryRefresh_Click(object sender, EventArgs e)
		{
			GridFill();
			ClearControls();
		}

		private void dgvCategories_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

				//bring picture
				pbCategory.Image = Image.FromFile(txtCategoryImagePath.Text);
			}
		}
	}
}