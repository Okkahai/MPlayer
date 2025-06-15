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
    class tblPlaylistDOA
    {
        private veritabaniBaglantisi baglanti;

        public tblPlaylistDOA()
        {
            baglanti = new veritabaniBaglantisi();
        }

        public bool insertPlaylist(string ID, string userID, string name, string datecreated)
        {
            string sorgu = string.Format("insert into PLAYLIST( USERID, NAME, DATECREATED) values (@USERID, @NAME, @DATECREATED)");

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(ID);

            sqlParameters[1] = new SqlParameter("@USERID", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToString(userID);

            sqlParameters[2] = new SqlParameter("@NAME", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(name);

            sqlParameters[3] = new SqlParameter("@DATECREATED", SqlDbType.Date);
            sqlParameters[3].Value = Convert.ToString(datecreated);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updatePlaylist(string ID, string userID, string name, string datecreated)
        {
            string sorgu = string.Format("insert into PLAYLIST( USERID, NAME, DATECREATED) values (@USERID, @NAME, @DATECREATED)");

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@USERID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(userID);

            sqlParameters[1] = new SqlParameter("@NAME", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(name);

            sqlParameters[2] = new SqlParameter("@DATECREATED", SqlDbType.Date);
            sqlParameters[2].Value = Convert.ToString(datecreated);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deletePlaylist(string ID)
        {
            string sorgu = string.Format($"delete from PLAYLIST where ID = {ID}");

            return baglanti.executeDeleteQuery(sorgu);
        }
        
        public DataTable playlistName(string playlistID)//unused
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            string sorgu =
                "SELECT PLAYLIST.NAME AS Playlist_Name " +
                "FROM PLAYLIST " +
                "WHERE PLAYLIST.ID = @PlaylistID";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@playlistID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(playlistID);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);
        }

    }
}
