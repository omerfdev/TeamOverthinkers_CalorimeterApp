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
			btnSignIn = new DrakeUI.Framework.DrakeUIButton();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnSignIn
			// 
			btnSignIn.FillColor = Color.DarkOliveGreen;
			btnSignIn.FillHoverColor = Color.DarkKhaki;
			btnSignIn.FillPressColor = Color.DarkKhaki;
			btnSignIn.FillSelectedColor = Color.DarkKhaki;
			btnSignIn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnSignIn.ForeColor = Color.Khaki;
			btnSignIn.Location = new Point(127, 288);
			btnSignIn.Margin = new Padding(3, 4, 3, 4);
			btnSignIn.Name = "btnSignIn";
			btnSignIn.RectColor = Color.DarkKhaki;
			btnSignIn.RectDisableColor = Color.FromArgb(227, 242, 253);
			btnSignIn.RectHoverColor = Color.Olive;
			btnSignIn.Size = new Size(95, 31);
			btnSignIn.Style = DrakeUI.Framework.UIStyle.Custom;
			btnSignIn.TabIndex = 8;
			btnSignIn.Text = "OK";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(46, 252);
			label2.Name = "label2";
			label2.Size = new Size(294, 20);
			label2.TabIndex = 7;
			label2.Text = "You have successfully verified your account.";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(115, 192);
			label1.Name = "label1";
			label1.Size = new Size(115, 35);
			label1.TabIndex = 6;
			label1.Text = "Verified!";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Location = new Point(88, 27);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(159, 163);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// VerificationAcceptedForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnSignIn);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "VerificationAcceptedForm";
			Text = "VerificationAcceptedForm";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DrakeUI.Framework.DrakeUIButton btnSignIn;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
	}
}