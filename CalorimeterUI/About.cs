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
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void pbGitHub_Click(object sender, EventArgs e)
		{
			UI_Methods.Methods.OpenBrowser("https://github.com/omerfdev");
		}

		private void About_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
		}
	}
}
