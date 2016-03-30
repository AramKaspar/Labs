namespace TomaCocktail
{
	partial class MainForm
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
		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonWarehouseman = new System.Windows.Forms.Button();
            this.buttonBarman = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWarehouseman
            // 
            this.buttonWarehouseman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWarehouseman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWarehouseman.Location = new System.Drawing.Point(3, 3);
            this.buttonWarehouseman.Name = "buttonWarehouseman";
            this.buttonWarehouseman.Size = new System.Drawing.Size(127, 60);
            this.buttonWarehouseman.TabIndex = 0;
            this.buttonWarehouseman.Text = "Менеджер";
            this.buttonWarehouseman.UseVisualStyleBackColor = true;
            this.buttonWarehouseman.Click += new System.EventHandler(this.buttonWarehouseman_Click);
            // 
            // buttonBarman
            // 
            this.buttonBarman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBarman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBarman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBarman.Location = new System.Drawing.Point(136, 3);
            this.buttonBarman.Name = "buttonBarman";
            this.buttonBarman.Size = new System.Drawing.Size(127, 60);
            this.buttonBarman.TabIndex = 1;
            this.buttonBarman.Text = "Бармен";
            this.buttonBarman.UseVisualStyleBackColor = true;
            this.buttonBarman.Click += new System.EventHandler(this.buttonBarman_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonWarehouseman, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBarman, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 66);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вход";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно входа";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonWarehouseman;
		private System.Windows.Forms.Button buttonBarman;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
	}
}

