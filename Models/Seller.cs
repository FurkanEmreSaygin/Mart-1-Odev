using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Models
{
    class Seller : User
    {
        public string TaxID { get; set; }
        public string Location { get; set;}
        public Seller(string name, string email, string password,int usertype, string taxId, string location) : base(name, email, password, usertype)
        {
            Location = location;
            TaxID = taxId;
        }

       
    }
}
