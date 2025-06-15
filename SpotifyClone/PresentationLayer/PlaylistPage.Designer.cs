
namespace SpotifyClone.PresentationLayer
{
    partial class PlaylistPage
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
            this.pLAYLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOTIFYCLONEDataSet = new SpotifyClone.SPOTIFYCLONEDataSet();
            this.btnCik = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pLAYLISTTableAdapter = new SpotifyClone.SPOTIFYCLONEDataSetTableAdapters.PLAYLISTTableAdapter();
            this.btnPausePlay = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sPOTIFYCLONEDataSet1 = new SpotifyClone.SPOTIFYCLONEDataSet1();
            this.pLAYLISTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYLISTTableAdapter1 = new SpotifyClone.SPOTIFYCLONEDataSet1TableAdapters.PLAYLISTTableAdapter();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblCurrentSong = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pLAYLISTBindingSource
            // 
            this.pLAYLISTBindingSource.DataMember = "PLAYLIST";
            this.pLAYLISTBindingSource.DataSource = this.sPOTIFYCLONEDataSet;
            // 
            // sPOTIFYCLONEDataSet
            // 
            this.sPOTIFYCLONEDataSet.DataSetName = "SPOTIFYCLONEDataSet";
            this.sPOTIFYCLONEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCik.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.Location = new System.Drawing.Point(18, 377);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(121, 58);
            this.btnCik.TabIndex = 3;
            this.btnCik.Text = "&Çık";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(242, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(663, 426);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pLAYLISTTableAdapter
            // 
            this.pLAYLISTTableAdapter.ClearBeforeFill = true;
            // 
            // btnPausePlay
            // 
            this.btnPausePlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPausePlay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPausePlay.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPausePlay.Location = new System.Drawing.Point(1077, 398);
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.Size = new System.Drawing.Size(45, 51);
            this.btnPausePlay.TabIndex = 12;
            this.btnPausePlay.Text = "Stop";
            this.btnPausePlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPausePlay.UseVisualStyleBackColor = false;
            this.btnPausePlay.CheckedChanged += new System.EventHandler(this.btnPausePlay_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(924, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 234);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNext.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(1149, 398);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 51);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPrevious.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevious.Location = new System.Drawing.Point(1006, 398);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(44, 51);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Prev";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(18, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 58);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Çal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sPOTIFYCLONEDataSet1
            // 
            this.sPOTIFYCLONEDataSet1.DataSetName = "SPOTIFYCLONEDataSet1";
            this.sPOTIFYCLONEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLAYLISTBindingSource1
            // 
            this.pLAYLISTBindingSource1.DataMember = "PLAYLIST";
            this.pLAYLISTBindingSource1.DataSource = this.sPOTIFYCLONEDataSet1;
            // 
            // pLAYLISTTableAdapter1
            // 
            this.pLAYLISTTableAdapter1.ClearBeforeFill = true;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Dank Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(12, 32);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(224, 31);
            this.lblPlaylistName.TabIndex = 14;
            this.lblPlaylistName.Text = "lblPlaylistName";
            // 
            // lblCurrentSong
            // 
            this.lblCurrentSong.AutoSize = true;
            this.lblCurrentSong.Font = new System.Drawing.Font("Dank Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSong.Location = new System.Drawing.Point(995, 275);
            this.lblCurrentSong.Name = "lblCurrentSong";
            this.lblCurrentSong.Size = new System.Drawing.Size(182, 31);
            this.lblCurrentSong.TabIndex = 15;
            this.lblCurrentSong.Text = "Current Song";
            this.lblCurrentSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataSource = this.pLAYLISTBindingSource1;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // PlaylistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1272, 480);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCurrentSong);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPausePlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCik);
            this.Name = "PlaylistPage";
            this.Text = "Çalma Listelerim";
            this.Load += new System.EventHandler(this.PlaylistPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYLISTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SPOTIFYCLONEDataSet sPOTIFYCLONEDataSet;
        private System.Windows.Forms.BindingSource pLAYLISTBindingSource;
        private SPOTIFYCLONEDataSetTableAdapters.PLAYLISTTableAdapter pLAYLISTTableAdapter;
        private System.Windows.Forms.CheckBox btnPausePlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button button1;
        private SPOTIFYCLONEDataSet1 sPOTIFYCLONEDataSet1;
        private System.Windows.Forms.BindingSource pLAYLISTBindingSource1;
        private SPOTIFYCLONEDataSet1TableAdapters.PLAYLISTTableAdapter pLAYLISTTableAdapter1;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label lblCurrentSong;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}