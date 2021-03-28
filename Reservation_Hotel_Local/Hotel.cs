using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_Hotel_Local
{
    class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }
        public List<Rome> Free_Roomes { get; set; }
        public List<Rome> Reserved_Roomes { get; set; }
        public Addres Addres { get; set; }

        public List<Resevation> Reservations { get; set;  }
        public Hotel(int id, string name, int star, List<Rome> roomes, Addres addres)
        {
            Id = id;
            Name = name;
            Star = star;
            Free_Roomes = roomes;
            Reserved_Roomes = new List<Rome>();
            Addres = addres;
        }
    }
}
