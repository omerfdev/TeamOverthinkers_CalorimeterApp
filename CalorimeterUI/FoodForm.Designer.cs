namespace CalorimeterUI
{
	partial class FoodForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
			txtAmount = new TextBox();
			lblCalories = new Label();
			flwFood = new FlowLayoutPanel();
			btnMinimize = new DrakeUI.Framework.DrakeUILabel();
			btnExit = new DrakeUI.Framework.DrakeUILabel();
			lblShowCalories = new Label();
			label1 = new Label();
			btnAdd = new ReaLTaiizor.Controls.CyberButton();
			lblFoodDescription = new Label();
			lblFoodName = new Label();
			SuspendLayout();
			// 
			// txtAmount
			// 
			txtAmount.BackColor = Color.FloralWhite;
			txtAmount.Location = new Point(531, 235);
			txtAmount.Margin = new Padding(3, 4, 3, 4);
			txtAmount.Name = "txtAmount";
			txtAmount.Size = new Size(44, 27);
			txtAmount.TabIndex = 71;
			txtAmount.Text = "0";
			txtAmount.TextAlign = HorizontalAlignment.Center;
			txtAmount.TextChanged += txtAmount_TextChanged;
			// 
			// lblCalories
			// 
			lblCalories.BackColor = Color.Transparent;
			lblCalories.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			lblCalories.Location = new Point(365, 183);
			lblCalories.Name = "lblCalories";
			lblCalories.Size = new Size(119, 28);
			lblCalories.TabIndex = 70;
			lblCalories.Text = "Calories:";
			lblCalories.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// flwFood
			// 
			flwFood.AutoScroll = true;
			flwFood.BackColor = Color.Transparent;
			flwFood.Location = new Point(77, 58);
			flwFood.Margin = new Padding(3, 4, 3, 4);
			flwFood.Name = "flwFood";
			flwFood.Size = new Size(267, 324);
			flwFood.TabIndex = 61;
			// 
			// btnMinimize
			// 
			btnMinimize.BackColor = Color.FromArgb(223, 231, 195);
			btnMinimize.Cursor = Cursors.Hand;
			btnMinimize.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
			btnMinimize.ForeColor = Color.Olive;
			btnMinimize.Location = new Point(543, 9);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(32, 45);
			btnMinimize.TabIndex = 68;
			btnMinimize.Text = "-";
			btnMinimize.TextAlign = ContentAlignment.MiddleLeft;
			btnMinimize.Click += btnMinimize_Click;
			btnMinimize.MouseEnter += btnMinimize_MouseEnter;
			btnMinimize.MouseLeave += btnMinimize_MouseLeave;
			// 
			// btnExit
			// 
			btnExit.BackColor = Color.FromArgb(223, 231, 195);
			btnExit.Cursor = Cursors.Hand;
			btnExit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btnExit.ForeColor = Color.Olive;
			btnExit.Location = new Point(581, 9);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(32, 44);
			btnExit.TabIndex = 67;
			btnExit.Text = "X";
			btnExit.TextAlign = ContentAlignment.MiddleLeft;
			btnExit.Click += btnExit_Click;
			btnExit.MouseEnter += btnExit_MouseEnter;
			btnExit.MouseLeave += btnExit_MouseLeave;
			// 
			// lblShowCalories
			// 
			lblShowCalories.BackColor = Color.Transparent;
			lblShowCalories.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblShowCalories.Location = new Point(491, 183);
			lblShowCalories.Name = "lblShowCalories";
			lblShowCalories.Size = new Size(119, 28);
			lblShowCalories.TabIndex = 66;
			lblShowCalories.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(386, 238);
			label1.Name = "label1";
			label1.Size = new Size(114, 28);
			label1.TabIndex = 65;
			label1.Text = "Amount (g):";
			// 
			// btnAdd
			// 
			btnAdd.Alpha = 20;
			btnAdd.BackColor = Color.Transparent;
			btnAdd.Background = true;
			btnAdd.Background_WidthPen = 4F;
			btnAdd.BackgroundPen = true;
			btnAdd.ColorBackground = Color.Lavender;
			btnAdd.ColorBackground_1 = Color.DarkKhaki;
			btnAdd.ColorBackground_2 = Color.DarkKhaki;
			btnAdd.ColorBackground_Pen = Color.FromArgb(161, 97, 110);
			btnAdd.ColorLighting = Color.DarkKhaki;
			btnAdd.ColorPen_1 = Color.DarkKhaki;
			btnAdd.ColorPen_2 = Color.DarkKhaki;
			btnAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			btnAdd.Effect_1 = true;
			btnAdd.Effect_1_ColorBackground = Color.DarkKhaki;
			btnAdd.Effect_1_Transparency = 25;
			btnAdd.Effect_2 = true;
			btnAdd.Effect_2_ColorBackground = Color.DarkKhaki;
			btnAdd.Effect_2_Transparency = 20;
			btnAdd.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.Black;
			btnAdd.Lighting = false;
			btnAdd.LinearGradient_Background = false;
			btnAdd.LinearGradientPen = false;
			btnAdd.Location = new Point(433, 286);
			btnAdd.Margin = new Padding(3, 4, 3, 4);
			btnAdd.Name = "btnAdd";
			btnAdd.PenWidth = 15;
			btnAdd.Rounding = true;
			btnAdd.RoundingInt = 70;
			btnAdd.Size = new Size(117, 67);
			btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			btnAdd.TabIndex = 64;
			btnAdd.Tag = "Cyber";
			btnAdd.TextButton = "Add";
			btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			btnAdd.Timer_Effect_1 = 5;
			btnAdd.Timer_RGB = 300;
			btnAdd.Click += btnAdd_Click;
			// 
			// lblFoodDescription
			// 
			lblFoodDescription.BackColor = Color.Transparent;
			lblFoodDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblFoodDescription.Location = new Point(395, 129);
			lblFoodDescription.Name = "lblFoodDescription";
			lblFoodDescription.Size = new Size(154, 28);
			lblFoodDescription.TabIndex = 63;
			lblFoodDescription.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblFoodName
			// 
			lblFoodName.BackColor = Color.Transparent;
			lblFoodName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
			lblFoodName.Location = new Point(352, 81);
			lblFoodName.Name = "lblFoodName";
			lblFoodName.Size = new Size(239, 48);
			lblFoodName.TabIndex = 62;
			lblFoodName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FoodForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(677, 470);
			Controls.Add(txtAmount);
			Controls.Add(lblCalories);
			Controls.Add(flwFood);
			Controls.Add(btnMinimize);
			Controls.Add(btnExit);
			Controls.Add(lblShowCalories);
			Controls.Add(label1);
			Controls.Add(btnAdd);
			Controls.Add(lblFoodDescription);
			Controls.Add(lblFoodName);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FoodForm";
			Text = "FoodForm";
			Load += FoodForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtAmount;
		private Label lblCalories;
		private FlowLayoutPanel flwFood;
		private DrakeUI.Framework.DrakeUILabel btnMinimize;
		private DrakeUI.Framework.DrakeUILabel btnExit;
		private Label lblShowCalories;
		private Label label1;
		private ReaLTaiizor.Controls.CyberButton btnAdd;
		private Label lblFoodDescription;
		private Label lblFoodName;
	}
}