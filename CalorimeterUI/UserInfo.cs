using BLL;
using Entities;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorimeterUI
{
	public partial class UserInfo : Form
	{
		public UserInfo()
		{
			InitializeComponent();
		}

		#region User Info Form Load
		private void UserInfo_Load(object sender, EventArgs e)
		{

			UI_Methods.Methods.FillCMB(cmbActivity);
			GetUserDetails();
		}
		#endregion

		#region User Details Show Process
		/// <summary>
		/// Method get User Info
		/// </summary>
		private void GetUserDetails()
		{
			BusinessLayer bll = new BusinessLayer();
			UserDetails userDetails = bll.UserDetails.Search(SignIn.UserID);
			txtHeight.Text = userDetails.Height.ToString();
			txtWeight.Text = userDetails.Weight.ToString();
			if (userDetails.Phone != null)
			{
				txtPhoneNumber.Text = userDetails.Phone.ToString();
			}
			dtpBirthDate.Value = userDetails.BirthDate;
			foreach (DailyActivities item in cmbActivity.Items)
			{
				if (item.Ratio == userDetails.DailyActivity)
				{
					cmbActivity.SelectedItem = item;
				}
			}
			if (userDetails.IsAllergic == true) chkAllergy.Checked = true;
			if (userDetails.GlutenPreference == true) chkGluten.Checked = true;
			if (userDetails.IsLactoseIntolerant == true) chkLactose.Checked = true;
			if (userDetails.IsVegetarian == true) chkVegetarian.Checked = true;
			if (userDetails.Gender == true)
				drbMale.Checked = true;
			else drbFemale.Checked = true;
		}
		#endregion

		#region Update User Details
		/// <summary>
		/// Method gives Update User Info
		/// </summary>
		public void UpdateUserDetails()
		{
			bool gender = false;
			if (drbMale.Checked)
				gender = true;
			if (drbFemale.Checked)
				gender = false;

			BusinessLayer bll = new BusinessLayer();
			UserDetails userDetails = bll.UserDetails.Search(SignIn.UserID);

			userDetails.UserID = SignIn.UserID;
			userDetails.Phone = txtPhoneNumber.Text;
			userDetails.Gender = gender;
			userDetails.BirthDate = dtpBirthDate.Value;
			userDetails.Height = int.Parse(txtHeight.Text);
			userDetails.Weight = int.Parse(txtWeight.Text);
			userDetails.IsAllergic = chkAllergy.Checked;
			userDetails.DailyActivity = ((DailyActivities)cmbActivity.SelectedItem).Ratio;
			userDetails.GlutenPreference = chkGluten.Checked;
			userDetails.IsLactoseIntolerant = chkLactose.Checked;
			userDetails.IsVegetarian = chkVegetarian.Checked;

			bll.UserDetails.Update(userDetails);
		}

		#endregion

		#region Button save click event and Update User Details
		/// <summary>
		/// Button Save Event gives Update User Details 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
		{
			UpdateUserDetails();
			MessageBox.Show("User info has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
		
		#region Form Textchanged process
		private void txtWeight_TextChanged(object sender, EventArgs e)
		{
			UI_Methods.Methods.OnlyNumberTextBox(txtWeight);
		}

		private void txtHeight_TextChanged(object sender, EventArgs e)
		{
			UI_Methods.Methods.OnlyNumberTextBox(txtHeight);
		}

		private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
		{
			UI_Methods.Methods.OnlyNumberTextBox(txtPhoneNumber);
		}
		#endregion
	}
}
