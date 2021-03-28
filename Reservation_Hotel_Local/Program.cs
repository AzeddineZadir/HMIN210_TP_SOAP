using System;
using System.Collections.Generic;

namespace Reservation_Hotel_Local
{
    class Program
    {
        public static List<Client> clients { get; set; }
        public static List<Hotel> hotels { get; set; }

        public static List<Resevation> reservations {get; set;}
        public static Client connected { get; set; }
        
        static void Main(string[] args)
        {

            // les clients 
            clients = new List<Client>();
            reservations = new List<Resevation>();
            CreditCard cart1 = new CreditCard(1, "2212322323232", "10/10/2020", 123, 1000);
            Client c1 = new Client("nom_client1", "prenom_client1", "a", "a", cart1);
            Client c2 = new Client("nom_client2", "prenom_client2", "a2@a.a", "0000", cart1);
            Client c3 = new Client("nom_client3", "prenom_client3", "a3@a.a", "0000", cart1);
            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);
            // une liste de chambres 
            List<Rome> rommes = new List<Rome>();
            Rome r1 = new Rome(1, 1, "simple", 60, false);
            Rome r2 = new Rome(2, 2, "double", 120, false);
            Rome r3 = new Rome(3, 5, "suite", 300, false);
            rommes.Add(r1);
            rommes.Add(r2);
            rommes.Add(r3);

            //laddress
            Addres adress = new Addres(1, "France", "montpellier", "rue voie d'eau","25b","","");

            hotels = new List<Hotel>();

            // Construire la liste des hotels 
            Hotel h1 = new Hotel(1, "hotel 1",2, rommes, adress);
            Hotel h2 = new Hotel(2, "hotel 2", 1, rommes, adress);
            Hotel h3 = new Hotel(3, "hotel 3", 5, rommes, adress);

            hotels.Add(h1);
            hotels.Add(h2);
            hotels.Add(h3);

            int commande = 0;
            

           
            while (true)
            {
                Console.WriteLine("LOCAL RESERVATION PROGRAM");
                Console.WriteLine("SIGN UP 1");
                Console.WriteLine("LOG IN  2");
                Console.WriteLine("RESERVATION 3");

                commande = int.Parse(Console.ReadLine());
                switch (commande)
                {
                    case 1:
                        signeUP();
                        break;
                    case 2:
                        Console.WriteLine("Votre Email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Votre mdp");
                        string pwd = Console.ReadLine();
                        connected = login(email, pwd);
                        Console.WriteLine(connected.Fname);
                        break;
                    case 3:
                        Console.WriteLine("Reservation ");
                        /*if (connected != null)
                        {*/
                            Console.WriteLine("************************");
                            Console.WriteLine("Dans quelle ville voulez vous réservé");
                            string ville = Console.ReadLine();
                            Console.WriteLine("Date d'arrivée");
                            string arrivee = Console.ReadLine();
                            Console.WriteLine("Date de départ ");
                            string depart = Console.ReadLine();
                            Console.WriteLine("Nombre de personnes  ");
                            int personnes = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nombre de jours  ");
                            int nb_jours = int.Parse(Console.ReadLine());

                        printReturnHotels(rechercheHotelDisponible(hotels,ville, arrivee, depart, personnes));
                            Console.WriteLine("L'id de l'Hotel");
                            int id_hotel = int .Parse(Console.ReadLine());

                            Console.WriteLine("L'id de la chambre ");
                            int id_chambre = int.Parse(Console.ReadLine());

                            reservationRoome(id_hotel, id_chambre,arrivee,depart,personnes,nb_jours);
                            
                        /* }
                         else
                         {
                             Console.WriteLine("Connectez vous svp ");
                         }
                        */
                        break;


                    default:
                        break;
                }
            }
            
            
           

        }

        private static void reservationRoome(int id_hotel, int id_chambre,string arrivee,string depar,int persones,int nb_jour)
        {
            Hotel h =  hotels.Find(x => x.Id == id_hotel);
            
            Rome r = h.Free_Roomes.Find(x => x.Id == id_chambre);
            Console.WriteLine(h.Free_Roomes.Count);
            h.Free_Roomes.Remove(r);
            Console.WriteLine(h.Free_Roomes.Count);
            h.Reserved_Roomes.Add(r);
            if (connected != null)
            {
                Console.WriteLine("user connected");
                Resevation reservation = new Resevation(reservations.Count + 1, arrivee, depar, persones, r, connected,nb_jour);
                reservations.Add(reservation);
                crediterClient(reservation);
            }
            
        }

        private static void crediterClient(Resevation reservation)
        {
            connected.Card.Solde -= (reservation.Rome.Price * reservation.Nb_day);
            Console.WriteLine(connected.Card.Solde);
        }

        private static void printReturnHotels(List<Hotel> hotels)
        {
            foreach (var hotel in hotels)
            {
                Console.WriteLine("*****Hotel ID : " + hotel.Id+" ******");
                Console.WriteLine("Hotel : " + hotel.Name);
                Console.WriteLine("Nb Etoiles : " + hotel.Star);
                foreach (var roome in hotel.Free_Roomes)
                {
                    Console.WriteLine("******Roome ID : " + roome.Id+" ******");
                    Console.WriteLine("Roome Price : " + roome.Price);
                    Console.WriteLine("Roome Type : " + roome.Type);

                }

                Console.WriteLine("****************************");
               
            }
        }

        private static List<Hotel> rechercheHotelDisponible(List<Hotel> hotels,string ville, string arrivee, string depart,int personnes)
        {
            List<Hotel> hotelstoReturn = new List<Hotel>();
            foreach (var hotel in hotels)
            {
                if (hotel.Addres.City.Equals(ville))
                {
                    foreach (var room in hotel.Free_Roomes)
                    {
                        if (room.Nb_bads >= personnes)
                        {
                            hotelstoReturn.Add(hotel);
                        }
                    }
                   
                }
            }
            
            return hotelstoReturn;
        }

        private static List<Rome> getDisponibleRommes(Hotel hotel)
        {
            List<Rome> free_roomes = new List<Rome>();
            foreach (var roome  in hotel.Free_Roomes)
            {
                if (roome.Reserved)
                {
                    free_roomes.Add(roome);
                }
            }
            return free_roomes;
        }

        private static Client login(string email, string pwd)
        {
            Client connected_client= new Client() ;
            foreach ( var c in clients) {
                string e = c.Email;
                string p = c.Pwd;
                if(e.Equals(email) & p.Equals(pwd))
                {
                    connected_client = c;
                }
            }
            return connected_client;
        }

        private static Client signeUP()
        {
            Console.WriteLine("Votre nom");
            string nom = Console.ReadLine();

            Console.WriteLine("Votre prénom");
            string prenom = Console.ReadLine();

            Console.WriteLine("Votre Email");
            string email = Console.ReadLine();

            Console.WriteLine("Votre mdp");
            string pwd = Console.ReadLine();

            Console.WriteLine("informations bancaires");

            Console.WriteLine("code ");
            string code = Console.ReadLine();

            Console.WriteLine("date d'éxpiration");
            string expiration_date = Console.ReadLine();

            Console.WriteLine("CCV");

            int ccv = int.Parse(Console.ReadLine());

            CreditCard creditCard = new CreditCard(1, code, expiration_date, ccv,1000);
            Client client = new Client(nom, prenom,email,pwd, creditCard);
            clients.Add(client);
            return client;
        }
    }
}
