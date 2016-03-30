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
	public partial class EditRecipeForm : Form
	{
		string result = string.Empty;
		string recipeText = string.Empty;

		public EditRecipeForm(string recipeText)
		{
			InitializeComponent();
			this.recipeText = recipeText;
		}
		private void EditRecipeForm_Load(object sender, EventArgs e)
		{			
			this.tareTableAdapter.Fill(this.dB_MainDataSetTare.Tare);
			this.productsTableAdapter.Fill(this.dB_MainDataSetProduct.Products);
			if (recipeText != String.Empty)
			{
				string[] mas = recipeText.Split(new char[] { '&' });
				textBoxDescription.Text = mas[2];
				foreach (string product in mas[0].Split(new char[] { ';' }))
				{
					string[] info = product.Split(new char[] { ':' });
					int counter = 0;
					foreach (DataGridViewRow row in dataGridViewProducts.Rows)
					{
						if ((int)row.Cells[idDataGridViewTextBoxColumn.Name].Value == int.Parse(info[0]))
						{
							dataGridViewProducts.Rows[counter].Cells[quantityDataGridViewTextBoxColumn.Name].Value =
								decimal.Parse(info[1]);
						}
						counter++;
					}
				}
				foreach (string tare in mas[1].Split(new char[] { ';' }))
				{
					string[] info = tare.Split(new char[] { ':' });
					int counter = 0;
					foreach (DataGridViewRow row in dataGridViewTare.Rows)
					{
						if ((int)row.Cells[idDataGridViewTextBoxColumn1.Name].Value == int.Parse(info[0]))
						{
							dataGridViewTare.Rows[counter].Cells[quamtityDataGridViewTextBoxColumn.Name].Value =
								decimal.Parse(info[1]);
						}
						counter++;
					}
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		public string GetResult()
		{
			return result;
		}

		private void ShowMessage(string text)
		{
			string caption = "Предупреждение!";
			MessageBox.Show(text, caption);
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			bool normal = false;
			bool accept = true;
			foreach (DataGridViewRow row in dataGridViewProducts.Rows)
			{
				if (row.Cells[quantityDataGridViewTextBoxColumn.Name].Value != null)
				{
					result += row.Cells[idDataGridViewTextBoxColumn.Name].Value.ToString()
						+ ":" + row.Cells[quantityDataGridViewTextBoxColumn.Name].Value.ToString() + ";";
					normal = true;
				}
			}
			if (normal == false)
			{
				ShowMessage("Без выбора");
				accept = false;
			}
			else
			{
				normal = false;
				result = result.Substring(0, result.Length - 1);
				result += "&";
				foreach (DataGridViewRow row in dataGridViewTare.Rows)
				{
					if (row.Cells[quamtityDataGridViewTextBoxColumn.Name].Value != null)
					{
						result += row.Cells[idDataGridViewTextBoxColumn1.Name].Value.ToString()
						+ ":" + row.Cells[quamtityDataGridViewTextBoxColumn.Name].Value.ToString() + ";";
						normal = true;
					}
				}
				if (normal == false)
				{
					ShowMessage("Без выбора!");
					accept = false;
				}
				else
				{
					result = result.Substring(0, result.Length - 1);
					result += "&" + textBoxDescription.Text;
					if (textBoxDescription.Text.Length == 0)
					{
						ShowMessage("Отсутствует!");
						accept = false;
					}
					if (accept == true)
					{
						DialogResult = System.Windows.Forms.DialogResult.OK;
					}
				}
			}
		}
	}
}
