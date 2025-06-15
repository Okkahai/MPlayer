using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SpotifyClone.dbConn;
using SpotifyClone.PocosLayer;
using SpotifyClone.BuisnessLogicLayer;
using SpotifyClone.DataAccessObjectLayer;
using SpotifyClone.Methods;

namespace SpotifyClone.PresentationLayer.UserEntry
{
    public partial class YeniKullanici : Form
    {
        private tblUserBLL _tblUserBLL;
        public YeniKullanici()
        {
            InitializeComponent();
            _tblUserBLL = new tblUserBLL();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            tblUser users = new tblUser();             
            users = _tblUserBLL.kullaniciKaydet(txtTelNo.Text, Convert.ToString(cmbGender.SelectedValue), txtUsername.Text, txtPassword.Text, txtName.Text, txtSurname.Text, dtpBirthDate.Text, txtEmail.Text, txtTelNo.Text, Convert.ToString(cmbCountry.SelectedValue));

            MessageBox.Show("Kayıt Başarılı");
            
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YeniKullanici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet9.COUNTRY' table. You can move, or remove it, as needed.
            this.cOUNTRYTableAdapter.Fill(this.sPOTIFYCLONEDataSet9.COUNTRY);
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet8.GENDER' table. You can move, or remove it, as needed.
            this.gENDERTableAdapter.Fill(this.sPOTIFYCLONEDataSet8.GENDER);

        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
