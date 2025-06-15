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
    class tblPlaylistsongsBLL
    {
        private tblPlaylistsongsDOA _tblPlaylistsongsDOA;

        public tblPlaylistsongsBLL()
        {
            _tblPlaylistsongsDOA = new tblPlaylistsongsDOA();
        }
        public tblPlaylistSongs sonrakiSarki(int count, string id)
        {
            tblPlaylistSongs sarkiSecim = new tblPlaylistSongs();
            DataTable dataTable = _tblPlaylistsongsDOA.sarkiDegistir(id);

            DataRow dr = dataTable.Rows[count];

            sarkiSecim.songID = dr["SONGID"].ToString();
            
            return sarkiSecim;
        }

        public tblPlaylistSongs playlisteSarkiEklemeKaydet(string SONGID, string PLAYLISTID, string USERID, string PLAYLISTORDER, string DATEADDED)
        {
            tblPlaylistSongs kaydetSarki = new tblPlaylistSongs();
            DataTable dataTable = new DataTable();


            _tblPlaylistsongsDOA.insertPlaylistSongs(SONGID, PLAYLISTID, USERID, PLAYLISTORDER, DATEADDED);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["SONGID"] = kaydetSarki.songID;
                dr["PLAYLISTID"] = kaydetSarki.playlistID;
                dr["USERID"] = kaydetSarki.userID;
                dr["PLAYLISTORDER"] = kaydetSarki.playlistorder;
                dr["DATEADED"] = kaydetSarki.dateadded;

            }

            return kaydetSarki;
        }

        public tblPlaylistSongs playlisteSarkiSilmeKaydet(string SONGID, string PLAYLISTID)
        {
            tblPlaylistSongs sarkiSil = new tblPlaylistSongs();
            DataTable dataTable = new DataTable();
            
            _tblPlaylistsongsDOA.deletePlaylist(SONGID, PLAYLISTID);

            return sarkiSil;
        }
    }
}
