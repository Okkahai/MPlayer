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
    public partial class Ana_Menu : Form
    {
        string ID;
        string ID_PLAYLIST;
        string NAME_PLAYLIST;
        string PLAYLIST_ID;
        private tblPlaylistBLL _tblPlaylistBLL;
        public Ana_Menu(string id)
        {
            ID = id;
            _tblPlaylistBLL = new tblPlaylistBLL();
            InitializeComponent();
            
        }

        public void list_playlist(string ID)
        {
            Listing _listing = new Listing();
            DataTable dataTable = _listing.playlist_All(ID);

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
        
        private void Ana_Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet7.PLAYLIST' table. You can move, or remove it, as needed.
            this.pLAYLISTTableAdapter.Fill(this.sPOTIFYCLONEDataSet7.PLAYLIST);
            DataGrid_Design dataGrid_Design = new DataGrid_Design();
            dataGrid_Design.SetFontAndColors(dataGridView1);
            list_playlist(ID);

        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //sadece id ile yapılabilir
            ID_PLAYLIST = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NAME_PLAYLIST = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            try
            {
                PlaylistPage playlistPage = new PlaylistPage(ID, ID_PLAYLIST, NAME_PLAYLIST);
                playlistPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        
        }
        private void btnEditPlaylists_Click(object sender, EventArgs e)
        {
            DuzenlePlaylist duzenlePlaylist = new DuzenlePlaylist(ID);
            duzenlePlaylist.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;
                string time = Convert.ToString(today);
                tblPlaylist playlists = new tblPlaylist();
                int numtemp = 1;
                string PLAYLIST_ID_TEMP = Convert.ToString(numtemp);
                playlists = _tblPlaylistBLL.playlistKaydet(PLAYLIST_ID_TEMP, ID, txtPlaylistName.Text, time);

                list_playlist(ID);

                this.pLAYLISTTableAdapter.Fill(this.sPOTIFYCLONEDataSet7.PLAYLIST);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            tblPlaylist playlistSil = new tblPlaylist();
            playlistSil = _tblPlaylistBLL.playlistSil(PLAYLIST_ID);

            list_playlist(ID);

            this.pLAYLISTTableAdapter.Fill(this.sPOTIFYCLONEDataSet7.PLAYLIST);
        }


        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PLAYLIST_ID = Convert.ToString(comboBox1.SelectedValue);
        }
    }
}
