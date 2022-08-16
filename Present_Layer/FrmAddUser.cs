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
    public partial class FrmAddUser : Form
    {

        Tools_Users tools = new Tools_Users();
        Entity entity = new Entity();
        private bool Edit = false;
        //public static string SuperUser_Type = Cache_User_Login.SuperUser;
        public string IdUser;



        public FrmAddUser()
        {
            InitializeComponent();
        }

        //Method Load
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            LoadDgv();
            ValidUserType();
            tbxPassword.UseSystemPasswordChar = true;
            tbxConfirmPass.UseSystemPasswordChar = true;
        }

        #region "Button Close Event"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Events On Click Buttons"
        private void btnSave_Click(object sender, EventArgs e)
        {   //para sacar un booleano en cadena de string que pueda leer SQL
            #region "Evaluate user type and enter bool value"
            string UserType = cbxTypeUser.SelectedItem.ToString();
            string confirm_TU = "";
            

            if (UserType == "Admin")
            {
                confirm_TU = "true";
            }
            else
            {
                confirm_TU= "false";
            }
            #endregion

            if (Edit == false)
            {
                if (tbxName.Text != "" && tbxLastname.Text != "" && tbxNickname.Text != "" && tbxPassword.Text != "" && tbxConfirmPass.Text != "" && tbxEmail.Text != "" && cbxTypeUser.SelectedItem.ToString() != "")
                {
                    if (tbxPassword.Text == tbxConfirmPass.Text)
                    {
                        try
                        {
                            tools.Create_User(tbxNickname.Text, tbxPassword.Text, tbxName.Text, tbxLastname.Text, confirm_TU, tbxEmail.Text);
                            MessageBox.Show("User created successfully");
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
                        MessageBox.Show("Passwords do not match in both fields");
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
                if (tbxName.Text != "" && tbxLastname.Text != "" && tbxNickname.Text != "" && tbxPassword.Text != "" && tbxConfirmPass.Text != "" && tbxEmail.Text != "" && cbxTypeUser.SelectedItem.ToString() != "")
                {
                    if (tbxPassword.Text == tbxConfirmPass.Text)
                    {
                        try
                        {
                            tools.Edit_User(tbxNickname.Text, tbxPassword.Text, tbxName.Text, tbxLastname.Text, confirm_TU, tbxEmail.Text, IdUser);
                            MessageBox.Show("User edited successfully");
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
                        MessageBox.Show("Passwords do not match in both fields");
                    }
                }
                else
                {
                    MessageBox.Show("Make sure you fill all the fields correctly");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAddUser.SelectedRows.Count > 0)
            {
                Edit = true;
                tbxNickname.Text = dgvAddUser.CurrentRow.Cells["LogName"].Value.ToString();
                tbxPassword.Text = dgvAddUser.CurrentRow.Cells["LogPassword"].Value.ToString();
                tbxName.Text = dgvAddUser.CurrentRow.Cells["Name"].Value.ToString();
                tbxLastname.Text = dgvAddUser.CurrentRow.Cells["LastName"].Value.ToString();
                cbxTypeUser.Text = dgvAddUser.CurrentRow.Cells["SuperUser"].Value.ToString();               
                IdUser = dgvAddUser.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddUser.SelectedRows.Count > 0)
            {
                IdUser = dgvAddUser.CurrentRow.Cells["Id"].Value.ToString();
                tools.Delete_User(IdUser);
                MessageBox.Show("User has been successfully deleted");
                LoadDgv();
                ClearForm();
            }
            else
            {
                MessageBox.Show("You must select a row first,\n please");
            }
        }

        #region "Eye Buttons"
        //Eye button efect
        private void btnVisiblePassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.UseSystemPasswordChar == true && tbxConfirmPass.UseSystemPasswordChar ==true)
            {
                tbxPassword.UseSystemPasswordChar = false;
                tbxConfirmPass.UseSystemPasswordChar = false;
                btnVisiblePassword.Visible = false;
                btnInvisiblePassword.Visible = true;
            }
        }

        private void btnInvisiblePassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.UseSystemPasswordChar == false && tbxConfirmPass.UseSystemPasswordChar == false)
            {
                tbxPassword.UseSystemPasswordChar = true;
                tbxConfirmPass.UseSystemPasswordChar = true;
                btnInvisiblePassword.Visible = false;
                btnVisiblePassword.Visible = true;
            }

        }
        #endregion

        #endregion


        #region "Others Methods"
        private void LoadDgv()
        {
            Tools_Users tool = new Tools_Users();
            dgvAddUser.DataSource = tool.ViewAllUsers();
        }

        private void ClearForm()
        {
            tbxName.Text = "";
            tbxLastname.Text = "";
            tbxEmail.Text = "";
            tbxNickname.Text = "";
            tbxPassword.Text = "";
            tbxConfirmPass.Text = "";
        }

        private void ValidUserType()
        {
            if (Cache_User_Login.SuperUser == "true")
            {
                return;
            }
            else
            {
                //Form Disable
                lblName.Visible = false;
                lblLastname.Visible = false;
                lblEmail.Visible = false;
                lblPassword.Visible = false;
                lblConfirmPass.Visible = false;
                lblUserType.Visible = false;
                lbNickname.Visible = false;

                //Form tbx's and cbx's disable
                tbxNickname.Visible = false;
                tbxPassword.Visible = false;
                tbxName.Visible = false;
                tbxLastname.Visible = false;
                tbxEmail.Visible = false;
                tbxConfirmPass.Visible = false;
                cbxTypeUser.Visible = false;


                //Btn's Form disable
                btnSave.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnInvisiblePassword.Visible = false;
                btnVisiblePassword.Visible = false;
            }
        }

        #endregion

    }
}
