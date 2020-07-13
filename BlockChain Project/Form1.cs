using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockChain_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            string identity = selectedItem.ToString();
            string pass = Password.Text;
            if (identity == "Manufacturer" && pass == "Manufacturer")
            {
                this.Hide();
                Form2 s = new Form2();
                s.ShowDialog();
                this.Close();
               

            }
            else if(identity == "Patient" && pass == "Patient")
            {
                this.Hide();
                PatientMenu s = new PatientMenu();
                s.Show();
            }
            else if (identity == "Clinic" && pass == "Clinic")
            {

                this.Hide();
                ClinicMenu s = new ClinicMenu();
                s.Show();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
