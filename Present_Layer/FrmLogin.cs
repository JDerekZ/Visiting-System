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
using Entity_Layer;
using Logic_Layer;

namespace Present_Layer
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();               
        }

        

        #region "Efects Modern Login"
        //Properties for FORM movement
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        //User tbx Effects
        private void tbxUser_Enter(object sender, EventArgs e)
        {
            if (tbxUser.Text == "USER")
            {
                tbxUser.Text = "";
                tbxUser.ForeColor = Color.LightGray;
            }
        }

        private void tbxUser_Leave(object sender, EventArgs e)
        {
            if (tbxUser.Text == "")
            {
                tbxUser.Text = "USER";
                tbxUser.ForeColor = Color.DimGray;
            }
        }
        //---//

        //Password tbx Effect
        private void btnPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "PASSWORD")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = Color.LightGray;
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxPassword.Text = "PASSWORD";
                tbxPassword.ForeColor = Color.DimGray;
                tbxPassword.UseSystemPasswordChar = false;
            }            
        }
        //--//


        //Close and Min Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //--//


        //Events of Movement
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lnklInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This is a visit system of the Technological Institute of the Americas.\nIf you have a user, you can enter the system to consult\nan appointment or to register one or register a user.", "▶Info◀");
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUser.Text != "USER" )
            {

                if (tbxPassword.Text != "PASSWORD")
                {

                    Tools_Login tools_login = new Tools_Login();

                    var Correct_login = tools_login.LoginUser(tbxUser.Text, tbxPassword.Text);

                    if (Correct_login==true)
                    {
                        this.Hide();
                        FrmLoadScreen welcome = new FrmLoadScreen();
                        welcome.ShowDialog();

                        FrmMain main = new FrmMain();
                        main.Show();
                        main.FormClosed += Logout; //Se sobrecarga el metodo de FormClosed con el método de cerrar sesión de debajo para mostrar de nuevo nuestro formulario de login.
                        
                    }
                    else
                    {
                        ErrorMessage("Incorrect Username or Password entered. \nPlease try again");
                        tbxPassword.Text = "PASSWORD";
                        tbxPassword.UseSystemPasswordChar = false;
                        tbxUser.Focus();
                    }

                }
                else
                {
                    ErrorMessage("Please enter password.");
                }

            }
            else
            {
                ErrorMessage("Please, enter a valid username.");
            }
            
         
        }

        //Method to display an error message
        private void ErrorMessage(string Type_error)
        {
            lblAlert.Text = "⚠️ "+Type_error;
            lblAlert.Visible = true;
        }

        //Method to show the Login form again when logging out.
        private void Logout(object sender, FormClosedEventArgs e)
        {            
            tbxPassword.Text = "PASSWORD";
            tbxPassword.UseSystemPasswordChar = false;
            tbxUser.Text = "USER";
            lblAlert.Visible = false;
            this.Show();
            tbxUser.Focus();
        }
    }
}
