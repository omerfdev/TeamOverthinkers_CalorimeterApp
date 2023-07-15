namespace CalorimeterUI
{
	partial class Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			grpPersonal = new ReaLTaiizor.Controls.CyberGroupBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			txtOldPassword = new ReaLTaiizor.Controls.MoonTextBox();
			txtNewPwAgain = new ReaLTaiizor.Controls.MoonTextBox();
			txtNewPassword = new ReaLTaiizor.Controls.MoonTextBox();
			btnSave = new ReaLTaiizor.Controls.CyberButton();
			lblChangePassword = new Label();
			grpPersonal.SuspendLayout();
			SuspendLayout();
			// 
			// grpPersonal
			// 
			grpPersonal.Alpha = 20;
			grpPersonal.BackColor = Color.Transparent;
			grpPersonal.Background = true;
			grpPersonal.Background_WidthPen = 3F;
			grpPersonal.BackgroundPen = true;
			grpPersonal.ColorBackground = Color.FromArgb(223, 231, 195);
			grpPersonal.ColorBackground_1 = Color.FromArgb(37, 52, 68);
			grpPersonal.ColorBackground_2 = Color.FromArgb(41, 63, 86);
			grpPersonal.ColorBackground_Pen = Color.FromArgb(161, 97, 110);
			grpPersonal.ColorLighting = Color.FromArgb(161, 97, 110);
			grpPersonal.ColorPen_1 = Color.FromArgb(37, 52, 68);
			grpPersonal.ColorPen_2 = Color.FromArgb(41, 63, 86);
			grpPersonal.Controls.Add(label3);
			grpPersonal.Controls.Add(label2);
			grpPersonal.Controls.Add(label1);
			grpPersonal.Controls.Add(txtOldPassword);
			grpPersonal.Controls.Add(txtNewPwAgain);
			grpPersonal.Controls.Add(txtNewPassword);
			grpPersonal.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			grpPersonal.ForeColor = Color.FromArgb(245, 245, 245);
			grpPersonal.Lighting = false;
			grpPersonal.LinearGradient_Background = false;
			grpPersonal.LinearGradientPen = false;
			grpPersonal.Location = new Point(204, 51);
			grpPersonal.Margin = new Padding(3, 4, 3, 4);
			grpPersonal.Name = "grpPersonal";
			grpPersonal.PenWidth = 15;
			grpPersonal.RGB = false;
			grpPersonal.Rounding = true;
			grpPersonal.RoundingInt = 60;
			grpPersonal.Size = new Size(393, 251);
			grpPersonal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			grpPersonal.TabIndex = 27;
			grpPersonal.Tag = "Cyber";
			grpPersonal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			grpPersonal.Timer_RGB = 300;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(21, 60);
			label3.Name = "label3";
			label3.Size = new Size(98, 25);
			label3.TabIndex = 18;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(21, 121);
			label2.Name = "label2";
			label2.Size = new Size(142, 25);
			label2.TabIndex = 17;
			label2.Text = "New Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(21, 185);
			label1.Name = "label1";
			label1.Size = new Size(208, 25);
			label1.TabIndex = 16;
			label1.Text = "Retype New Password";
			// 
			// txtOldPassword
			// 
			txtOldPassword.BackColor = Color.Lavender;
			txtOldPassword.BorderColor = Color.FromArgb(161, 97, 110);
			txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
			txtOldPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtOldPassword.ForeColor = Color.Black;
			txtOldPassword.Location = new Point(230, 57);
			txtOldPassword.Margin = new Padding(3, 4, 3, 4);
			txtOldPassword.MaxLength = 16;
			txtOldPassword.Name = "txtOldPassword";
			txtOldPassword.Size = new Size(143, 30);
			txtOldPassword.TabIndex = 1;
			txtOldPassword.TextAlign = HorizontalAlignment.Center;
			txtOldPassword.UseSystemPasswordChar = true;
			// 
			// txtNewPwAgain
			// 
			txtNewPwAgain.BackColor = Color.Lavender;
			txtNewPwAgain.BorderColor = Color.FromArgb(161, 97, 110);
			txtNewPwAgain.BorderStyle = BorderStyle.FixedSingle;
			txtNewPwAgain.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNewPwAgain.ForeColor = Color.Black;
			txtNewPwAgain.Location = new Point(230, 177);
			txtNewPwAgain.Margin = new Padding(3, 4, 3, 4);
			txtNewPwAgain.MaxLength = 16;
			txtNewPwAgain.Name = "txtNewPwAgain";
			txtNewPwAgain.Size = new Size(143, 30);
			txtNewPwAgain.TabIndex = 3;
			txtNewPwAgain.TextAlign = HorizontalAlignment.Center;
			txtNewPwAgain.UseSystemPasswordChar = true;
			// 
			// txtNewPassword
			// 
			txtNewPassword.BackColor = Color.Lavender;
			txtNewPassword.BorderColor = Color.FromArgb(161, 97, 110);
			txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
			txtNewPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNewPassword.ForeColor = Color.Black;
			txtNewPassword.Location = new Point(230, 113);
			txtNewPassword.Margin = new Padding(3, 4, 3, 4);
			txtNewPassword.MaxLength = 16;
			txtNewPassword.Name = "txtNewPassword";
			txtNewPassword.Size = new Size(143, 30);
			txtNewPassword.TabIndex = 2;
			txtNewPassword.TextAlign = HorizontalAlignment.Center;
			txtNewPassword.UseSystemPasswordChar = true;
			// 
			// btnSave
			// 
			btnSave.Alpha = 20;
			btnSave.BackColor = Color.Transparent;
			btnSave.Background = true;
			btnSave.Background_WidthPen = 4F;
			btnSave.BackgroundPen = true;
			btnSave.ColorBackground = Color.Lavender;
			btnSave.ColorBackground_1 = Color.DarkKhaki;
			btnSave.ColorBackground_2 = Color.DarkKhaki;
			btnSave.ColorBackground_Pen = Color.FromArgb(161, 97, 110);
			btnSave.ColorLighting = Color.DarkKhaki;
			btnSave.ColorPen_1 = Color.DarkKhaki;
			btnSave.ColorPen_2 = Color.DarkKhaki;
			btnSave.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			btnSave.Effect_1 = true;
			btnSave.Effect_1_ColorBackground = Color.DarkKhaki;
			btnSave.Effect_1_Transparency = 25;
			btnSave.Effect_2 = true;
			btnSave.Effect_2_ColorBackground = Color.DarkKhaki;
			btnSave.Effect_2_Transparency = 20;
			btnSave.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
			btnSave.ForeColor = Color.Black;
			btnSave.Lighting = false;
			btnSave.LinearGradient_Background = false;
			btnSave.LinearGradientPen = false;
			btnSave.Location = new Point(351, 349);
			btnSave.Margin = new Padding(3, 5, 3, 5);
			btnSave.Name = "btnSave";
			btnSave.PenWidth = 15;
			btnSave.Rounding = true;
			btnSave.RoundingInt = 70;
			btnSave.Size = new Size(112, 81);
			btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			btnSave.TabIndex = 26;
			btnSave.Tag = "Cyber";
			btnSave.TextButton = "Save";
			btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			btnSave.Timer_Effect_1 = 5;
			btnSave.Timer_RGB = 300;
			btnSave.Click += btnSave_Click;
			// 
			// lblChangePassword
			// 
			lblChangePassword.AutoSize = true;
			lblChangePassword.BackColor = Color.Transparent;
			lblChangePassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblChangePassword.ForeColor = Color.FromArgb(161, 97, 110);
			lblChangePassword.Location = new Point(307, 20);
			lblChangePassword.Name = "lblChangePassword";
			lblChangePassword.Size = new Size(199, 25);
			lblChangePassword.TabIndex = 25;
			lblChangePassword.Text = "Change Passsword";
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(grpPersonal);
			Controls.Add(btnSave);
			Controls.Add(lblChangePassword);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Settings";
			Text = "Settings";
			Load += Settings_Load;
			grpPersonal.ResumeLayout(false);
			grpPersonal.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ReaLTaiizor.Controls.CyberGroupBox grpPersonal;
		private Label label3;
		private Label label2;
		private Label label1;
		private ReaLTaiizor.Controls.MoonTextBox txtOldPassword;
		private ReaLTaiizor.Controls.MoonTextBox txtNewPwAgain;
		private ReaLTaiizor.Controls.MoonTextBox txtNewPassword;
		private ReaLTaiizor.Controls.CyberButton btnSave;
		private Label lblChangePassword;
	}
}