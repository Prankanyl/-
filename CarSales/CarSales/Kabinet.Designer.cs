namespace CarSales
{
    partial class Kabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kabinet));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDDataSet3 = new CarSales.BDDataSet3();
            this.avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoTableAdapter = new CarSales.BDDataSet3TableAdapters.avtoTableAdapter();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(20, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Информация о пользователях";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(20, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Информация об автомобилях";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(20, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Информация об покупках";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(36, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 88);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро пожаловать";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.releaseDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.privodDataGridViewTextBoxColumn,
            this.bodyTypeDataGridViewTextBoxColumn,
            this.transmissionDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(292, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1073, 494);
            this.dataGridView1.TabIndex = 5;
            // 
            // bDDataSet3
            // 
            this.bDDataSet3.DataSetName = "BDDataSet3";
            this.bDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtoBindingSource
            // 
            this.avtoBindingSource.DataMember = "avto";
            this.avtoBindingSource.DataSource = this.bDDataSet3;
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // releaseDataGridViewTextBoxColumn
            // 
            this.releaseDataGridViewTextBoxColumn.DataPropertyName = "Release";
            this.releaseDataGridViewTextBoxColumn.HeaderText = "Release";
            this.releaseDataGridViewTextBoxColumn.Name = "releaseDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // privodDataGridViewTextBoxColumn
            // 
            this.privodDataGridViewTextBoxColumn.DataPropertyName = "privod";
            this.privodDataGridViewTextBoxColumn.HeaderText = "privod";
            this.privodDataGridViewTextBoxColumn.Name = "privodDataGridViewTextBoxColumn";
            // 
            // bodyTypeDataGridViewTextBoxColumn
            // 
            this.bodyTypeDataGridViewTextBoxColumn.DataPropertyName = "BodyType";
            this.bodyTypeDataGridViewTextBoxColumn.HeaderText = "BodyType";
            this.bodyTypeDataGridViewTextBoxColumn.Name = "bodyTypeDataGridViewTextBoxColumn";
            // 
            // transmissionDataGridViewTextBoxColumn
            // 
            this.transmissionDataGridViewTextBoxColumn.DataPropertyName = "Transmission";
            this.transmissionDataGridViewTextBoxColumn.HeaderText = "Transmission";
            this.transmissionDataGridViewTextBoxColumn.Name = "transmissionDataGridViewTextBoxColumn";
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // Kabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1364, 769);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kabinet";
            this.Text = "Kabinet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kabinet_FormClosing);
            this.Load += new System.EventHandler(this.Kabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDataSet3 bDDataSet3;
        private System.Windows.Forms.BindingSource avtoBindingSource;
        private BDDataSet3TableAdapters.avtoTableAdapter avtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
    }
}