namespace CalorimeterUI
{
	partial class Categories
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
			btnMinimize = new DrakeUI.Framework.DrakeUILabel();
			btnExit = new DrakeUI.Framework.DrakeUILabel();
			txtSearchBar = new TextBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// btnMinimize
			// 
			btnMinimize.BackColor = Color.FromArgb(223, 231, 195);
			btnMinimize.Cursor = Cursors.Hand;
			btnMinimize.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
			btnMinimize.ForeColor = Color.Olive;
			btnMinimize.Location = new Point(461, 14);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(28, 36);
			btnMinimize.TabIndex = 57;
			btnMinimize.Text = "-";
			btnMinimize.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnExit
			// 
			btnExit.BackColor = Color.FromArgb(223, 231, 195);
			btnExit.Cursor = Cursors.Hand;
			btnExit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btnExit.ForeColor = Color.Olive;
			btnExit.Location = new Point(511, 19);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(28, 31);
			btnExit.TabIndex = 56;
			btnExit.Text = "X";
			btnExit.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtSearchBar
			// 
			txtSearchBar.BackColor = Color.FromArgb(223, 231, 195);
			txtSearchBar.BorderStyle = BorderStyle.FixedSingle;
			txtSearchBar.ForeColor = Color.Black;
			txtSearchBar.Location = new Point(211, 23);
			txtSearchBar.MaxLength = 20;
			txtSearchBar.Name = "txtSearchBar";
			txtSearchBar.PlaceholderText = "search a category";
			txtSearchBar.Size = new Size(132, 27);
			txtSearchBar.TabIndex = 55;
			txtSearchBar.TextAlign = HorizontalAlignment.Center;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
			flowLayoutPanel1.Location = new Point(53, 58);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(486, 446);
			flowLayoutPanel1.TabIndex = 54;
			// 
			// Categories
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(587, 568);
			Controls.Add(btnMinimize);
			Controls.Add(btnExit);
			Controls.Add(txtSearchBar);
			Controls.Add(flowLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Categories";
			Text = "Categories";
			Load += Categories_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DrakeUI.Framework.DrakeUILabel btnMinimize;
		private DrakeUI.Framework.DrakeUILabel btnExit;
		private TextBox txtSearchBar;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}