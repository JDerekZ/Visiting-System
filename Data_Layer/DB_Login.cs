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
    public class DB_Login
    {

        private DB_Connect connect = new DB_Connect();

        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();


        public bool Login(string user, string password)
        {
            cmd.Connection = connect.OpensqlConnection();
            cmd.CommandText = "SP_Confirm_Login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userLogin", user);
            cmd.Parameters.AddWithValue("@passwordLogin", password);

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Cache_User_Login.Id_User = reader.GetInt32(0);
                    Cache_User_Login.Name = reader.GetString(3);
                    Cache_User_Login.Nickname = reader.GetString(1);
                    Cache_User_Login.Lastname = reader.GetString(4);
                    Cache_User_Login.SuperUser = reader.GetString(5);
                    Cache_User_Login.Email = reader.GetString(6);
                }

                return true;
            }
            else
            {
                return false;  
            }

           
        }



    }
}
