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
    class tblPlaylistBLL
    {
        private tblPlaylistDOA _tblPlaylistDOA;

        public tblPlaylistBLL()
        {
            _tblPlaylistDOA = new tblPlaylistDOA();
        }

        public tblPlaylist playlistKaydet(string ID, string userID, string name, string datecreated)
        {
            tblPlaylist kaydetPlaylist = new tblPlaylist();
            DataTable dataTable = new DataTable();


            _tblPlaylistDOA.insertPlaylist( ID, userID, name, datecreated);

            foreach(DataRow dr in dataTable.Rows)
            {

                dr["ID"] = kaydetPlaylist.id_p;
                dr["USERID"] = kaydetPlaylist.userID_p;
                dr["NAME"] = kaydetPlaylist.name_p;
                dr["DATECREATED"] = kaydetPlaylist.datecreated_p;
            }

            return kaydetPlaylist;
        }

        public tblPlaylist playlistGuncelle(string ID, string userID, string name, string datecreated)//incele
        {
            tblPlaylist guncellePlaylist = new tblPlaylist();
            DataTable dataTable = new DataTable();

            
            _tblPlaylistDOA.updatePlaylist(ID, userID, name, datecreated);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["USERID"] = guncellePlaylist.userID_p;
                dr["NAME"] = guncellePlaylist.name_p;
                dr["DATECREATED"] = guncellePlaylist.datecreated_p;
            }

            return guncellePlaylist;
        }

        public tblPlaylist playlistSil(string ID)
        {
            tblPlaylist playlistSil = new tblPlaylist();
            DataTable dataTable = new DataTable();

            _tblPlaylistDOA.deletePlaylist(Convert.ToString(ID));

            return playlistSil;
        }

        public tblPlaylist playlistIsim(string playlistID)//unused
        {
            tblPlaylist playlistName = new tblPlaylist();
            DataTable dataTable = _tblPlaylistDOA.playlistName(playlistID);
            
            foreach (DataRow dr in dataTable.Rows)
            {
                playlistName.name_p = dr["Playlist_Name"].ToString();
            }

            return playlistName;
        }

       


    }
}
