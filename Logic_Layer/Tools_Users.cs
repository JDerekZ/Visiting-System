using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using System.Data;
using Entity_Layer;

namespace Logic_Layer
{
    public class Tools_Users
    {

        private C_User c_User = new C_User();


        #region "CRUD"
        public DataTable ViewAllUsers()
        {
            DataTable table = new DataTable();
            table = c_User.viewAll();
            return table;
        }

        public void Create_User(string username, string password, string name, string lastname, string super_u, string email)
        {

            c_User.Create_User(username, password, name, lastname, super_u, email);

        }

        public void Edit_User(string username, string password, string name, string lastname, string super_u, string email, string id)
        {

            c_User.Edit_User(username, password, name, lastname, super_u, email, (Convert.ToInt32(id)));

        }

        public void Delete_User(string id)
        {

            c_User.Delete_User(Convert.ToInt32(id));

        }
        #endregion

    }
}
