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
	public partial class WarehousemanForm : Form
	{
		public WarehousemanForm()
		{
			InitializeComponent();
		}

		private void WarehousemanForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MainDataSetTare.Tare". При необходимости она может быть перемещена или удалена.
			this.tareTableAdapter.Fill(this.dB_MainDataSetTare.Tare);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MainDataSetProduct.Products". При необходимости она может быть перемещена или удалена.
			this.productsTableAdapter.Fill(this.dB_MainDataSetProduct.Products);

		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();

				this.productsBindingSource.EndEdit();
				this.productsTableAdapter.Update(this.dB_MainDataSetProduct);

				this.tareBindingSource.EndEdit();
				this.tareTableAdapter.Update(this.dB_MainDataSetTare);

				// TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MainDataSetTare.Tare". При необходимости она может быть перемещена или удалена.
				this.tareTableAdapter.Fill(this.dB_MainDataSetTare.Tare);
				// TODO: данная строка кода позволяет загрузить данные в таблицу "dB_MainDataSetProduct.Products". При необходимости она может быть перемещена или удалена.
				this.productsTableAdapter.Fill(this.dB_MainDataSetProduct.Products);

				MessageBox.Show("Обновление успешно!");
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Ошибка обновления!");
			}
		}
	}
}
