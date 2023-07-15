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
			pbCheckMail = new PictureBox();
			lblMail = new Label();
			txtMail = new ReaLTaiizor.Controls.DungeonTextBox();
			pbBack = new ReaLTaiizor.Controls.ParrotPictureBox();
			errorProviderEmail = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)pbCheckMail).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProviderEmail).BeginInit();
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
			btnSend.Location = new Point(183, 235);
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
			// pbCheckMail
			// 
			pbCheckMail.BackColor = Color.Transparent;
			pbCheckMail.Image = (Image)resources.GetObject("pbCheckMail.Image");
			pbCheckMail.Location = new Point(332, 196);
			pbCheckMail.Name = "pbCheckMail";
			pbCheckMail.Size = new Size(30, 29);
			pbCheckMail.SizeMode = PictureBoxSizeMode.StretchImage;
			pbCheckMail.TabIndex = 57;
			pbCheckMail.TabStop = false;
			pbCheckMail.Visible = false;
			// 
			// lblMail
			// 
			lblMail.AutoSize = true;
			lblMail.BackColor = Color.Transparent;
			lblMail.Location = new Point(120, 169);
			lblMail.Name = "lblMail";
			lblMail.Size = new Size(52, 20);
			lblMail.TabIndex = 56;
			lblMail.Text = "E-Mail";
			// 
			// txtMail
			// 
			txtMail.BackColor = Color.Transparent;
			txtMail.BorderColor = Color.FromArgb(180, 180, 180);
			txtMail.EdgeColor = Color.White;
			txtMail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtMail.ForeColor = Color.DimGray;
			txtMail.Location = new Point(120, 196);
			txtMail.MaxLength = 200;
			txtMail.Multiline = false;
			txtMail.Name = "txtMail";
			txtMail.ReadOnly = false;
			txtMail.Size = new Size(206, 33);
			txtMail.TabIndex = 55;
			txtMail.TextAlignment = HorizontalAlignment.Left;
			txtMail.UseSystemPasswordChar = false;
			txtMail.TextChanged += txtMail_TextChanged;
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
			pbBack.Location = new Point(39, 27);
			pbBack.Name = "pbBack";
			pbBack.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			pbBack.Size = new Size(43, 34);
			pbBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			pbBack.TabIndex = 54;
			pbBack.Text = "parrotPictureBox1";
			pbBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			pbBack.Click += pbBack_Click;
			pbBack.MouseEnter += pbBack_MouseEnter;
			pbBack.MouseLeave += pbBack_MouseLeave;
			// 
			// errorProviderEmail
			// 
			errorProviderEmail.ContainerControl = this;
			// 
			// ForgetPassword
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(507, 396);
			Controls.Add(btnSend);
			Controls.Add(pbCheckMail);
			Controls.Add(lblMail);
			Controls.Add(txtMail);
			Controls.Add(pbBack);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ForgetPassword";
			Text = "ResetPassword";
			Load += ResetPassword_Load;
			((System.ComponentModel.ISupportInitialize)pbCheckMail).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProviderEmail).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DrakeUI.Framework.DrakeUIButton btnSend;
		private PictureBox pbCheckMail;
		private Label lblMail;
		private ReaLTaiizor.Controls.DungeonTextBox txtMail;
		private ReaLTaiizor.Controls.ParrotPictureBox pbBack;
		private ErrorProvider errorProviderEmail;
	}
}