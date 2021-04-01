using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class Data
    {
        // une liste de chambres 
        
        static List<Resevation> reservations = new List<Resevation>();
        

        static List<Rome> rommes = new List<Rome>() { new Rome(1, 1, "simple", 60), new Rome(2, 2, "double", 120), new Rome(3, 5, "suite", 300) };
        

        //laddress
       static  Addres adress = new Addres(1, "France", "montpellier", "rue voie d'eau", "25b", "", "");
        // les offres 
        Offre o1 = new Offre(1, 10);
        Offre o2 = new Offre(2, 20);
        Offre o3 = new Offre(3, 30);
        //les agences 

        static List<Agence> agences = new List<Agence>() { new Agence(1, "a1", "a1", new Offre(1, 10)), new Agence(2, "agence1","mdp", new Offre(2, 20)), new Agence(3, "agence1","mdp", new Offre(3, 30)) };
       


        public static Hotel h1 = new Hotel(1, "hotel 1", 2, rommes, adress, agences);

        public static Hotel getHotel()
        {
            return h1;
        }
    }
}