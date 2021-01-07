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
            DateTime d = DateTime.Today;
            startdate.Text = d.ToString("MM/dd/yyyy");
            subfees.Text = Convert.ToString((int)nofmonths.Value * 100);
            c = new MemberController();
        }

        private void Parking_Load(object sender, EventArgs e)
        {

        }

        private void Subscribe_Click(object sender, EventArgs e)
        {
            if (memberid.Text == "" || subfees.Text == "" || startdate.Text == "" || nofmonths.Text == "")//validation part
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
                    DateTime d = DateTime.Today;
                    if (startdate.Text==d.ToString())
                    {
                        d=d.AddMonths((int)nofmonths.Value );
                    }
                    else
                    {
                        d = Convert.ToDateTime(startdate.Text);
                        d=d.AddMonths((int)nofmonths.Value );
                    }
                    int fee = (int)nofmonths.Value * 100;
                    subfees.Text = Convert.ToString(fee);
                    int r=c.ParkingSubscribe(startdate.Text,fee, d.ToString(), (int)mid);
                    MessageBox.Show("Subscribtion successfully");
                }
            }
        }

        private void subfees_TextChanged(object sender, EventArgs e)
        {
        }

        private void nofmonths_ValueChanged(object sender, EventArgs e)
        {
            subfees.Text = Convert.ToString((int)nofmonths.Value * 100);
        }
    }
}
