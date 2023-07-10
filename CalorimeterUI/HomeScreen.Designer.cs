namespace CalorimeterUI
{
	partial class HomeScreen
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
			flwSideBar = new FlowLayoutPanel();
			pnlMenu = new Panel();
			lblMenuBar = new Label();
			pcBoxMenu = new PictureBox();
			pnlHome = new Panel();
			btnHome = new Button();
			pnlUserInfo = new Panel();
			btnUserInfo = new Button();
			pnlMeals = new Panel();
			panel2 = new Panel();
			panel3 = new Panel();
			button3 = new Button();
			button2 = new Button();
			btnMeals = new Button();
			pnlSettings = new Panel();
			panel5 = new Panel();
			panel6 = new Panel();
			button4 = new Button();
			button5 = new Button();
			btnSettings = new Button();
			pnlContact = new Panel();
			panel8 = new Panel();
			panel9 = new Panel();
			button7 = new Button();
			button8 = new Button();
			timerSideBar = new System.Windows.Forms.Timer(components);
			btnContact = new Button();
			flwSideBar.SuspendLayout();
			pnlMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).BeginInit();
			pnlHome.SuspendLayout();
			pnlUserInfo.SuspendLayout();
			pnlMeals.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			pnlSettings.SuspendLayout();
			panel5.SuspendLayout();
			panel6.SuspendLayout();
			pnlContact.SuspendLayout();
			panel8.SuspendLayout();
			panel9.SuspendLayout();
			SuspendLayout();
			// 
			// flwSideBar
			// 
			flwSideBar.BackColor = Color.Transparent;
			flwSideBar.Controls.Add(pnlMenu);
			flwSideBar.Controls.Add(pnlHome);
			flwSideBar.Controls.Add(pnlUserInfo);
			flwSideBar.Controls.Add(pnlMeals);
			flwSideBar.Controls.Add(pnlSettings);
			flwSideBar.Controls.Add(pnlContact);
			flwSideBar.Dock = DockStyle.Left;
			flwSideBar.Location = new Point(0, 0);
			flwSideBar.MaximumSize = new Size(280, 900);
			flwSideBar.MinimumSize = new Size(81, 900);
			flwSideBar.Name = "flwSideBar";
			flwSideBar.Size = new Size(280, 900);
			flwSideBar.TabIndex = 4;
			// 
			// pnlMenu
			// 
			pnlMenu.Controls.Add(lblMenuBar);
			pnlMenu.Controls.Add(pcBoxMenu);
			pnlMenu.Location = new Point(3, 3);
			pnlMenu.Name = "pnlMenu";
			pnlMenu.Size = new Size(263, 62);
			pnlMenu.TabIndex = 1;
			// 
			// lblMenuBar
			// 
			lblMenuBar.BackColor = Color.Transparent;
			lblMenuBar.FlatStyle = FlatStyle.Flat;
			lblMenuBar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblMenuBar.ForeColor = Color.Black;
			lblMenuBar.Location = new Point(89, 24);
			lblMenuBar.Name = "lblMenuBar";
			lblMenuBar.Size = new Size(80, 31);
			lblMenuBar.TabIndex = 5;
			lblMenuBar.Text = "Menu";
			// 
			// pcBoxMenu
			// 
			pcBoxMenu.Cursor = Cursors.Hand;
			pcBoxMenu.Image = (Image)resources.GetObject("pcBoxMenu.Image");
			pcBoxMenu.Location = new Point(9, 9);
			pcBoxMenu.Name = "pcBoxMenu";
			pcBoxMenu.Size = new Size(57, 56);
			pcBoxMenu.SizeMode = PictureBoxSizeMode.StretchImage;
			pcBoxMenu.TabIndex = 0;
			pcBoxMenu.TabStop = false;
			pcBoxMenu.Click += pcBoxMenu_Click;
			// 
			// pnlHome
			// 
			pnlHome.Controls.Add(btnHome);
			pnlHome.Location = new Point(3, 71);
			pnlHome.MaximumSize = new Size(263, 258);
			pnlHome.MinimumSize = new Size(263, 93);
			pnlHome.Name = "pnlHome";
			pnlHome.Size = new Size(263, 107);
			pnlHome.TabIndex = 5;
			// 
			// btnHome
			// 
			btnHome.BackColor = Color.DarkOliveGreen;
			btnHome.FlatStyle = FlatStyle.Flat;
			btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnHome.ForeColor = Color.Transparent;
			btnHome.Image = (Image)resources.GetObject("btnHome.Image");
			btnHome.ImageAlign = ContentAlignment.MiddleLeft;
			btnHome.Location = new Point(3, 12);
			btnHome.Name = "btnHome";
			btnHome.Padding = new Padding(5, 0, 0, 0);
			btnHome.Size = new Size(247, 81);
			btnHome.TabIndex = 4;
			btnHome.Text = "                 Home";
			btnHome.TextAlign = ContentAlignment.MiddleRight;
			btnHome.UseVisualStyleBackColor = false;
			// 
			// pnlUserInfo
			// 
			pnlUserInfo.Controls.Add(btnUserInfo);
			pnlUserInfo.Location = new Point(3, 184);
			pnlUserInfo.MaximumSize = new Size(263, 281);
			pnlUserInfo.MinimumSize = new Size(263, 101);
			pnlUserInfo.Name = "pnlUserInfo";
			pnlUserInfo.Size = new Size(263, 103);
			pnlUserInfo.TabIndex = 5;
			// 
			// btnUserInfo
			// 
			btnUserInfo.BackColor = Color.DarkOliveGreen;
			btnUserInfo.FlatStyle = FlatStyle.Flat;
			btnUserInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnUserInfo.ForeColor = Color.Transparent;
			btnUserInfo.Image = (Image)resources.GetObject("btnUserInfo.Image");
			btnUserInfo.ImageAlign = ContentAlignment.MiddleLeft;
			btnUserInfo.Location = new Point(3, 12);
			btnUserInfo.Name = "btnUserInfo";
			btnUserInfo.Padding = new Padding(5, 0, 0, 0);
			btnUserInfo.Size = new Size(247, 81);
			btnUserInfo.TabIndex = 4;
			btnUserInfo.Text = "              User Info";
			btnUserInfo.TextAlign = ContentAlignment.MiddleRight;
			btnUserInfo.UseVisualStyleBackColor = false;
			// 
			// pnlMeals
			// 
			pnlMeals.Controls.Add(panel2);
			pnlMeals.Controls.Add(btnMeals);
			pnlMeals.Location = new Point(3, 293);
			pnlMeals.MaximumSize = new Size(263, 258);
			pnlMeals.MinimumSize = new Size(263, 93);
			pnlMeals.Name = "pnlMeals";
			pnlMeals.Size = new Size(263, 104);
			pnlMeals.TabIndex = 6;
			// 
			// panel2
			// 
			panel2.Controls.Add(panel3);
			panel2.Controls.Add(button2);
			panel2.Location = new Point(3, 403);
			panel2.MaximumSize = new Size(263, 258);
			panel2.MinimumSize = new Size(263, 93);
			panel2.Name = "panel2";
			panel2.Size = new Size(263, 104);
			panel2.TabIndex = 7;
			// 
			// panel3
			// 
			panel3.Controls.Add(button3);
			panel3.Location = new Point(8, 8);
			panel3.MaximumSize = new Size(263, 258);
			panel3.MinimumSize = new Size(263, 93);
			panel3.Name = "panel3";
			panel3.Size = new Size(263, 104);
			panel3.TabIndex = 7;
			// 
			// button3
			// 
			button3.BackColor = Color.DarkOliveGreen;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button3.ForeColor = Color.Transparent;
			button3.Image = (Image)resources.GetObject("button3.Image");
			button3.ImageAlign = ContentAlignment.MiddleLeft;
			button3.Location = new Point(3, 12);
			button3.Name = "button3";
			button3.Padding = new Padding(5, 0, 0, 0);
			button3.Size = new Size(247, 81);
			button3.TabIndex = 4;
			button3.Text = "                 Meals";
			button3.TextAlign = ContentAlignment.MiddleRight;
			button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.DarkOliveGreen;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.Transparent;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(3, 12);
			button2.Name = "button2";
			button2.Padding = new Padding(5, 0, 0, 0);
			button2.Size = new Size(247, 81);
			button2.TabIndex = 4;
			button2.Text = "                 Meals";
			button2.TextAlign = ContentAlignment.MiddleRight;
			button2.UseVisualStyleBackColor = false;
			// 
			// btnMeals
			// 
			btnMeals.BackColor = Color.DarkOliveGreen;
			btnMeals.FlatStyle = FlatStyle.Flat;
			btnMeals.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnMeals.ForeColor = Color.Transparent;
			btnMeals.Image = (Image)resources.GetObject("btnMeals.Image");
			btnMeals.ImageAlign = ContentAlignment.MiddleLeft;
			btnMeals.Location = new Point(3, 12);
			btnMeals.Name = "btnMeals";
			btnMeals.Padding = new Padding(5, 0, 0, 0);
			btnMeals.Size = new Size(247, 81);
			btnMeals.TabIndex = 4;
			btnMeals.Text = "                 Meals";
			btnMeals.TextAlign = ContentAlignment.MiddleRight;
			btnMeals.UseVisualStyleBackColor = false;
			// 
			// pnlSettings
			// 
			pnlSettings.Controls.Add(panel5);
			pnlSettings.Controls.Add(btnSettings);
			pnlSettings.Location = new Point(3, 403);
			pnlSettings.MaximumSize = new Size(263, 258);
			pnlSettings.MinimumSize = new Size(263, 93);
			pnlSettings.Name = "pnlSettings";
			pnlSettings.Size = new Size(263, 104);
			pnlSettings.TabIndex = 8;
			// 
			// panel5
			// 
			panel5.Controls.Add(panel6);
			panel5.Controls.Add(button5);
			panel5.Location = new Point(3, 403);
			panel5.MaximumSize = new Size(263, 258);
			panel5.MinimumSize = new Size(263, 93);
			panel5.Name = "panel5";
			panel5.Size = new Size(263, 104);
			panel5.TabIndex = 7;
			// 
			// panel6
			// 
			panel6.Controls.Add(button4);
			panel6.Location = new Point(8, 8);
			panel6.MaximumSize = new Size(263, 258);
			panel6.MinimumSize = new Size(263, 93);
			panel6.Name = "panel6";
			panel6.Size = new Size(263, 104);
			panel6.TabIndex = 7;
			// 
			// button4
			// 
			button4.BackColor = Color.DarkOliveGreen;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button4.ForeColor = Color.Transparent;
			button4.Image = (Image)resources.GetObject("button4.Image");
			button4.ImageAlign = ContentAlignment.MiddleLeft;
			button4.Location = new Point(3, 12);
			button4.Name = "button4";
			button4.Padding = new Padding(5, 0, 0, 0);
			button4.Size = new Size(247, 81);
			button4.TabIndex = 4;
			button4.Text = "                 Meals";
			button4.TextAlign = ContentAlignment.MiddleRight;
			button4.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			button5.BackColor = Color.DarkOliveGreen;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button5.ForeColor = Color.Transparent;
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(3, 12);
			button5.Name = "button5";
			button5.Padding = new Padding(5, 0, 0, 0);
			button5.Size = new Size(247, 81);
			button5.TabIndex = 4;
			button5.Text = "                 Meals";
			button5.TextAlign = ContentAlignment.MiddleRight;
			button5.UseVisualStyleBackColor = false;
			// 
			// btnSettings
			// 
			btnSettings.BackColor = Color.DarkOliveGreen;
			btnSettings.FlatStyle = FlatStyle.Flat;
			btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnSettings.ForeColor = Color.Transparent;
			btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
			btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
			btnSettings.Location = new Point(3, 12);
			btnSettings.Name = "btnSettings";
			btnSettings.Padding = new Padding(5, 0, 0, 0);
			btnSettings.Size = new Size(247, 81);
			btnSettings.TabIndex = 4;
			btnSettings.Text = "                 Settings";
			btnSettings.TextAlign = ContentAlignment.MiddleRight;
			btnSettings.UseVisualStyleBackColor = false;
			// 
			// pnlContact
			// 
			pnlContact.Controls.Add(btnContact);
			pnlContact.Controls.Add(panel8);
			pnlContact.Location = new Point(3, 513);
			pnlContact.MaximumSize = new Size(263, 258);
			pnlContact.MinimumSize = new Size(263, 93);
			pnlContact.Name = "pnlContact";
			pnlContact.Size = new Size(263, 113);
			pnlContact.TabIndex = 7;
			// 
			// panel8
			// 
			panel8.Controls.Add(panel9);
			panel8.Controls.Add(button8);
			panel8.Location = new Point(3, 403);
			panel8.MaximumSize = new Size(263, 258);
			panel8.MinimumSize = new Size(263, 93);
			panel8.Name = "panel8";
			panel8.Size = new Size(263, 104);
			panel8.TabIndex = 7;
			// 
			// panel9
			// 
			panel9.Controls.Add(button7);
			panel9.Location = new Point(8, 8);
			panel9.MaximumSize = new Size(263, 258);
			panel9.MinimumSize = new Size(263, 93);
			panel9.Name = "panel9";
			panel9.Size = new Size(263, 104);
			panel9.TabIndex = 7;
			// 
			// button7
			// 
			button7.BackColor = Color.DarkOliveGreen;
			button7.FlatStyle = FlatStyle.Flat;
			button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button7.ForeColor = Color.Transparent;
			button7.Image = (Image)resources.GetObject("button7.Image");
			button7.ImageAlign = ContentAlignment.MiddleLeft;
			button7.Location = new Point(3, 12);
			button7.Name = "button7";
			button7.Padding = new Padding(5, 0, 0, 0);
			button7.Size = new Size(247, 81);
			button7.TabIndex = 4;
			button7.Text = "                 Meals";
			button7.TextAlign = ContentAlignment.MiddleRight;
			button7.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			button8.BackColor = Color.DarkOliveGreen;
			button8.FlatStyle = FlatStyle.Flat;
			button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button8.ForeColor = Color.Transparent;
			button8.Image = (Image)resources.GetObject("button8.Image");
			button8.ImageAlign = ContentAlignment.MiddleLeft;
			button8.Location = new Point(3, 12);
			button8.Name = "button8";
			button8.Padding = new Padding(5, 0, 0, 0);
			button8.Size = new Size(247, 81);
			button8.TabIndex = 4;
			button8.Text = "                 Meals";
			button8.TextAlign = ContentAlignment.MiddleRight;
			button8.UseVisualStyleBackColor = false;
			// 
			// timerSideBar
			// 
			timerSideBar.Interval = 1;
			timerSideBar.Tick += timerSideBar_Tick;
			// 
			// btnContact
			// 
			btnContact.BackColor = Color.DarkOliveGreen;
			btnContact.FlatStyle = FlatStyle.Flat;
			btnContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnContact.ForeColor = Color.Transparent;
			btnContact.Image = (Image)resources.GetObject("btnContact.Image");
			btnContact.ImageAlign = ContentAlignment.MiddleLeft;
			btnContact.Location = new Point(3, 12);
			btnContact.Name = "btnContact";
			btnContact.Padding = new Padding(5, 0, 0, 0);
			btnContact.Size = new Size(247, 81);
			btnContact.TabIndex = 8;
			btnContact.Text = "                 Contact";
			btnContact.TextAlign = ContentAlignment.MiddleRight;
			btnContact.UseVisualStyleBackColor = false;
			// 
			// HomeScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OliveDrab;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(917, 628);
			Controls.Add(flwSideBar);
			FormBorderStyle = FormBorderStyle.None;
			Name = "HomeScreen";
			Text = "HomeScreen";
			flwSideBar.ResumeLayout(false);
			pnlMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).EndInit();
			pnlHome.ResumeLayout(false);
			pnlUserInfo.ResumeLayout(false);
			pnlMeals.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			pnlSettings.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel6.ResumeLayout(false);
			pnlContact.ResumeLayout(false);
			panel8.ResumeLayout(false);
			panel9.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flwSideBar;
		private Panel pnlMenu;
		private Label lblMenuBar;
		private PictureBox pcBoxMenu;
		private Panel pnlHome;
		private Button btnListOrder;
		private Button btnAddOrder;
		private Button btnHome;
		private Panel pnlUserInfo;
		private Button btnAddExtraMenu;
		private Button btnAddMenu;
		private Button btnUserInfo;
		private Panel pnlMeals;
		private Button btnMeals;
		private Panel panel2;
		private Panel panel3;
		private Button button3;
		private Button button2;
		private Panel pnlSettings;
		private Panel panel6;
		private Button button4;
		private Button button5;
		private Button btnSettings;
		private Panel pnlContact;
		private Panel panel8;
		private Panel panel9;
		private Button button7;
		private Button button8;
		private Button btnContact;
		private System.Windows.Forms.Timer timerSideBar;
		private Panel panel5;

	}
}