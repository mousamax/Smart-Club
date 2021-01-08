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
    public partial class ManageMyAcitivities : Form
    {
        MemberController controllerobj;
        bool load = true;
        string memberid = "1";  /// just for testing will be changed when we get id after login   
        string teamidselected = "";
        public ManageMyAcitivities()
        {
            InitializeComponent();

            //hide time tools untill the button is clicked
            button4.Hide();
            textBox1.Hide();
            textBox3.Hide();
            comboBox7.Hide();
            comboBox8.Hide();
            label3.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            ////

            controllerobj = new MemberController();
            DataTable dt = controllerobj.GetActivityofanmember(memberid);
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load)
            {
                load = false;
                return;
            }

            dataGridView1.Refresh();
            string actid = controllerobj.GetActivityidFromName(comboBox1.Text);
            DataTable dt = controllerobj.GetTeamsOfaMemberInaCertainActivity(memberid, actid);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e) // drop button
        {
            if (teamidselected != "")
            {
                controllerobj.DropMefromCertainTeam(memberid, teamidselected);
                Refreshment();

            }
        }

        // here refreshment for combo box and data grid view again
        private void Refreshment()
        {
            DataTable dt = controllerobj.GetActivityofanmember(memberid);
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = dt;

            dataGridView1.Refresh();
            string actid = controllerobj.GetActivityidFromName(comboBox1.Text);
            dt = controllerobj.GetTeamsOfaMemberInaCertainActivity(memberid, actid);
            dataGridView1.DataSource = dt;

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //handler if you clicked on outerboundaries
                return;


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                teamidselected = (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                return;
            }
            teamidselected = "";
        }

        private void button3_Click(object sender, EventArgs e) //show time and change
        {
            if (teamidselected != "")
            {
                //Show time tools when the button is clicked
                button4.Show();
                textBox1.Show();
                textBox3.Show();
                comboBox7.Show();
                comboBox8.Show();
                label3.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                ////

                DataTable dt = controllerobj.GetTrainingTimeofTeam(teamidselected);
                if (dt != null)
                    textBox1.Text = dt.Rows[0][0].ToString();
                else
                    textBox1.Text = "Unavailable";
            }
            return;
        }




        private void comboBox7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (load)
                return;

            StringBuilder err = new StringBuilder();
            Object data = ValidationClass.IsValidYear(textBox3.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            int z = Convert.ToInt32(textBox3.Text);
            int zz = Convert.ToInt32(comboBox7.Text);
            int days = DateTime.DaysInMonth(z, zz);
            int[] x = new int[days];
            for (int i = 0; i < days; i++)
            {
                x[i] = i + 1;
            }
            comboBox8.DataSource = x;
        }

        private void comboBox7_DropDown(object sender, EventArgs e)
        {

            StringBuilder err = new StringBuilder();
            Object data = ValidationClass.IsValidYear(textBox3.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object data = ValidationClass.IsValidYear(textBox3.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
                return;
            }

            string date = textBox3.Text + "-" + comboBox7.Text + "-" + comboBox8.Text;

            controllerobj.changeTrainingTimeofTeam(teamidselected, date);

            button3_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (teamidselected != "")
            {
                //hide time tools untill the button is clicked
                button4.Hide();

                textBox3.Hide();
                comboBox7.Hide();
                comboBox8.Hide();
                label3.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                ////

                textBox1.Show();
                DataTable dt = controllerobj.GetLevelofTeam(teamidselected);
                if (dt != null)
                    textBox1.Text = dt.Rows[0][0].ToString();
                else
                    textBox1.Text = "Unavailable";
            }
            return;

        }


    }
}
