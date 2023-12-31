﻿using AdminCategory;
using CalorimeterUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminConsole
{
	public partial class Admin : Form
	{
		public Admin()
		{
			InitializeComponent();
		}

		private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Category category = new Category();
			category.ShowDialog();
		}

		private void foodToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Food food = new Food();
			food.ShowDialog();
		}

		private void Admin_Load(object sender, EventArgs e)
		{
			if (SignIn.DarkMode == true) { this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplandark.png"); }
			else
			{
				this.BackgroundImage = Image.FromFile("..\\..\\..\\Image\\arkaplan.png");
			}
		}
	}
}
