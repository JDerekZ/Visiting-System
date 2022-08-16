using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Entity_Layer;


namespace Data_Layer
{
    public class C_Date
    {

        private DB_Connect connect = new DB_Connect();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();

        #region "Search Methods"
        public DataTable Search_Built(string built)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Search_Date_B";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@search", built);
            reader = cmd.ExecuteReader();
            table.Load(reader);
            connect.ClosedsqlConnection();

            return table;
        }

        public DataTable Search_Classroom(string classroom)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Search_Date_C";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@search", classroom);
            reader = cmd.ExecuteReader();
            table.Load(reader);
            connect.ClosedsqlConnection();

            return table;
        }
        #endregion

        #region "CRUD"
        //for Read
        public DataTable viewAll()
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_List_Date";
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            table.Load(reader);
            connect.ClosedsqlConnection();

            return table;
        }



        //For Create
        public void Create_Date(string name, string lastname, string career, string email, string built, DateTime date, string classroom, string reason)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Create_Date";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@career", career);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@building", built);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@classroom",classroom);
            cmd.Parameters.AddWithValue("@reason", reason);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connect.ClosedsqlConnection();
        }

        //For Update
        public void Edit_Date(string name, string lastname, string career, string email, string built, DateTime date, string classroom, string reason, int id)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Edit_Date";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@career", career);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@building", built);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@classroom", classroom);
            cmd.Parameters.AddWithValue("@reason", reason);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connect.ClosedsqlConnection();
        }

        //For Delete
        public void Delete_Date(int id)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Delete_Date";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connect.ClosedsqlConnection();
        }
        #endregion
   
    }
}
