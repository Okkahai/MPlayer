using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SpotifyClone.dbConn;
using SpotifyClone.PocosLayer;

namespace SpotifyClone.DataAccessObjectLayer
{
    class tblPlaylistsongsDOA
    {
        private veritabaniBaglantisi baglanti;

        public tblPlaylistsongsDOA()
        {
            baglanti = new veritabaniBaglantisi();
        }
        
        public DataTable sarkiDegistir(string playlistID)
        {
            string sorgu = string.Format("SELECT SONGID from PLAYLISTSONGS where PLAYLISTID = @playlistID");

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@playlistID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(playlistID);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);
        }  

        public bool insertPlaylistSongs(string SONGID, string PLAYLISTID, string USERID, string PLAYLISTORDER, string DATEADDED)
        {
            string sorgu = string.Format("INSERT INTO PLAYLISTSONGS (SONGID, PLAYLISTID, USERID, PLAYLISTORDER, DATEADDED) VALUES (@SongID, @PlaylistID, @UserID, @PlaylistOrder, @DateAdded)");
            
            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@SONGID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(SONGID);

            sqlParameters[1] = new SqlParameter("@PLAYLISTID", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToString(PLAYLISTID);

            sqlParameters[2] = new SqlParameter("@USERID", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(USERID);

            sqlParameters[3] = new SqlParameter("@PLAYLISTORDER", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToString(PLAYLISTORDER);

            sqlParameters[4] = new SqlParameter("@DATEADDED", SqlDbType.DateTime);
            sqlParameters[4].Value = Convert.ToString(DATEADDED);
            
            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool deletePlaylist(string song_id, string playlist_id)
        {
            string sorgu = string.Format("DELETE FROM PLAYLISTSONGS WHERE SONGID = @SongID AND PLAYLISTID = @PlaylistID;");
            
            return baglanti.executeDeleteQuery(sorgu);
        }

    }
}
 