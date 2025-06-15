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
using SpotifyClone.PresentationLayer.UserEntry;
using System.Media;
using SpotifyClone.BuisnessLogicLayer;
using SpotifyClone.Methods;

namespace SpotifyClone.PresentationLayer
{
    public partial class PlaylistPage : Form
    {
        string ID;
        string PLAYLIST_ID;
        string PLAYLIST_NAME;
        int COUNT = 0;
        private SoundPlayer soundPlayer;
        tblPlaylistsongsBLL _tblPlaylistsongsBLL;
        tblSongBLL _tblSongBLL;

        public PlaylistPage(string id, string playlist_id, string playlist_name)
        {

            ID = id;
            PLAYLIST_ID = playlist_id;
            PLAYLIST_NAME = playlist_name;

            _tblPlaylistsongsBLL = new tblPlaylistsongsBLL();
            _tblSongBLL = new tblSongBLL();

            tblPlaylistSongs _tblPlaylistSongs = new tblPlaylistSongs();
            _tblPlaylistSongs = _tblPlaylistsongsBLL.sonrakiSarki(COUNT, PLAYLIST_ID);

            string SONG_ID = _tblPlaylistSongs.songID;

            tblSong _tblSong = new tblSong();
            _tblSong = _tblSongBLL.konum(SONG_ID);

            string songPath = _tblSong.path;


            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = songPath;
            soundPlayer.Load();

            InitializeComponent();
        }

        private void PlaylistPage_Load(object sender, EventArgs e)
        {
            DataGrid_Design dataGrid_Design = new DataGrid_Design();
            dataGrid_Design.SetFontAndColors(dataGridView2);
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet1.PLAYLIST' table. You can move, or remove it, as needed.
            this.pLAYLISTTableAdapter1.Fill(this.sPOTIFYCLONEDataSet1.PLAYLIST);
            lblPlaylistName.Text = Convert.ToString(comboBox1.Text);
            lblCurrentSong.Text = null;
            list_detail(PLAYLIST_ID);
            // TODO: This line of code loads data into the 'sPOTIFYCLONEDataSet.PLAYLIST' table. You can move, or remove it, as needed.
            this.pLAYLISTTableAdapter.Fill(this.sPOTIFYCLONEDataSet.PLAYLIST);
        }

        public void list_detail(string PLAYLIST_ID)
        {
            Listing _listing = new Listing();
            DataTable dataTable = _listing.playlistsongs_Detail(PLAYLIST_ID);

            if (dataTable != null)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                dataGridView2.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("Null DataTable");
            }


        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            Ana_Menu anaMenu = new Ana_Menu(ID);
            anaMenu.Show();
            this.Hide();
            
        }

        private void btnPausePlay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnPausePlay.Checked)
                {
                    btnPausePlay.Text = "Start";
                    soundPlayer.Stop();
                }
                else
                {
                    btnPausePlay.Text = "Stop";
                    soundPlayer.Play();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }

        private string funcSongPath(int count, string playlist_id)
        {
            tblPlaylistSongs _tblPlaylistSongs = new tblPlaylistSongs();
            _tblPlaylistSongs = _tblPlaylistsongsBLL.sonrakiSarki(COUNT, PLAYLIST_ID);

            string SONG_ID = _tblPlaylistSongs.songID;

            tblSong _tblSong = new tblSong();
            _tblSong = _tblSongBLL.konum(SONG_ID);

            return _tblSong.path;
        }

        private string funcSongName(int count, string playlist_id)
        {
            tblPlaylistSongs _tblPlaylistSongs = new tblPlaylistSongs();
            _tblPlaylistSongs = _tblPlaylistsongsBLL.sonrakiSarki(COUNT, PLAYLIST_ID);

            string SONG_ID = _tblPlaylistSongs.songID;

            tblSong _tblSong = new tblSong();
            _tblSong = _tblSongBLL.isim(SONG_ID);

            return _tblSong.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string songPath = funcSongPath(COUNT, PLAYLIST_ID);
            
            lblCurrentSong.Text = funcSongName(COUNT, PLAYLIST_ID);
            
            soundPlayer.SoundLocation = songPath;
            soundPlayer.Load();
            soundPlayer.Play();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                COUNT--;

                string songPath = funcSongPath(COUNT, PLAYLIST_ID);
                
                lblCurrentSong.Text = funcSongName(COUNT, PLAYLIST_ID);

                soundPlayer.SoundLocation = songPath;
                soundPlayer.Load();
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                COUNT++;
                
                string songPath = funcSongPath(COUNT, PLAYLIST_ID);
                
                lblCurrentSong.Text = funcSongName(COUNT, PLAYLIST_ID);

                soundPlayer.SoundLocation = songPath;
                soundPlayer.Load();
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PLAYLIST_ID = Convert.ToString(comboBox1.SelectedValue);
            
            list_detail(PLAYLIST_ID);
            
            lblPlaylistName.Text = Convert.ToString(comboBox1.Text);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
