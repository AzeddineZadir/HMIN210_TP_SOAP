using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class Resevation
    {
        public int Id { get; set; }
        public DateTime Arrived_date { get; set; }
        public DateTime Exit_date { get; set; }
        public int Nb_supported_personnes { get; set; }
        
        public Client Client { get; set; }
        public double Nb_day { get; set; }


        public Resevation()
        {
            
        }
        public Resevation(int id, DateTime arrived_date, DateTime exit_date, int nb_supported_personnes, Client client, double nb_day)
        {
            Id = id;
            Arrived_date = arrived_date;
            Exit_date = exit_date;
            Nb_supported_personnes = nb_supported_personnes;
            this.Client = client;
            Nb_day = nb_day;
        }
    }
}