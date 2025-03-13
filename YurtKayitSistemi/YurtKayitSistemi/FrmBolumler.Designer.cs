namespace YurtKayitSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbDuzenle = new System.Windows.Forms.PictureBox();
            this.pcbSil = new System.Windows.Forms.PictureBox();
            this.pcbEkle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumID = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtOtomasyonDataSet = new YurtKayitSistemi.YurtKayıtOtomasyonDataSet();
            this.bölümlerTableAdapter = new YurtKayitSistemi.YurtKayıtOtomasyonDataSetTableAdapters.BölümlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bölümlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbDuzenle
            // 
            this.pcbDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcbDuzenle.Image")));
            this.pcbDuzenle.Location = new System.Drawing.Point(470, 88);
            this.pcbDuzenle.Name = "pcbDuzenle";
            this.pcbDuzenle.Size = new System.Drawing.Size(83, 57);
            this.pcbDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDuzenle.TabIndex = 1;
            this.pcbDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbDuzenle, "Bölüm Güncelle");
            this.pcbDuzenle.Click += new System.EventHandler(this.pcbDuzenle_Click);
            // 
            // pcbSil
            // 
            this.pcbSil.BackColor = System.Drawing.SystemColors.Control;
            this.pcbSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbSil.Image")));
            this.pcbSil.Location = new System.Drawing.Point(529, 21);
            this.pcbSil.Name = "pcbSil";
            this.pcbSil.Size = new System.Drawing.Size(71, 61);
            this.pcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSil.TabIndex = 2;
            this.pcbSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbSil, "Bölüm Sil");
            this.pcbSil.Click += new System.EventHandler(this.pcbSil_Click);
            // 
            // pcbEkle
            // 
            this.pcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbEkle.Image")));
            this.pcbEkle.Location = new System.Drawing.Point(406, 21);
            this.pcbEkle.Name = "pcbEkle";
            this.pcbEkle.Size = new System.Drawing.Size(78, 61);
            this.pcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEkle.TabIndex = 3;
            this.pcbEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbEkle, "Bölüm Ekle");
            this.pcbEkle.Click += new System.EventHandler(this.pcbEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bölüm id:";
            // 
            // txtBolumID
            // 
            this.txtBolumID.Enabled = false;
            this.txtBolumID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumID.Location = new System.Drawing.Point(128, 21);
            this.txtBolumID.Name = "txtBolumID";
            this.txtBolumID.Size = new System.Drawing.Size(204, 30);
            this.txtBolumID.TabIndex = 5;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAd.Location = new System.Drawing.Point(128, 73);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(204, 30);
            this.txtBolumAd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bölümAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bölümlerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 244);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bölümAdDataGridViewTextBoxColumn
            // 
            this.bölümAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bölümAdDataGridViewTextBoxColumn.DataPropertyName = "BölümAd";
            this.bölümAdDataGridViewTextBoxColumn.HeaderText = "BölümAd";
            this.bölümAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bölümAdDataGridViewTextBoxColumn.Name = "bölümAdDataGridViewTextBoxColumn";
            // 
            // bölümlerBindingSource
            // 
            this.bölümlerBindingSource.DataMember = "Bölümler";
            this.bölümlerBindingSource.DataSource = this.yurtKayıtOtomasyonDataSet;
            // 
            // yurtKayıtOtomasyonDataSet
            // 
            this.yurtKayıtOtomasyonDataSet.DataSetName = "YurtKayıtOtomasyonDataSet";
            this.yurtKayıtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bölümlerTableAdapter
            // 
            this.bölümlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbEkle);
            this.Controls.Add(this.pcbSil);
            this.Controls.Add(this.pcbDuzenle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bölümlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbDuzenle;
        private System.Windows.Forms.PictureBox pcbSil;
        private System.Windows.Forms.PictureBox pcbEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumID;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayıtOtomasyonDataSet yurtKayıtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource bölümlerBindingSource;
        private YurtKayıtOtomasyonDataSetTableAdapters.BölümlerTableAdapter bölümlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}