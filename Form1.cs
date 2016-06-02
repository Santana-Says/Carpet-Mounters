using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpet_Mounters
{
    public partial class CarpetMounters : Form
    {
        public CarpetMounters()
        {
            InitializeComponent();
            GenerateRandom();
        }

        private void GenerateRandom()
        {
            //create a random number
            Random myRandom = new Random();

            //generate a random number between 1 and 10000
            int x = myRandom.Next(1, 10000);

            //display in lblOrderNumber
            lblTicketNum2.Text = x.ToString();
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLocation.SelectedIndex)
            {
                case 0:
                    picLocation.Image = imageList1.Images["apartment.jpg"];
                    break;
                case 1:
                    picLocation.Image = imageList1.Images["house.jpg"];
                    break;
                case 2:
                    picLocation.Image = imageList1.Images["biz.jpg"];
                    break;
            }
        }

        private void cbCarpeting_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCarpeting.SelectedIndex)
            {
                case 0:
                    picCarpet.Image = imageList1.Images["berber.jpg"];
                    break;
                case 1:
                    picCarpet.Image = imageList1.Images["pattern.jpg"];
                    break;
            }
        }
    }
}
