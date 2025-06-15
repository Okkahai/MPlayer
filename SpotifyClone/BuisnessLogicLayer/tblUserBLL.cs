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
    class tblUserBLL
    {
        private tblUserDOA _tblUserDOA;

        public tblUserBLL()
        {
            _tblUserDOA = new tblUserDOA();
        }

        public tblUser girisSorgula(string username, string password)
        {
            tblUser kullaniciGirisi = new tblUser();

            DataTable dataTable = _tblUserDOA.searchUsernameandPassword(username, password);

            foreach(DataRow dr in dataTable.Rows)
            {
                kullaniciGirisi.username = dr["USERNAME"].ToString();
                kullaniciGirisi.userpassword = dr["USERPASSWORD"].ToString();

                //to carry the id in the input
                //put it inside the constructor and filter the person in future forms or codes
                kullaniciGirisi.id = dr["ID"].ToString();
                
                
            }
            return kullaniciGirisi;
        }

        public tblUser kullaniciKaydet (string ID, string GENDERID, string USERNAME, string USERPASSWORD, string NAME, string SURNAME,
                        string DATEOFBIRTH, string EMAIL, string TELNO, string COUNTRYID)
        {
            tblUser kaydetKullanici = new tblUser();
            DataTable dataTable = new DataTable();


            _tblUserDOA.insertUser(ID, GENDERID, USERNAME, USERPASSWORD, NAME, SURNAME, DATEOFBIRTH, EMAIL, TELNO, COUNTRYID);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["ID"] = kaydetKullanici.id;
                dr["GENDERID"] = kaydetKullanici.genderID;
                dr["USERNAME"] = kaydetKullanici.username;
                dr["USERPASSWORD"] = kaydetKullanici.userpassword;
                dr["NAME"] = kaydetKullanici.name;
                dr["SURNAME"] = kaydetKullanici.surname;
                dr["DATEOFBIRTH"] = kaydetKullanici.dateofbirth;
                dr["EMAIL"] = kaydetKullanici.email;
                dr["TELNO"] = kaydetKullanici.telno;
                dr["COUNTRYID"] = kaydetKullanici.countryID;
                
            }

            return kaydetKullanici;
        }

    }
}
