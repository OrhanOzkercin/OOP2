using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Oop2
{
    class Getdatabase
    {
        static private Getdatabase dh;
        private Getdatabase() { }
        public static Getdatabase getInstance()
        {
            if (dh == null)
                dh = new Getdatabase();
            return dh;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=185.149.100.17\\MSSQLSERVER2014;Initial Catalog=oopA;User ID=oop;Password=Pass123");

        public Costumer GetCostumer(string username, string password)
        {
            Costumer costumer = null;
            try
            {
                dh.baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Uyeler where Username=@Username", baglanti);
                komut.Parameters.AddWithValue("Username", username);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Read();
                if (password == (string)dr["Password"])
                {
                    costumer = Costumer.getInstance();
                    costumer.UserId = (int)(dr["Userid"]);
                    costumer.Name = dr["Name"].ToString();
                    costumer.Adress =dr["Adress"].ToString();
                    costumer.Email = dr["Mail"].ToString();
                    costumer.Username = dr["Username"].ToString();
                    costumer.Password = dr["Password"].ToString();
                    costumer.Gender = (bool)dr["Gender"];
                    costumer.Image = dr["UserPicture"].ToString();


                    if ((bool)dr["Admincheck"] == true)
                    {
                        MainForm.Isroot = true;
                    }
                    else
                    {
                        MainForm.Isroot = false;
                    }
                    try
                    {
                        costumer.Image = "http://torrent-oyun.gen.tr/images/" + costumer.UserId + ".jpg";
                    }
                    catch
                    {
                        if (costumer.Gender)
                            costumer.Image = "http://torrent-oyun.gen.tr/images/male.png";
                        else
                            costumer.Image = "http://torrent-oyun.gen.tr/images/female.png";
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Connection Crashed, Please try again. \n" + ex.Message, "Connection Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dh.baglanti.Close();
            return costumer;

        }
        public void UpdateImage(string filepath, string username)
        {
            Costumer costumer=Costumer.getInstance();
            dh.baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Uyeler where Username=@Username", baglanti);
            komut.Parameters.AddWithValue("Username", username);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            string Username = "torrent2";
            string Password = "7Jl3tw91Eb";
            string Urlpath = "ftp://185.149.103.190";
                       
            WebClient Client = new WebClient();
            Client.Credentials = new System.Net.NetworkCredential(Username, Password);
            Client.BaseAddress = Urlpath;
            string deneme = username;
            Client.UploadFile(username + ".jpg", WebRequestMethods.Ftp.UploadFile, filepath);

            dh.baglanti.Close();
        }
        public void CustomerUpdate(Costumer cstmr)
        {
            string kayitcustomer = "UPDATE Customer SET Name=@Name,Address=@Address,Mail=@Mail,Username=@Username,Password=@Password,Gender=@Gender where ID=@ID";
            dh.baglanti.Open();
            SqlCommand cmd = new SqlCommand(kayitcustomer, baglanti);
            cmd.Parameters.AddWithValue("ID", cstmr.UserId);
            cmd.Parameters.AddWithValue("Name", cstmr.Name);
            cmd.Parameters.AddWithValue("Address", cstmr.Adress);
            cmd.Parameters.AddWithValue("Email", cstmr.Email);
            cmd.Parameters.AddWithValue("Username", cstmr.Username);
            cmd.Parameters.AddWithValue("Password", cstmr.Password);
            cmd.Parameters.AddWithValue("Gender", cstmr.Gender);
            cmd.ExecuteNonQuery();
            dh.baglanti.Close();

        }

        public void BookUpdate(Book book)
        {
            string kayitbook = "UPDATE Customer SET Bookname=@Name,Writer=@Writer,Publisher=@Publisher,Price=@Price,Page=@Page,Gender=@Gender where Bookid=@ID";
            dh.baglanti.Open();
            SqlCommand cmd = new SqlCommand(kayitbook, baglanti);
            cmd.Parameters.AddWithValue("ID", book.ProductID);
            cmd.Parameters.AddWithValue("Name", book.name);
            cmd.Parameters.AddWithValue("Writer", book.Writer);
            cmd.Parameters.AddWithValue("Publisher", book.Publisher);
            cmd.Parameters.AddWithValue("Price", book.price);
            cmd.Parameters.AddWithValue("Page", book.Page);
            cmd.ExecuteNonQuery();
            dh.baglanti.Close();

        }

        public void CreateCostumer(Costumer c1,string path)
        {
            string create = ("INSERT INTO Tbl_Uyeler (Username,Name,Password,Mail,Adress,Gender,UserPicture,UserTel,Admincheck) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,'0')");
            dh.baglanti.Open();
            SqlCommand cmd = new SqlCommand(create, baglanti);
            cmd.Parameters.AddWithValue("@p1", c1.Username);
            cmd.Parameters.AddWithValue("@p2", c1.Name);
            cmd.Parameters.AddWithValue("@p3", c1.Password);
            cmd.Parameters.AddWithValue("@p4", c1.Email);
            cmd.Parameters.AddWithValue("@p5", c1.Adress);
            cmd.Parameters.AddWithValue("@p6", c1.Gender);
            cmd.Parameters.AddWithValue("@p7", path);
            cmd.Parameters.AddWithValue("@p8", "000");
            cmd.ExecuteNonQuery();
            dh.baglanti.Close();


        }


    }

}
