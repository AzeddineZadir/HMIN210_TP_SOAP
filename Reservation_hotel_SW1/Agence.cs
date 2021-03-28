using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class Agence
    {
        public int Id { get; set; }
        public string AgenceName { get; set; }
        public string AgencPwd { get; set; }

        public Offre Loffre { get; set; }


        public Agence()
        {

        }
        public Agence(int id, string agenceName, string agencPwd, Offre loffre)
        {
            Id = id;
            AgenceName = agenceName;
            AgencPwd = agencPwd;
            Loffre = loffre; 
        }
    }
}