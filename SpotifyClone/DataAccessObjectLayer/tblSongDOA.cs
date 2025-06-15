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
    class tblSongDOA
    {
        private veritabaniBaglantisi baglanti;

        public tblSongDOA()
        {
            baglanti = new veritabaniBaglantisi();
        }

        public DataTable sarkiKonum(string songID)
        {
            string sorgu = string.Format("select PATH from SONG where ID = @songID");

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@songID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(songID);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);
        }

        public DataTable sarkIsim(string songID)
        {
            veritabaniBaglantisi veritabaniBaglantisi = new veritabaniBaglantisi();

            string sorgu = string.Format("SELECT SONG.NAME AS Song_Name FROM SONG WHERE SONG.ID = @SongID");
            
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@SongID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(songID);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);
        }
    }
}
