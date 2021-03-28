using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_Hotel_Local
{
    class Client
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public  string Email { get; set; }
        public string Pwd   { get; set; }

        public CreditCard Card { get; set; }

        public Client()
        {
            
        }
        public Client(string fname, string lname, string email, string pwd, CreditCard card)
        {
            Fname = fname;
            Lname = lname;
            Email = email;
            Pwd = pwd;
            Card = card;
        }

    }
}
