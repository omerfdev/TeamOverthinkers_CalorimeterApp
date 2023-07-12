namespace AdminCategory
{
	partial class Category
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
			lblCategoryName = new Label();
			lblCtgImagePath = new Label();
			lblCategoryDescripition = new Label();
			lblCategoryID = new Label();
			txtCategoryID = new ReaLTaiizor.Controls.DungeonTextBox();
			txtCategoryName = new ReaLTaiizor.Controls.DungeonTextBox();
			txtCategoryDescription = new ReaLTaiizor.Controls.DungeonTextBox();
			txtCategoryImagePath = new ReaLTaiizor.Controls.DungeonTextBox();
			btnCategoryAdd = new DrakeUI.Framework.DrakeUIButton();
			btnCategoryDelete = new DrakeUI.Framework.DrakeUIButton();
			btnCategoryUpdate = new DrakeUI.Framework.DrakeUIButton();
			dgvCategories = new DataGridView();
			chkIsActive = new CheckBox();
			chkIsAllergen = new CheckBox();
			chkIsGlutenFree = new CheckBox();
			chkHasLactose = new CheckBox();
			chkIsVegaterian = new CheckBox();
			pbCategory = new PictureBox();
			btnAddPicture = new Button();
			btnCategoryRefresh = new DrakeUI.Framework.DrakeUIButton();
			((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbCategory).BeginInit();
			SuspendLayout();
			// 
			// lblCategoryName
			// 
			lblCategoryName.AutoSize = true;
			lblCategoryName.BackColor = Color.Transparent;
			lblCategoryName.Location = new Point(12, 63);
			lblCategoryName.Name = "lblCategoryName";
			lblCategoryName.Size = new Size(49, 20);
			lblCategoryName.TabIndex = 77;
			lblCategoryName.Text = "Name";
			// 
			// lblCtgImagePath
			// 
			lblCtgImagePath.AutoSize = true;
			lblCtgImagePath.BackColor = Color.Transparent;
			lblCtgImagePath.Location = new Point(12, 171);
			lblCtgImagePath.Name = "lblCtgImagePath";
			lblCtgImagePath.Size = new Size(79, 20);
			lblCtgImagePath.TabIndex = 79;
			lblCtgImagePath.Text = "ImagePath";
			// 
			// lblCategoryDescripition
			// 
			lblCategoryDescripition.AutoSize = true;
			lblCategoryDescripition.BackColor = Color.Transparent;
			lblCategoryDescripition.Location = new Point(12, 117);
			lblCategoryDescripition.Name = "lblCategoryDescripition";
			lblCategoryDescripition.Size = new Size(89, 20);
			lblCategoryDescripition.TabIndex = 80;
			lblCategoryDescripition.Text = "Descripition";
			// 
			// lblCategoryID
			// 
			lblCategoryID.AutoSize = true;
			lblCategoryID.BackColor = Color.Transparent;
			lblCategoryID.Location = new Point(12, 9);
			lblCategoryID.Name = "lblCategoryID";
			lblCategoryID.Size = new Size(24, 20);
			lblCategoryID.TabIndex = 76;
			lblCategoryID.Text = "ID";
			// 
			// txtCategoryID
			// 
			txtCategoryID.BackColor = Color.Transparent;
			txtCategoryID.BorderColor = Color.FromArgb(180, 180, 180);
			txtCategoryID.EdgeColor = Color.White;
			txtCategoryID.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtCategoryID.ForeColor = Color.DimGray;
			txtCategoryID.Location = new Point(12, 27);
			txtCategoryID.MaxLength = 32767;
			txtCategoryID.Multiline = false;
			txtCategoryID.Name = "txtCategoryID";
			txtCategoryID.ReadOnly = false;
			txtCategoryID.Size = new Size(285, 33);
			txtCategoryID.TabIndex = 82;
			txtCategoryID.TextAlignment = HorizontalAlignment.Left;
			txtCategoryID.UseSystemPasswordChar = false;
			// 
			// txtCategoryName
			// 
			txtCategoryName.BackColor = Color.Transparent;
			txtCategoryName.BorderColor = Color.FromArgb(180, 180, 180);
			txtCategoryName.EdgeColor = Color.White;
			txtCategoryName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtCategoryName.ForeColor = Color.DimGray;
			txtCategoryName.Location = new Point(12, 81);
			txtCategoryName.MaxLength = 32767;
			txtCategoryName.Multiline = false;
			txtCategoryName.Name = "txtCategoryName";
			txtCategoryName.ReadOnly = false;
			txtCategoryName.Size = new Size(285, 33);
			txtCategoryName.TabIndex = 82;
			txtCategoryName.TextAlignment = HorizontalAlignment.Left;
			txtCategoryName.UseSystemPasswordChar = false;
			// 
			// txtCategoryDescription
			// 
			txtCategoryDescription.BackColor = Color.Transparent;
			txtCategoryDescription.BorderColor = Color.FromArgb(180, 180, 180);
			txtCategoryDescription.EdgeColor = Color.White;
			txtCategoryDescription.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtCategoryDescription.ForeColor = Color.DimGray;
			txtCategoryDescription.Location = new Point(12, 135);
			txtCategoryDescription.MaxLength = 32767;
			txtCategoryDescription.Multiline = false;
			txtCategoryDescription.Name = "txtCategoryDescription";
			txtCategoryDescription.ReadOnly = false;
			txtCategoryDescription.Size = new Size(285, 33);
			txtCategoryDescription.TabIndex = 82;
			txtCategoryDescription.TextAlignment = HorizontalAlignment.Left;
			txtCategoryDescription.UseSystemPasswordChar = false;
			// 
			// txtCategoryImagePath
			// 
			txtCategoryImagePath.BackColor = Color.Transparent;
			txtCategoryImagePath.BorderColor = Color.FromArgb(180, 180, 180);
			txtCategoryImagePath.EdgeColor = Color.White;
			txtCategoryImagePath.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtCategoryImagePath.ForeColor = Color.DimGray;
			txtCategoryImagePath.Location = new Point(12, 189);
			txtCategoryImagePath.MaxLength = 32767;
			txtCategoryImagePath.Multiline = false;
			txtCategoryImagePath.Name = "txtCategoryImagePath";
			txtCategoryImagePath.ReadOnly = false;
			txtCategoryImagePath.Size = new Size(285, 33);
			txtCategoryImagePath.TabIndex = 82;
			txtCategoryImagePath.TextAlignment = HorizontalAlignment.Left;
			txtCategoryImagePath.UseSystemPasswordChar = false;
			// 
			// btnCategoryAdd
			// 
			btnCategoryAdd.FillColor = Color.Olive;
			btnCategoryAdd.FillHoverColor = Color.DarkKhaki;
			btnCategoryAdd.FillPressColor = Color.DarkKhaki;
			btnCategoryAdd.FillSelectedColor = Color.DarkKhaki;
			btnCategoryAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCategoryAdd.ForeColor = Color.Khaki;
			btnCategoryAdd.Location = new Point(485, 32);
			btnCategoryAdd.Name = "btnCategoryAdd";
			btnCategoryAdd.RectColor = Color.FromArgb(30, 136, 229);
			btnCategoryAdd.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnCategoryAdd.Size = new Size(90, 28);
			btnCategoryAdd.Style = DrakeUI.Framework.UIStyle.Custom;
			btnCategoryAdd.TabIndex = 83;
			btnCategoryAdd.Text = "Add";
			btnCategoryAdd.Click += btnCategoryAdd_Click;
			// 
			// btnCategoryDelete
			// 
			btnCategoryDelete.FillColor = Color.Olive;
			btnCategoryDelete.FillHoverColor = Color.DarkKhaki;
			btnCategoryDelete.FillPressColor = Color.DarkKhaki;
			btnCategoryDelete.FillSelectedColor = Color.DarkKhaki;
			btnCategoryDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCategoryDelete.ForeColor = Color.Khaki;
			btnCategoryDelete.Location = new Point(485, 86);
			btnCategoryDelete.Name = "btnCategoryDelete";
			btnCategoryDelete.RectColor = Color.FromArgb(30, 136, 229);
			btnCategoryDelete.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnCategoryDelete.Size = new Size(90, 28);
			btnCategoryDelete.Style = DrakeUI.Framework.UIStyle.Custom;
			btnCategoryDelete.TabIndex = 83;
			btnCategoryDelete.Text = "Delete";
			btnCategoryDelete.Click += btnCategoryDelete_Click;
			// 
			// btnCategoryUpdate
			// 
			btnCategoryUpdate.FillColor = Color.Olive;
			btnCategoryUpdate.FillHoverColor = Color.DarkKhaki;
			btnCategoryUpdate.FillPressColor = Color.DarkKhaki;
			btnCategoryUpdate.FillSelectedColor = Color.DarkKhaki;
			btnCategoryUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCategoryUpdate.ForeColor = Color.Khaki;
			btnCategoryUpdate.Location = new Point(485, 140);
			btnCategoryUpdate.Name = "btnCategoryUpdate";
			btnCategoryUpdate.RectColor = Color.FromArgb(30, 136, 229);
			btnCategoryUpdate.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnCategoryUpdate.Size = new Size(90, 28);
			btnCategoryUpdate.Style = DrakeUI.Framework.UIStyle.Custom;
			btnCategoryUpdate.TabIndex = 83;
			btnCategoryUpdate.Text = "Update";
			btnCategoryUpdate.Click += btnCategoryUpdate_Click;
			// 
			// dgvCategories
			// 
			dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCategories.Location = new Point(12, 294);
			dgvCategories.Name = "dgvCategories";
			dgvCategories.RowHeadersWidth = 51;
			dgvCategories.RowTemplate.Height = 29;
			dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCategories.Size = new Size(776, 308);
			dgvCategories.TabIndex = 84;
			dgvCategories.CellContentDoubleClick += dgvCategories_CellContentDoubleClick;
			// 
			// chkIsActive
			// 
			chkIsActive.AutoSize = true;
			chkIsActive.BackColor = Color.Transparent;
			chkIsActive.Location = new Point(12, 238);
			chkIsActive.Name = "chkIsActive";
			chkIsActive.Size = new Size(82, 24);
			chkIsActive.TabIndex = 85;
			chkIsActive.Text = "IsActive";
			chkIsActive.UseVisualStyleBackColor = false;
			// 
			// chkIsAllergen
			// 
			chkIsAllergen.AutoSize = true;
			chkIsAllergen.BackColor = Color.Transparent;
			chkIsAllergen.Location = new Point(332, 36);
			chkIsAllergen.Name = "chkIsAllergen";
			chkIsAllergen.Size = new Size(97, 24);
			chkIsAllergen.TabIndex = 86;
			chkIsAllergen.Text = "IsAllergen";
			chkIsAllergen.UseVisualStyleBackColor = false;
			// 
			// chkIsGlutenFree
			// 
			chkIsGlutenFree.AutoSize = true;
			chkIsGlutenFree.BackColor = Color.Transparent;
			chkIsGlutenFree.Location = new Point(332, 90);
			chkIsGlutenFree.Name = "chkIsGlutenFree";
			chkIsGlutenFree.Size = new Size(112, 24);
			chkIsGlutenFree.TabIndex = 86;
			chkIsGlutenFree.Text = "IsGlutenFree";
			chkIsGlutenFree.UseVisualStyleBackColor = false;
			// 
			// chkHasLactose
			// 
			chkHasLactose.AutoSize = true;
			chkHasLactose.BackColor = Color.Transparent;
			chkHasLactose.Location = new Point(332, 140);
			chkHasLactose.Name = "chkHasLactose";
			chkHasLactose.Size = new Size(106, 24);
			chkHasLactose.TabIndex = 86;
			chkHasLactose.Text = "HasLactose";
			chkHasLactose.UseVisualStyleBackColor = false;
			// 
			// chkIsVegaterian
			// 
			chkIsVegaterian.AutoSize = true;
			chkIsVegaterian.BackColor = Color.Transparent;
			chkIsVegaterian.Location = new Point(332, 194);
			chkIsVegaterian.Name = "chkIsVegaterian";
			chkIsVegaterian.Size = new Size(112, 24);
			chkIsVegaterian.TabIndex = 86;
			chkIsVegaterian.Text = "IsVegaterian";
			chkIsVegaterian.UseVisualStyleBackColor = false;
			// 
			// pbCategory
			// 
			pbCategory.BackColor = Color.Transparent;
			pbCategory.Location = new Point(630, 32);
			pbCategory.Name = "pbCategory";
			pbCategory.Size = new Size(125, 150);
			pbCategory.SizeMode = PictureBoxSizeMode.StretchImage;
			pbCategory.TabIndex = 87;
			pbCategory.TabStop = false;
			// 
			// btnAddPicture
			// 
			btnAddPicture.Location = new Point(648, 188);
			btnAddPicture.Name = "btnAddPicture";
			btnAddPicture.Size = new Size(94, 30);
			btnAddPicture.TabIndex = 88;
			btnAddPicture.Text = "Add Picture";
			btnAddPicture.UseVisualStyleBackColor = true;
			btnAddPicture.Click += btnAddPicture_Click;
			// 
			// btnCategoryRefresh
			// 
			btnCategoryRefresh.FillColor = Color.Olive;
			btnCategoryRefresh.FillHoverColor = Color.DarkKhaki;
			btnCategoryRefresh.FillPressColor = Color.DarkKhaki;
			btnCategoryRefresh.FillSelectedColor = Color.DarkKhaki;
			btnCategoryRefresh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCategoryRefresh.ForeColor = Color.Khaki;
			btnCategoryRefresh.Location = new Point(485, 193);
			btnCategoryRefresh.Name = "btnCategoryRefresh";
			btnCategoryRefresh.RectColor = Color.FromArgb(30, 136, 229);
			btnCategoryRefresh.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnCategoryRefresh.Size = new Size(90, 29);
			btnCategoryRefresh.Style = DrakeUI.Framework.UIStyle.Custom;
			btnCategoryRefresh.TabIndex = 89;
			btnCategoryRefresh.Text = "Refresh";
			btnCategoryRefresh.Click += btnCategoryRefresh_Click;
			// 
			// Category
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 614);
			Controls.Add(btnCategoryRefresh);
			Controls.Add(btnAddPicture);
			Controls.Add(pbCategory);
			Controls.Add(chkIsVegaterian);
			Controls.Add(chkHasLactose);
			Controls.Add(chkIsGlutenFree);
			Controls.Add(chkIsAllergen);
			Controls.Add(chkIsActive);
			Controls.Add(dgvCategories);
			Controls.Add(btnCategoryUpdate);
			Controls.Add(btnCategoryDelete);
			Controls.Add(btnCategoryAdd);
			Controls.Add(txtCategoryImagePath);
			Controls.Add(txtCategoryDescription);
			Controls.Add(txtCategoryName);
			Controls.Add(txtCategoryID);
			Controls.Add(lblCategoryName);
			Controls.Add(lblCtgImagePath);
			Controls.Add(lblCategoryDescripition);
			Controls.Add(lblCategoryID);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Category";
			Text = "Add Category";
			Load += Category_Load;
			((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
			((System.ComponentModel.ISupportInitialize)pbCategory).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblCategoryName;
		private Label lblCtgImagePath;
		private Label lblCategoryDescripition;
		private Label lblCategoryID;
		private ReaLTaiizor.Controls.DungeonTextBox txtCategoryID;
		private ReaLTaiizor.Controls.DungeonTextBox txtCategoryName;
		private ReaLTaiizor.Controls.DungeonTextBox txtCategoryDescription;
		private ReaLTaiizor.Controls.DungeonTextBox txtCategoryImagePath;
		private DrakeUI.Framework.DrakeUIButton btnCategoryAdd;
		private DrakeUI.Framework.DrakeUIButton btnCategoryDelete;
		private DrakeUI.Framework.DrakeUIButton btnCategoryUpdate;
		private DataGridView dgvCategories;
		private CheckBox chkIsActive;
		private CheckBox chkIsAllergen;
		private CheckBox chkIsGlutenFree;
		private CheckBox chkHasLactose;
		private CheckBox chkIsVegaterian;
		private PictureBox pbCategory;
		private Button btnAddPicture;
		private DrakeUI.Framework.DrakeUIButton btnCategoryRefresh;
	}
}