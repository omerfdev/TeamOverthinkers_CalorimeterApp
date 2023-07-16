namespace CalorimeterUI
{
	partial class Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			crcProgressCarbon = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
			crcProgressCalorie = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
			crcProgressProtein = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
			crcProgressFat = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
			lblDateTimeNow = new ReaLTaiizor.Controls.DungeonHeaderLabel();
			lblWelcome = new ReaLTaiizor.Controls.DungeonHeaderLabel();
			dAvatar = new DrakeUI.Framework.DrakeUIAvatar();
			lblCalorie = new Label();
			lblFat = new Label();
			lblProtein = new Label();
			lblCarbon = new Label();
			label1 = new Label();
			flwFood = new FlowLayoutPanel();
			label2 = new Label();
			SuspendLayout();
			// 
			// crcProgressCarbon
			// 
			crcProgressCarbon.AnimationSpeed = 5;
			crcProgressCarbon.BackColor = Color.AliceBlue;
			crcProgressCarbon.BackgroundImage = (Image)resources.GetObject("crcProgressCarbon.BackgroundImage");
			crcProgressCarbon.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			crcProgressCarbon.FilledColor = Color.FromArgb(191, 140, 151);
			crcProgressCarbon.FilledColorAlpha = 130;
			crcProgressCarbon.FilledThickness = 40;
			crcProgressCarbon.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			crcProgressCarbon.IsAnimated = false;
			crcProgressCarbon.Location = new Point(39, 25);
			crcProgressCarbon.Margin = new Padding(3, 4, 3, 4);
			crcProgressCarbon.Name = "crcProgressCarbon";
			crcProgressCarbon.Percentage = 50;
			crcProgressCarbon.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			crcProgressCarbon.ShowText = true;
			crcProgressCarbon.Size = new Size(128, 133);
			crcProgressCarbon.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			crcProgressCarbon.TabIndex = 32;
			crcProgressCarbon.TextColor = Color.Black;
			crcProgressCarbon.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			crcProgressCarbon.TextSize = 10;
			crcProgressCarbon.UnFilledColor = Color.FromArgb(122, 105, 140);
			crcProgressCarbon.UnfilledThickness = 24;
			// 
			// crcProgressCalorie
			// 
			crcProgressCalorie.AnimationSpeed = 5;
			crcProgressCalorie.BackColor = Color.AliceBlue;
			crcProgressCalorie.BackgroundImage = (Image)resources.GetObject("crcProgressCalorie.BackgroundImage");
			crcProgressCalorie.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			crcProgressCalorie.FilledColor = Color.FromArgb(191, 140, 151);
			crcProgressCalorie.FilledColorAlpha = 130;
			crcProgressCalorie.FilledThickness = 40;
			crcProgressCalorie.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			crcProgressCalorie.IsAnimated = false;
			crcProgressCalorie.Location = new Point(630, 25);
			crcProgressCalorie.Margin = new Padding(3, 4, 3, 4);
			crcProgressCalorie.Name = "crcProgressCalorie";
			crcProgressCalorie.Percentage = 50;
			crcProgressCalorie.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			crcProgressCalorie.ShowText = true;
			crcProgressCalorie.Size = new Size(128, 133);
			crcProgressCalorie.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			crcProgressCalorie.TabIndex = 31;
			crcProgressCalorie.TextColor = Color.Black;
			crcProgressCalorie.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			crcProgressCalorie.TextSize = 10;
			crcProgressCalorie.UnFilledColor = Color.FromArgb(122, 105, 140);
			crcProgressCalorie.UnfilledThickness = 24;
			// 
			// crcProgressProtein
			// 
			crcProgressProtein.AnimationSpeed = 5;
			crcProgressProtein.BackColor = Color.AliceBlue;
			crcProgressProtein.BackgroundImage = (Image)resources.GetObject("crcProgressProtein.BackgroundImage");
			crcProgressProtein.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			crcProgressProtein.FilledColor = Color.FromArgb(191, 140, 151);
			crcProgressProtein.FilledColorAlpha = 130;
			crcProgressProtein.FilledThickness = 40;
			crcProgressProtein.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			crcProgressProtein.IsAnimated = false;
			crcProgressProtein.Location = new Point(186, 25);
			crcProgressProtein.Margin = new Padding(3, 4, 3, 4);
			crcProgressProtein.Name = "crcProgressProtein";
			crcProgressProtein.Percentage = 50;
			crcProgressProtein.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			crcProgressProtein.ShowText = true;
			crcProgressProtein.Size = new Size(128, 133);
			crcProgressProtein.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			crcProgressProtein.TabIndex = 30;
			crcProgressProtein.TextColor = Color.Black;
			crcProgressProtein.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			crcProgressProtein.TextSize = 10;
			crcProgressProtein.UnFilledColor = Color.FromArgb(122, 105, 140);
			crcProgressProtein.UnfilledThickness = 24;
			// 
			// crcProgressFat
			// 
			crcProgressFat.AnimationSpeed = 5;
			crcProgressFat.BackColor = Color.AliceBlue;
			crcProgressFat.BackgroundImage = (Image)resources.GetObject("crcProgressFat.BackgroundImage");
			crcProgressFat.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			crcProgressFat.FilledColor = Color.FromArgb(191, 140, 151);
			crcProgressFat.FilledColorAlpha = 130;
			crcProgressFat.FilledThickness = 40;
			crcProgressFat.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			crcProgressFat.IsAnimated = false;
			crcProgressFat.Location = new Point(481, 25);
			crcProgressFat.Margin = new Padding(3, 4, 3, 4);
			crcProgressFat.Name = "crcProgressFat";
			crcProgressFat.Percentage = 50;
			crcProgressFat.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			crcProgressFat.ShowText = true;
			crcProgressFat.Size = new Size(128, 133);
			crcProgressFat.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			crcProgressFat.TabIndex = 29;
			crcProgressFat.TextColor = Color.Black;
			crcProgressFat.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			crcProgressFat.TextSize = 10;
			crcProgressFat.UnFilledColor = Color.FromArgb(122, 105, 140);
			crcProgressFat.UnfilledThickness = 24;
			// 
			// lblDateTimeNow
			// 
			lblDateTimeNow.AutoSize = true;
			lblDateTimeNow.BackColor = Color.Transparent;
			lblDateTimeNow.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			lblDateTimeNow.ForeColor = Color.FromArgb(76, 76, 77);
			lblDateTimeNow.Location = new Point(301, 182);
			lblDateTimeNow.Name = "lblDateTimeNow";
			lblDateTimeNow.Size = new Size(0, 25);
			lblDateTimeNow.TabIndex = 28;
			// 
			// lblWelcome
			// 
			lblWelcome.AutoSize = true;
			lblWelcome.BackColor = Color.Transparent;
			lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			lblWelcome.ForeColor = Color.FromArgb(76, 76, 77);
			lblWelcome.Location = new Point(301, 240);
			lblWelcome.Name = "lblWelcome";
			lblWelcome.Size = new Size(0, 25);
			lblWelcome.TabIndex = 27;
			// 
			// dAvatar
			// 
			dAvatar.BackgroundImage = (Image)resources.GetObject("dAvatar.BackgroundImage");
			dAvatar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dAvatar.ForeColor = Color.FromArgb(30, 136, 229);
			dAvatar.Icon = DrakeUI.Framework.DrakeUIAvatar.UIIcon.Image;
			dAvatar.Image = (Image)resources.GetObject("dAvatar.Image");
			dAvatar.Location = new Point(341, 13);
			dAvatar.Margin = new Padding(3, 4, 3, 4);
			dAvatar.Name = "dAvatar";
			dAvatar.Size = new Size(119, 136);
			dAvatar.TabIndex = 26;
			dAvatar.Text = "drakeuiAvatar1";
			// 
			// lblCalorie
			// 
			lblCalorie.AutoSize = true;
			lblCalorie.BackColor = Color.Transparent;
			lblCalorie.Location = new Point(672, 167);
			lblCalorie.Margin = new Padding(4, 0, 4, 0);
			lblCalorie.Name = "lblCalorie";
			lblCalorie.Size = new Size(56, 20);
			lblCalorie.TabIndex = 46;
			lblCalorie.Text = "Calorie";
			// 
			// lblFat
			// 
			lblFat.AutoSize = true;
			lblFat.BackColor = Color.Transparent;
			lblFat.Location = new Point(539, 167);
			lblFat.Margin = new Padding(4, 0, 4, 0);
			lblFat.Name = "lblFat";
			lblFat.Size = new Size(28, 20);
			lblFat.TabIndex = 45;
			lblFat.Text = "Fat";
			// 
			// lblProtein
			// 
			lblProtein.AutoSize = true;
			lblProtein.BackColor = Color.Transparent;
			lblProtein.Location = new Point(226, 167);
			lblProtein.Margin = new Padding(4, 0, 4, 0);
			lblProtein.Name = "lblProtein";
			lblProtein.Size = new Size(56, 20);
			lblProtein.TabIndex = 44;
			lblProtein.Text = "Protein";
			// 
			// lblCarbon
			// 
			lblCarbon.AutoSize = true;
			lblCarbon.BackColor = Color.Transparent;
			lblCarbon.Location = new Point(60, 167);
			lblCarbon.Margin = new Padding(4, 0, 4, 0);
			lblCarbon.Name = "lblCarbon";
			lblCarbon.Size = new Size(107, 20);
			lblCarbon.TabIndex = 43;
			lblCarbon.Text = "Carbonhydrate";
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(250, 302);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(279, 29);
			label1.TabIndex = 48;
			label1.Text = "Top 5 most preferred foods.";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// flwFood
			// 
			flwFood.BackColor = Color.Transparent;
			flwFood.Location = new Point(53, 298);
			flwFood.Margin = new Padding(4);
			flwFood.Name = "flwFood";
			flwFood.Size = new Size(675, 144);
			flwFood.TabIndex = 47;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(240, 446);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(279, 29);
			label2.TabIndex = 48;
			label2.Text = "Top 5 most preferred foods.";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 484);
			Controls.Add(label2);
			Controls.Add(flwFood);
			Controls.Add(label1);
			Controls.Add(lblCalorie);
			Controls.Add(lblFat);
			Controls.Add(lblProtein);
			Controls.Add(lblCarbon);
			Controls.Add(crcProgressCarbon);
			Controls.Add(crcProgressCalorie);
			Controls.Add(crcProgressProtein);
			Controls.Add(crcProgressFat);
			Controls.Add(lblDateTimeNow);
			Controls.Add(lblWelcome);
			Controls.Add(dAvatar);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Home";
			Text = "Home";
			Load += Home_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ReaLTaiizor.Controls.ParrotCircleProgressBar crcProgressCarbon;
		private ReaLTaiizor.Controls.ParrotCircleProgressBar crcProgressCalorie;
		private ReaLTaiizor.Controls.ParrotCircleProgressBar crcProgressProtein;
		private ReaLTaiizor.Controls.ParrotCircleProgressBar crcProgressFat;
		private ReaLTaiizor.Controls.DungeonHeaderLabel lblDateTimeNow;
		private ReaLTaiizor.Controls.DungeonHeaderLabel lblWelcome;
		private DrakeUI.Framework.DrakeUIAvatar dAvatar;
		private Label lblCalorie;
		private Label lblFat;
		private Label lblProtein;
		private Label lblCarbon;
		private Label label1;
		private FlowLayoutPanel flwFood;
		private Label label2;
	}
}