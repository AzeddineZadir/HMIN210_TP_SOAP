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
    public partial class OffresListe : Form
    {
        private string dateArrivee;
        private string dateDepart;
        private int nbLits;
        private int id_roome;
        public OffresListe(ServiceReservationHotel.Rome [] listOffres, string dA, string dD, int nbL)
        {
            InitializeComponent();
            ServiceReservationHotel.ReservatioHotelService1 service = new ServiceReservationHotel.ReservatioHotelService1();
            DataGridViewTextBoxColumn dgvIdCulumn = new DataGridViewTextBoxColumn();
            dgvIdCulumn.HeaderText="ID";

            DataGridViewTextBoxColumn dgvTypeCulumn = new DataGridViewTextBoxColumn();
            dgvTypeCulumn.HeaderText = "Type chambre";

            DataGridViewTextBoxColumn dgvNbLitCulumn = new DataGridViewTextBoxColumn();
            dgvNbLitCulumn.HeaderText = "Nombre de lit";

            DataGridViewTextBoxColumn dgvPriceCulumn = new DataGridViewTextBoxColumn();
            dgvPriceCulumn.HeaderText = "Prix pour une nuits ";

            DataGridViewImageColumn dgimvc = new DataGridViewImageColumn();
            dgimvc.HeaderText = "Images ";
            dgimvc.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv_offeres.Columns.Add(dgvIdCulumn);
            dgv_offeres.Columns.Add(dgvTypeCulumn);
            dgv_offeres.Columns.Add(dgvNbLitCulumn);
            dgv_offeres.Columns.Add(dgvPriceCulumn);
            
                      
            dgv_offeres.Columns.Add(dgimvc);


            dgv_offeres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_offeres.RowTemplate.Height = 130;
            dgv_offeres.AllowUserToAddRows = false;
            foreach (var item in listOffres)
            {
                
               
                string imageStr = service.SendImage(item.Id);

                Image item_image = getImageFromString(imageStr);
                dgv_offeres.Rows.Add(item.Id.ToString(), item.Type, item.Nb_bads.ToString(), item.Price.ToString(), item_image);
                /*string[] row = { item.Id.ToString(),item.Type , item.Nb_bads.ToString(), item.Price.ToString() };
                var listViewItem = new ListViewItem(row);*/
               /* lv_offres.Items.Add(listViewItem);*/
            }
           
            

            this.dateArrivee = dA;
            this.dateDepart = dD;
            this.nbLits = nbL;
            
        }

        private void b_reserver_Click(object sender, EventArgs e)
        {
            string nomClient = tb_nom.Text;
            string prenomClient = tb_prenom.Text;
            string id = tb_idroom.Text;
            if (nomClient == "" || prenomClient == "" || id =="")
            {
                MessageBox.Show("Veuillez remplir tout les champs pour effectuer une reservation");
            }
            else
            {
                ServiceReservationHotel.ReservatioHotelService1 service = new ServiceReservationHotel.ReservatioHotelService1();

                /* ServiceReservationHotel.Rome reponse = service.ReserveRoome("a1", "a1pwd", dateArrivee, dateDepart,Convert.ToInt32( tb_idroom.Text),tb_nom.Text,tb_prenom.Text);*/
                ServiceReservationHotel.Rome rep = service.ReserveRoome("a1", "a1pwd", dateArrivee, dateDepart, Convert.ToInt32(tb_idroom.Text), tb_nom.Text, tb_prenom.Text);
                
                if (rep == null)
                {
                    MessageBox.Show("Nous somme désolés, l'offre n'est plus disponible, veuillez réessayer");
                }
                else
                {
                    MessageBox.Show("Chambre réservé avec le numéro de reservation " + rep);

                    string imageStr = service.SendImage(rep.Id);

                    RoomDetailsForm roomeForme = new RoomDetailsForm (rep,imageStr);
                    roomeForme.Show();
                    this.Hide();
                }
            }






        }

        private Image getImageFromString(string imgString)
        {

            byte[] imageByte = Convert.FromBase64String(imgString);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(imageByte, 0, imageByte.Length);
            stream.Write(imageByte, 0, imageByte.Length);
            Image image = Image.FromStream(stream, true);

            return image;

        }
       

       
    }
}
