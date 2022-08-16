using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Data_Layer;
using System.Data;
using Entity_Layer;

namespace Logic_Layer
{
    public class Tools_Dates
    {
        private C_Date c_Date = new C_Date();


        //Search Built
        public DataTable Search_Date_Built(string built)
        {
            DataTable table = new DataTable();
            table = c_Date.Search_Built(built);
            return table;
        }

        //Search Classroom
        public DataTable Search_Date_Classroom(string classroom)
        {
            DataTable table = new DataTable();
            table = c_Date.Search_Classroom(classroom);
            return table;
        }

        #region CRUD
        public DataTable ViewAllDates()
        {
            DataTable table = new DataTable();
            table = c_Date.viewAll();
            return table;
        }

        public void Create_Date(string name, string lastname, string career, string email, string built, DateTime date, string classroom, string reason)
        {

            c_Date.Create_Date(name, lastname, career, email, built, date, classroom, reason);

        }


        public void Edit_Date(string name, string lastname, string career, string email, string built, DateTime date, string classroom, string reason, string id)
        {

            c_Date.Edit_Date(name, lastname, career, email, built, date, classroom, reason, Convert.ToInt32(id));

        }


        public void Delete_Contact(string id)
        {

            c_Date.Delete_Date(Convert.ToInt32(id));

        }
        #endregion

    }
}
