namespace CalorimeterUI
{
	partial class UserInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
			btnSave = new ReaLTaiizor.Controls.CyberButton();
			grpPersonal = new ReaLTaiizor.Controls.CyberGroupBox();
			cmbActivity = new DrakeUI.Framework.DrakeUIComboBox();
			label4 = new Label();
			txtWeight = new ReaLTaiizor.Controls.CrownTextBox();
			txtHeight = new ReaLTaiizor.Controls.CrownTextBox();
			label3 = new Label();
			txtPhoneNumber = new ReaLTaiizor.Controls.CrownTextBox();
			label2 = new Label();
			dtpBirthDate = new DrakeUI.Framework.DrakeUIDatePicker();
			lblWeight = new Label();
			lblHeight = new Label();
			label1 = new Label();
			chkGluten = new DrakeUI.Framework.DrakeUICheckBox();
			chkLactose = new DrakeUI.Framework.DrakeUICheckBox();
			chkVegetarian = new DrakeUI.Framework.DrakeUICheckBox();
			chkAllergy = new DrakeUI.Framework.DrakeUICheckBox();
			drbFemale = new DrakeUI.Framework.DrakeUIRadioButton();
			drbMale = new DrakeUI.Framework.DrakeUIRadioButton();
			grpPersonal.SuspendLayout();
			SuspendLayout();
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
			btnSave.Location = new Point(654, 347);
			btnSave.Margin = new Padding(3, 4, 3, 4);
			btnSave.Name = "btnSave";
			btnSave.PenWidth = 15;
			btnSave.Rounding = true;
			btnSave.RoundingInt = 70;
			btnSave.Size = new Size(117, 67);
			btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			btnSave.TabIndex = 24;
			btnSave.Tag = "Cyber";
			btnSave.TextButton = "Save";
			btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			btnSave.Timer_Effect_1 = 5;
			btnSave.Timer_RGB = 300;
			btnSave.Click += btnSave_Click;
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
			grpPersonal.Controls.Add(cmbActivity);
			grpPersonal.Controls.Add(label4);
			grpPersonal.Controls.Add(txtWeight);
			grpPersonal.Controls.Add(txtHeight);
			grpPersonal.Controls.Add(label3);
			grpPersonal.Controls.Add(txtPhoneNumber);
			grpPersonal.Controls.Add(label2);
			grpPersonal.Controls.Add(dtpBirthDate);
			grpPersonal.Controls.Add(lblWeight);
			grpPersonal.Controls.Add(lblHeight);
			grpPersonal.Controls.Add(label1);
			grpPersonal.Controls.Add(chkGluten);
			grpPersonal.Controls.Add(chkLactose);
			grpPersonal.Controls.Add(chkVegetarian);
			grpPersonal.Controls.Add(chkAllergy);
			grpPersonal.Controls.Add(drbFemale);
			grpPersonal.Controls.Add(drbMale);
			grpPersonal.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
			grpPersonal.ForeColor = Color.FromArgb(245, 245, 245);
			grpPersonal.Lighting = false;
			grpPersonal.LinearGradient_Background = false;
			grpPersonal.LinearGradientPen = false;
			grpPersonal.Location = new Point(120, 37);
			grpPersonal.Name = "grpPersonal";
			grpPersonal.PenWidth = 15;
			grpPersonal.RGB = false;
			grpPersonal.Rounding = true;
			grpPersonal.RoundingInt = 60;
			grpPersonal.Size = new Size(483, 377);
			grpPersonal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			grpPersonal.TabIndex = 23;
			grpPersonal.Tag = "Cyber";
			grpPersonal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			grpPersonal.Timer_RGB = 300;
			// 
			// cmbActivity
			// 
			cmbActivity.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
			cmbActivity.FillColor = Color.FromArgb(223, 231, 195);
			cmbActivity.FillDisableColor = Color.FromArgb(223, 231, 195);
			cmbActivity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cmbActivity.Location = new Point(280, 177);
			cmbActivity.Margin = new Padding(4, 5, 4, 5);
			cmbActivity.MinimumSize = new Size(63, 0);
			cmbActivity.Name = "cmbActivity";
			cmbActivity.Padding = new Padding(0, 0, 30, 0);
			cmbActivity.RectColor = Color.FromArgb(161, 97, 110);
			cmbActivity.RectDisableColor = Color.FromArgb(223, 231, 195);
			cmbActivity.Size = new Size(119, 30);
			cmbActivity.Style = DrakeUI.Framework.UIStyle.Custom;
			cmbActivity.TabIndex = 20;
			cmbActivity.TextAlignment = ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.FromArgb(64, 64, 64);
			label4.Location = new Point(84, 177);
			label4.Name = "label4";
			label4.Size = new Size(174, 25);
			label4.TabIndex = 19;
			label4.Text = "Daily Activity Level";
			// 
			// txtWeight
			// 
			txtWeight.BackColor = Color.FromArgb(223, 231, 195);
			txtWeight.BorderStyle = BorderStyle.FixedSingle;
			txtWeight.ForeColor = Color.FromArgb(161, 97, 110);
			txtWeight.Location = new Point(280, 68);
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new Size(119, 27);
			txtWeight.TabIndex = 17;
			txtWeight.TextAlign = HorizontalAlignment.Center;
			txtWeight.TextChanged += txtWeight_TextChanged;
			// 
			// txtHeight
			// 
			txtHeight.BackColor = Color.FromArgb(223, 231, 195);
			txtHeight.BorderStyle = BorderStyle.FixedSingle;
			txtHeight.ForeColor = Color.FromArgb(161, 97, 110);
			txtHeight.Location = new Point(280, 18);
			txtHeight.Name = "txtHeight";
			txtHeight.Size = new Size(119, 27);
			txtHeight.TabIndex = 16;
			txtHeight.TextAlign = HorizontalAlignment.Center;
			txtHeight.TextChanged += txtHeight_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(64, 64, 64);
			label3.Location = new Point(84, 144);
			label3.Name = "label3";
			label3.Size = new Size(143, 25);
			label3.TabIndex = 15;
			label3.Text = "Phone Number";
			// 
			// txtPhoneNumber
			// 
			txtPhoneNumber.BackColor = Color.FromArgb(223, 231, 195);
			txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
			txtPhoneNumber.ForeColor = Color.FromArgb(161, 97, 110);
			txtPhoneNumber.Location = new Point(280, 142);
			txtPhoneNumber.Name = "txtPhoneNumber";
			txtPhoneNumber.Size = new Size(119, 27);
			txtPhoneNumber.TabIndex = 14;
			txtPhoneNumber.TextAlign = HorizontalAlignment.Center;
			txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(64, 64, 64);
			label2.Location = new Point(84, 222);
			label2.Name = "label2";
			label2.Size = new Size(97, 25);
			label2.TabIndex = 13;
			label2.Text = "Birth Date";
			// 
			// dtpBirthDate
			// 
			dtpBirthDate.DateFormat = "dd-MM-yyyy";
			dtpBirthDate.FillColor = Color.FromArgb(223, 231, 195);
			dtpBirthDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dtpBirthDate.Location = new Point(280, 222);
			dtpBirthDate.Margin = new Padding(4, 5, 4, 5);
			dtpBirthDate.MaxLength = 10;
			dtpBirthDate.MinimumSize = new Size(63, 0);
			dtpBirthDate.Name = "dtpBirthDate";
			dtpBirthDate.Padding = new Padding(0, 0, 30, 0);
			dtpBirthDate.RectColor = Color.FromArgb(161, 97, 110);
			dtpBirthDate.RectDisableColor = Color.FromArgb(227, 242, 253);
			dtpBirthDate.Size = new Size(119, 30);
			dtpBirthDate.Style = DrakeUI.Framework.UIStyle.Custom;
			dtpBirthDate.SymbolDropDown = 61555;
			dtpBirthDate.SymbolNormal = 61555;
			dtpBirthDate.TabIndex = 12;
			dtpBirthDate.Text = "09-07-2023";
			dtpBirthDate.TextAlignment = ContentAlignment.MiddleLeft;
			dtpBirthDate.Value = new DateTime(2023, 7, 9, 0, 0, 0, 0);
			// 
			// lblWeight
			// 
			lblWeight.AutoSize = true;
			lblWeight.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblWeight.ForeColor = Color.FromArgb(64, 64, 64);
			lblWeight.Location = new Point(84, 66);
			lblWeight.Name = "lblWeight";
			lblWeight.Size = new Size(74, 25);
			lblWeight.TabIndex = 11;
			lblWeight.Text = "Weight";
			// 
			// lblHeight
			// 
			lblHeight.AutoSize = true;
			lblHeight.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblHeight.ForeColor = Color.FromArgb(64, 64, 64);
			lblHeight.Location = new Point(84, 18);
			lblHeight.Name = "lblHeight";
			lblHeight.Size = new Size(68, 25);
			lblHeight.TabIndex = 10;
			lblHeight.Text = "Height";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(84, 268);
			label1.Name = "label1";
			label1.Size = new Size(70, 25);
			label1.TabIndex = 9;
			label1.Text = "Filters:";
			// 
			// chkGluten
			// 
			chkGluten.CheckBoxColor = Color.FromArgb(161, 97, 110);
			chkGluten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			chkGluten.Location = new Point(84, 326);
			chkGluten.Name = "chkGluten";
			chkGluten.Padding = new Padding(22, 0, 0, 0);
			chkGluten.Size = new Size(87, 29);
			chkGluten.Style = DrakeUI.Framework.UIStyle.Custom;
			chkGluten.TabIndex = 8;
			chkGluten.Text = "Gluten";
			// 
			// chkLactose
			// 
			chkLactose.CheckBoxColor = Color.FromArgb(161, 97, 110);
			chkLactose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			chkLactose.Location = new Point(301, 326);
			chkLactose.Name = "chkLactose";
			chkLactose.Padding = new Padding(22, 0, 0, 0);
			chkLactose.Size = new Size(109, 29);
			chkLactose.Style = DrakeUI.Framework.UIStyle.Custom;
			chkLactose.TabIndex = 7;
			chkLactose.Text = "Lactose";
			// 
			// chkVegetarian
			// 
			chkVegetarian.CheckBoxColor = Color.FromArgb(161, 97, 110);
			chkVegetarian.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			chkVegetarian.Location = new Point(84, 291);
			chkVegetarian.Name = "chkVegetarian";
			chkVegetarian.Padding = new Padding(22, 0, 0, 0);
			chkVegetarian.Size = new Size(153, 29);
			chkVegetarian.Style = DrakeUI.Framework.UIStyle.Custom;
			chkVegetarian.TabIndex = 6;
			chkVegetarian.Text = "Vegetarian";
			// 
			// chkAllergy
			// 
			chkAllergy.CheckBoxColor = Color.FromArgb(161, 97, 110);
			chkAllergy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			chkAllergy.Location = new Point(301, 291);
			chkAllergy.Name = "chkAllergy";
			chkAllergy.Padding = new Padding(22, 0, 0, 0);
			chkAllergy.Size = new Size(87, 29);
			chkAllergy.Style = DrakeUI.Framework.UIStyle.Custom;
			chkAllergy.TabIndex = 5;
			chkAllergy.Text = "Allergy";
			// 
			// drbFemale
			// 
			drbFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			drbFemale.Location = new Point(257, 107);
			drbFemale.Name = "drbFemale";
			drbFemale.Padding = new Padding(22, 0, 0, 0);
			drbFemale.RadioButtonColor = Color.FromArgb(161, 97, 110);
			drbFemale.Size = new Size(93, 29);
			drbFemale.Style = DrakeUI.Framework.UIStyle.Custom;
			drbFemale.TabIndex = 4;
			drbFemale.Text = "Female";
			// 
			// drbMale
			// 
			drbMale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
			drbMale.Location = new Point(94, 107);
			drbMale.Name = "drbMale";
			drbMale.Padding = new Padding(22, 0, 0, 0);
			drbMale.RadioButtonColor = Color.FromArgb(161, 97, 110);
			drbMale.Size = new Size(87, 29);
			drbMale.Style = DrakeUI.Framework.UIStyle.Custom;
			drbMale.TabIndex = 3;
			drbMale.Text = "Male";
			// 
			// UserInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(btnSave);
			Controls.Add(grpPersonal);
			FormBorderStyle = FormBorderStyle.None;
			Name = "UserInfo";
			Text = "UserInfo";
			Load += UserInfo_Load;
			grpPersonal.ResumeLayout(false);
			grpPersonal.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ReaLTaiizor.Controls.CyberButton btnSave;
		private ReaLTaiizor.Controls.CyberGroupBox grpPersonal;
		private DrakeUI.Framework.DrakeUIComboBox cmbActivity;
		private Label label4;
		private ReaLTaiizor.Controls.CrownTextBox txtWeight;
		private ReaLTaiizor.Controls.CrownTextBox txtHeight;
		private Label label3;
		private ReaLTaiizor.Controls.CrownTextBox txtPhoneNumber;
		private Label label2;
		private DrakeUI.Framework.DrakeUIDatePicker dtpBirthDate;
		private Label lblWeight;
		private Label lblHeight;
		private Label label1;
		private DrakeUI.Framework.DrakeUICheckBox chkGluten;
		private DrakeUI.Framework.DrakeUICheckBox chkLactose;
		private DrakeUI.Framework.DrakeUICheckBox chkVegetarian;
		private DrakeUI.Framework.DrakeUICheckBox chkAllergy;
		private DrakeUI.Framework.DrakeUIRadioButton drbFemale;
		private DrakeUI.Framework.DrakeUIRadioButton drbMale;
	}
}