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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            FirstPanel.Visible = false;
            SecondPanel.Visible = false;
            ThirdPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (FirstPanel.Visible == true)
                FirstPanel.Visible = false;

            if (SecondPanel.Visible == true)
                SecondPanel.Visible = false;
            if (ThirdPanel.Visible == true)
                ThirdPanel.Visible = false;
        }

        private void ShowSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;

           
        }

        #region FirstSubmenu
        private void FirstSubmenubutton_Click(object sender, EventArgs e)
        {
            ShowSubmenu(FirstPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code showing form or whatever
            testform x = new testform();
            openChildForm(x);
            hideSubMenu();
        }

        private void addevent_Click(object sender, EventArgs e)
        {
            Event x = new Event();
            openChildForm(x);

            hideSubMenu();
        }

        private void parkingsubscribe_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            openChildForm(p);

            hideSubMenu();
        }      
#endregion

        #region SecondSubmenu

        private void SecondSubButton_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SecondPanel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //code showing form or whatever

            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //code showing form or whatever

            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code showing form or whatever

            hideSubMenu();
        }
        #endregion

        #region ThirdSubmenu

        private void ThirdSubButton_Click(object sender, EventArgs e)
        {
            ShowSubmenu(ThirdPanel);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //code showing form or whatever

            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //code showing form or whatever

            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //code showing form or whatever

            hideSubMenu();
        }

        #endregion

        private new Form ActiveForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(ChildForm);
            panelchildform.Tag = ChildForm;
            ChildForm.BringToFront(); // because we have a logoo
            ChildForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if(ActiveForm!=null)
                ActiveForm.Close();
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LOGIN x = new LOGIN();
            openChildForm(x);
        }   



    }
}
