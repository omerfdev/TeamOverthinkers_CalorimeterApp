namespace CalorimeterUI
{
	partial class EmailVerificationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailVerificationForm));
			pbBack = new ReaLTaiizor.Controls.ParrotPictureBox();
			btnSend = new DrakeUI.Framework.DrakeUIButton();
			dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
			txtVerification = new ReaLTaiizor.Controls.DungeonTextBox();
			SuspendLayout();
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
			pbBack.Location = new Point(26, 24);
			pbBack.Name = "pbBack";
			pbBack.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			pbBack.Size = new Size(43, 35);
			pbBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			pbBack.TabIndex = 59;
			pbBack.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			pbBack.Click += pbBack_Click;
			pbBack.MouseEnter += pbBack_MouseEnter;
			pbBack.MouseLeave += pbBack_MouseLeave;
			// 
			// btnSend
			// 
			btnSend.FillColor = Color.Olive;
			btnSend.FillHoverColor = Color.DarkKhaki;
			btnSend.FillPressColor = Color.DarkKhaki;
			btnSend.FillSelectedColor = Color.DarkKhaki;
			btnSend.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnSend.ForeColor = Color.Khaki;
			btnSend.Location = new Point(209, 151);
			btnSend.Name = "btnSend";
			btnSend.RectColor = Color.DarkKhaki;
			btnSend.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnSend.RectHoverColor = Color.Olive;
			btnSend.Size = new Size(99, 37);
			btnSend.Style = DrakeUI.Framework.UIStyle.Custom;
			btnSend.TabIndex = 58;
			btnSend.Text = "Send";
			btnSend.Click += btnSend_Click;
			// 
			// dungeonLabel1
			// 
			dungeonLabel1.BackColor = Color.Transparent;
			dungeonLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
			dungeonLabel1.Location = new Point(160, 77);
			dungeonLabel1.Name = "dungeonLabel1";
			dungeonLabel1.Size = new Size(197, 31);
			dungeonLabel1.TabIndex = 57;
			dungeonLabel1.Text = "Verification Code";
			dungeonLabel1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtVerification
			// 
			txtVerification.BackColor = Color.Transparent;
			txtVerification.BorderColor = Color.FromArgb(180, 180, 180);
			txtVerification.EdgeColor = Color.White;
			txtVerification.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
			txtVerification.ForeColor = Color.DimGray;
			txtVerification.Location = new Point(160, 111);
			txtVerification.MaxLength = 32767;
			txtVerification.Multiline = false;
			txtVerification.Name = "txtVerification";
			txtVerification.ReadOnly = false;
			txtVerification.Size = new Size(197, 33);
			txtVerification.TabIndex = 56;
			txtVerification.TextAlignment = HorizontalAlignment.Left;
			txtVerification.UseSystemPasswordChar = false;
			// 
			// EmailVerificationForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(506, 278);
			Controls.Add(pbBack);
			Controls.Add(btnSend);
			Controls.Add(dungeonLabel1);
			Controls.Add(txtVerification);
			FormBorderStyle = FormBorderStyle.None;
			Name = "EmailVerificationForm";
			Text = "EmailVerificationForm";
			Load += EmailVerificationForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private ReaLTaiizor.Controls.ParrotPictureBox pbBack;
		private DrakeUI.Framework.DrakeUIButton btnSend;
		private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
		private ReaLTaiizor.Controls.DungeonTextBox txtVerification;
	}
}