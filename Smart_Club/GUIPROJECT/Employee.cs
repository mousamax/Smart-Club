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
    public partial class Employee : Form
    {
        DBapplication.EMPController empcontroller;
        public Employee()
        {
            InitializeComponent();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            empcontroller = new DBapplication.EMPController();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            // It is good to use Int16.TryParse first to check if the entered 'status' is a number
            // You should valaidate from the beginning that entered value to be integer.
            int SSN;
            bool isParsable = Int32.TryParse(SSNTextBox.Text, out SSN);
            if (!isParsable && SSN < 0)
            {
                MessageBox.Show("Invalid SSN.");
                return;
            }
            int Salary;
            if (!Int32.TryParse(SalarytextBox.Text, out Salary) && Salary < 0)
            {
                MessageBox.Show("Invalid Salary.");
                return;
            }
            int Super_SSN;
            if (!Int32.TryParse(superssntextBox.Text, out Super_SSN) && Super_SSN < 0)
            {
                MessageBox.Show("Invalid Super_SSN.");
                return;
            }
            int Dno;
            if (!Int32.TryParse(DnotextBox.Text, out Dno) && Dno < 0)
            {
                MessageBox.Show("Invalid Dno.");
                return;
            }
            int result = empcontroller.Insert(SSN, FNameTextBox.Text, MinittextBox.Text, LNametextBox.Text,SexcomboBox.Text, Salary, Super_SSN, Dno);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Employee failed");
            }
            else
            {
                MessageBox.Show("The Employee is inserted successfully!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = empcontroller.SelectAllEmp();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int SSN;
            bool isParsable = Int32.TryParse(deleteSSNtextBox.Text, out SSN);
            if (!isParsable && SSN < 0)
            {
                MessageBox.Show("Invalid SSN.");
                return;
            }
            int result = empcontroller.Delete(SSN);
            if (result == 0)
            {
                MessageBox.Show("The deletion of the Employee failed");
            }
            else
            {
                MessageBox.Show("The Employee is Fired successfully!");
            }
        }
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            int SSN;
            bool isParsable = Int32.TryParse(EditSSNtextBox.Text, out SSN);
            if (!isParsable && SSN < 0)
            {
                MessageBox.Show("Invalid SSN.");
                return;
            }
            int Salary;
            if (!Int32.TryParse(NewSalarytextBox.Text, out Salary) && Salary < 0)
            {
                MessageBox.Show("Invalid Salary.");
                return;
            }
            int result = empcontroller.Update_Salary(SSN,Salary);
            if (result == 0)
            {
                MessageBox.Show("The modification of the Salary failed");
            }
            else
            {
                MessageBox.Show("The Salary is Updated successfully!");
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
