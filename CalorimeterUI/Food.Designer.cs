namespace AdminConsole
{
	partial class Food
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
			chkIsActive = new CheckBox();
			dgvFood = new DataGridView();
			btnCategoryUpdate = new DrakeUI.Framework.DrakeUIButton();
			btnCategoryDelete = new DrakeUI.Framework.DrakeUIButton();
			btnCategoryAdd = new DrakeUI.Framework.DrakeUIButton();
			txtFoodID = new ReaLTaiizor.Controls.DungeonTextBox();
			lblFoodName = new Label();
			lblCarbonhydtrateValue = new Label();
			lblCategoryID = new Label();
			lblFoodID = new Label();
			lblProteinValue = new Label();
			lblFatValue = new Label();
			lblCalories = new Label();
			lblFoodImagePath = new Label();
			txtFoodImagePath = new ReaLTaiizor.Controls.DungeonTextBox();
			lblFoodDescription = new Label();
			txtFoodDescription = new ReaLTaiizor.Controls.DungeonTextBox();
			nmrCarbonhydrateValue = new NumericUpDown();
			nmrProteinValue = new NumericUpDown();
			nmrFatValue = new NumericUpDown();
			nmrCalories = new NumericUpDown();
			txtFoodName = new ReaLTaiizor.Controls.DungeonTextBox();
			pictureBox1 = new PictureBox();
			btnAddPicture = new Button();
			btnRefresh = new DrakeUI.Framework.DrakeUIButton();
			btnCategoryNameShow = new Button();
			txtFoodCategoryID = new ReaLTaiizor.Controls.DungeonTextBox();
			((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrCarbonhydrateValue).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrProteinValue).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrFatValue).BeginInit();
			((System.ComponentModel.ISupportInitialize)nmrCalories).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// chkIsActive
			// 
			chkIsActive.AutoSize = true;
			chkIsActive.BackColor = Color.Transparent;
			chkIsActive.Location = new Point(258, 236);
			chkIsActive.Name = "chkIsActive";
			chkIsActive.Size = new Size(82, 24);
			chkIsActive.TabIndex = 99;
			chkIsActive.Text = "IsActive";
			chkIsActive.UseVisualStyleBackColor = false;
			// 
			// dgvFood
			// 
			dgvFood.BackgroundColor = SystemColors.ControlDarkDark;
			dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFood.Location = new Point(12, 299);
			dgvFood.Name = "dgvFood";
			dgvFood.RowHeadersWidth = 51;
			dgvFood.RowTemplate.Height = 29;
			dgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvFood.Size = new Size(735, 308);
			dgvFood.TabIndex = 98;
			dgvFood.CellMouseDoubleClick += dgvFood_CellMouseDoubleClick;
			// 
			// btnCategoryUpdate
			// 
			btnCategoryUpdate.FillColor = Color.Olive;
			btnCategoryUpdate.FillHoverColor = Color.DarkKhaki;
			btnCategoryUpdate.FillPressColor = Color.DarkKhaki;
			btnCategoryUpdate.FillSelectedColor = Color.DarkKhaki;
			btnCategoryUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCategoryUpdate.ForeColor = Color.Khaki;
			btnCategoryUpdate.Location = new Point(467, 144);
			btnCategoryUpdate.Name = "btnCategoryUpdate";
			btnCategoryUpdate.RectColor = Color.FromArgb(30, 136, 229);
			btnCategoryUpdate.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnCategoryUpdate.Size = new Size(90, 28);
			btnCategoryUpdate.Style = DrakeUI.Framework.UIStyle.Custom;
			btnCategoryUpdate.TabIndex = 96;
			btnCategoryUpdate.Text = "Update";
			btnCategoryUpdate.Click += btnCategoryUpdate_Click;
			// 
			// btnCategoryDelete
			// 
			btnCategoryDelete.FillColor = Color.Olive;
			btnCategoryDelete.FillHoverColor = Color.DarkKhaki;
			btnCategoryDelete.FillPressColor = Color.DarkKhaki;
			btnCategoryDelete.FillSelectedColor = Color.DarkKhaki;
			btnCategoryDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCategoryDelete.ForeColor = Color.Khaki;
			btnCategoryDelete.Location = new Point(467, 90);
			btnCategoryDelete.Name = "btnCategoryDelete";
			btnCategoryDelete.RectColor = Color.FromArgb(30, 136, 229);
			btnCategoryDelete.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnCategoryDelete.Size = new Size(90, 28);
			btnCategoryDelete.Style = DrakeUI.Framework.UIStyle.Custom;
			btnCategoryDelete.TabIndex = 97;
			btnCategoryDelete.Text = "Delete";
			btnCategoryDelete.Click += btnCategoryDelete_Click;
			// 
			// btnCategoryAdd
			// 
			btnCategoryAdd.FillColor = Color.Olive;
			btnCategoryAdd.FillHoverColor = Color.DarkKhaki;
			btnCategoryAdd.FillPressColor = Color.DarkKhaki;
			btnCategoryAdd.FillSelectedColor = Color.DarkKhaki;
			btnCategoryAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCategoryAdd.ForeColor = Color.Khaki;
			btnCategoryAdd.Location = new Point(467, 36);
			btnCategoryAdd.Name = "btnCategoryAdd";
			btnCategoryAdd.RectColor = Color.FromArgb(30, 136, 229);
			btnCategoryAdd.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnCategoryAdd.Size = new Size(90, 28);
			btnCategoryAdd.Style = DrakeUI.Framework.UIStyle.Custom;
			btnCategoryAdd.TabIndex = 95;
			btnCategoryAdd.Text = "Add";
			btnCategoryAdd.Click += btnCategoryAdd_Click;
			// 
			// txtFoodID
			// 
			txtFoodID.BackColor = Color.Transparent;
			txtFoodID.BorderColor = Color.FromArgb(180, 180, 180);
			txtFoodID.EdgeColor = Color.White;
			txtFoodID.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtFoodID.ForeColor = Color.DimGray;
			txtFoodID.Location = new Point(12, 33);
			txtFoodID.MaxLength = 32767;
			txtFoodID.Multiline = false;
			txtFoodID.Name = "txtFoodID";
			txtFoodID.ReadOnly = false;
			txtFoodID.Size = new Size(206, 33);
			txtFoodID.TabIndex = 91;
			txtFoodID.TextAlignment = HorizontalAlignment.Left;
			txtFoodID.UseSystemPasswordChar = false;
			// 
			// lblFoodName
			// 
			lblFoodName.AutoSize = true;
			lblFoodName.BackColor = Color.Transparent;
			lblFoodName.Location = new Point(12, 69);
			lblFoodName.Name = "lblFoodName";
			lblFoodName.Size = new Size(87, 20);
			lblFoodName.TabIndex = 88;
			lblFoodName.Text = "Food Name";
			// 
			// lblCarbonhydtrateValue
			// 
			lblCarbonhydtrateValue.AutoSize = true;
			lblCarbonhydtrateValue.BackColor = Color.Transparent;
			lblCarbonhydtrateValue.Location = new Point(256, 15);
			lblCarbonhydtrateValue.Name = "lblCarbonhydtrateValue";
			lblCarbonhydtrateValue.Size = new Size(152, 20);
			lblCarbonhydtrateValue.TabIndex = 89;
			lblCarbonhydtrateValue.Text = "Carbonhydtrate Value";
			// 
			// lblCategoryID
			// 
			lblCategoryID.AutoSize = true;
			lblCategoryID.BackColor = Color.Transparent;
			lblCategoryID.Location = new Point(15, 236);
			lblCategoryID.Name = "lblCategoryID";
			lblCategoryID.Size = new Size(84, 20);
			lblCategoryID.TabIndex = 90;
			lblCategoryID.Text = "CategoryID";
			// 
			// lblFoodID
			// 
			lblFoodID.AutoSize = true;
			lblFoodID.BackColor = Color.Transparent;
			lblFoodID.Location = new Point(12, 15);
			lblFoodID.Name = "lblFoodID";
			lblFoodID.Size = new Size(58, 20);
			lblFoodID.TabIndex = 87;
			lblFoodID.Text = "FoodID";
			// 
			// lblProteinValue
			// 
			lblProteinValue.AutoSize = true;
			lblProteinValue.BackColor = Color.Transparent;
			lblProteinValue.Location = new Point(256, 69);
			lblProteinValue.Name = "lblProteinValue";
			lblProteinValue.Size = new Size(96, 20);
			lblProteinValue.TabIndex = 89;
			lblProteinValue.Text = "Protein Value";
			// 
			// lblFatValue
			// 
			lblFatValue.AutoSize = true;
			lblFatValue.BackColor = Color.Transparent;
			lblFatValue.Location = new Point(256, 123);
			lblFatValue.Name = "lblFatValue";
			lblFatValue.Size = new Size(68, 20);
			lblFatValue.TabIndex = 89;
			lblFatValue.Text = "Fat Value";
			// 
			// lblCalories
			// 
			lblCalories.AutoSize = true;
			lblCalories.BackColor = Color.Transparent;
			lblCalories.Location = new Point(256, 176);
			lblCalories.Name = "lblCalories";
			lblCalories.Size = new Size(62, 20);
			lblCalories.TabIndex = 89;
			lblCalories.Text = "Calories";
			// 
			// lblFoodImagePath
			// 
			lblFoodImagePath.AutoSize = true;
			lblFoodImagePath.BackColor = Color.Transparent;
			lblFoodImagePath.Location = new Point(12, 128);
			lblFoodImagePath.Name = "lblFoodImagePath";
			lblFoodImagePath.Size = new Size(113, 20);
			lblFoodImagePath.TabIndex = 89;
			lblFoodImagePath.Text = "FoodImagePath";
			// 
			// txtFoodImagePath
			// 
			txtFoodImagePath.BackColor = Color.Transparent;
			txtFoodImagePath.BorderColor = Color.FromArgb(180, 180, 180);
			txtFoodImagePath.EdgeColor = Color.White;
			txtFoodImagePath.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtFoodImagePath.ForeColor = Color.DimGray;
			txtFoodImagePath.Location = new Point(12, 146);
			txtFoodImagePath.MaxLength = 32767;
			txtFoodImagePath.Multiline = false;
			txtFoodImagePath.Name = "txtFoodImagePath";
			txtFoodImagePath.ReadOnly = false;
			txtFoodImagePath.Size = new Size(206, 33);
			txtFoodImagePath.TabIndex = 94;
			txtFoodImagePath.TextAlignment = HorizontalAlignment.Left;
			txtFoodImagePath.UseSystemPasswordChar = false;
			// 
			// lblFoodDescription
			// 
			lblFoodDescription.AutoSize = true;
			lblFoodDescription.BackColor = Color.Transparent;
			lblFoodDescription.Location = new Point(12, 182);
			lblFoodDescription.Name = "lblFoodDescription";
			lblFoodDescription.Size = new Size(123, 20);
			lblFoodDescription.TabIndex = 89;
			lblFoodDescription.Text = "Food Description";
			// 
			// txtFoodDescription
			// 
			txtFoodDescription.BackColor = Color.Transparent;
			txtFoodDescription.BorderColor = Color.FromArgb(180, 180, 180);
			txtFoodDescription.EdgeColor = Color.White;
			txtFoodDescription.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtFoodDescription.ForeColor = Color.DimGray;
			txtFoodDescription.Location = new Point(12, 200);
			txtFoodDescription.MaxLength = 32767;
			txtFoodDescription.Multiline = false;
			txtFoodDescription.Name = "txtFoodDescription";
			txtFoodDescription.ReadOnly = false;
			txtFoodDescription.Size = new Size(206, 33);
			txtFoodDescription.TabIndex = 94;
			txtFoodDescription.TextAlignment = HorizontalAlignment.Left;
			txtFoodDescription.UseSystemPasswordChar = false;
			// 
			// nmrCarbonhydrateValue
			// 
			nmrCarbonhydrateValue.Location = new Point(258, 37);
			nmrCarbonhydrateValue.Name = "nmrCarbonhydrateValue";
			nmrCarbonhydrateValue.Size = new Size(173, 27);
			nmrCarbonhydrateValue.TabIndex = 104;
			// 
			// nmrProteinValue
			// 
			nmrProteinValue.Location = new Point(258, 92);
			nmrProteinValue.Name = "nmrProteinValue";
			nmrProteinValue.Size = new Size(173, 27);
			nmrProteinValue.TabIndex = 104;
			// 
			// nmrFatValue
			// 
			nmrFatValue.Location = new Point(258, 146);
			nmrFatValue.Name = "nmrFatValue";
			nmrFatValue.Size = new Size(173, 27);
			nmrFatValue.TabIndex = 104;
			// 
			// nmrCalories
			// 
			nmrCalories.Location = new Point(256, 200);
			nmrCalories.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			nmrCalories.Name = "nmrCalories";
			nmrCalories.Size = new Size(173, 27);
			nmrCalories.TabIndex = 104;
			// 
			// txtFoodName
			// 
			txtFoodName.BackColor = Color.Transparent;
			txtFoodName.BorderColor = Color.FromArgb(180, 180, 180);
			txtFoodName.EdgeColor = Color.White;
			txtFoodName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtFoodName.ForeColor = Color.DimGray;
			txtFoodName.Location = new Point(12, 92);
			txtFoodName.MaxLength = 32767;
			txtFoodName.Multiline = false;
			txtFoodName.Name = "txtFoodName";
			txtFoodName.ReadOnly = false;
			txtFoodName.Size = new Size(206, 33);
			txtFoodName.TabIndex = 91;
			txtFoodName.TextAlignment = HorizontalAlignment.Left;
			txtFoodName.UseSystemPasswordChar = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Location = new Point(591, 33);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 139);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 105;
			pictureBox1.TabStop = false;
			// 
			// btnAddPicture
			// 
			btnAddPicture.Location = new Point(617, 189);
			btnAddPicture.Name = "btnAddPicture";
			btnAddPicture.Size = new Size(94, 38);
			btnAddPicture.TabIndex = 106;
			btnAddPicture.Text = "Add Picture";
			btnAddPicture.UseVisualStyleBackColor = true;
			btnAddPicture.Click += btnAddPicture_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.FillColor = Color.Olive;
			btnRefresh.FillHoverColor = Color.DarkKhaki;
			btnRefresh.FillPressColor = Color.DarkKhaki;
			btnRefresh.FillSelectedColor = Color.DarkKhaki;
			btnRefresh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnRefresh.ForeColor = Color.Khaki;
			btnRefresh.Location = new Point(467, 189);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.RectColor = Color.FromArgb(30, 136, 229);
			btnRefresh.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnRefresh.Size = new Size(90, 32);
			btnRefresh.Style = DrakeUI.Framework.UIStyle.Custom;
			btnRefresh.TabIndex = 107;
			btnRefresh.Text = "Refresh";
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnCategoryNameShow
			// 
			btnCategoryNameShow.Location = new Point(144, 259);
			btnCategoryNameShow.Name = "btnCategoryNameShow";
			btnCategoryNameShow.Size = new Size(74, 34);
			btnCategoryNameShow.TabIndex = 108;
			btnCategoryNameShow.Text = "Show";
			btnCategoryNameShow.UseVisualStyleBackColor = true;
			btnCategoryNameShow.Click += btnCategoryNameShow_Click;
			// 
			// txtFoodCategoryID
			// 
			txtFoodCategoryID.BackColor = Color.Transparent;
			txtFoodCategoryID.BorderColor = Color.FromArgb(180, 180, 180);
			txtFoodCategoryID.EdgeColor = Color.White;
			txtFoodCategoryID.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtFoodCategoryID.ForeColor = Color.DimGray;
			txtFoodCategoryID.Location = new Point(15, 259);
			txtFoodCategoryID.MaxLength = 32767;
			txtFoodCategoryID.Multiline = false;
			txtFoodCategoryID.Name = "txtFoodCategoryID";
			txtFoodCategoryID.ReadOnly = false;
			txtFoodCategoryID.Size = new Size(114, 33);
			txtFoodCategoryID.TabIndex = 109;
			txtFoodCategoryID.TextAlignment = HorizontalAlignment.Left;
			txtFoodCategoryID.UseSystemPasswordChar = false;
			// 
			// Food
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(762, 618);
			Controls.Add(txtFoodCategoryID);
			Controls.Add(btnCategoryNameShow);
			Controls.Add(btnRefresh);
			Controls.Add(btnAddPicture);
			Controls.Add(pictureBox1);
			Controls.Add(nmrCalories);
			Controls.Add(nmrFatValue);
			Controls.Add(nmrProteinValue);
			Controls.Add(nmrCarbonhydrateValue);
			Controls.Add(chkIsActive);
			Controls.Add(dgvFood);
			Controls.Add(btnCategoryUpdate);
			Controls.Add(btnCategoryDelete);
			Controls.Add(btnCategoryAdd);
			Controls.Add(txtFoodDescription);
			Controls.Add(txtFoodImagePath);
			Controls.Add(txtFoodName);
			Controls.Add(txtFoodID);
			Controls.Add(lblFoodName);
			Controls.Add(lblFoodDescription);
			Controls.Add(lblFoodImagePath);
			Controls.Add(lblCalories);
			Controls.Add(lblFatValue);
			Controls.Add(lblProteinValue);
			Controls.Add(lblCarbonhydtrateValue);
			Controls.Add(lblCategoryID);
			Controls.Add(lblFoodID);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Food";
			Text = "Add Food";
			Load += Food_Load;
			((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrCarbonhydrateValue).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrProteinValue).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrFatValue).EndInit();
			((System.ComponentModel.ISupportInitialize)nmrCalories).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox chkIsVegaterian;
		private CheckBox chkHasLactose;
		private CheckBox chkIsGlutenFree;
		private CheckBox chkIsAllergen;
		private CheckBox chkIsActive;
		private DataGridView dgvFood;
		private DrakeUI.Framework.DrakeUIButton btnCategoryUpdate;
		private DrakeUI.Framework.DrakeUIButton btnCategoryDelete;
		private DrakeUI.Framework.DrakeUIButton btnCategoryAdd;
		private ReaLTaiizor.Controls.DungeonTextBox txtCategoryImagePath;
		private ReaLTaiizor.Controls.DungeonTextBox txtCategoryDescription;
		private ReaLTaiizor.Controls.DungeonTextBox txtCategoryName;
		private ReaLTaiizor.Controls.DungeonTextBox txtFoodID;
		private Label lblFoodName;
		private Label lblCarbonhydtrateValue;
		private Label lblCategoryID;
		private Label lblFoodID;
		private Label lblProteinValue;
		private Label lblFatValue;
		private Label lblCalories;
		private Label lblFoodImagePath;
		private ReaLTaiizor.Controls.DungeonTextBox txtFoodImagePath;
		private Label lblFoodDescription;
		private ReaLTaiizor.Controls.DungeonTextBox txtFoodDescription;
		private NumericUpDown nmrCarbonhydrateValue;
		private NumericUpDown nmrProteinValue;
		private NumericUpDown nmrFatValue;
		private NumericUpDown nmrCalories;
		private ReaLTaiizor.Controls.DungeonTextBox txtFoodName;
		private PictureBox pictureBox1;
		private Button btnAddPicture;
		private DrakeUI.Framework.DrakeUIButton btnRefresh;
		private Button btnCategoryNameShow;
		private ReaLTaiizor.Controls.DungeonTextBox txtFoodCategoryID;
	}
}