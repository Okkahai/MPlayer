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
using SpotifyClone.PresentationLayer.UserEntry;

namespace SpotifyClone.PresentationLayer
{
    
    public partial class DuzenlePlaylist : Form
    {
       
        string ID;
        string PLAYLIST_ID;
        string PLAYLIST_ORDER;

        tblPlaylistsongsBLL _tblPlaylistsongsBLL;
        public DuzenlePlaylist(string id)
        {
            int num = 1;
            ID = id;
            PLAYLIST_ID = Convert.ToString(num);
            _tblPlaylistsongsBLL = new tblPlaylistsongsBLL();
            InitializeComponent();
        }

         
        private void DuzenlePlaylist_Load(object sender, EventArgs e)
        {
            DataGrid_Design dataGrid_Design = new DataGrid_Design();
            dataGrid_Design.SetFontAndColors(dataGridView1);
            dataGrid_Design.SetFontAndColors(dataGridView2);
            list_SONGS(PLAYLIST_ID);
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet3.PLAYLIST' table. You can move, or remove it, as needed.
            this.pLAYLISTTableAdapter1.Fill(this.sPOTIFYCLONEDataSet3.PLAYLIST);
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet2.SONG' table. You can move, or remove it, as needed.
            this.sONGTableAdapter.Fill(this.sPOTIFYCLONEDataSet2.SONG);
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet.PLAYLIST' table. You can move, or remove it, as needed.
            this.pLAYLISTTableAdapter.Fill(this.sPOTIFYCLONEDataSet.PLAYLIST);

        }

        public void list_SONGS(string playlist_id)
        {
            Listing _listing = new Listing();
            DataTable dataTable = _listing.songAndPlaylist_Name_Duration_Order(playlist_id);

            if (dataTable != null)
            {
                BindingSource bindingSource = new BindingSource(); 
                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("Null DataTable");
            }

        }


        public void list_SONGLIST()
        {
            Listing _listing = new Listing();
            DataTable dataTable = _listing.song_ID_Name_Duration();

            if (dataTable != null)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("Null DataTable");
            }


        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Ana_Menu ana_Menu = new Ana_Menu(ID);
            ana_Menu.Show();
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//silmek için
        {
            txtSongID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSongName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PLAYLIST_ORDER = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)//eklemek için
        {
            txtSongID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtSongName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string time = Convert.ToString(today);

            tblPlaylistSongs _tblPlaylistSongs = new tblPlaylistSongs();
            _tblPlaylistSongs = _tblPlaylistsongsBLL.playlisteSarkiEklemeKaydet(txtSongID.Text, PLAYLIST_ID, ID, PLAYLIST_ORDER, time);
            
            list_SONGS(PLAYLIST_ID);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            tblPlaylistSongs _tblPlaylistSongs = new tblPlaylistSongs();
            _tblPlaylistSongs = _tblPlaylistsongsBLL.playlisteSarkiSilmeKaydet(txtSongID.Text, PLAYLIST_ID);

            list_SONGS(PLAYLIST_ID);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PLAYLIST_ID = Convert.ToString(comboBox1.SelectedValue);
            list_SONGS(PLAYLIST_ID);
        }

  

































































        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaylistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSongID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

       
    }
}
