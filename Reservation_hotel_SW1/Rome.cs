using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Reservation_hotel_SW1
{
    public class Rome
    {
        public int Id { get; set; }
        public int Nb_bads { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public bool Reserved { get; set; }
       
        public List<Resevation> ReservationsLog = new List<Resevation>();
       
        public string StringImage { get; set; }

        public Image RoomeImage
        {
            get
            {
                byte[] imageByte = Convert.FromBase64String(StringImage);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(imageByte, 0, imageByte.Length);
                stream.Write(imageByte, 0, imageByte.Length);
                Image image = Image.FromStream(stream, true);
                return image;
            }
           
        }

        public Rome()
        {
          
        }
        public Rome(int id, int nb_bads, string type, float price)
        {
            Id = id;
            Nb_bads = nb_bads;
            Type = type;
            Price = price;
           
            

        }


        public Boolean getDisponibilite(DateTime dA, DateTime dD)
        {
            Boolean dispo = true;
            foreach ( var r in ReservationsLog)
            {

                if (DateTime.Compare(dA, r.Exit_date) < 0 || DateTime.Compare(r.Arrived_date, dD) <= 0)
                {
                    dispo = false;
                }
            }
            return dispo;
        }
        public void addreservation( Resevation r)
        {
            this.ReservationsLog.Add(r);
        }
    }
}