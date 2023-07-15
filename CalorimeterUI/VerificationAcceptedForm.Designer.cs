namespace CalorimeterUI
{
	partial class VerificationAcceptedForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationAcceptedForm));
			btnOk = new DrakeUI.Framework.DrakeUIButton();
			lblVerifiedInfo = new Label();
			lblVerified = new Label();
			pbVerified = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbVerified).BeginInit();
			SuspendLayout();
			// 
			// btnOk
			// 
			btnOk.FillColor = Color.DarkOliveGreen;
			btnOk.FillHoverColor = Color.DarkKhaki;
			btnOk.FillPressColor = Color.DarkKhaki;
			btnOk.FillSelectedColor = Color.DarkKhaki;
			btnOk.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnOk.ForeColor = Color.Khaki;
			btnOk.Location = new Point(156, 237);
			btnOk.Margin = new Padding(3, 4, 3, 4);
			btnOk.Name = "btnOk";
			btnOk.RectColor = Color.DarkKhaki;
			btnOk.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnOk.RectHoverColor = Color.Olive;
			btnOk.Size = new Size(95, 31);
			btnOk.Style = DrakeUI.Framework.UIStyle.Custom;
			btnOk.TabIndex = 8;
			btnOk.Text = "OK";
			// 
			// lblVerifiedInfo
			// 
			lblVerifiedInfo.AutoSize = true;
			lblVerifiedInfo.BackColor = Color.Transparent;
			lblVerifiedInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblVerifiedInfo.Location = new Point(75, 201);
			lblVerifiedInfo.Name = "lblVerifiedInfo";
			lblVerifiedInfo.Size = new Size(294, 20);
			lblVerifiedInfo.TabIndex = 7;
			lblVerifiedInfo.Text = "You have successfully verified your account.";
			// 
			// lblVerified
			// 
			lblVerified.AutoSize = true;
			lblVerified.BackColor = Color.Transparent;
			lblVerified.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			lblVerified.Location = new Point(156, 141);
			lblVerified.Name = "lblVerified";
			lblVerified.Size = new Size(115, 35);
			lblVerified.TabIndex = 6;
			lblVerified.Text = "Verified!";
			// 
			// pbVerified
			// 
			pbVerified.BackColor = Color.Transparent;
			pbVerified.Image = (Image)resources.GetObject("pbVerified.Image");
			pbVerified.Location = new Point(105, 144);
			pbVerified.Name = "pbVerified";
			pbVerified.Size = new Size(33, 32);
			pbVerified.SizeMode = PictureBoxSizeMode.StretchImage;
			pbVerified.TabIndex = 5;
			pbVerified.TabStop = false;
			// 
			// VerificationAcceptedForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(410, 380);
			Controls.Add(btnOk);
			Controls.Add(lblVerifiedInfo);
			Controls.Add(lblVerified);
			Controls.Add(pbVerified);
			FormBorderStyle = FormBorderStyle.None;
			Name = "VerificationAcceptedForm";
			Text = "VerificationAcceptedForm";
			Load += VerificationAcceptedForm_Load;
			((System.ComponentModel.ISupportInitialize)pbVerified).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DrakeUI.Framework.DrakeUIButton btnOk;
		private Label lblVerifiedInfo;
		private Label lblVerified;
		private PictureBox pbVerified;
	}
}