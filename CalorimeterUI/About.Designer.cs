namespace CalorimeterUI
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			pbAvocado = new PictureBox();
			pbGitHub = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbAvocado).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbGitHub).BeginInit();
			SuspendLayout();
			// 
			// pbAvocado
			// 
			pbAvocado.BackColor = Color.Transparent;
			pbAvocado.Image = (Image)resources.GetObject("pbAvocado.Image");
			pbAvocado.Location = new Point(66, 48);
			pbAvocado.Name = "pbAvocado";
			pbAvocado.Size = new Size(170, 155);
			pbAvocado.SizeMode = PictureBoxSizeMode.StretchImage;
			pbAvocado.TabIndex = 0;
			pbAvocado.TabStop = false;
			// 
			// pbGitHub
			// 
			pbGitHub.BackColor = Color.Transparent;
			pbGitHub.Image = (Image)resources.GetObject("pbGitHub.Image");
			pbGitHub.Location = new Point(493, 48);
			pbGitHub.Name = "pbGitHub";
			pbGitHub.Size = new Size(170, 155);
			pbGitHub.SizeMode = PictureBoxSizeMode.Zoom;
			pbGitHub.TabIndex = 1;
			pbGitHub.TabStop = false;
			pbGitHub.Click += pbGitHub_Click;
			// 
			// About
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(pbGitHub);
			Controls.Add(pbAvocado);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "About";
			Text = "About";
			Load += About_Load;
			((System.ComponentModel.ISupportInitialize)pbAvocado).EndInit();
			((System.ComponentModel.ISupportInitialize)pbGitHub).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbAvocado;
		private PictureBox pbGitHub;
	}
}