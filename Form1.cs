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
<<<<<<< HEAD
=======
        //module level variables
        int roomLengthFeet = 0, roomLengthInch = 0, roomWidthFeet = 0, roomWidthInch = 0;
        double roomTotalFoot = 0.0, roomTotalInch = 0.0, quoteTotal = 0.0, carpetPrice = 0.0;

>>>>>>> refs/remotes/origin/master
        public CarpetMounters()
        {
            InitializeComponent();
            GenerateRandom();
        }
<<<<<<< HEAD
=======


        //function to validate integers for feet inch, if invalid display error message
        private void ValidateInt(string label1, string label2, string boxtext, ref int result)
        {
            string message = "";
            string Str = boxtext.Trim();

            int Num;

            bool isNum = int.TryParse(Str, out Num);

            if (isNum)
            {
                result = Num;
            }
            //display error if not an interger number
            else
            {
                message = string.Format("{0} {1} Value is incorrect, please enter a correct number", label1, label2);

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //validate positive number or 0 value and error message if invalid
            if (Num < 0)
            {
                message = string.Format("{0} {1} Value is incorrect, please enter a positive number number", label1, label2);

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
>>>>>>> refs/remotes/origin/master


        // function to calculate the total square foot for the room
        private void CalculateRoom()
        {
            //validate room lenght and wid
            ValidateInt(lblRoomLen.Text, lblFt1.Text, txtLengthFt.Text, ref roomLengthFeet);
            ValidateInt(lblRoomLen.Text, lblIn1.Text, txtLengthIn.Text, ref roomLengthInch);
            ValidateInt(lblRoomWid.Text, lblFt2.Text, txtWidthFt.Text, ref roomWidthFeet);
            ValidateInt(lblRoomWid.Text, lblIn2.Text, txtWidthIn.Text, ref roomWidthInch);

            // convert feet to inch
            double inch1 = (roomLengthFeet * 12) + roomLengthInch;
            double inch2 = (roomWidthFeet * 12) + roomWidthInch;
            // calculate total inch
            roomTotalInch = inch1 * inch2;

            // convert inch back to feet rounding to feet
            roomTotalFoot = roomTotalInch / 144;

            //assing the result to the totalsq feet variable
            roomTotalFoot = Math.Round(roomTotalFoot, 2);
            lblTotalSQFeet.Text = roomTotalFoot.ToString();
        }
        
        
        //random number generator function 
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            roomLengthFeet = 0; roomLengthInch = 0; roomWidthFeet = 0; roomWidthInch = 0;
            roomTotalFoot = 0.0; roomTotalInch = 0.0; quoteTotal = 0.0; carpetPrice = 0.0;
            txtName.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtLengthFt.Text = "";
            txtWidthFt.Text = "";
            txtLengthIn.Text = "";
            txtWidthIn.Text = "";

            lblQuote2.Text = "";
            radioBurgandy.Checked = false;
            RadioCharcoal.Checked = false;
            radioIvory.Checked = false;
            radioRegular.Checked = false;
            radioSameDay.Checked = false;
            checkAllergyCoat.Checked = false;
            checkStain.Checked = false;
        }

        //order calculation
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //string summaryMessage = "Location Type"
            CalculateRoom();
            //MessageBox.Show("Location Type:", "Quote Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        //link pic boxes to combo boxes
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
