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
			btnMeals = new Button();
			pnlSettings = new Panel();
			btnSettings = new Button();
			pnlContact = new Panel();
			btnContact = new Button();
			pnlLogout = new Panel();
			btnLogout = new Button();
			timerSideBar = new System.Windows.Forms.Timer(components);
			flwSideBar.SuspendLayout();
			pnlMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).BeginInit();
			pnlHome.SuspendLayout();
			pnlUserInfo.SuspendLayout();
			pnlMeals.SuspendLayout();
			pnlSettings.SuspendLayout();
			pnlContact.SuspendLayout();
			pnlLogout.SuspendLayout();
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
			flwSideBar.Controls.Add(pnlLogout);
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
			btnHome.Tag = "1";
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
			btnUserInfo.Tag = "2";
			btnUserInfo.Text = "              User Info";
			btnUserInfo.TextAlign = ContentAlignment.MiddleRight;
			btnUserInfo.UseVisualStyleBackColor = false;
			// 
			// pnlMeals
			// 
			pnlMeals.Controls.Add(btnMeals);
			pnlMeals.Location = new Point(3, 293);
			pnlMeals.MaximumSize = new Size(263, 258);
			pnlMeals.MinimumSize = new Size(263, 93);
			pnlMeals.Name = "pnlMeals";
			pnlMeals.Size = new Size(263, 104);
			pnlMeals.TabIndex = 6;
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
			btnMeals.Tag = "3";
			btnMeals.Text = "                 Meals";
			btnMeals.TextAlign = ContentAlignment.MiddleRight;
			btnMeals.UseVisualStyleBackColor = false;
			// 
			// pnlSettings
			// 
			pnlSettings.Controls.Add(btnSettings);
			pnlSettings.Location = new Point(3, 403);
			pnlSettings.MaximumSize = new Size(263, 258);
			pnlSettings.MinimumSize = new Size(263, 93);
			pnlSettings.Name = "pnlSettings";
			pnlSettings.Size = new Size(263, 104);
			pnlSettings.TabIndex = 8;
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
			btnSettings.Tag = "4";
			btnSettings.Text = "                 Settings";
			btnSettings.TextAlign = ContentAlignment.MiddleRight;
			btnSettings.UseVisualStyleBackColor = false;
			// 
			// pnlContact
			// 
			pnlContact.Controls.Add(btnContact);
			pnlContact.Location = new Point(3, 513);
			pnlContact.MaximumSize = new Size(263, 258);
			pnlContact.MinimumSize = new Size(263, 93);
			pnlContact.Name = "pnlContact";
			pnlContact.Size = new Size(263, 113);
			pnlContact.TabIndex = 7;
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
			btnContact.Tag = "5";
			btnContact.Text = "                 Contact";
			btnContact.TextAlign = ContentAlignment.MiddleRight;
			btnContact.UseVisualStyleBackColor = false;
			// 
			// pnlLogout
			// 
			pnlLogout.Controls.Add(btnLogout);
			pnlLogout.Location = new Point(3, 632);
			pnlLogout.MaximumSize = new Size(263, 258);
			pnlLogout.MinimumSize = new Size(263, 93);
			pnlLogout.Name = "pnlLogout";
			pnlLogout.Size = new Size(263, 113);
			pnlLogout.TabIndex = 9;
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.DarkOliveGreen;
			btnLogout.FlatStyle = FlatStyle.Flat;
			btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogout.ForeColor = Color.Transparent;
			btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
			btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
			btnLogout.Location = new Point(3, 12);
			btnLogout.Name = "btnLogout";
			btnLogout.Padding = new Padding(5, 0, 0, 0);
			btnLogout.Size = new Size(247, 81);
			btnLogout.TabIndex = 8;
			btnLogout.Tag = "6";
			btnLogout.Text = "                 Logout";
			btnLogout.TextAlign = ContentAlignment.MiddleRight;
			btnLogout.UseVisualStyleBackColor = false;
			// 
			// timerSideBar
			// 
			timerSideBar.Interval = 1;
			timerSideBar.Tick += timerSideBar_Tick;
			// 
			// HomeScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OliveDrab;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(917, 775);
			Controls.Add(flwSideBar);
			FormBorderStyle = FormBorderStyle.None;
			IsMdiContainer = true;
			Name = "HomeScreen";
			Text = "HomeScreen";
			Load += HomeScreen_Load;
			MouseDown += HomeScreen_MouseDown;
			MouseMove += HomeScreen_MouseMove;
			MouseUp += HomeScreen_MouseUp;
			flwSideBar.ResumeLayout(false);
			pnlMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pcBoxMenu).EndInit();
			pnlHome.ResumeLayout(false);
			pnlUserInfo.ResumeLayout(false);
			pnlMeals.ResumeLayout(false);
			pnlSettings.ResumeLayout(false);
			pnlContact.ResumeLayout(false);
			pnlLogout.ResumeLayout(false);
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
		private Panel pnlSettings;
		private Button btnSettings;
		private Panel pnlContact;
		private Button btnContact;
		private System.Windows.Forms.Timer timerSideBar;
		private Panel pnlLogout;
		private Button btnLogout;
	}
}