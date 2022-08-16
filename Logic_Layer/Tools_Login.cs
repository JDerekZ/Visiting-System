using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using Entity_Layer;

namespace Logic_Layer
{
    public class Tools_Login
    {

        DB_Login db_Login = new DB_Login();

        public bool LoginUser(string user, string pass)
        {

            return db_Login.Login(user, pass);

        }

   
    }
}
