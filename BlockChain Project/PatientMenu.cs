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
    public partial class PatientMenu : Form
    {
        public PatientMenu()
        {
            InitializeComponent();
            label1.Text = "0xe3B811cca2012D6118491efB777c1b8893ADceaB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.Show();

        }

        private void transferOwnerShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientTransfer s = new PatientTransfer();
            s.Show();
        }

        private void decommisioningDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Decommision s = new Decommision();
            s.Show();
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
