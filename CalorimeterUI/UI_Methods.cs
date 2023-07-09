using MimeKit;
using ReaLTaiizor.Controls;
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
			public static void SendEmail(string body, string name, string mail)
			{
				var email = new MimeMessage();

				email.From.Add(new MailboxAddress("CaloriMeterApp", "overthinkersapp@gmail.com"));
				email.To.Add(new MailboxAddress(name, mail));

				email.Subject = "Email Verification";
				email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
				{
					Text = body
				};
				using (var smtp = new SmtpClient())
				{
					smtp.Connect("smtp.gmail.com", 587, false);
					smtp.Authenticate("overthinkersapp@gmail.com", "kobmseidvyjqmnqg");
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
					rb.Value = 40;
					rb.ProgressColorA = Color.Red;
					rb.ProgressColorB = Color.Red;
				}
				else if (pd.Length == 9 && pd.Any(char.IsDigit) && pd.Any(char.IsLetter))
				{
					rb.Value = 70;
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
		}
	}
}
