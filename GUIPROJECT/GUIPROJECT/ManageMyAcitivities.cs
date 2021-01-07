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
        string memberid = "1";  /// just for testing will be changed when we get id after login   
        public ManageMyAcitivities()
        {
            InitializeComponent();
            controllerobj = new MemberController();
            DataTable dt = controllerobj.GetActivityofanmember(memberid);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember="Name";
        }





    }
}
