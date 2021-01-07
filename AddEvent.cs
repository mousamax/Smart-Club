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
    public partial class AddEvent : Form
    {
        EMPController controllerObj;
        public AddEvent()
        {
            InitializeComponent();
            controllerObj = new EMPController();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int r = controllerObj.AddEvent(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
            if (r > 0)
                MessageBox.Show("Event inserted successfully");
            else
                MessageBox.Show("Insertion Failed");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowAllEvents();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
