using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_Hotel_Local
{
    class Resevation
    {
        public int Id { get; set; }
        public string Arrived_date { get; set; }
        public string Exit_date { get; set; }
        public int Nb_supported_personnes { get; set; }
        public Rome Rome { get; set; }
        public Client Client { get; set; }
        public int Nb_day { get; set; }

        public Resevation(int id, string arrived_date, string exit_date, int nb_supported_personnes, Rome rome,Client client,int nb_day)
        {
            Id = id;
            Arrived_date = arrived_date;
            Exit_date = exit_date;
            Nb_supported_personnes = nb_supported_personnes;
            this.Rome = rome;
            this.Client = client;
            Nb_day = nb_day;
        }
    }
}
