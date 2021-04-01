using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }
        public List<Rome> Roomes { get; set; }
       
        public Addres Addres { get; set; }
        
        public List<Agence> Agences { get; set; }



        public Hotel()
        {


        }

        public Hotel(int id, string name, int star, List<Rome> roomes, Addres addres , List<Agence> agences)
        {
            Id = id;
            Name = name;
            Star = star;
            Roomes = roomes;
            Addres = addres;
            Agences = agences;

        }

        public List<Rome> getChambresDispo(int nbP, DateTime dA, DateTime dD)
        {
            List<Rome> lCh = new List<Rome>();
            foreach (Rome ch in Roomes)
            {
                Debug.WriteLine("ch.id" + ch.Id+" resault"+ ch.getDisponibilite(dA,dD));

                if (ch.getDisponibilite(dA, dD) == true & ch.Nb_bads >= nbP)
                {
                    lCh.Add(ch);
                }
            }
            return lCh;
        }
    }
}