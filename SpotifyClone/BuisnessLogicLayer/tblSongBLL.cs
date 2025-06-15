using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpotifyClone.DataAccessObjectLayer;
using SpotifyClone.PocosLayer;

namespace SpotifyClone.BuisnessLogicLayer
{
    class tblSongBLL
    {
        private tblSongDOA _tblSongDOA;

        public tblSongBLL()
        {
            _tblSongDOA = new tblSongDOA();
        }

        public tblSong konum(string id)
        {
            tblSong sarkiKonum = new tblSong();
            DataTable dataTable = _tblSongDOA.sarkiKonum(id);

            foreach(DataRow dr in dataTable.Rows)
            {
                sarkiKonum.path = dr["PATH"].ToString().Trim('"');
            }

            return sarkiKonum;
        }

        public tblSong isim(string songID)
        {
            tblSong songName = new tblSong();
            DataTable dataTable = _tblSongDOA.sarkIsim(songID);

            foreach (DataRow dr in dataTable.Rows)
            {
                songName.name = dr["Song_Name"].ToString();

            }

            return songName;
        }


    }
}
