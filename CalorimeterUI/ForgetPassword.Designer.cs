namespace CalorimeterUI
{
	partial class ForgetPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
			btnSend = new DrakeUI.Framework.DrakeUIButton();
			pcEmail = new PictureBox();
			lblMail = new Label();
			txtEmail = new ReaLTaiizor.Controls.DungeonTextBox();
			pbBack = new ReaLTaiizor.Controls.ParrotPictureBox();
			errorProviderForgetPassword = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)pcEmail).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProviderForgetPassword).BeginInit();
			SuspendLayout();
			// 
			// btnSend
			// 
			btnSend.FillColor = Color.Olive;
			btnSend.FillHoverColor = Color.DarkKhaki;
			btnSend.FillPressColor = Color.DarkKhaki;
			btnSend.FillSelectedColor = Color.DarkKhaki;
			btnSend.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnSend.ForeColor = Color.Khaki;
			btnSend.Location = new Point(166, 230);
			btnSend.Name = "btnSend";
			btnSend.RectColor = Color.DarkKhaki;
			btnSend.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnSend.RectHoverColor = Color.Olive;
			btnSend.Size = new Size(99, 38);
			btnSend.Style = DrakeUI.Framework.UIStyle.Custom;
			btnSend.TabIndex = 58;
			btnSend.Text = "Send";
			btnSend.Click += btnSend_Click;
			// 
			// pcEmail
			// 
			pcEmail.BackColor = Color.Transparent;
			pcEmail.Image = (Image)resources.GetObject("pcEmail.Image");
			pcEmail.Location = new Point(315, 191);
			pcEmail.Name = "pcEmail";
			pcEmail.Size = new Size(30, 29);
			pcEmail.SizeMode = PictureBoxSizeMode.StretchImage;
			pcEmail.TabIndex = 57;
			pcEmail.TabStop = false;
			pcEmail.Visible = false;
			// 
			// lblMail
			// 
			lblMail.AutoSize = true;
			lblMail.Location = new Point(103, 164);
			lblMail.Name = "lblMail";
			lblMail.Size = new Size(52, 20);
			lblMail.TabIndex = 56;
			lblMail.Text = "E-Mail";
			// 
			// txtEmail
			// 
			txtEmail.BackColor = Color.Transparent;
			txtEmail.BorderColor = Color.FromArgb(180, 180, 180);
			txtEmail.EdgeColor = Color.White;
			txtEmail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmail.ForeColor = Color.DimGray;
			txtEmail.Location = new Point(103, 191);
			txtEmail.MaxLength = 200;
			txtEmail.Multiline = false;
			txtEmail.Name = "txtEmail";
			txtEmail.ReadOnly = false;
			txtEmail.Size = new Size(206, 33);
			txtEmail.TabIndex = 55;
			txtEmail.TextAlignment = HorizontalAlignment.Left;
			txtEmail.UseSystemPasswordChar = false;
			txtEmail.TextChanged += txtEmail_TextChanged;
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
			pbBack.Location = new Point(22, 22);
			pbBack.Name = "pbBack";
			pbBack.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			pbBack.Size = new Size(43, 34);
			pbBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			pbBack.TabIndex = 54;
			pbBack.Text = "ppbBack";
			pbBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			pbBack.Click += pbBack_Click;
			pbBack.MouseEnter += pbBack_MouseEnter;
			pbBack.MouseLeave += pbBack_MouseLeave;
			// 
			// errorProviderForgetPassword
			// 
			errorProviderForgetPassword.ContainerControl = this;
			// 
			// ForgetPassword
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(448, 450);
			Controls.Add(btnSend);
			Controls.Add(pcEmail);
			Controls.Add(lblMail);
			Controls.Add(txtEmail);
			Controls.Add(pbBack);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ForgetPassword";
			Text = "ForgetPassword";
			Load += ForgetPassword_Load;
			((System.ComponentModel.ISupportInitialize)pcEmail).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProviderForgetPassword).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DrakeUI.Framework.DrakeUIButton btnSend;
		private PictureBox pcEmail;
		private Label lblMail;
		private ReaLTaiizor.Controls.DungeonTextBox txtEmail;
		private ReaLTaiizor.Controls.ParrotPictureBox pbBack;
		private ErrorProvider errorProviderForgetPassword;
	}
}