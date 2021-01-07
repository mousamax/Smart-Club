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
    public partial class showActivitylist : Form
    {
        MemberController controllerObj;
        public showActivitylist()
        {
            InitializeComponent();
            controllerObj = new MemberController();
            DataTable dt = controllerObj.Selectteam();
            activitylist.DataSource = dt;
            activitylist.DisplayMember = "ID";
        }

        private void showactivity_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.selectNfromteam(int.Parse(activitylist.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
