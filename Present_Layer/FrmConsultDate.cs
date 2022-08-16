using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Layer;
using Logic_Layer;

namespace Present_Layer
{
    public partial class FrmConsultDate : Form
    {

        Tools_Dates tools = new Tools_Dates();


        public FrmConsultDate()
        {
            InitializeComponent();
        }

        private void FrmConsultDate_Load(object sender, EventArgs e)
        {

        }

        #region "Close Button"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion



        #region "Modern Search Effects like a Login"
        //Efects tbxSearch by Built
        private void tbxSearchBuilt_Enter(object sender, EventArgs e)
        {
            if (tbxSearchBuilt.Text == "Search by building")
            {
                tbxSearchBuilt.Text = "";
                tbxSearchBuilt.ForeColor = Color.LightGray;
            }
        }
        
        private void tbxSearchBuilt_Leave(object sender, EventArgs e)
        {
            if (tbxSearchBuilt.Text == "")
            {
                tbxSearchBuilt.Text = "Search by building";
                tbxSearchBuilt.ForeColor = Color.DimGray;
            }
        }

        //Efects tbxSearch by Classroom
        private void tbxSearchClassroom_Enter(object sender, EventArgs e)
        {
            if (tbxSearchClassroom.Text == "Search by classroom")
            {
                tbxSearchClassroom.Text = "";
                tbxSearchClassroom.ForeColor = Color.LightGray;
            }
        }

        private void tbxSearchClassroom_Leave(object sender, EventArgs e)
        {
            if (tbxSearchClassroom.Text == "")
            {
                tbxSearchClassroom.Text = "Search by classroom";
                tbxSearchClassroom.ForeColor = Color.DimGray;
            }
        }
        #endregion
       
        
        #region "Buttons Events"
        private void btnSearchClassroom_Click(object sender, EventArgs e)
        {
            LoadSearch_Classroom(tbxSearchClassroom.Text);
            ClearForm();
        }
        private void btnSearchBuilt_Click(object sender, EventArgs e)
        {
            LoadSearch_Built(tbxSearchBuilt.Text);
            ClearForm();
        }

        #endregion


        #region "Others Methods"

        private void LoadSearch_Built(string built)
        {
            Tools_Dates tool = new Tools_Dates();
            dgvConsult.DataSource = tool.Search_Date_Built(built);
        }

        private void LoadSearch_Classroom(string classroom)
        {
            Tools_Dates tool = new Tools_Dates();
            dgvConsult.DataSource = tool.Search_Date_Classroom(classroom);
        }

        private void ClearForm()
        {
            tbxSearchBuilt.Text = "Search by building";
            tbxSearchClassroom.Text = "Search by classroom";
        }
        #endregion
    }
}
