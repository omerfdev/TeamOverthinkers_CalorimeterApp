namespace AdminConsole
{
	partial class Admin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
			menuStrip1 = new MenuStrip();
			addToolStripMenuItem = new ToolStripMenuItem();
			categoryToolStripMenuItem = new ToolStripMenuItem();
			foodToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(7, 3, 0, 3);
			menuStrip1.Size = new Size(469, 30);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// addToolStripMenuItem
			// 
			addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, foodToolStripMenuItem });
			addToolStripMenuItem.Name = "addToolStripMenuItem";
			addToolStripMenuItem.Size = new Size(51, 24);
			addToolStripMenuItem.Text = "Add";
			// 
			// categoryToolStripMenuItem
			// 
			categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			categoryToolStripMenuItem.Size = new Size(152, 26);
			categoryToolStripMenuItem.Text = "Category";
			categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
			// 
			// foodToolStripMenuItem
			// 
			foodToolStripMenuItem.Name = "foodToolStripMenuItem";
			foodToolStripMenuItem.Size = new Size(152, 26);
			foodToolStripMenuItem.Text = "Food";
			foodToolStripMenuItem.Click += foodToolStripMenuItem_Click;
			// 
			// Admin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(469, 313);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 4, 3, 4);
			Name = "Admin";
			Text = "Console";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem categoryToolStripMenuItem;
		private ToolStripMenuItem foodToolStripMenuItem;
	}
}