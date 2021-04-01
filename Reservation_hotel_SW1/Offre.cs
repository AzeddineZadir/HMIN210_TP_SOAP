using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class Offre
    {

        public int Id { get; set; }
        public int Pourcentage { get; set; }

        public Offre()
        {
        }

        public Offre(int id, int pourcentage)
        {
            Id = id;
            Pourcentage = pourcentage;
        }
    }
}