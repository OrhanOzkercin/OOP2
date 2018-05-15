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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void btnGiris_MouseClick(object sender, MouseEventArgs e)
        {
           
            Getdatabase dh = Getdatabase.getInstance();
            //Costumer logined = Costumer.getInstance();
            Costumer customer = dh.GetCostumer(txtKadi.Text, txtSifre.Text);
            if (customer != null)
            {
                if (txtKadi.Text == customer.Username && txtSifre.Text == customer.Password)
                {
                    MessageBox.Show("Girdi");
                }

            }
            else
                MessageBox.Show("Wrong Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
