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
    public partial class RoomDetailsForm : Form
    {
        private ServiceReservationHotel.Rome selectedRoome;
        private string imagestr ;
        public RoomDetailsForm(ServiceReservationHotel.Rome rome, string imagestr)
        {
            InitializeComponent();
            this.selectedRoome = rome;
            this.imagestr = imagestr;
            tb_roomid.Text = rome.Id.ToString();
            tb_rometype.Text = rome.Type;
            tb_roomnbplace.Text = rome.Nb_bads.ToString();
            tb_roomprice.Text = rome.Price.ToString();

            byte[] imageByte = Convert.FromBase64String(this.imagestr);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(imageByte, 0, imageByte.Length);
            stream.Write(imageByte, 0, imageByte.Length);
            Image image = Image.FromStream(stream, true);
            pb_roome.Image = image;


        }

       
    }
}
