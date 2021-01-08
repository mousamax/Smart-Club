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
    public partial class Activities_Reviews : Form
    {
        MemberController controllerobj;
        Form1 myparent;
        public Activities_Reviews(Form1 parent)
        {
            InitializeComponent();
            myparent = parent;
            controllerobj = new MemberController();
            DataTable dt= controllerobj.GetAllActivityNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "")
                textBox1.Text = controllerobj.GetLikesOfActivity(comboBox1.Text).Rows[0][0].ToString() ;
            else
                MessageBox.Show("No Activity Selected");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                myparent.openChildForm(new EnrollinActivity());
            }
            else
                MessageBox.Show("No Activity Selected");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DataTable dt= controllerobj.GetReviewsOfCertainActivity(comboBox1.Text);
           dataGridView1.Refresh();
            if (dt == null)
               MessageBox.Show("No Reviews Available");
           
               dataGridView1.DataSource = dt;
             
        }


   
    }
}
