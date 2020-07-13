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
    public partial class ClinicMenu : Form
    {
        public ClinicMenu()
        {
            InitializeComponent();
            label1.Text = "0x1aaE918c19A475dBa7b1c88eB3A7bFd0F2c357b4";

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
            ClinicTransfer s = new ClinicTransfer();
            s.Show();
        }

        private void deviceDecommisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClinicDecommision s = new ClinicDecommision();
            s.Show();
        }

        private void ClinicMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
