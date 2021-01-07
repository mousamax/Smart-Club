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
    public partial class TurnInToMember : Form
    {
        MemberController controllerObj;
        public TurnInToMember()
        {
            InitializeComponent();
            controllerObj = new MemberController();
        }

        private void GtoM_Click(object sender, EventArgs e)
        {
            if (Fname.Text == ""||Lname.Text == ""|| sex.Text=="" ||age.Value.ToString()=="")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                controllerObj.turntomember(Fname.Text, Lname.Text, sex.Text,(int)age.Value);
                MessageBox.Show("Membership Request added successfully");
            }
        }
    }
}
