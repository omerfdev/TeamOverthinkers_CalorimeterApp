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
		/// <summary>
		/// Update User Info
		/// </summary>
		private void UpdateUserDetails()
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
		/// <summary>
		/// Method gives textbox input only int.
		/// </summary>
		/// <param name="ctb"></param>
		private void OnlyNumberTextBox(CrownTextBox ctb)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(ctb.Text, "[^0-9]"))
			{
				ctb.Text = ctb.Text.Remove(ctb.Text.Length - 1);
				ctb.SelectionStart = ctb.Text.Length;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			UpdateUserDetails();
			MessageBox.Show("User info has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#region Form Textchanged process
		private void txtWeight_TextChanged(object sender, EventArgs e)
		{
			OnlyNumberTextBox(txtWeight);
		}

		private void txtHeight_TextChanged(object sender, EventArgs e)
		{
			OnlyNumberTextBox(txtHeight);
		}

		private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
		{
			OnlyNumberTextBox(txtPhoneNumber);
		}
		#endregion
	}
}
