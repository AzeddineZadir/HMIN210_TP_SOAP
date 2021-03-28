using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencyClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_search_Click(object sender, EventArgs e)
        {

            if (tb_da.Text != "" && tb_dd.Text != "" && tb_nbp.Text !="" )
            {
                int nbLits = Convert.ToInt32(tb_nbp.Text);
                string dateArriveString = tb_da.Text;
                string dateDepartString = tb_dd.Text;
                ServiceReservationHotel.ReservatioHotelService1 service = new ServiceReservationHotel.ReservatioHotelService1();
                ServiceReservationHotel.Rome[] listOffres;
                listOffres = service.GetDisponibilites("a1", "a1pwd", dateArriveString, dateDepartString, nbLits);
              /*  MessageBox.Show(listOffres[0].Type);*/
                OffresListe OffresListe = new OffresListe(listOffres, dateArriveString, dateDepartString, nbLits);
                OffresListe.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs pour effectuer une recherche ");
            }
            
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
