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
    public partial class UpdateEndmembership : Form
    {
        MemberController controllerObj;
        public UpdateEndmembership()
        {
            InitializeComponent();
            controllerObj = new MemberController();
            string dt = controllerObj.get_enddate(1);
            enddate.Text = dt;
            
        }

        private void Extendmembership_Click(object sender, EventArgs e)
        {


            controllerObj.Update_Membership(enddate.Text);
            MessageBox.Show("Membership Extended successfully please go pay the Extention fees");
            string dt = controllerObj.get_enddate(1);
            enddate.Text = dt;
        }

        private void Terminatemembership_Click(object sender, EventArgs e)
        {
            controllerObj.Terminate_Membership(enddate.Text);
            MessageBox.Show("Membership Teerminated");
            string dt = controllerObj.get_enddate(1);
            enddate.Text = dt;
        }
    }
}
