namespace CalorimeterUI
{
	partial class RemoveFood
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveFood));
			btnRemove = new ReaLTaiizor.Controls.CyberButton();
			lblFoodName = new Label();
			btnMinimize = new DrakeUI.Framework.DrakeUILabel();
			btnExit = new DrakeUI.Framework.DrakeUILabel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// btnRemove
			// 
			btnRemove.Alpha = 20;
			btnRemove.BackColor = Color.Transparent;
			btnRemove.Background = true;
			btnRemove.Background_WidthPen = 4F;
			btnRemove.BackgroundPen = true;
			btnRemove.ColorBackground = Color.Lavender;
			btnRemove.ColorBackground_1 = Color.DarkKhaki;
			btnRemove.ColorBackground_2 = Color.DarkKhaki;
			btnRemove.ColorBackground_Pen = Color.FromArgb(161, 97, 110);
			btnRemove.ColorLighting = Color.DarkKhaki;
			btnRemove.ColorPen_1 = Color.DarkKhaki;
			btnRemove.ColorPen_2 = Color.DarkKhaki;
			btnRemove.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			btnRemove.Effect_1 = true;
			btnRemove.Effect_1_ColorBackground = Color.DarkKhaki;
			btnRemove.Effect_1_Transparency = 25;
			btnRemove.Effect_2 = true;
			btnRemove.Effect_2_ColorBackground = Color.DarkKhaki;
			btnRemove.Effect_2_Transparency = 20;
			btnRemove.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
			btnRemove.ForeColor = Color.Black;
			btnRemove.Lighting = false;
			btnRemove.LinearGradient_Background = false;
			btnRemove.LinearGradientPen = false;
			btnRemove.Location = new Point(479, 356);
			btnRemove.Margin = new Padding(3, 4, 3, 4);
			btnRemove.Name = "btnRemove";
			btnRemove.PenWidth = 15;
			btnRemove.Rounding = true;
			btnRemove.RoundingInt = 70;
			btnRemove.Size = new Size(117, 67);
			btnRemove.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			btnRemove.TabIndex = 67;
			btnRemove.Tag = "Cyber";
			btnRemove.TextButton = "Remove";
			btnRemove.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			btnRemove.Timer_Effect_1 = 5;
			btnRemove.Timer_RGB = 300;
			// 
			// lblFoodName
			// 
			lblFoodName.BackColor = Color.Transparent;
			lblFoodName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
			lblFoodName.Location = new Point(185, 364);
			lblFoodName.Name = "lblFoodName";
			lblFoodName.Size = new Size(239, 48);
			lblFoodName.TabIndex = 66;
			lblFoodName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnMinimize
			// 
			btnMinimize.BackColor = Color.FromArgb(223, 231, 195);
			btnMinimize.Cursor = Cursors.Hand;
			btnMinimize.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
			btnMinimize.ForeColor = Color.Olive;
			btnMinimize.Location = new Point(563, 28);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(32, 45);
			btnMinimize.TabIndex = 65;
			btnMinimize.Text = "-";
			btnMinimize.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnExit
			// 
			btnExit.BackColor = Color.FromArgb(223, 231, 195);
			btnExit.Cursor = Cursors.Hand;
			btnExit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btnExit.ForeColor = Color.Olive;
			btnExit.Location = new Point(601, 28);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(32, 44);
			btnExit.TabIndex = 64;
			btnExit.Text = "X";
			btnExit.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = Color.Transparent;
			flowLayoutPanel1.Location = new Point(166, 83);
			flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(464, 265);
			flowLayoutPanel1.TabIndex = 63;
			// 
			// RemoveFood
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(btnRemove);
			Controls.Add(lblFoodName);
			Controls.Add(btnMinimize);
			Controls.Add(btnExit);
			Controls.Add(flowLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "RemoveFood";
			Text = "RemoveFood";
			Load += RemoveFood_Load;
			ResumeLayout(false);
		}

		#endregion

		private ReaLTaiizor.Controls.CyberButton btnRemove;
		private Label lblFoodName;
		private DrakeUI.Framework.DrakeUILabel btnMinimize;
		private DrakeUI.Framework.DrakeUILabel btnExit;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}