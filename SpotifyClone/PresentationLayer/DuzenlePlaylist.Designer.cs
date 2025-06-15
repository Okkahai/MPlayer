
namespace SpotifyClone.PresentationLayer
{
    partial class DuzenlePlaylist
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
            this.pnlYeniKayit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pLAYLISTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPOTIFYCLONEDataSet3 = new SpotifyClone.SPOTIFYCLONEDataSet3();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSongID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCik = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPOTIFYCLONEDataSet = new SpotifyClone.SPOTIFYCLONEDataSet();
            this.pLAYLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYLISTTableAdapter = new SpotifyClone.SPOTIFYCLONEDataSetTableAdapters.PLAYLISTTableAdapter();
            this.sONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOTIFYCLONEDataSet2 = new SpotifyClone.SPOTIFYCLONEDataSet2();
            this.sONGTableAdapter = new SpotifyClone.SPOTIFYCLONEDataSet2TableAdapters.SONGTableAdapter();
            this.pLAYLISTTableAdapter1 = new SpotifyClone.SPOTIFYCLONEDataSet3TableAdapters.PLAYLISTTableAdapter();
            this.dURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlYeniKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlYeniKayit
            // 
            this.pnlYeniKayit.Controls.Add(this.label1);
            this.pnlYeniKayit.Controls.Add(this.comboBox1);
            this.pnlYeniKayit.Controls.Add(this.btnSil);
            this.pnlYeniKayit.Controls.Add(this.btnEkle);
            this.pnlYeniKayit.Controls.Add(this.txtSongName);
            this.pnlYeniKayit.Controls.Add(this.label5);
            this.pnlYeniKayit.Controls.Add(this.txtSongID);
            this.pnlYeniKayit.Controls.Add(this.label6);
            this.pnlYeniKayit.Controls.Add(this.btnCik);
            this.pnlYeniKayit.Location = new System.Drawing.Point(12, 372);
            this.pnlYeniKayit.Name = "pnlYeniKayit";
            this.pnlYeniKayit.Size = new System.Drawing.Size(879, 195);
            this.pnlYeniKayit.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Playlist";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.DataSource = this.pLAYLISTBindingSource1;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // pLAYLISTBindingSource1
            // 
            this.pLAYLISTBindingSource1.DataMember = "PLAYLIST";
            this.pLAYLISTBindingSource1.DataSource = this.sPOTIFYCLONEDataSet3;
            // 
            // sPOTIFYCLONEDataSet3
            // 
            this.sPOTIFYCLONEDataSet3.DataSetName = "SPOTIFYCLONEDataSet3";
            this.sPOTIFYCLONEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gray;
            this.btnSil.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(808, 103);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(57, 35);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Gray;
            this.btnEkle.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(808, 62);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(57, 35);
            this.btnEkle.TabIndex = 37;
            this.btnEkle.Text = "E&kle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.BackColor = System.Drawing.Color.Silver;
            this.txtSongName.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSongName.Location = new System.Drawing.Point(163, 117);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(161, 21);
            this.txtSongName.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(88, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "İsim";
            // 
            // txtSongID
            // 
            this.txtSongID.BackColor = System.Drawing.Color.Silver;
            this.txtSongID.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSongID.Location = new System.Drawing.Point(163, 84);
            this.txtSongID.Name = "txtSongID";
            this.txtSongID.Size = new System.Drawing.Size(161, 21);
            this.txtSongID.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(86, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Şarkı ID";
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.Gray;
            this.btnCik.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.Location = new System.Drawing.Point(808, 144);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(57, 35);
            this.btnCik.TabIndex = 11;
            this.btnCik.Text = "&Çık";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(517, 354);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sPOTIFYCLONEDataSet
            // 
            this.sPOTIFYCLONEDataSet.DataSetName = "SPOTIFYCLONEDataSet";
            this.sPOTIFYCLONEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLAYLISTBindingSource
            // 
            this.pLAYLISTBindingSource.DataMember = "PLAYLIST";
            this.pLAYLISTBindingSource.DataSource = this.sPOTIFYCLONEDataSet;
            // 
            // pLAYLISTTableAdapter
            // 
            this.pLAYLISTTableAdapter.ClearBeforeFill = true;
            // 
            // sONGBindingSource
            // 
            this.sONGBindingSource.DataMember = "SONG";
            this.sONGBindingSource.DataSource = this.sPOTIFYCLONEDataSet2;
            // 
            // sPOTIFYCLONEDataSet2
            // 
            this.sPOTIFYCLONEDataSet2.DataSetName = "SPOTIFYCLONEDataSet2";
            this.sPOTIFYCLONEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sONGTableAdapter
            // 
            this.sONGTableAdapter.ClearBeforeFill = true;
            // 
            // pLAYLISTTableAdapter1
            // 
            this.pLAYLISTTableAdapter1.ClearBeforeFill = true;
            // 
            // dURATIONDataGridViewTextBoxColumn
            // 
            this.dURATIONDataGridViewTextBoxColumn.DataPropertyName = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.dURATIONDataGridViewTextBoxColumn.Name = "dURATIONDataGridViewTextBoxColumn";
            this.dURATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.dURATIONDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sONGBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(535, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(356, 354);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // DuzenlePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(902, 583);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pnlYeniKayit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DuzenlePlaylist";
            this.Text = "DuzenlePlaylist";
            this.Load += new System.EventHandler(this.DuzenlePlaylist_Load);
            this.pnlYeniKayit.ResumeLayout(false);
            this.pnlYeniKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlYeniKayit;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSongID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private SPOTIFYCLONEDataSet sPOTIFYCLONEDataSet;
        private System.Windows.Forms.BindingSource pLAYLISTBindingSource;
        private SPOTIFYCLONEDataSetTableAdapters.PLAYLISTTableAdapter pLAYLISTTableAdapter;
        private SPOTIFYCLONEDataSet2 sPOTIFYCLONEDataSet2;
        private System.Windows.Forms.BindingSource sONGBindingSource;
        private SPOTIFYCLONEDataSet2TableAdapters.SONGTableAdapter sONGTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private SPOTIFYCLONEDataSet3 sPOTIFYCLONEDataSet3;
        private System.Windows.Forms.BindingSource pLAYLISTBindingSource1;
        private SPOTIFYCLONEDataSet3TableAdapters.PLAYLISTTableAdapter pLAYLISTTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}