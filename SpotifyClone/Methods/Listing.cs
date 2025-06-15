using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SpotifyClone.dbConn;
using SpotifyClone.PocosLayer;
using SpotifyClone.PresentationLayer.UserEntry;
using SpotifyClone.BuisnessLogicLayer;
using SpotifyClone.DataAccessObjectLayer;
using System.Data;

namespace SpotifyClone.Methods
{
    class Listing
    {
        public DataTable playlist_PlaylistID_Name(string userID)
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            string queryText = "SELECT PLAYLIST.ID AS Id, PLAYLIST.NAME AS PlaylistName FROM PLAYLIST WHERE PLAYLIST.USERID = @UserID";

            SqlCommand query = new SqlCommand(queryText, veritabaniBaglantisi.connection);
            query.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)).Value = Convert.ToInt32(userID);

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable songAndPlaylist_Name_Duration_Order(string playlist_id)
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            string queryText =
                "SELECT SONG.ID AS SongID, SONG.NAME AS SongName, SONG.DURATION AS SongDuration, PLAYLISTSONGS.PLAYLISTORDER AS PlaylistOrder " +
                "FROM SONG " +
                "JOIN PLAYLISTSONGS ON SONG.ID = PLAYLISTSONGS.SONGID " +
                "WHERE PLAYLISTSONGS.PLAYLISTID = @PlaylistID";

            SqlCommand query = new SqlCommand(queryText, veritabaniBaglantisi.connection);
            query.Parameters.Add(new SqlParameter("@PlaylistID", SqlDbType.Int)).Value = Convert.ToInt32(playlist_id);

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable song_ID_Name_Duration()
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            SqlCommand query = new SqlCommand(
                "SELECT ID AS SongID, NAME AS SongName, DURATION AS SongDuration FROM SONG",
                veritabaniBaglantisi.connection
            );

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable playlistsongs_Detail(string playlistID)
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            string queryText = "SELECT PLAYLIST.ID AS PlaylistID, SONG.NAME AS SongName, ARTIST.NAME AS ArtistName, " +
                               "SONG.DURATION AS SongDuration, ALBUM.TITLE AS AlbumName, PLAYLISTSONGS.DATEADDED AS DateAdded " +
                               "FROM PLAYLISTSONGS " +
                               "JOIN PLAYLIST ON PLAYLISTSONGS.PLAYLISTID = PLAYLIST.ID " +
                               "JOIN SONG ON PLAYLISTSONGS.SONGID = SONG.ID " +
                               "JOIN ARTIST ON SONG.ARTISTID = ARTIST.ID " +
                               "JOIN ALBUM ON SONG.ALBUMID = ALBUM.ID " +
                               "WHERE PLAYLISTSONGS.PLAYLISTID = @PlaylistID " +
                               "ORDER BY PLAYLISTSONGS.DATEADDED ASC";

            SqlCommand query = new SqlCommand(queryText, veritabaniBaglantisi.connection);
            query.Parameters.Add(new SqlParameter("@PlaylistID", SqlDbType.Int)).Value = Convert.ToInt32(playlistID);

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
            
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable playlist_All(string userID)
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            string queryText = "SELECT * FROM PLAYLIST WHERE USERID = @UserID";
            SqlCommand query = new SqlCommand(queryText, veritabaniBaglantisi.connection);
            query.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)).Value = Convert.ToInt32(userID);

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable user_All()
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            string queryText = "SELECT * FROM [USER];";
            SqlCommand query = new SqlCommand(queryText, veritabaniBaglantisi.connection);

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query);

            dataAdapter.Fill(dataTable);

            return dataTable;
        }

       

    }
}
