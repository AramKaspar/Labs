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
	public partial class BarmanForm : Form
	{
		public BarmanForm()
		{
			InitializeComponent();
		}

		private void BarmanForm_Load(object sender, EventArgs e)
		{		
			this.recipesTableAdapter.Fill(this.dB_MainDataSetRecipes.Recipes);
		}
		private void dataGridViewCocktails_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == editRecipe.Index)
			{
				EditRecipeForm editRecipeForm = new EditRecipeForm(
						dataGridViewCocktails[recipeDataGridViewTextBoxColumn.Name, e.RowIndex].Value.ToString() );
				editRecipeForm.ShowDialog();
				if (editRecipeForm.DialogResult == System.Windows.Forms.DialogResult.OK)
				{
					dataGridViewCocktails[recipeDataGridViewTextBoxColumn.Name, e.RowIndex].Value =
						editRecipeForm.GetResult();
				}
			}
		}

		private void buttonSync_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();

				this.recipesBindingSource.EndEdit();
				this.recipesTableAdapter.Update(this.dB_MainDataSetRecipes);		
				this.recipesTableAdapter.Fill(this.dB_MainDataSetRecipes.Recipes);

				MessageBox.Show("Обновление");
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Ошибка!");
			}
		}
	}
}
