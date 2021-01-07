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
    public partial class Guestreviews : Form
    {
        MemberController controllerObj;
        public Guestreviews()
        {
            InitializeComponent();
            controllerObj = new MemberController();
        }
        private void reviews_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.selectreviews();
            reviewsGridView.DataSource = dt;
            reviewsGridView.Refresh();
        }
    }
}
