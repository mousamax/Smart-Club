using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIPROJECT
{
    public partial class Event : Form
    {
        MemberController c;
        public Event()
        {
            InitializeComponent();
            c = new MemberController();
        }

        private void addevent_Click(object sender, EventArgs e)
        {
            if (eventname.Text == "" || eventplace.Text == ""|| eventdate.Text==""||eventfees.Text==""||memberid.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object fees = ValidationClass.isPositiveInteger(eventfees.Text, err);
                Object mid = ValidationClass.isPositiveInteger(memberid.Text, err);
                if (fees == null || mid == null)
                {
                    MessageBox.Show("Some inputs has incorrect values " + err.ToString());
                }
                else
                {
                    int r = c.Addevent(eventname.Text, eventplace.Text, eventdate.Text, (int)fees, (int)mid);
                    MessageBox.Show("Event Inserted successfully");
                }
            }

        }
    }
}
