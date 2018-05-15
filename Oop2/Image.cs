using System.Net;

using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;

namespace Oop2
{
    class Image
    {
        static private Image image;
        public static Image getInstance()
        {
            if (image == null)
                image = new Image();
            return image;
        }
        public static Bitmap getImage(string Url)
        {
           WebRequest rs = WebRequest.Create(Url);
            try
            {
                return (Bitmap)Bitmap.FromStream(rs.GetResponse().GetResponseStream());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Server Connection Crashed, Please try again. \n" + ex.Message, "Connection Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }


        }
       
        public string Connect()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "All files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);

                    return fi.FullName;
                }
                else return"";
            }
        }
    }
 }

