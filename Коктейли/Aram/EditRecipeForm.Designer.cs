namespace TomaCocktail
{
	partial class EditRecipeForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBMainDataSetProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dB_MainDataSetProduct = new TomaCocktail.DB_MainDataSetProduct();
			this.dataGridViewTare = new System.Windows.Forms.DataGridView();
			this.tareBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dB_MainDataSetTare = new TomaCocktail.DB_MainDataSetTare();
			this.productsTableAdapter = new TomaCocktail.DB_MainDataSetProductTableAdapters.ProductsTableAdapter();
			this.tareTableAdapter = new TomaCocktail.DB_MainDataSetTareTableAdapters.TareTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quamtityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBMainDataSetProductBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tareBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetTare)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.AllowUserToAddRows = false;
			this.dataGridViewProducts.AllowUserToDeleteRows = false;
			this.dataGridViewProducts.AutoGenerateColumns = false;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
			this.dataGridViewProducts.DataSource = this.productsBindingSource;
			this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewProducts.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.Size = new System.Drawing.Size(472, 221);
			this.dataGridViewProducts.TabIndex = 0;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.dBMainDataSetProductBindingSource;
			// 
			// dBMainDataSetProductBindingSource
			// 
			this.dBMainDataSetProductBindingSource.DataSource = this.dB_MainDataSetProduct;
			this.dBMainDataSetProductBindingSource.Position = 0;
			// 
			// dB_MainDataSetProduct
			// 
			this.dB_MainDataSetProduct.DataSetName = "DB_MainDataSetProduct";
			this.dB_MainDataSetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridViewTare
			// 
			this.dataGridViewTare.AllowUserToAddRows = false;
			this.dataGridViewTare.AllowUserToDeleteRows = false;
			this.dataGridViewTare.AutoGenerateColumns = false;
			this.dataGridViewTare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.quamtityDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
			this.dataGridViewTare.DataSource = this.tareBindingSource;
			this.dataGridViewTare.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTare.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewTare.Name = "dataGridViewTare";
			this.dataGridViewTare.Size = new System.Drawing.Size(472, 151);
			this.dataGridViewTare.TabIndex = 1;
			// 
			// tareBindingSource
			// 
			this.tareBindingSource.DataMember = "Tare";
			this.tareBindingSource.DataSource = this.dB_MainDataSetTare;
			// 
			// dB_MainDataSetTare
			// 
			this.dB_MainDataSetTare.DataSetName = "DB_MainDataSetTare";
			this.dB_MainDataSetTare.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// tareTableAdapter
			// 
			this.tareTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Location = new System.Drawing.Point(3, 16);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(304, 311);
			this.textBoxDescription.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxDescription);
			this.groupBox1.Location = new System.Drawing.Point(504, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 330);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Описание";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewProducts);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(478, 240);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Продукты";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridViewTare);
			this.groupBox3.Location = new System.Drawing.Point(12, 258);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(478, 170);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Тара";
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(669, 361);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(142, 64);
			this.buttonOk.TabIndex = 6;
			this.buttonOk.Text = "Принять";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(507, 361);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(142, 64);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			this.idDataGridViewTextBoxColumn1.Visible = false;
			// 
			// typeDataGridViewTextBoxColumn1
			// 
			this.typeDataGridViewTextBoxColumn1.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn1.HeaderText = "type";
			this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
			// 
			// priceDataGridViewTextBoxColumn1
			// 
			this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
			this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
			this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
			// 
			// quamtityDataGridViewTextBoxColumn
			// 
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = "0";
			this.quamtityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.quamtityDataGridViewTextBoxColumn.HeaderText = "quantity";
			this.quamtityDataGridViewTextBoxColumn.Name = "quamtityDataGridViewTextBoxColumn";
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			this.timeDataGridViewTextBoxColumn.Visible = false;
			// 
			// EditRecipeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(826, 440);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EditRecipeForm";
			this.Text = "Редактор Рецепта";
			this.Load += new System.EventHandler(this.EditRecipeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBMainDataSetProductBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tareBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetTare)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.DataGridView dataGridViewTare;
		private System.Windows.Forms.BindingSource dBMainDataSetProductBindingSource;
		private DB_MainDataSetProduct dB_MainDataSetProduct;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private DB_MainDataSetProductTableAdapters.ProductsTableAdapter productsTableAdapter;
		private DB_MainDataSetTare dB_MainDataSetTare;
		private System.Windows.Forms.BindingSource tareBindingSource;
		private DB_MainDataSetTareTableAdapters.TareTableAdapter tareTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn quamtityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
	}
}