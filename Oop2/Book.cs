using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class Book: Product
    {
     
        
        private string writer;
        private string publisher;
        private int page;
        private string description;




        private static Book instance;

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        private Book() { }
        public static Book getInstance()
        {
            if (instance == null)
                instance = new Book();
            return instance;
        }

        public override void ShowProperties()
        {
            throw new NotImplementedException();
        }
    }
}
