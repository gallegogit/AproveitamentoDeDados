using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataBaseCSV
{
   public class DBAccess
    {
        private static SqlConnection objConnection;
        private static SqlDataAdapter objDataAdapter;
        string ConnectionString = "";

       

        //private static void OpenConnection()
        //{
        //    try
        //    {
        //        if (objConnection == null)
        //        {
        //            objConnection = new SqlConnection(@"Data Source=localhost\\SQL2008; Initial Catalog=BaseAproveHiDoctor; User Id=sa; Password=totvs@123");
        //            objConnection.Open();
        //        }
        //        else
        //        {
        //            if (objConnection.State != ConnectionState.Open)
        //            {
        //                objConnection = new SqlConnection(@"Data Source=localhost\\SQL2008; Initial Catalog=BaseAproveHiDoctor; User Id=sa; Password=totvs@123");
        //                objConnection.Open();
        //            }
        //        }
        //    }
        //    catch (Exception ex) { }
        //}

        public DBAccess(string connStr)
        {
            this.ConnectionString = connStr;
        }

        public void OpenConection()
        {
            try
            {
                objConnection = new SqlConnection(ConnectionString);
                objConnection.Open();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //private static void CloseConnection()
        //{
        //    try
        //    {
        //        if (!(objConnection == null))
        //        {
        //            if (objConnection.State == ConnectionState.Open)
        //            {
        //                objConnection.Close();
        //                objConnection.Dispose();
        //            }
        //        }
        //    }
        //    catch (Exception ex) { }
        //}
        public void CloseConnection()
        {
            objConnection.Close();
        }


        public DataTable FillDataTable(string Query, DataTable Table)
        {

            OpenConection();
            try
            {
                objDataAdapter = new SqlDataAdapter(Query, objConnection);
                objDataAdapter.Fill(Table);
                objDataAdapter.Dispose();
                CloseConnection();

                return Table;
            }
            catch
            {
                return null;
            }
        }


        public SqlDataReader ExecuteReader(string cmd)
        {
            try
            {
                SqlDataReader objReader;
                string ConnectionString = "";
                objConnection = new SqlConnection(ConnectionString);
                OpenConection();
                SqlCommand cmdRedr = new SqlCommand(cmd, objConnection);
                objReader = cmdRedr.ExecuteReader(CommandBehavior.CloseConnection);
                cmdRedr.Dispose();
                return objReader;
            }
            catch
            {
                return null;
            }
        }
        public void ExecuteQuery(string query, string method = "")
        {
            try
            {
                OpenConection();
                SqlCommand cmd = new SqlCommand(query, objConnection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw;
            }
            //try
            //{
            //    string ConnectionString = "Data Source=localhost\\SQL2008; Initial Catalog=BaseAproveHiDoctor; User Id=sa; Password=totvs@123";
            //    using (SqlConnection connection = new SqlConnection(ConnectionString))
            //    {
            //        using (SqlCommand cmd = new SqlCommand(query, connection))
            //        {
            //            connection.Open();
            //            cmd.ExecuteNonQuery();
            //            connection.Close();
            //            return true;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }
    }
}