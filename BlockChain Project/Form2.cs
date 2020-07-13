using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Nethereum.Web3.Accounts;
using Nethereum.Web3;
namespace BlockChain_Project
{

    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Ethereum Address:0x594559a12AF7CC1085f65c53f4252535Bad12203";
        }

        private void createSmartContractToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form5 s = new Form5();
            s.ShowDialog();
            

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        

        private void displaySmartContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form6 f = new Form6();
            f.Show();
           
        }

        private void transferOnwerShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferOwnership s = new TransferOwnership();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s =new Form1();
            s.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
