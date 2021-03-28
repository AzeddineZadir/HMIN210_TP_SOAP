using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_Hotel_Local
{
    class Rome
    {
        public int Id { get; set; }
        public int Nb_bads { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool Reserved { get; set; }

        public Rome(int id, int nb_bads, string type, int price, bool state)
        {
            Id = id;
            Nb_bads = nb_bads;
            Type = type;
            Price = price;
            Reserved = state;
        }
    }
}
