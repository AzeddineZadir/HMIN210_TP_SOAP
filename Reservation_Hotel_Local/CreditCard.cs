using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_Hotel_Local
{
    class CreditCard
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Expiration_date { get; set;  }
        public int  Ccv { get; set; }

        public int Solde { get; set; }



        public CreditCard(int iD, string code, string expiration_date, int ccv,int solde)
        {
            ID = iD;
            Code = code;
            Expiration_date = expiration_date;
            Ccv = ccv;
            Solde = solde;
        }
    }
}
