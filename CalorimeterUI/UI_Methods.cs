using BLL;
using DrakeUI.Framework;
using Entities;
using MimeKit;
using MimeKit.Utils;
using ReaLTaiizor.Controls;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace CalorimeterUI
{
	public class UI_Methods
	{
		public static class Methods
		{
			#region Random Verfication Code Method
			public static int VerificationCode;
			public static int RandomVerificationCode()
			{
				Random rnd = new Random();
				VerificationCode = rnd.Next(100000, 999999);
				return VerificationCode;
			}
			#endregion

			#region Send Email process
			public static void SendEmail(string body, string name, string mail, string subject)
			{
				BodyBuilder builder = new BodyBuilder();
				var email = new MimeMessage();

				email.From.Add(new MailboxAddress("CaloriMeterApp", "appoverthinkers@gmail.com"));
				email.To.Add(new MailboxAddress(name, mail));

				email.Subject = subject;

				var image = builder.LinkedResources.Add("..\\..\\..\\Image\\cute-avacado.png");
				image.ContentId = MimeUtils.GenerateMessageId();
				builder.HtmlBody = string.Format(@$"{body}<center><img src=""cid:{0}""></center>", image.ContentId);
				email.Body = builder.ToMessageBody();
				using (var smtp = new SmtpClient())
				{
					smtp.Connect("smtp.gmail.com", 587, false);

					// Note: only needed if the SMTP server requires authentication
					smtp.Authenticate("appoverthinkers@gmail.com", "rkzdlfwuohkkjjzb");

					smtp.Send(email);
					smtp.Disconnect(true);


				}
			}
			#endregion

			#region Visibility process
			public static void Visibility(Control control)
			{
				if (control.Visible)
				{
					control.Visible = false;
				}
				else if (control.Visible == false)
				{
					control.Visible = true;
				}
			}
			#endregion

			#region Email Validation 
			public static void EmailValidation(DungeonTextBox tb, ErrorProvider er, PictureBox pb)
			{
				string email = tb.Text;
				Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
				Match match = regex.Match(email);
				if (match.Success)
				{
					er.Clear();
					pb.Visible = true;
				}
				else
				{
					pb.Visible = false;
					er.SetError(tb, "Please provide a valid Email");
				}
			}
			#endregion

			#region Remember me process
			private static string filePath = "usernamePassword.txt";
			public static void RememberMe(System.Windows.Forms.CheckBox chkRememberMe, string mail, string txtPassword)
			{
				if (chkRememberMe.Checked)
				{
					string[] userData = { mail, txtPassword };
					File.WriteAllLines(filePath, userData);
				}
				else
				{
					txtPassword = string.Empty;
					mail = string.Empty;
					string[] veriler = { mail, txtPassword };
					File.WriteAllLines(filePath, veriler);
				}
			}
			#endregion

			#region Form Fill User Info Remember Check
			public static void UserInfoRememberCheck(System.Windows.Forms.CheckBox chkRememberMe, DungeonTextBox txtMail, DungeonTextBox txtPassword)
			{
				if (File.Exists(filePath))
				{
					string[] veriler = File.ReadAllLines(filePath);

					if (veriler.Length >= 2)
					{
						if (veriler[0] != string.Empty)
						{
							chkRememberMe.Checked = true;
						}
						else
						{
							chkRememberMe.Checked = false;
						}
						txtMail.Text = veriler[0];
						txtPassword.Text = veriler[1];
					}
					else { txtMail.Text = string.Empty; txtPassword.Text = string.Empty; }
				}
			}
			#endregion

			#region Password Check Method
			/// <summary>
			/// Method gives Password Quality Check 
			/// </summary>
			/// <param name="pd"></param>
			/// <param name="confirmpd"></param>
			/// <returns></returns>
			public static bool PasswordCheckMethod(string pd, string confirmpd)
			{
				bool PasswordControl = false;
				string password = pd;
				string confirmPassword = confirmpd;

				if (password.Length > 16)
				{
					MessageBox.Show("The password cannot be more than 16 characters.");
					return PasswordControl;
				}
				else if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
				{
					MessageBox.Show("Password must contain at least one capital or small letter.");
					return PasswordControl;
				}
				else if (!password.Any(char.IsDigit))
				{
					MessageBox.Show("The password must contain at least one number.");
					return PasswordControl;
				}
				else if (password != confirmPassword)
				{
					MessageBox.Show("Passwords do not match.");
					return PasswordControl;
				}
				else
				{
					return PasswordControl = true;
				}
			}
			#endregion

			#region Password Strength
			public static void PasswordStrength(string pd, RibbonProgressBarLeft rb)
			{
				if (pd.Length < 8)
				{
					rb.Value = 15;
					rb.ProgressColorA = Color.Red;
					rb.ProgressColorB = Color.Red;
				}
				else if (pd.All(char.IsDigit) || pd.All(char.IsLetter))
				{
					rb.Value = 45;
					rb.ProgressColorA = Color.Red;
					rb.ProgressColorB = Color.Red;
				}
				else if (pd.Length == 9 && pd.Any(char.IsDigit) && pd.Any(char.IsLetter))
				{
					rb.Value = 65;
					rb.ProgressColorA = Color.Orange;
					rb.ProgressColorB = Color.Orange;
				}
				else if (pd.Length >= 10 && pd.Any(char.IsUpper) && pd.Any(char.IsLower) && pd.Any(char.IsDigit))
				{
					rb.Value = 100;
					rb.ProgressColorA = Color.Green;
					rb.ProgressColorB = Color.Green;
				}
			}
			#endregion

			#region Generate Password
			/// <summary>
			/// Method gives 8-16 character password
			/// </summary>
			/// <returns></returns>
			public static string GeneratePassword()

			{
				Random rnd = new Random();
				string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789*-_,!.";
				int length = rnd.Next(8, 17);
				char[] password = new char[length];
				bool hasUpper = false;
				bool hasLower = false;
				bool hasSpecial = false;

				for (int i = 0; i < length; i++)
				{

					password[i] = characters[rnd.Next(characters.Length)];

					if (char.IsUpper(password[i]))

						hasUpper = true;

					else if (char.IsLower(password[i]))

						hasLower = true;

					else if (IsSpecialCharacter(password[i]))

						hasSpecial = true;

				}

				if (!hasUpper || !hasLower || !hasSpecial)
				{
					return GeneratePassword();
				}

				return new string(password);
			}
			/// <summary>
			/// Method Check Special Character
			/// </summary>
			/// <param name="c"></param>
			/// <returns></returns>
			public static bool IsSpecialCharacter(char c)

			{

				char[] specialChars = { '*', '-', '_', '!', '.' };

				return specialChars.Contains(c);
			}
			#endregion

			#region Password Hash Process
			public static string GenerateHash(string password)
			{
				byte[] inputBytes = Encoding.UTF8.GetBytes(password);
				byte[] hashedBytes;

				using (SHA256 sha256 = SHA256.Create())
				{
					hashedBytes = sha256.ComputeHash(inputBytes);
				}

				StringBuilder sb = new StringBuilder();
				foreach (byte b in hashedBytes)
				{
					sb.Append(b.ToString("x2"));
				}

				return sb.ToString();
			}
			#endregion

			#region Textbox input check int process 
			/// <summary>
			/// Method gives textbox input only int.
			/// </summary>
			/// <param name="ctb"></param>

			public static void OnlyNumberTextBox(CrownTextBox ctb)
			{
				if (System.Text.RegularExpressions.Regex.IsMatch(ctb.Text, "[^0-9]"))
				{
					ctb.Text = ctb.Text.Remove(ctb.Text.Length - 1);
					ctb.SelectionStart = ctb.Text.Length;
				}
			}


			#endregion

			#region Calculate Carbonhydrate, Protein, Fat, Calorie Value.

			public static decimal TotalCarbonhydrateValue;
			public static decimal TotalProteinValue;
			public static decimal TotalFatValue;
			public static decimal TotalCalorieValue;

			public static decimal TargetedCarbonhydrateValue;
			public static decimal TargetedProteinValue;
			public static decimal TargetedFatValue;
			public static decimal TargetedCalories;
			/// <summary>
			/// Method gives Calculate Food Calorie.
			/// </summary>
			/// <param name="foods"></param>
			/// <param name="amount"></param>
			public static void CalculateNutritionalValues(Foods foods, decimal amount)
			{
				TotalProteinValue += foods.ProteinValue * amount * 7.71m / 100;
				TotalCarbonhydrateValue += foods.CarbonHydrateValue * amount * 7.71m / 100;
				TotalFatValue += foods.FatValue * amount * 7.71m / 100;
				TotalCalorieValue += foods.Calories * amount / 100;
			}

			/// <summary>
			/// Methods gives User Target Calorie By Day.
			/// </summary>
			public static void CalculateTargetedCalorie()
			{
				Users user = new Users();
				BusinessLayer bl = new BusinessLayer();
				UserDetails ud = new UserDetails();
				user = bl.Users.Search(SignIn.UserID);
				ud = bl.UserDetails.Search(SignIn.UserID);

				if (ud.Gender == true)
				{
					TargetedCalories = (((10 * (ud.Weight)) + (6.25m * (ud.Height)) - (5 * (DateTime.Now.Year - ud.BirthDate.Year)) + 5) * ud.DailyActivity);
				}
				else if (ud.Gender == false)
				{
					TargetedCalories = (((10 * (ud.Weight)) + (6.25m * (ud.Height)) - (5 * (DateTime.Now.Year - ud.BirthDate.Year)) - 161) * ud.DailyActivity);
				}
				TargetedFatValue = TargetedCalories * 0.27m;
				TargetedCarbonhydrateValue = TargetedCalories * 0.50m;
				TargetedProteinValue = TargetedCalories * 0.23m;
			}
			public static void FillCMB(DrakeUIComboBox cmb)
			{
				List<DailyActivities> activities = new List<DailyActivities>()
			{
				new DailyActivities() { ActivityName = "Not Active At All", Ratio = 1.2m},
				new DailyActivities() { ActivityName = "Less Active", Ratio = 1.38m },
				new DailyActivities() { ActivityName = "Kind of active", Ratio = 1.55m },
				new DailyActivities() { ActivityName = "Active", Ratio = 1.73m },
				new DailyActivities() { ActivityName = "Sporty", Ratio = 1.9m }
			};
				cmb.DataSource = activities;
				cmb.DisplayMember = "ActivityName";
				cmb.ValueMember = "Ratio";
			}
			#endregion

			#region Open Browser
			public static void OpenBrowser(string url)
			{
				Task.Delay(2000);

				Process.Start(new ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true
				});

			}
			#endregion

			#region TextBox Check Inputs.
			/// <summary>
			/// Method gives TextBox Inputs Check Only Number.
			/// </summary>
			/// <param name="txt"></param>
			public static void OnlyNumberTextBox(TextBox txt)
			{
				if (System.Text.RegularExpressions.Regex.IsMatch(txt.Text, "[^0-9]"))
				{
					txt.Text = txt.Text.Remove(txt.Text.Length - 1);
					txt.SelectionStart = txt.Text.Length;
				}
			}
			#endregion

			#region Home Page Fill Progress Bars
			/// <summary>
			/// Method gives Fill Progress Bars
			/// </summary>
			public static void FillCircularProgressBars()
			{
				BusinessLayer bll = new BusinessLayer();
				List<User_Food_Meal> UserMeals = new List<User_Food_Meal>();
				int userid = SignIn.UserID;
				UserMeals = bll.User_Food_Meal.SearchFoodHistory(userid, DateTime.Now).ToList();
				for (int i = 0; i < UserMeals.Count; i++)
				{
					Methods.CalculateNutritionalValues(UserMeals[i].Foods, UserMeals[i].Amount);
				}
			}
			#endregion

		}
	}
}
