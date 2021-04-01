using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class Addres
    {
        public int Id { get; set; }
        public string Contry { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Locality { get; set; }
        public string Gps { get; set; }


        public Addres()
        {
           
        }


        public Addres(int id, string contry, string city, string street, string number, string locality, string gps)
        {
            Id = id;
            Contry = contry;
            City = city;
            Street = street;
            Number = number;
            Locality = locality;
            Gps = gps;
        }
    }
}