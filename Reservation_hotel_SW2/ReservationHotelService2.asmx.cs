using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Reservation_hotel_SW2
{
    /// <summary>
    /// Description résumée de ReservationHotelService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ReservationHotelService2 : System.Web.Services.WebService
    {

        public static Hotel h1 { get; set; }


        public ReservationHotelService2()
        {
            h1 = Data.getHotel();

        }


        [WebMethod]
        public List<Rome> GetDisponibilites(string AgenceName, string AgencePwd, string DateDR, string DateFR, int NbPersonnes)
        {

            string[] string_date_DR = DateDR.Split('/');
            string[] string_date_FR = DateFR.Split('/');
            int[] int_date_DR = Array.ConvertAll(string_date_DR, s => int.Parse(s));
            int[] int_date_FR = Array.ConvertAll(string_date_FR, s => int.Parse(s));

            DateTime DR = new DateTime(int_date_DR[2], int_date_DR[1], int_date_DR[0]);
            DateTime FR = new DateTime(int_date_FR[2], int_date_FR[1], int_date_FR[0]);
            Console.WriteLine(FR.ToString("MM/dd/yyyy"));

            Agence agency = new Agence();
            foreach (var age in h1.Agences)
            {
                if (age.AgenceName == AgenceName && age.AgencPwd == AgencePwd)
                {
                    agency = age;
                }
            }

            List<Rome> free_roomes = new List<Rome>();
            free_roomes = h1.getChambresDispo(NbPersonnes, DR, FR);

            Debug.WriteLine("nombre de chambre libre retourner  " + free_roomes.Count);

            Debug.WriteLine("price befor promotion  " + free_roomes[0].Price);
            setRoomPriceByAgency(agency, free_roomes);
            Debug.WriteLine("price after promotion  " + free_roomes[0].Price);

            return (free_roomes);

        }



        [WebMethod]
        public Rome ReserveRoome(string AgenceName, string AgencePwd, string DateDR, string DateFR, int room_id, string nom, string prenom)
        {
            string[] string_date_DR = DateDR.Split('/');
            string[] string_date_FR = DateFR.Split('/');
            int[] int_date_DR = Array.ConvertAll(string_date_DR, s => int.Parse(s));
            int[] int_date_FR = Array.ConvertAll(string_date_FR, s => int.Parse(s));

            DateTime DR = new DateTime(int_date_DR[2], int_date_DR[1], int_date_DR[0]);
            DateTime FR = new DateTime(int_date_FR[2], int_date_FR[1], int_date_FR[0]);

            double numberOfDays = (FR - DR).TotalDays;
            h1.Roomes.Find(x => x.Id == room_id).ReservationsLog.Add(new Resevation(h1.Roomes.Find(x => x.Id == room_id).ReservationsLog.Count + 1, DR, FR, h1.Roomes.Find(x => x.Id == room_id).Nb_bads, new Client(), numberOfDays));


            /* h1.Roomes[0].ReservationsLog.Add(new Resevation(h1.Roomes[0].ReservationsLog.Count + 1, DR, FR, h1.Roomes[0].Nb_bads, new Client(), numberOfDays));*/

            /*Rome rome = h1.Roomes[0];*/
            /* Debug.WriteLine("LA roome " + rome.ReservationsLog.Count);
             Debug.WriteLine("LA roome " + h1.Roomes[1].ReservationsLog.Count);*/
            /*rome.addreservation(new Resevation());*/
            /*Debug.WriteLine("LA roome " + rome.ReservationsLog.Count);*/
            return h1.Roomes.Find(x => x.Id == room_id);
        }


        [WebMethod]
        public string SendImage(int id)
        {
            string imageStr = "";

            System.Drawing.Image image = System.Drawing.Image.FromFile(Server.MapPath("images") + "\\im_" + id + ".jpg");
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageByte = stream.ToArray();
            imageStr = Convert.ToBase64String(imageByte);
            stream.Dispose();
            image.Dispose();

            return imageStr;
        }


        [WebMethod]
        public Hotel GetHotel()
        {

            return h1;
        }



        public List<Rome> addImages(List<Rome> roomes)
        {
            List<Rome> roomesWimg = new List<Rome>();

            foreach (var item in roomes)
            {
                string imageStr = "";

                System.Drawing.Image image = System.Drawing.Image.FromFile(Server.MapPath("images") + "\\im_" + item.Id + ".jpg");
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageByte = stream.ToArray();
                imageStr = Convert.ToBase64String(imageByte);
                stream.Dispose();
                image.Dispose();

                item.StringImage = imageStr;
            }

            return roomesWimg;

        }
        public float getRommePriceByAgency(Agence agence, Rome rome)
        {

            int remise = agence.Loffre.Pourcentage;
            int offre_id = agence.Loffre.Id;

            float price = rome.Price - (rome.Price * remise / 100);

            return price;
        }


        public void setRoomPriceByAgency(Agence agence, List<Rome> roomes)
        {

            foreach (var roome in roomes)
            {
                roome.Price = getRommePriceByAgency(agence, roome);
            }

        }
    }
}
