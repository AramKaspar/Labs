using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaCocktail
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		private void buttonWarehouseman_Click(object sender, EventArgs e)
		{
			WarehousemanForm warehousemanform = new WarehousemanForm();
			warehousemanform.ShowDialog();
		}
		private void buttonBarman_Click(object sender, EventArgs e)
		{
			BarmanForm barmanForm = new BarmanForm();
			barmanForm.ShowDialog();
		}
	}
}
