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
    public class C_User
    {
        private DB_Connect connect = new DB_Connect();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();


        #region "CRUD"
        //For Read
        public DataTable viewAll()
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_List_Users";
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            table.Load(reader);
            connect.ClosedsqlConnection();

            return table;
        }

        //For Create
        public void Create_User(string username, string password, string name, string lastname, string super_u, string email)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Create_User";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@superuser", super_u);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connect.ClosedsqlConnection();
        }

        //For Edit
        public void Edit_User(string username, string password, string name, string lastname, string super_u, string email, int id)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Edit_User";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@superuser", super_u);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connect.ClosedsqlConnection();
        }

        //For Delete
        public void Delete_User(int id)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Delete_User";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connect.ClosedsqlConnection();
        }
        #endregion

    }
}
