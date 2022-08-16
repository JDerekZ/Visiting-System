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
    public partial class FrmAddDate : Form
    {
        
        Tools_Dates tools = new Tools_Dates();
        Entity entity = new Entity();
        private bool Edit = false;
        //public static string SuperUser_Type = Cache_User_Login.SuperUser;
        public string IdDate;

        public FrmAddDate()
        {
            InitializeComponent();
        }

        private void FrmAddDate_Load(object sender, EventArgs e)
        {
            LoadDgv();            
            ValidUserType();
        }

        #region "Close button"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region "Buttons Events"
        private void btnSave_Click(object sender, EventArgs e)
        {
            string built = entity.Built = cbxBuilt.SelectedItem.ToString();
            string classroom = entity.Classroom = cbxClassroom.SelectedItem.ToString();
            string career = cbxCareer.SelectedItem.ToString();

            if (Edit == false)
            {
                if (tbxName.Text != "" && tbxLastname.Text != "" && cbxCareer.Text != "" && tbxEmail.Text != "" && cbxBuilt.Text != "" && cbxClassroom.Text != "" && tbxReason.Text != "")
                {
                    try
                    {
                        tools.Create_Date(tbxName.Text, tbxLastname.Text, career, tbxEmail.Text, built, dtpDate.Value, classroom, tbxReason.Text);
                        MessageBox.Show("Date created successfully");
                        LoadDgv();
                        ClearForm();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Data could not be inserted:" + x);
                    }
                }
                else
                {
                    MessageBox.Show("Make sure you fill all the fields correctly");
                }
            }
            //To Edit on Click Save
            if (Edit == true)
            {
                if (tbxName.Text != "" && tbxLastname.Text != "" && cbxCareer.Text != "" && tbxEmail.Text != "" && cbxBuilt.Text != "" && cbxClassroom.Text != "" && tbxReason.Text != "")
                {

                    try
                    {
                        tools.Edit_Date(tbxName.Text, tbxLastname.Text, career, tbxEmail.Text, built, dtpDate.Value, classroom, tbxReason.Text, IdDate);
                        MessageBox.Show("Se editó la cita correctamente");
                        Edit = false;
                        LoadDgv();
                        ClearForm();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("No se pudo editar los datos correctamente por:" + x);
                    }

                }              
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAddDate.SelectedRows.Count > 0)
            {
                Edit = true;
                tbxName.Text = dgvAddDate.CurrentRow.Cells["Name"].Value.ToString();
                tbxLastname.Text = dgvAddDate.CurrentRow.Cells["LastName"].Value.ToString();
                cbxCareer.Text = dgvAddDate.CurrentRow.Cells["Career"].Value.ToString();
                tbxEmail.Text = dgvAddDate.CurrentRow.Cells["Email"].Value.ToString();
                cbxBuilt.Text = dgvAddDate.CurrentRow.Cells["Building"].Value.ToString();
                dtpDate.Text = dgvAddDate.CurrentRow.Cells["DateAndHour"].Value.ToString();
                cbxClassroom.Text = dgvAddDate.CurrentRow.Cells["Classroom"].Value.ToString();
                tbxReason.Text = dgvAddDate.CurrentRow.Cells["Reason"].Value.ToString();
                IdDate = dgvAddDate.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddDate.SelectedRows.Count > 0)
            {
                IdDate = dgvAddDate.CurrentRow.Cells["Id"].Value.ToString();
                tools.Delete_Contact(IdDate);
                MessageBox.Show("Date has been successfully deleted");
                LoadDgv();
                ClearForm();
            }
            else
            {
                MessageBox.Show("You must select a row first,\n please");
            }
        }
        #endregion


        #region "Others Methods"
        private void LoadDgv()
        {
            Tools_Dates tool = new Tools_Dates();
            dgvAddDate.DataSource = tool.ViewAllDates();
        }


        private void ClearForm()
        {
            tbxName.Text = "";
            tbxLastname.Text = "";
            tbxEmail.Text = "";
            dtpDate.ResetText();
            tbxReason.Text = "";
            cbxBuilt.Text = "";
            cbxCareer.Text = "";
            cbxClassroom.Text = "";
        }

        private void ValidUserType()
        {
            if (Cache_User_Login.SuperUser == "true")
            {
                return;
            }
            else
            {
                //Form Disable:
                tbxName.Visible = false;
                tbxLastname.Visible = false;
                cbxCareer.Visible = false;
                tbxEmail.Visible = false;
                cbxBuilt.Visible = false;
                dtpDate.Visible = false;
                cbxClassroom.Visible = false;
                tbxReason.Visible = false;
                //labels
                lblBuilt.Visible = false;
                lblCareer.Visible = false;
                lblDate.Visible = false;
                lblLastName.Visible = false;
                lblName.Visible = false;
                lblClassroom.Visible = false;
                lblEmail.Visible = false;
                lblReason.Visible = false;

                //btnSave.Enabled = false;
                btnSave.Visible = false;

                //btnEdit.Enabled = false;
                btnEdit.Visible = false;

                //btnDelete.Enabled = false;
                btnDelete.Visible = false;
            }
        }
        #endregion

    }
}
