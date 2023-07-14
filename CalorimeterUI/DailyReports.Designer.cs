namespace CalorimeterUI
{
	partial class DailyReports
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyReports));
			btnMonthlyMeal = new Button();
			btnWeeklyFoods = new Button();
			btnMonthlyFoods = new Button();
			btnWeeklyMeal = new Button();
			dgvReports = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
			SuspendLayout();
			// 
			// btnMonthlyMeal
			// 
			btnMonthlyMeal.Location = new Point(196, 23);
			btnMonthlyMeal.Margin = new Padding(4);
			btnMonthlyMeal.Name = "btnMonthlyMeal";
			btnMonthlyMeal.Size = new Size(141, 29);
			btnMonthlyMeal.TabIndex = 14;
			btnMonthlyMeal.Text = "Monthly Meals";
			btnMonthlyMeal.UseVisualStyleBackColor = true;
			btnMonthlyMeal.Click += btnMonthlyMeal_Click;
			// 
			// btnWeeklyFoods
			// 
			btnWeeklyFoods.Location = new Point(475, 23);
			btnWeeklyFoods.Margin = new Padding(4);
			btnWeeklyFoods.Name = "btnWeeklyFoods";
			btnWeeklyFoods.Size = new Size(141, 29);
			btnWeeklyFoods.TabIndex = 13;
			btnWeeklyFoods.Text = "Weekly Foods";
			btnWeeklyFoods.UseVisualStyleBackColor = true;
			btnWeeklyFoods.Click += btnWeeklyFoods_Click;
			// 
			// btnMonthlyFoods
			// 
			btnMonthlyFoods.Location = new Point(623, 23);
			btnMonthlyFoods.Margin = new Padding(4);
			btnMonthlyFoods.Name = "btnMonthlyFoods";
			btnMonthlyFoods.Size = new Size(141, 29);
			btnMonthlyFoods.TabIndex = 12;
			btnMonthlyFoods.Text = "Monthly Foods";
			btnMonthlyFoods.UseVisualStyleBackColor = true;
			btnMonthlyFoods.Click += btnMonthlyFoods_Click;
			// 
			// btnWeeklyMeal
			// 
			btnWeeklyMeal.Location = new Point(37, 23);
			btnWeeklyMeal.Margin = new Padding(4);
			btnWeeklyMeal.Name = "btnWeeklyMeal";
			btnWeeklyMeal.Size = new Size(141, 29);
			btnWeeklyMeal.TabIndex = 11;
			btnWeeklyMeal.Text = "Weekly Meals";
			btnWeeklyMeal.UseVisualStyleBackColor = true;
			btnWeeklyMeal.Click += btnWeeklyMeal_Click;
			// 
			// dgvReports
			// 
			dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvReports.Location = new Point(196, 86);
			dgvReports.Margin = new Padding(4);
			dgvReports.Name = "dgvReports";
			dgvReports.RowHeadersWidth = 51;
			dgvReports.RowTemplate.Height = 25;
			dgvReports.Size = new Size(426, 351);
			dgvReports.TabIndex = 10;
			// 
			// DailyReports
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(btnMonthlyMeal);
			Controls.Add(btnWeeklyFoods);
			Controls.Add(btnMonthlyFoods);
			Controls.Add(btnWeeklyMeal);
			Controls.Add(dgvReports);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "DailyReports";
			Text = "DailyReports";
			((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnMonthlyMeal;
		private Button btnWeeklyFoods;
		private Button btnMonthlyFoods;
		private Button btnWeeklyMeal;
		private DataGridView dgvReports;
	}
}