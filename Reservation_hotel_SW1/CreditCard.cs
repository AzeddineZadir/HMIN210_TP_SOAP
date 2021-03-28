using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class CreditCard
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Expiration_date { get; set; }
        public int Ccv { get; set; }

        public float Solde { get; set; }


        public CreditCard()
        {
           
        }
        public CreditCard(int iD, string code, string expiration_date, int ccv, float solde)
        {
            ID = iD;
            Code = code;
            Expiration_date = expiration_date;
            Ccv = ccv;
            Solde = solde;
        }
    }
}