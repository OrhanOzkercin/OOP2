using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class Magazine : Product
    {
        private string issue;
        private string type;
        private string description;

        public string Issue
        {
            get
            {
                return issue;
            }

            set
            {
                issue = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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
        public override void ShowProperties()
        {
            throw new NotImplementedException();
        }

    }
}
