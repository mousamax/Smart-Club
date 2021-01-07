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
    public partial class EnrollinActivity : Form
    {
        MemberController controllerobj;
        string memberid = "1";  /// just for testing will be changed when we get id after login
        public EnrollinActivity()
        {
            InitializeComponent();
            teamexists();
            controllerobj = new MemberController();
            DataTable dt=  controllerobj.GetAllActivityNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
        }
        private void teamexists()
        {
            button1.Show();
            comboBox4.Enabled = true;
            button2.Hide();
            label2.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            textBox3.Hide();
            comboBox7.Hide();
            comboBox8.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;
            dt = controllerobj.GetCoachesofCertainActivity(comboBox1.Text);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Fname";
        }

        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;

            dt = controllerobj.GetTeamsofCertainActivityandCoach(comboBox1.Text, comboBox3.Text);
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Team_ID";
            if (dt == null)
            {
                comboBox4.Enabled = false;
                MessageBox.Show("No Teams available now");
                button1.Hide();
                button2.Show();
                label2.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                textBox3.Show();
                comboBox7.Show();
                comboBox8.Show(); 
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Invalid Action");
                return;
            }
            controllerobj.EnrollMemberinTeam(memberid, comboBox4.Text);
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object data = ValidationClass.IsValidYear(textBox3.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            if (comboBox7.Text == "" || comboBox8.Text == "")
            {
                MessageBox.Show("please complete the date");
                return;
            }
            string date = textBox3.Text + "-" + comboBox7.Text + "-" + comboBox8.Text;
            controllerobj.CreateNewTeamforaCertainActivity(date);
            string teamid = controllerobj.get_team_id(date, "1", "1");

            controllerobj.EnrollMemberinTeam(memberid, teamid); // i send parameter "null" as a team id 
                                                                // since its auto made
            
            controllerobj.insertinTeamActivityCoach( teamid, comboBox3.Text, comboBox1.Text);                                   
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            teamexists();
        }

        private void comboBox7_DropDown(object sender, EventArgs e)
        {
            StringBuilder err=new StringBuilder();
            Object data = ValidationClass.IsValidYear(textBox3.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
                return;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder err = new StringBuilder();
            Object data = ValidationClass.IsValidYear(textBox3.Text, err);
            if (data == null)
            {
                MessageBox.Show(err.ToString());
                return;
            }
            int z=Convert.ToInt32(textBox3.Text);
            int zz = Convert.ToInt32(comboBox7.Text);
            int days = DateTime.DaysInMonth(z, zz);
            int []x=new int[days];
            for (int i = 0; i < days; i++)
			{
			 x[i]=i+1;
			}
            comboBox8.DataSource = x;
        
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("We're Sorry but no available Coaches");
                 return;
        }



      





    }
}
