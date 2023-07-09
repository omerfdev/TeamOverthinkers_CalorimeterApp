namespace CalorimeterUI
{
	partial class SignIn
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
			toggleMode = new ReaLTaiizor.Controls.DungeonToggleButton();
			chkRemember = new CheckBox();
			pcEmailVerification = new PictureBox();
			pbHidePw = new PictureBox();
			lblPwd = new Label();
			lblMail = new Label();
			lblForgetPwd = new ReaLTaiizor.Controls.DungeonLinkLabel();
			lblSignUp = new ReaLTaiizor.Controls.DungeonLinkLabel();
			btnSignIn = new DrakeUI.Framework.DrakeUIButton();
			txtPwd = new ReaLTaiizor.Controls.DungeonTextBox();
			txtMail = new ReaLTaiizor.Controls.DungeonTextBox();
			errorProviderEmail = new ErrorProvider(components);
			dlblDownForm = new DrakeUI.Framework.DrakeUILabel();
			dlblExitForm = new DrakeUI.Framework.DrakeUILabel();
			((System.ComponentModel.ISupportInitialize)pcEmailVerification).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbHidePw).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProviderEmail).BeginInit();
			SuspendLayout();
			// 
			// toggleMode
			// 
			toggleMode.Location = new Point(691, 414);
			toggleMode.Name = "toggleMode";
			toggleMode.Size = new Size(79, 27);
			toggleMode.TabIndex = 1;
			toggleMode.Text = "toggleMode";
			toggleMode.Toggled = false;
			toggleMode.ToggledBackColorA = Color.DarkOliveGreen;
			toggleMode.ToggledBackColorB = Color.DarkOliveGreen;
			toggleMode.ToggledBorderColorA = Color.Transparent;
			toggleMode.ToggledBorderColorB = Color.Transparent;
			toggleMode.ToggledBorderColorC = SystemColors.Control;
			toggleMode.ToggledBorderColorD = SystemColors.Control;
			toggleMode.ToggledColorA = Color.DarkKhaki;
			toggleMode.ToggledColorB = Color.DarkKhaki;
			toggleMode.ToggledColorC = Color.Olive;
			toggleMode.ToggledColorD = Color.Olive;
			toggleMode.ToggledIOColorA = Color.WhiteSmoke;
			toggleMode.ToggledIOColorB = Color.WhiteSmoke;
			toggleMode.ToggledOnOffColorA = Color.WhiteSmoke;
			toggleMode.ToggledOnOffColorB = Color.WhiteSmoke;
			toggleMode.ToggledYesNoColorA = Color.WhiteSmoke;
			toggleMode.ToggledYesNoColorB = Color.DimGray;
			toggleMode.Type = ReaLTaiizor.Controls.DungeonToggleButton._Type.IO;
			toggleMode.ToggledChanged += toggleMode_ToggledChanged;
			// 
			// chkRemember
			// 
			chkRemember.AutoSize = true;
			chkRemember.BackColor = Color.Transparent;
			chkRemember.Location = new Point(372, 284);
			chkRemember.Name = "chkRemember";
			chkRemember.Size = new Size(129, 24);
			chkRemember.TabIndex = 62;
			chkRemember.Text = "Remember Me";
			chkRemember.UseVisualStyleBackColor = false;
			// 
			// pcEmailVerification
			// 
			pcEmailVerification.BackColor = Color.Transparent;
			pcEmailVerification.Image = (Image)resources.GetObject("pcEmailVerification.Image");
			pcEmailVerification.Location = new Point(602, 187);
			pcEmailVerification.Name = "pcEmailVerification";
			pcEmailVerification.Size = new Size(30, 29);
			pcEmailVerification.TabIndex = 61;
			pcEmailVerification.TabStop = false;
			pcEmailVerification.Visible = false;
			// 
			// pbHidePw
			// 
			pbHidePw.BackColor = Color.Transparent;
			pbHidePw.BackgroundImage = (Image)resources.GetObject("pbHidePw.BackgroundImage");
			pbHidePw.BackgroundImageLayout = ImageLayout.Stretch;
			pbHidePw.Cursor = Cursors.Hand;
			pbHidePw.Location = new Point(602, 250);
			pbHidePw.Name = "pbHidePw";
			pbHidePw.Size = new Size(32, 28);
			pbHidePw.SizeMode = PictureBoxSizeMode.Zoom;
			pbHidePw.TabIndex = 60;
			pbHidePw.TabStop = false;
			pbHidePw.Click += pbHidePw_Click;
			// 
			// lblPwd
			// 
			lblPwd.BackColor = Color.Transparent;
			lblPwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblPwd.ForeColor = Color.DarkOliveGreen;
			lblPwd.Location = new Point(347, 219);
			lblPwd.Name = "lblPwd";
			lblPwd.Size = new Size(100, 23);
			lblPwd.TabIndex = 59;
			lblPwd.Text = "    Password";
			lblPwd.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblMail
			// 
			lblMail.BackColor = Color.Transparent;
			lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblMail.ForeColor = Color.DarkOliveGreen;
			lblMail.Location = new Point(347, 157);
			lblMail.Name = "lblMail";
			lblMail.Size = new Size(100, 23);
			lblMail.TabIndex = 53;
			lblMail.Text = "E-Mail";
			lblMail.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblForgetPwd
			// 
			lblForgetPwd.ActiveLinkColor = Color.DarkKhaki;
			lblForgetPwd.AutoSize = true;
			lblForgetPwd.BackColor = Color.Transparent;
			lblForgetPwd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblForgetPwd.LinkBehavior = LinkBehavior.AlwaysUnderline;
			lblForgetPwd.LinkColor = Color.DarkOliveGreen;
			lblForgetPwd.Location = new Point(474, 364);
			lblForgetPwd.Name = "lblForgetPwd";
			lblForgetPwd.Size = new Size(160, 25);
			lblForgetPwd.TabIndex = 58;
			lblForgetPwd.TabStop = true;
			lblForgetPwd.Text = "Forgot Password?";
			lblForgetPwd.VisitedLinkColor = Color.FromArgb(240, 119, 70);
			lblForgetPwd.LinkClicked += lblForgetPwd_LinkClicked;
			// 
			// lblSignUp
			// 
			lblSignUp.ActiveLinkColor = Color.DarkKhaki;
			lblSignUp.AutoSize = true;
			lblSignUp.BackColor = Color.Transparent;
			lblSignUp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			lblSignUp.LinkBehavior = LinkBehavior.AlwaysUnderline;
			lblSignUp.LinkColor = Color.DarkOliveGreen;
			lblSignUp.Location = new Point(369, 364);
			lblSignUp.Name = "lblSignUp";
			lblSignUp.Size = new Size(78, 25);
			lblSignUp.TabIndex = 57;
			lblSignUp.TabStop = true;
			lblSignUp.Text = "Sign Up";
			lblSignUp.VisitedLinkColor = Color.FromArgb(240, 119, 70);
			// 
			// btnSignIn
			// 
			btnSignIn.FillColor = Color.DarkOliveGreen;
			btnSignIn.FillHoverColor = Color.DarkKhaki;
			btnSignIn.FillPressColor = Color.DarkKhaki;
			btnSignIn.FillSelectedColor = Color.DarkKhaki;
			btnSignIn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnSignIn.ForeColor = Color.Khaki;
			btnSignIn.Location = new Point(445, 314);
			btnSignIn.Name = "btnSignIn";
			btnSignIn.RectColor = Color.DarkKhaki;
			btnSignIn.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnSignIn.RectHoverColor = Color.Olive;
			btnSignIn.Size = new Size(96, 38);
			btnSignIn.Style = DrakeUI.Framework.UIStyle.Custom;
			btnSignIn.TabIndex = 54;
			btnSignIn.Text = "Sign In";
			btnSignIn.Click += btnSignIn_Click;
			// 
			// txtPwd
			// 
			txtPwd.BackColor = Color.Transparent;
			txtPwd.BorderColor = Color.FromArgb(128, 255, 128);
			txtPwd.EdgeColor = SystemColors.MenuText;
			txtPwd.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtPwd.ForeColor = Color.Olive;
			txtPwd.Location = new Point(372, 245);
			txtPwd.MaxLength = 16;
			txtPwd.Multiline = false;
			txtPwd.Name = "txtPwd";
			txtPwd.ReadOnly = false;
			txtPwd.Size = new Size(224, 33);
			txtPwd.TabIndex = 56;
			txtPwd.TextAlignment = HorizontalAlignment.Left;
			txtPwd.UseSystemPasswordChar = true;
			// 
			// txtMail
			// 
			txtMail.BackColor = Color.Transparent;
			txtMail.BorderColor = Color.FromArgb(128, 255, 128);
			txtMail.EdgeColor = Color.Red;
			txtMail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtMail.ForeColor = Color.Olive;
			txtMail.Location = new Point(372, 183);
			txtMail.MaxLength = 200;
			txtMail.Multiline = false;
			txtMail.Name = "txtMail";
			txtMail.ReadOnly = false;
			txtMail.Size = new Size(224, 33);
			txtMail.TabIndex = 55;
			txtMail.TextAlignment = HorizontalAlignment.Left;
			txtMail.UseSystemPasswordChar = false;
			txtMail.TextChanged += txtMail_TextChanged;
			// 
			// errorProviderEmail
			// 
			errorProviderEmail.ContainerControl = this;
			// 
			// dlblDownForm
			// 
			dlblDownForm.BackColor = Color.Transparent;
			dlblDownForm.Cursor = Cursors.Hand;
			dlblDownForm.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
			dlblDownForm.ForeColor = Color.Olive;
			dlblDownForm.Location = new Point(668, 9);
			dlblDownForm.Name = "dlblDownForm";
			dlblDownForm.Size = new Size(28, 34);
			dlblDownForm.TabIndex = 64;
			dlblDownForm.Text = "-";
			dlblDownForm.TextAlign = ContentAlignment.MiddleLeft;
			dlblDownForm.Click += dlblDownForm_Click;
			dlblDownForm.MouseEnter += dlblDownForm_MouseEnter;
			dlblDownForm.MouseLeave += dlblDownForm_MouseLeave;
			// 
			// dlblExitForm
			// 
			dlblExitForm.BackColor = Color.Transparent;
			dlblExitForm.Cursor = Cursors.Hand;
			dlblExitForm.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
			dlblExitForm.ForeColor = Color.Olive;
			dlblExitForm.Location = new Point(731, 14);
			dlblExitForm.Name = "dlblExitForm";
			dlblExitForm.Size = new Size(28, 33);
			dlblExitForm.TabIndex = 63;
			dlblExitForm.Text = "X";
			dlblExitForm.TextAlign = ContentAlignment.MiddleLeft;
			dlblExitForm.Click += dlblExitForm_Click;
			dlblExitForm.MouseEnter += dlblExitForm_MouseEnter;
			dlblExitForm.MouseLeave += dlblExitForm_MouseLeave;
			// 
			// SignIn
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(782, 453);
			Controls.Add(dlblDownForm);
			Controls.Add(dlblExitForm);
			Controls.Add(chkRemember);
			Controls.Add(pcEmailVerification);
			Controls.Add(pbHidePw);
			Controls.Add(lblPwd);
			Controls.Add(lblMail);
			Controls.Add(lblForgetPwd);
			Controls.Add(lblSignUp);
			Controls.Add(btnSignIn);
			Controls.Add(txtPwd);
			Controls.Add(txtMail);
			Controls.Add(toggleMode);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "SignIn";
			Text = "Calorimeter";
			MouseDown += SignIn_MouseDown;
			MouseMove += SignIn_MouseMove;
			MouseUp += SignIn_MouseUp;
			((System.ComponentModel.ISupportInitialize)pcEmailVerification).EndInit();
			((System.ComponentModel.ISupportInitialize)pbHidePw).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProviderEmail).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ReaLTaiizor.Controls.DungeonToggleButton toggleMode;
		private CheckBox chkRemember;
		private PictureBox pcEmailVerification;
		private PictureBox pbHidePw;
		private Label lblPwd;
		private Label lblMail;
		private ReaLTaiizor.Controls.DungeonLinkLabel lblForgetPwd;
		private ReaLTaiizor.Controls.DungeonLinkLabel lblSignUp;
		private DrakeUI.Framework.DrakeUIButton btnSignIn;
		private ReaLTaiizor.Controls.DungeonTextBox txtPwd;
		private ReaLTaiizor.Controls.DungeonTextBox txtMail;
		private ErrorProvider errorProviderEmail;
		private DrakeUI.Framework.DrakeUILabel dlblDownForm;
		private DrakeUI.Framework.DrakeUILabel dlblExitForm;
	}
}