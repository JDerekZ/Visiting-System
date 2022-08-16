using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logic_Layer;
using Entity_Layer;

namespace Present_Layer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Load_User_Info();
        }

        #region "Movement Top Bar"
        //Properties for FORM movement
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Event on click the mouse and move bar
        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region "Code Of Buttons Close and Min"

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                 Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region "On_Click Event Forms"

        private void btnAddCites_Click(object sender, EventArgs e)
        {
            OpenForm<FrmAddDate>();
        }

        private void btnConsultVisit_Click(object sender, EventArgs e)
        {
            OpenForm<FrmConsultDate>();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            OpenForm<FrmAddUser>();
        }
        #endregion


        //Methods
        #region "Method to Load Forms"
        //Method to Load Forms in Panel on FrmMain
        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            Form frm;
            frm = pContainer.Controls.OfType<MyForm>().FirstOrDefault(); //Busca en la colección existente el formulario

            //si el formulario o instancia del mismo no exista:
            if (frm == null)
            {
                frm = new MyForm();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                pContainer.Controls.Add(frm);
                pContainer.Tag = frm;
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                frm.BringToFront();
            }
        }
        #endregion

        //Method to Load Labels of Frm Main
        private void Load_User_Info()
        {
            if (Cache_User_Login.SuperUser == "true")
            {
                lblRole.Text = "Admin";
            }
            else
            {
                lblRole.Text = "General";
            }
            
            lblName.Text = Cache_User_Login.Name;
            lblLastname.Text = Cache_User_Login.Lastname;
            lblEmail.Text = Cache_User_Login.Email;
        }



        //Function to call the Form
        //OpenForm<//Name Of FRM//>();
    }
}
