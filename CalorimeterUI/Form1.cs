using BLL;
using DAL;

namespace CalorimeterUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Context db = new Context();
		BusinessLayer bll = new BusinessLayer();
	}
}