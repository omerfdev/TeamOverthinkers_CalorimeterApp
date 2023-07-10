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
	public partial class HomeScreen : Form
	{
		public HomeScreen()
		{
			InitializeComponent();
		}

		private void HomeScreen_Load(object sender, EventArgs e)
		{
			flwSideBar.Width = flwSideBar.MinimumSize.Width;
		}
		bool sideBarExpand;
		private void pcBoxMenu_Click(object sender, EventArgs e)
		{
			timerSideBar.Start();
		}

		private void timerSideBar_Tick(object sender, EventArgs e)
		{
			if (sideBarExpand)
			{
				flwSideBar.Width -= 10;
				if (flwSideBar.Width == flwSideBar.MinimumSize.Width)
				{
					sideBarExpand = false;
					timerSideBar.Stop();
				}

			}
			else
			{
				flwSideBar.Width += 10;
				if (flwSideBar.Width == flwSideBar.MaximumSize.Width)
				{
					sideBarExpand = true;
					timerSideBar.Stop();
				}

			}
		}
	}
}
