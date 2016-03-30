namespace TomaCocktail
{
	partial class BarmanForm
	{		
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewCocktails = new System.Windows.Forms.DataGridView();
			this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dB_MainDataSetRecipes = new TomaCocktail.DB_MainDataSetRecipes();
			this.recipesTableAdapter = new TomaCocktail.DB_MainDataSetRecipesTableAdapters.RecipesTableAdapter();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editRecipe = new System.Windows.Forms.DataGridViewButtonColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonSync = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCocktails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetRecipes)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(13, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(745, 419);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(737, 393);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Обработка заказов";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.buttonSync);
			this.tabPage2.Controls.Add(this.dataGridViewCocktails);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(737, 393);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Редактор коктейлей";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridViewCocktails
			// 
			this.dataGridViewCocktails.AutoGenerateColumns = false;
			this.dataGridViewCocktails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCocktails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.editRecipe,
            this.priceDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.recipeDataGridViewTextBoxColumn});
			this.dataGridViewCocktails.DataSource = this.recipesBindingSource;
			this.dataGridViewCocktails.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewCocktails.MultiSelect = false;
			this.dataGridViewCocktails.Name = "dataGridViewCocktails";
			this.dataGridViewCocktails.Size = new System.Drawing.Size(457, 381);
			this.dataGridViewCocktails.TabIndex = 0;
			this.dataGridViewCocktails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCocktails_CellClick);
			// 
			// recipesBindingSource
			// 
			this.recipesBindingSource.DataMember = "Recipes";
			this.recipesBindingSource.DataSource = this.dB_MainDataSetRecipes;
			// 
			// dB_MainDataSetRecipes
			// 
			this.dB_MainDataSetRecipes.DataSetName = "DB_MainDataSetRecipes";
			this.dB_MainDataSetRecipes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// recipesTableAdapter
			// 
			this.recipesTableAdapter.ClearBeforeFill = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// editRecipe
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.NullValue = "Изменить";
			this.editRecipe.DefaultCellStyle = dataGridViewCellStyle2;
			this.editRecipe.HeaderText = "recipe";
			this.editRecipe.Name = "editRecipe";
			this.editRecipe.ReadOnly = true;
			this.editRecipe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.editRecipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.editRecipe.Text = "Изменить";
			this.editRecipe.ToolTipText = "Изменить рецепт";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// recipeDataGridViewTextBoxColumn
			// 
			this.recipeDataGridViewTextBoxColumn.DataPropertyName = "recipe";
			this.recipeDataGridViewTextBoxColumn.HeaderText = "recipeText";
			this.recipeDataGridViewTextBoxColumn.Name = "recipeDataGridViewTextBoxColumn";
			this.recipeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.recipeDataGridViewTextBoxColumn.Visible = false;
			// 
			// buttonSync
			// 
			this.buttonSync.Location = new System.Drawing.Point(469, 6);
			this.buttonSync.Name = "buttonSync";
			this.buttonSync.Size = new System.Drawing.Size(262, 43);
			this.buttonSync.TabIndex = 1;
			this.buttonSync.Text = "Синхронизировать";
			this.buttonSync.UseVisualStyleBackColor = true;
			this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
			// 
			// BarmanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 444);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BarmanForm";
			this.Text = "Бармен";
			this.Load += new System.EventHandler(this.BarmanForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCocktails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetRecipes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridViewCocktails;
		private DB_MainDataSetRecipes dB_MainDataSetRecipes;
		private System.Windows.Forms.BindingSource recipesBindingSource;
		private DB_MainDataSetRecipesTableAdapters.RecipesTableAdapter recipesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn editRecipe;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button buttonSync;
	}
}