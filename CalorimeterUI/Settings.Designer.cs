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
			lblDarkMode = new Label();
			lblChangePassword = new Label();
			SuspendLayout();
			// 
			// lblDarkMode
			// 
			lblDarkMode.AutoSize = true;
			lblDarkMode.BackColor = Color.Transparent;
			lblDarkMode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblDarkMode.ForeColor = Color.FromArgb(64, 64, 64);
			lblDarkMode.Location = new Point(198, 180);
			lblDarkMode.Name = "lblDarkMode";
			lblDarkMode.Size = new Size(108, 25);
			lblDarkMode.TabIndex = 14;
			lblDarkMode.Text = "Dark Mode";
			// 
			// lblChangePassword
			// 
			lblChangePassword.AutoSize = true;
			lblChangePassword.BackColor = Color.Transparent;
			lblChangePassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblChangePassword.ForeColor = Color.FromArgb(64, 64, 64);
			lblChangePassword.Location = new Point(198, 138);
			lblChangePassword.Name = "lblChangePassword";
			lblChangePassword.Size = new Size(183, 25);
			lblChangePassword.TabIndex = 13;
			lblChangePassword.Text = "Change Passsword";
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(lblDarkMode);
			Controls.Add(lblChangePassword);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Settings";
			Text = "Settings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblDarkMode;
		private Label lblChangePassword;
	}
}