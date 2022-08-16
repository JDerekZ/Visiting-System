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


namespace Present_Layer
{
    public partial class FrmLoadScreen : Form
    {
        public FrmLoadScreen()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            CircleProgressBar.Value += 1;

            CircleProgressBar.Text = CircleProgressBar.Value.ToString();
           
            if (CircleProgressBar.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FrmLoadScreen_Load(object sender, EventArgs e)
        {
            lblUser.Text = Cache_User_Login.Name + "\n" + Cache_User_Login.Lastname;
            lblNickName.Text = "NickName:" + " " + Cache_User_Login.Nickname;
            
            if (Cache_User_Login.SuperUser == "true")
            {
                lblRole.Text = "Role:" + " " + "Admin";
            }
            else
            {
                lblRole.Text = "Role:" + " " + "General";
            }

            this.Opacity = 0.0;
            CircleProgressBar.Value = 0;
            CircleProgressBar.Minimum = 0;
            CircleProgressBar.Maximum = 100;

            timer1.Start();
        }


    }
}
