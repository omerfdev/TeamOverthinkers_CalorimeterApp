namespace CalorimeterUI
{
	partial class SignUp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
			pictureBox1 = new PictureBox();
			rpBarPassword = new ReaLTaiizor.Controls.RibbonProgressBarLeft();
			pbHidePw = new PictureBox();
			dtpBirthDate = new DrakeUI.Framework.DrakeUIDatePicker();
			btnSignUp = new DrakeUI.Framework.DrakeUIButton();
			lblRePwd = new Label();
			txtRePwd = new ReaLTaiizor.Controls.DungeonTextBox();
			lblPwd = new Label();
			lblMail = new Label();
			lblBirthDate = new Label();
			lblSurname = new Label();
			lblName = new Label();
			txtPwd = new ReaLTaiizor.Controls.DungeonTextBox();
			txtMail = new ReaLTaiizor.Controls.DungeonTextBox();
			txtSurname = new ReaLTaiizor.Controls.DungeonTextBox();
			txtName = new ReaLTaiizor.Controls.DungeonTextBox();
			pbBack = new ReaLTaiizor.Controls.ParrotPictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbHidePw).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(371, 234);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(30, 29);
			pictureBox1.TabIndex = 69;
			pictureBox1.TabStop = false;
			pictureBox1.Visible = false;
			// 
			// rpBarPassword
			// 
			rpBarPassword.BackColor = Color.Transparent;
			rpBarPassword.BaseColor = Color.FromArgb(75, 255, 255, 255);
			rpBarPassword.BorderColor = Color.FromArgb(117, 120, 117);
			rpBarPassword.ColorA = Color.FromArgb(203, 201, 205);
			rpBarPassword.ColorB = Color.FromArgb(188, 186, 190);
			rpBarPassword.EdgeColor = Color.FromArgb(125, 97, 94, 90);
			rpBarPassword.ForeColor = Color.Black;
			rpBarPassword.HatchType = System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal;
			rpBarPassword.Location = new Point(163, 329);
			rpBarPassword.Maximum = 100;
			rpBarPassword.Name = "rpBarPassword";
			rpBarPassword.PercentageText = "%";
			rpBarPassword.ProgressBorderColorA = Color.FromArgb(150, 97, 94, 90);
			rpBarPassword.ProgressBorderColorB = Color.FromArgb(153, 151, 155);
			rpBarPassword.ProgressColorA = Color.FromArgb(203, 201, 205);
			rpBarPassword.ProgressColorB = Color.FromArgb(188, 186, 190);
			rpBarPassword.ProgressLineColorA = Color.FromArgb(40, 255, 255, 255);
			rpBarPassword.ProgressLineColorB = Color.FromArgb(20, 255, 255, 255);
			rpBarPassword.ShowEdge = false;
			rpBarPassword.ShowPercentage = false;
			rpBarPassword.Size = new Size(203, 10);
			rpBarPassword.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			rpBarPassword.TabIndex = 68;
			rpBarPassword.Text = "ribbonProgressBarLeft1";
			rpBarPassword.Value = 0;
			// 
			// pbHidePw
			// 
			pbHidePw.BackColor = Color.Transparent;
			pbHidePw.BackgroundImage = (Image)resources.GetObject("pbHidePw.BackgroundImage");
			pbHidePw.BackgroundImageLayout = ImageLayout.Zoom;
			pbHidePw.Location = new Point(371, 290);
			pbHidePw.Name = "pbHidePw";
			pbHidePw.Size = new Size(32, 28);
			pbHidePw.SizeMode = PictureBoxSizeMode.Zoom;
			pbHidePw.TabIndex = 67;
			pbHidePw.TabStop = false;
			pbHidePw.Click += pbHidePw_Click;
			// 
			// dtpBirthDate
			// 
			dtpBirthDate.FillColor = Color.White;
			dtpBirthDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dtpBirthDate.Location = new Point(164, 178);
			dtpBirthDate.Margin = new Padding(4, 5, 4, 5);
			dtpBirthDate.MaxLength = 10;
			dtpBirthDate.MinimumSize = new Size(63, 0);
			dtpBirthDate.Name = "dtpBirthDate";
			dtpBirthDate.Padding = new Padding(0, 0, 30, 0);
			dtpBirthDate.RectColor = Color.FromArgb(56, 142, 60);
			dtpBirthDate.RectDisableColor = Color.FromArgb(227, 242, 253);
			dtpBirthDate.Size = new Size(201, 30);
			dtpBirthDate.Style = DrakeUI.Framework.UIStyle.Green;
			dtpBirthDate.SymbolDropDown = 61555;
			dtpBirthDate.SymbolNormal = 61555;
			dtpBirthDate.TabIndex = 66;
			dtpBirthDate.Text = "2023-07-07";
			dtpBirthDate.TextAlignment = ContentAlignment.MiddleLeft;
			dtpBirthDate.Value = new DateTime(2023, 7, 7, 16, 0, 25, 425);
			// 
			// btnSignUp
			// 
			btnSignUp.FillColor = Color.Olive;
			btnSignUp.FillHoverColor = Color.DarkKhaki;
			btnSignUp.FillPressColor = Color.DarkKhaki;
			btnSignUp.FillSelectedColor = Color.DarkKhaki;
			btnSignUp.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnSignUp.ForeColor = Color.Khaki;
			btnSignUp.Location = new Point(211, 409);
			btnSignUp.Name = "btnSignUp";
			btnSignUp.RectColor = Color.DarkKhaki;
			btnSignUp.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnSignUp.RectHoverColor = Color.Olive;
			btnSignUp.Size = new Size(83, 28);
			btnSignUp.Style = DrakeUI.Framework.UIStyle.Custom;
			btnSignUp.TabIndex = 65;
			btnSignUp.Text = "Sign Up";
			btnSignUp.Click += btnSignUp_Click;
			// 
			// lblRePwd
			// 
			lblRePwd.AutoSize = true;
			lblRePwd.BackColor = Color.Transparent;
			lblRePwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblRePwd.ForeColor = Color.Olive;
			lblRePwd.Location = new Point(164, 347);
			lblRePwd.Name = "lblRePwd";
			lblRePwd.Size = new Size(141, 20);
			lblRePwd.TabIndex = 64;
			lblRePwd.Text = "Re-Enter Password";
			// 
			// txtRePwd
			// 
			txtRePwd.BackColor = Color.Transparent;
			txtRePwd.BorderColor = Color.FromArgb(180, 180, 180);
			txtRePwd.EdgeColor = Color.White;
			txtRePwd.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtRePwd.ForeColor = Color.DimGray;
			txtRePwd.Location = new Point(164, 370);
			txtRePwd.MaxLength = 16;
			txtRePwd.Multiline = false;
			txtRePwd.Name = "txtRePwd";
			txtRePwd.ReadOnly = false;
			txtRePwd.Size = new Size(202, 33);
			txtRePwd.TabIndex = 63;
			txtRePwd.TextAlignment = HorizontalAlignment.Left;
			txtRePwd.UseSystemPasswordChar = true;
			// 
			// lblPwd
			// 
			lblPwd.AutoSize = true;
			lblPwd.BackColor = Color.Transparent;
			lblPwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblPwd.ForeColor = Color.Olive;
			lblPwd.Location = new Point(163, 267);
			lblPwd.Name = "lblPwd";
			lblPwd.Size = new Size(76, 20);
			lblPwd.TabIndex = 62;
			lblPwd.Text = "Password";
			// 
			// lblMail
			// 
			lblMail.AutoSize = true;
			lblMail.BackColor = Color.Transparent;
			lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblMail.ForeColor = Color.Olive;
			lblMail.Location = new Point(163, 211);
			lblMail.Name = "lblMail";
			lblMail.Size = new Size(53, 20);
			lblMail.TabIndex = 61;
			lblMail.Text = "E-Mail";
			// 
			// lblBirthDate
			// 
			lblBirthDate.AutoSize = true;
			lblBirthDate.BackColor = Color.Transparent;
			lblBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblBirthDate.ForeColor = Color.Olive;
			lblBirthDate.Location = new Point(163, 152);
			lblBirthDate.Name = "lblBirthDate";
			lblBirthDate.Size = new Size(81, 20);
			lblBirthDate.TabIndex = 60;
			lblBirthDate.Text = "Birth Date";
			// 
			// lblSurname
			// 
			lblSurname.AutoSize = true;
			lblSurname.BackColor = Color.Transparent;
			lblSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblSurname.ForeColor = Color.Olive;
			lblSurname.Location = new Point(163, 94);
			lblSurname.Name = "lblSurname";
			lblSurname.Size = new Size(71, 20);
			lblSurname.TabIndex = 59;
			lblSurname.Text = "Surname";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.Transparent;
			lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblName.ForeColor = Color.Olive;
			lblName.Location = new Point(163, 35);
			lblName.Name = "lblName";
			lblName.Size = new Size(51, 20);
			lblName.TabIndex = 58;
			lblName.Text = "Name";
			// 
			// txtPwd
			// 
			txtPwd.BackColor = Color.Transparent;
			txtPwd.BorderColor = Color.FromArgb(180, 180, 180);
			txtPwd.EdgeColor = Color.White;
			txtPwd.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtPwd.ForeColor = Color.DimGray;
			txtPwd.Location = new Point(163, 290);
			txtPwd.MaxLength = 16;
			txtPwd.Multiline = false;
			txtPwd.Name = "txtPwd";
			txtPwd.ReadOnly = false;
			txtPwd.Size = new Size(202, 33);
			txtPwd.TabIndex = 57;
			txtPwd.TextAlignment = HorizontalAlignment.Left;
			txtPwd.UseSystemPasswordChar = true;
			// 
			// txtMail
			// 
			txtMail.BackColor = Color.Transparent;
			txtMail.BorderColor = Color.FromArgb(180, 180, 180);
			txtMail.EdgeColor = Color.White;
			txtMail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtMail.ForeColor = Color.DimGray;
			txtMail.Location = new Point(163, 234);
			txtMail.MaxLength = 200;
			txtMail.Multiline = false;
			txtMail.Name = "txtMail";
			txtMail.ReadOnly = false;
			txtMail.Size = new Size(202, 33);
			txtMail.TabIndex = 56;
			txtMail.TextAlignment = HorizontalAlignment.Left;
			txtMail.UseSystemPasswordChar = false;
			// 
			// txtSurname
			// 
			txtSurname.BackColor = Color.Transparent;
			txtSurname.BorderColor = Color.FromArgb(180, 180, 180);
			txtSurname.EdgeColor = Color.White;
			txtSurname.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtSurname.ForeColor = Color.DimGray;
			txtSurname.Location = new Point(163, 116);
			txtSurname.MaxLength = 50;
			txtSurname.Multiline = false;
			txtSurname.Name = "txtSurname";
			txtSurname.ReadOnly = false;
			txtSurname.Size = new Size(202, 33);
			txtSurname.TabIndex = 55;
			txtSurname.TextAlignment = HorizontalAlignment.Left;
			txtSurname.UseSystemPasswordChar = false;
			// 
			// txtName
			// 
			txtName.BackColor = Color.Transparent;
			txtName.BorderColor = Color.FromArgb(180, 180, 180);
			txtName.EdgeColor = Color.White;
			txtName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtName.ForeColor = Color.DimGray;
			txtName.Location = new Point(163, 58);
			txtName.MaxLength = 50;
			txtName.Multiline = false;
			txtName.Name = "txtName";
			txtName.ReadOnly = false;
			txtName.Size = new Size(202, 33);
			txtName.TabIndex = 54;
			txtName.TextAlignment = HorizontalAlignment.Left;
			txtName.UseSystemPasswordChar = false;
			// 
			// pbBack
			// 
			pbBack.BackColor = Color.Transparent;
			pbBack.BackgroundImage = (Image)resources.GetObject("pbBack.BackgroundImage");
			pbBack.BackgroundImageLayout = ImageLayout.Zoom;
			pbBack.ColorLeft = Color.DodgerBlue;
			pbBack.ColorRight = Color.DodgerBlue;
			pbBack.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			pbBack.Cursor = Cursors.Hand;
			pbBack.FilterAlpha = 200;
			pbBack.FilterEnabled = true;
			pbBack.Image = null;
			pbBack.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
			pbBack.IsElipse = false;
			pbBack.IsParallax = false;
			pbBack.Location = new Point(32, 12);
			pbBack.Name = "pbBack";
			pbBack.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			pbBack.Size = new Size(43, 34);
			pbBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			pbBack.TabIndex = 53;
			pbBack.Text = "parrotPictureBox1";
			pbBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			pbBack.Click += pbBack_Click;
			pbBack.MouseEnter += pbBack_MouseEnter;
			pbBack.MouseLeave += pbBack_MouseLeave;
			// 
			// SignUp
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(520, 450);
			Controls.Add(pictureBox1);
			Controls.Add(rpBarPassword);
			Controls.Add(pbHidePw);
			Controls.Add(dtpBirthDate);
			Controls.Add(btnSignUp);
			Controls.Add(lblRePwd);
			Controls.Add(txtRePwd);
			Controls.Add(lblPwd);
			Controls.Add(lblMail);
			Controls.Add(lblBirthDate);
			Controls.Add(lblSurname);
			Controls.Add(lblName);
			Controls.Add(txtPwd);
			Controls.Add(txtMail);
			Controls.Add(txtSurname);
			Controls.Add(txtName);
			Controls.Add(pbBack);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "SignUp";
			Text = "SignUp";
			Load += SignUp_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbHidePw).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private ReaLTaiizor.Controls.RibbonProgressBarLeft rpBarPassword;
		private PictureBox pbHidePw;
		private DrakeUI.Framework.DrakeUIDatePicker dtpBirthDate;
		private DrakeUI.Framework.DrakeUIButton btnSignUp;
		private Label lblRePwd;
		private ReaLTaiizor.Controls.DungeonTextBox txtRePwd;
		private Label lblPwd;
		private Label lblMail;
		private Label lblBirthDate;
		private Label lblSurname;
		private Label lblName;
		private ReaLTaiizor.Controls.DungeonTextBox txtPwd;
		private ReaLTaiizor.Controls.DungeonTextBox txtMail;
		private ReaLTaiizor.Controls.DungeonTextBox txtSurname;
		private ReaLTaiizor.Controls.DungeonTextBox txtName;
		private ReaLTaiizor.Controls.ParrotPictureBox pbBack;
	}
}