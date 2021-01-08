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
    public partial class EnrollGuestinActivity : Form
    {
       MemberController controllerobj;
        string guestid = "1";  /// just for testing will be changed when we get id after login
        public EnrollGuestinActivity()
        {
            InitializeComponent();
            
            controllerobj = new MemberController();
            DataTable dt=  controllerobj.GetAllActivityNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
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
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Invalid Action");
                return;
            }
            int actsize = controllerobj.GetTeamActualSize(comboBox4.Text);
            int maxsize = controllerobj.GetTeamSize(comboBox4.Text);
            if (actsize == maxsize)
            {
                MessageBox.Show("Team is full ");
                return;
            }
            DataTable dt = controllerobj.GetGuestTeam(guestid);
            if (dt != null)
            {
                MessageBox.Show("You're Allowed To join one team only");
                return;
            }
           int x= controllerobj.EnrollGuestinTeam(guestid, comboBox4.Text);
           if (x == 0)
               MessageBox.Show("Failed");
           else
               MessageBox.Show("Successfully Enrolled");
        }

       
        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("We're Sorry but no available Coaches");
                 return;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           string x= controllerobj.GetTrainingTimeofTeam(comboBox4.Text).Rows[0][0].ToString();
           textBox1.Text = x;
        }


    }
}
