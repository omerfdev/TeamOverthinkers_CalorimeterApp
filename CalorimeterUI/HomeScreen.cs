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
		#region Move Home Screen Form
		private bool mouseDown;
		private Point lastLocation;
		private void HomeScreen_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}
		private void HomeScreen_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}
		private void HomeScreen_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}
		#endregion

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

		private void btnSettings_Click(object sender, EventArgs e)
		{

		}

		private void HomeScreen_Load(object sender, EventArgs e)
		{
			flwSideBar.Width = flwSideBar.MinimumSize.Width;
		}
	}
}
