using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Oop2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static bool Isroot;
        private void isadmin()
        {
            Admincheck.Checked = Isroot;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProfile.Image = Image.getImage(@"http://torrent-oyun.gen.tr/images/defaultuser.png");
            PictureLogin.Image = Image.getImage(@"http://torrent-oyun.gen.tr/images/login.png");
            PictureSignup.Image = Image.getImage(@"http://torrent-oyun.gen.tr/images/signup.png");
        }
       

        private void PictureLogin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void PictureSignup_MouseClick(object sender, MouseEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void PictureLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
            updateScreen();
        }
        public void updateScreen()
        {
            Costumer cs = Costumer.getInstance();
            Console.WriteLine(cs.Name.ToString());
            if (cs != null)
            {
                btnCard.Visible = true;
                btnLogout.Visible = true;
                btnMyprofile.Visible = true;
                btnPrev.Visible = true;
                bool flag = false;
                Getdatabase db = new Getdatabase();
                db.IsAdmin(cs, ref flag);
                if (flag)
                {
                    btnAdmin.Visible = true;
                }
            }
        }
        
    }
}
