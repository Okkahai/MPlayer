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
    class tblUserDOA
    {
        private veritabaniBaglantisi baglanti;

        public tblUserDOA()
        {
            baglanti = new veritabaniBaglantisi();
        }

        public DataTable searchUsernameandPassword(string username, string password)
        {
            string sorgu = string.Format("select * from [USER] where USERNAME = @username and USERPASSWORD = @password");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);

            sqlParameters[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(password);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);
        }

        public bool insertUser(string ID, string GENDERID, string USERNAME, string USERPASSWORD, string NAME, string SURNAME,
                        string DATEOFBIRTH, string EMAIL, string TELNO, string COUNTRYID)
        {
            string sorgu = string.Format("insert into [USER]( GENDERID, USERNAME, USERPASSWORD, NAME, SURNAME, DATEOFBIRTH, EMAIL,  TELNO, COUNTRYID) values ( @GENDERID, @USERNAME, @USERPASSWORD, @NAME, @SURNAME, @DATEOFBIRTH, @EMAIL,  @TELNO, @COUNTRYID)");

            SqlParameter[] sqlParameters = new SqlParameter[10];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(ID);

            sqlParameters[1] = new SqlParameter("@GENDERID", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToString(GENDERID);

            sqlParameters[2] = new SqlParameter("@USERNAME", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(USERNAME);

            sqlParameters[3] = new SqlParameter("@USERPASSWORD", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(USERPASSWORD);

            sqlParameters[4] = new SqlParameter("@NAME", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(NAME);

            sqlParameters[5] = new SqlParameter("@SURNAME", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(SURNAME);

            sqlParameters[6] = new SqlParameter("@DATEOFBIRTH", SqlDbType.Date);
            sqlParameters[6].Value = Convert.ToString(DATEOFBIRTH);

            sqlParameters[7] = new SqlParameter("@EMAIL", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(EMAIL);

            sqlParameters[8] = new SqlParameter("@TELNO", SqlDbType.VarChar);
            sqlParameters[8].Value = Convert.ToString(TELNO);

            sqlParameters[9] = new SqlParameter("@COUNTRYID", SqlDbType.Int);
            sqlParameters[9].Value = Convert.ToString(COUNTRYID);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

    }
}
