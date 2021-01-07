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
    public partial class AddActivty : Form
    {
        EMPController controllerObj;

        public AddActivty()
        {
            InitializeComponent();
            controllerObj = new EMPController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //No validation was tested will be implemented Later
            int r = controllerObj.AddActivity( textBox2.Text, textBox3.Text);
            if (r > 0)
                MessageBox.Show("Activity inserted successfully");
            else
                MessageBox.Show("Insertion Failed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //This GridVView is for testing Only ShouldBeRemoved Later
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowAllActivities();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
