using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class Book
    {
        private int bookid;
        private string bookname;
        private string writer;
        private string publisher;
        private int price;
        private int page;
        


        private static Book instance;
        private Book() { }
        public static Book getInstance()
        {
            if (instance == null)
                instance = new Book();
            return instance;
        }

        public int Bookid
        {
            get
            {
                return bookid;
            }

            set
            {
                bookid = value;
            }
        }

        public string Bookname
        {
            get
            {
                return bookname;
            }

            set
            {
                bookname = value;
            }
        }

        public string Writer
        {
            get
            {
                return writer;
            }

            set
            {
                writer = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

        
    }
}
