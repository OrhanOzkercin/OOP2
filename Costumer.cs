using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Oop2
{
    public class Costumer
    {
        private int userId;
        private string name;
        private string adress;
        private string email;
        private string username;
        private string password;
        private bool gender;
        private string image;
        private string usertel;
       

        private static Costumer instance;
        private Costumer() { }
        public static Costumer getInstance()
        {
            if (instance == null)
                instance = new Costumer();
            return instance;
        }


        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public string Usertel
        {
            get
            {
                return usertel;
            }

            set
            {
                usertel = value;
            }
        }
    }
}
