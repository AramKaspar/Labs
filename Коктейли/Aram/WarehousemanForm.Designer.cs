namespace TomaCocktail
{
	partial class WarehousemanForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.dataGridViewTares = new System.Windows.Forms.DataGridView();
			this.buttonSave = new System.Windows.Forms.Button();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.dB_MainDataSetProduct = new TomaCocktail.DB_MainDataSetProduct();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productsTableAdapter = new TomaCocktail.DB_MainDataSetProductTableAdapters.ProductsTableAdapter();
			this.dB_MainDataSetTare = new TomaCocktail.DB_MainDataSetTare();
			this.tareBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tareTableAdapter = new TomaCocktail.DB_MainDataSetTareTableAdapters.TareTableAdapter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quamtityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTares)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetTare)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tareBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewTares
			// 
			this.dataGridViewTares.AutoGenerateColumns = false;
			this.dataGridViewTares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.quamtityDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
			this.dataGridViewTares.DataSource = this.tareBindingSource;
			this.dataGridViewTares.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTares.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewTares.Name = "dataGridViewTares";
			this.dataGridViewTares.Size = new System.Drawing.Size(804, 186);
			this.dataGridViewTares.TabIndex = 1;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(335, 12);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(181, 23);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Обновить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// dataGridViewProducts
			// 
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
			this.dataGridViewProducts.Size = new System.Drawing.Size(804, 223);
			this.dataGridViewProducts.TabIndex = 0;
			// 
			// dB_MainDataSetProduct
			// 
			this.dB_MainDataSetProduct.DataSetName = "DB_MainDataSetProduct";
			this.dB_MainDataSetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.dB_MainDataSetProduct;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// dB_MainDataSetTare
			// 
			this.dB_MainDataSetTare.DataSetName = "DB_MainDataSetTare";
			this.dB_MainDataSetTare.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tareBindingSource
			// 
			this.tareBindingSource.DataMember = "Tare";
			this.tareBindingSource.DataSource = this.dB_MainDataSetTare;
			// 
			// tareTableAdapter
			// 
			this.tareTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridViewProducts);
			this.groupBox1.Location = new System.Drawing.Point(12, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(810, 242);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Продукты";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridViewTares);
			this.groupBox2.Location = new System.Drawing.Point(12, 289);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(810, 205);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тара";
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
			this.typeDataGridViewTextBoxColumn1.Width = 200;
			// 
			// priceDataGridViewTextBoxColumn1
			// 
			this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
			this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
			this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
			// 
			// quamtityDataGridViewTextBoxColumn
			// 
			this.quamtityDataGridViewTextBoxColumn.DataPropertyName = "quamtity";
			this.quamtityDataGridViewTextBoxColumn.HeaderText = "quamtity";
			this.quamtityDataGridViewTextBoxColumn.Name = "quamtityDataGridViewTextBoxColumn";
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
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
			this.nameDataGridViewTextBoxColumn.Width = 250;
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
			this.typeDataGridViewTextBoxColumn.Width = 200;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// WarehousemanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 506);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "WarehousemanForm";
			this.Text = "Владелец склада";
			this.Load += new System.EventHandler(this.WarehousemanForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTares)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_MainDataSetTare)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tareBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewTares;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private DB_MainDataSetProduct dB_MainDataSetProduct;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private DB_MainDataSetProductTableAdapters.ProductsTableAdapter productsTableAdapter;
		private DB_MainDataSetTare dB_MainDataSetTare;
		private System.Windows.Forms.BindingSource tareBindingSource;
		private DB_MainDataSetTareTableAdapters.TareTableAdapter tareTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn quamtityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
	}
}