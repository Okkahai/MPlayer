
namespace SpotifyClone.PresentationLayer.UserEntry
{
    partial class Ana_Menu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditPlaylists = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pLAYLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOTIFYCLONEDataSet7 = new SpotifyClone.SPOTIFYCLONEDataSet7();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.pLAYLISTTableAdapter = new SpotifyClone.SPOTIFYCLONEDataSet7TableAdapters.PLAYLISTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dank Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalma Listelerim";
            // 
            // btnEditPlaylists
            // 
            this.btnEditPlaylists.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btnEditPlaylists.Appearance.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditPlaylists.Appearance.Options.UseBackColor = true;
            this.btnEditPlaylists.Appearance.Options.UseFont = true;
            this.btnEditPlaylists.Location = new System.Drawing.Point(660, 372);
            this.btnEditPlaylists.Name = "btnEditPlaylists";
            this.btnEditPlaylists.Size = new System.Drawing.Size(160, 58);
            this.btnEditPlaylists.TabIndex = 6;
            this.btnEditPlaylists.Text = "D&üzenle";
            this.btnEditPlaylists.Click += new System.EventHandler(this.btnEditPlaylists_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dank Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(492, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Çalma Listelerini \r\nDüzenle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtPlaylistName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnCik);
            this.panel1.Location = new System.Drawing.Point(476, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 268);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mevcut Listeler";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pLAYLISTBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pLAYLISTBindingSource
            // 
            this.pLAYLISTBindingSource.DataMember = "PLAYLIST";
            this.pLAYLISTBindingSource.DataSource = this.sPOTIFYCLONEDataSet7;
            // 
            // sPOTIFYCLONEDataSet7
            // 
            this.sPOTIFYCLONEDataSet7.DataSetName = "SPOTIFYCLONEDataSet7";
            this.sPOTIFYCLONEDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.BackColor = System.Drawing.Color.Silver;
            this.txtPlaylistName.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaylistName.Location = new System.Drawing.Point(150, 130);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(161, 21);
            this.txtPlaylistName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Yeni İsim";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Gray;
            this.btnEkle.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(158, 230);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(57, 35);
            this.btnEkle.TabIndex = 34;
            this.btnEkle.Text = "E&kle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gray;
            this.btnSil.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(221, 230);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(57, 35);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.Gray;
            this.btnCik.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.Location = new System.Drawing.Point(284, 230);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(57, 35);
            this.btnCik.TabIndex = 32;
            this.btnCik.Text = "Çık";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // pLAYLISTTableAdapter
            // 
            this.pLAYLISTTableAdapter.ClearBeforeFill = true;
            // 
            // Ana_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(846, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditPlaylists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ana_Menu";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Ana_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnEditPlaylists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private SPOTIFYCLONEDataSet7 sPOTIFYCLONEDataSet7;
        private System.Windows.Forms.BindingSource pLAYLISTBindingSource;
        private SPOTIFYCLONEDataSet7TableAdapters.PLAYLISTTableAdapter pLAYLISTTableAdapter;
    }
}