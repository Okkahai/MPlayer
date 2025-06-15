using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SpotifyClone.dbConn
{
    class veritabaniBaglantisi
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection connection;

        public veritabaniBaglantisi()
        {
            dataAdapter = new SqlDataAdapter();
            connection = new SqlConnection(@"Data Source=;Integrated Security=True");// enter the database connection string here
        }

        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;

            DataSet ds = new DataSet();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();

                dataAdapter.SelectCommand = myCommand;
                dataAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error {ex}");
                return null;
            }


            return dataTable;
        }

        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error {ex}");
                return false;
            }


            return true;
        }

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error {ex}");
                return false;
            }


            return true;
        }

        public bool executeDeleteQuery(String _query)
        {
            SqlCommand myCommand = new SqlCommand();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                dataAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error {ex}");
                return false;
            }

            return true;
        }
    }
}
