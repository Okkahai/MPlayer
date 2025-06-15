
namespace SpotifyClone.PresentationLayer.UserEntry
{
    partial class YeniKullanici
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
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.gENDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOTIFYCLONEDataSet8 = new SpotifyClone.SPOTIFYCLONEDataSet8();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cOUNTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOTIFYCLONEDataSet9 = new SpotifyClone.SPOTIFYCLONEDataSet9();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnCik = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gENDERTableAdapter = new SpotifyClone.SPOTIFYCLONEDataSet8TableAdapters.GENDERTableAdapter();
            this.cOUNTRYTableAdapter = new SpotifyClone.SPOTIFYCLONEDataSet9TableAdapters.COUNTRYTableAdapter();
            this.pnlYeniKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gENDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlYeniKayit
            // 
            this.pnlYeniKayit.Controls.Add(this.dtpBirthDate);
            this.pnlYeniKayit.Controls.Add(this.cmbGender);
            this.pnlYeniKayit.Controls.Add(this.cmbCountry);
            this.pnlYeniKayit.Controls.Add(this.label11);
            this.pnlYeniKayit.Controls.Add(this.txtTelNo);
            this.pnlYeniKayit.Controls.Add(this.txtEmail);
            this.pnlYeniKayit.Controls.Add(this.txtSurname);
            this.pnlYeniKayit.Controls.Add(this.txtName);
            this.pnlYeniKayit.Controls.Add(this.txtPassword);
            this.pnlYeniKayit.Controls.Add(this.txtUsername);
            this.pnlYeniKayit.Controls.Add(this.btnCik);
            this.pnlYeniKayit.Controls.Add(this.btnKaydet);
            this.pnlYeniKayit.Controls.Add(this.label9);
            this.pnlYeniKayit.Controls.Add(this.label5);
            this.pnlYeniKayit.Controls.Add(this.label6);
            this.pnlYeniKayit.Controls.Add(this.label7);
            this.pnlYeniKayit.Controls.Add(this.label8);
            this.pnlYeniKayit.Controls.Add(this.label3);
            this.pnlYeniKayit.Controls.Add(this.label4);
            this.pnlYeniKayit.Controls.Add(this.label2);
            this.pnlYeniKayit.Location = new System.Drawing.Point(12, 12);
            this.pnlYeniKayit.Name = "pnlYeniKayit";
            this.pnlYeniKayit.Size = new System.Drawing.Size(961, 271);
            this.pnlYeniKayit.TabIndex = 5;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(524, 28);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(193, 20);
            this.dtpBirthDate.TabIndex = 31;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.DataSource = this.gENDERBindingSource;
            this.cmbGender.DisplayMember = "NAME";
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(524, 136);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(193, 21);
            this.cmbGender.TabIndex = 30;
            this.cmbGender.ValueMember = "ID";
            // 
            // gENDERBindingSource
            // 
            this.gENDERBindingSource.DataMember = "GENDER";
            this.gENDERBindingSource.DataSource = this.sPOTIFYCLONEDataSet8;
            // 
            // sPOTIFYCLONEDataSet8
            // 
            this.sPOTIFYCLONEDataSet8.DataSetName = "SPOTIFYCLONEDataSet8";
            this.sPOTIFYCLONEDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DataSource = this.cOUNTRYBindingSource;
            this.cmbCountry.DisplayMember = "NAME";
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(524, 177);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(193, 21);
            this.cmbCountry.TabIndex = 29;
            this.cmbCountry.ValueMember = "ID";
            // 
            // cOUNTRYBindingSource
            // 
            this.cOUNTRYBindingSource.DataMember = "COUNTRY";
            this.cOUNTRYBindingSource.DataSource = this.sPOTIFYCLONEDataSet9;
            // 
            // sPOTIFYCLONEDataSet9
            // 
            this.sPOTIFYCLONEDataSet9.DataSetName = "SPOTIFYCLONEDataSet9";
            this.sPOTIFYCLONEDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(430, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ülke";
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.Color.Silver;
            this.txtTelNo.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(524, 67);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(193, 21);
            this.txtTelNo.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(524, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 21);
            this.txtEmail.TabIndex = 18;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.Silver;
            this.txtSurname.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(136, 156);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(161, 21);
            this.txtSurname.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(136, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 21);
            this.txtName.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Silver;
            this.txtPassword.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(136, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 21);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Silver;
            this.txtUsername.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(136, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 21);
            this.txtUsername.TabIndex = 13;
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.Gray;
            this.btnCik.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.Location = new System.Drawing.Point(891, 221);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(57, 35);
            this.btnCik.TabIndex = 11;
            this.btnCik.Text = "Çık";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Gray;
            this.btnKaydet.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(891, 180);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(57, 35);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(430, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(430, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(430, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "E-Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(430, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dank Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // gENDERTableAdapter
            // 
            this.gENDERTableAdapter.ClearBeforeFill = true;
            // 
            // cOUNTRYTableAdapter
            // 
            this.cOUNTRYTableAdapter.ClearBeforeFill = true;
            // 
            // YeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(991, 296);
            this.Controls.Add(this.pnlYeniKayit);
            this.Name = "YeniKullanici";
            this.Text = "YeniKullanici";
            this.Load += new System.EventHandler(this.YeniKullanici_Load);
            this.pnlYeniKayit.ResumeLayout(false);
            this.pnlYeniKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gENDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOTIFYCLONEDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlYeniKayit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbCountry;
        private SPOTIFYCLONEDataSet8 sPOTIFYCLONEDataSet8;
        private System.Windows.Forms.BindingSource gENDERBindingSource;
        private SPOTIFYCLONEDataSet8TableAdapters.GENDERTableAdapter gENDERTableAdapter;
        private SPOTIFYCLONEDataSet9 sPOTIFYCLONEDataSet9;
        private System.Windows.Forms.BindingSource cOUNTRYBindingSource;
        private SPOTIFYCLONEDataSet9TableAdapters.COUNTRYTableAdapter cOUNTRYTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}