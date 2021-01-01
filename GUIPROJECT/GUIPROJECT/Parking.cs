using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPROJECT
{
    public partial class Parking : Form
    {
        MemberController c;
        public Parking()
        {
            InitializeComponent();
            c = new MemberController();
        }

        private void Parking_Load(object sender, EventArgs e)
        {

        }

        private void Subscribe_Click(object sender, EventArgs e)
        {
            if (memberid.Text == "" || subfees.Text == "" || startdate.Text == "" || enddate.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object fees = ValidationClass.isPositiveInteger(subfees.Text, err);
                Object mid = ValidationClass.isPositiveInteger(memberid.Text, err);
                if (fees == null || mid == null)
                {
                    MessageBox.Show("Some inputs has incorrect values " + err.ToString());
                }
                else
                {
                    int r=c.ParkingSubscribe(startdate.Text, (int)fees, enddate.Text, (int)mid);
                    MessageBox.Show("Subscribtion successfully");
                }
            }
        }
    }
}
